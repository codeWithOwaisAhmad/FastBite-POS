using FastBite.Core.Contracts;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace FastBite.App.Views
{
    public partial class DashboardView : UserControl
    {
        private readonly IOrderService _orderService;
        private readonly IMenuItemService _menuItemService;

        public DashboardView(IOrderService orderService, IMenuItemService menuItemService)
        {
            InitializeComponent();
            _orderService = orderService;
            _menuItemService = menuItemService;
        }

        // ─────────────────────────────────────────
        // LOAD — populate everything
        // ─────────────────────────────────────────
        private void DashboardView_Load(object sender, EventArgs e)
        {
            try
            {
                LoadStatCards();
                LoadBarChart();
                LoadPieChart();
                LoadLineChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading dashboard:\n{ex.Message}",
                    "Dashboard Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // ─────────────────────────────────────────
        // STAT CARDS — top row summary numbers
        // ─────────────────────────────────────────
        private void LoadStatCards()
        {
            decimal totalRevenue = _orderService.GetTotalRevenue();
            int totalOrders = _orderService.GetTotalOrdersCount();
            int totalMenuItems = _menuItemService.GetAll().Count;

            var statusCounts = _orderService.GetOrderCountByStatus();
            int pendingCount = statusCounts.ContainsKey("Pending") ? statusCounts["Pending"] : 0;

            lblRevenueValue.Text = $"Rs. {totalRevenue:N0}";
            lblOrdersValue.Text = totalOrders.ToString();
            lblMenuItemsValue.Text = totalMenuItems.ToString();
            lblPendingValue.Text = pendingCount.ToString();
        }

        // ─────────────────────────────────────────
        // BAR CHART — Revenue by Category
        // ─────────────────────────────────────────
        private void LoadBarChart()
        {
            chartBar.Series.Clear();
            chartBar.ChartAreas.Clear();
            chartBar.Titles.Clear();
            chartBar.Legends.Clear();

            chartBar.Titles.Add(new Title
            {
                Text = "Revenue by Category (Rs.)",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80)
            });

            var chartArea = new ChartArea("BarArea");
            chartArea.BackColor = Color.White;
            chartArea.AxisX.MajorGrid.Enabled = false;
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartArea.AxisY.LabelStyle.Format = "N0";
            chartArea.AxisX.LabelStyle.Enabled = false;  // hide x-axis labels
            chartBar.ChartAreas.Add(chartArea);

            // ── Get data FIRST then set axis maximum ──────
            Dictionary<string, decimal> data = _orderService.GetRevenueByCategory();

            // Give 35% extra space above tallest bar
            // so ALL labels appear outside on top
            if (data.Count > 0)
            {
                double maxVal = Convert.ToDouble(data.Values.Max());
                chartArea.AxisY.Maximum = maxVal * 1.35;
                chartArea.AxisY.Minimum = 0;
            }

            Color[] colors = {
                Color.FromArgb(230, 126,  34),   // orange
                Color.FromArgb( 41, 128, 185),   // blue
                Color.FromArgb( 39, 174,  96),   // green
                Color.FromArgb(142,  68, 173),   // purple
                Color.FromArgb(231,  76,  60),   // red
            };

            // Each category gets its own series = separate bars
            int colorIdx = 0;
            foreach (var kvp in data)
            {
                var series = new Series(kvp.Key)
                {
                    ChartType = SeriesChartType.Column,
                    ChartArea = "BarArea",
                    IsValueShownAsLabel = true,
                    LabelFormat = "N0",
                    Font = new Font("Segoe UI", 9F, FontStyle.Bold),
                    Color = colors[colorIdx % colors.Length]
                };

                // Force label OUTSIDE on top — never inside bar
                series.SmartLabelStyle.Enabled = false;
                series.SmartLabelStyle.AllowOutsidePlotArea = LabelOutsidePlotAreaStyle.Yes;

                series.Points.AddXY(kvp.Key, kvp.Value);
                chartBar.Series.Add(series);
                colorIdx++;
            }

            // Add legend at bottom so colors are explained
            var legend = new Legend("BarLegend")
            {
                Font = new Font("Segoe UI", 9F),
                BackColor = Color.White,
                Docking = Docking.Bottom
            };
            chartBar.Legends.Add(legend);

            foreach (var s in chartBar.Series)
                s.Legend = "BarLegend";

            chartBar.BackColor = Color.White;
        }

        // ─────────────────────────────────────────
        // PIE CHART — Orders by Status
        // ─────────────────────────────────────────
        private void LoadPieChart()
        {
            chartPie.Series.Clear();
            chartPie.ChartAreas.Clear();
            chartPie.Titles.Clear();
            chartPie.Legends.Clear();

            chartPie.Titles.Add(new Title
            {
                Text = "Orders by Status",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80)
            });

            var chartArea = new ChartArea("PieArea");
            chartArea.BackColor = Color.White;
            chartPie.ChartAreas.Add(chartArea);

            var legend = new Legend("PieLegend")
            {
                Font = new Font("Segoe UI", 9F),
                BackColor = Color.White,
                Docking = Docking.Bottom
            };
            chartPie.Legends.Add(legend);

            var series = new Series("Status")
            {
                ChartType = SeriesChartType.Pie,
                ChartArea = "PieArea",
                Legend = "PieLegend",
                IsValueShownAsLabel = true,
                LabelFormat = "#0",
                Font = new Font("Segoe UI", 9F, FontStyle.Bold)
            };

            var statusColors = new Dictionary<string, Color>
            {
                { "Completed", Color.FromArgb( 39, 174,  96) },
                { "Pending",   Color.FromArgb(243, 156,  18) },
                { "Confirmed", Color.FromArgb( 41, 128, 185) },
                { "Cancelled", Color.FromArgb(231,  76,  60) }
            };

            Dictionary<string, int> data = _orderService.GetOrderCountByStatus();
            foreach (var kvp in data)
            {
                int idx = series.Points.AddXY(kvp.Key, kvp.Value);
                series.Points[idx].LegendText = $"{kvp.Key} ({kvp.Value})";
                if (statusColors.ContainsKey(kvp.Key))
                    series.Points[idx].Color = statusColors[kvp.Key];
            }

            series["PieLabelStyle"] = "Outside";
            chartPie.Series.Add(series);
            chartPie.BackColor = Color.White;
        }

        // ─────────────────────────────────────────
        // LINE CHART — Daily Revenue Last 7 Days
        // ─────────────────────────────────────────
        private void LoadLineChart()
        {
            chartLine.Series.Clear();
            chartLine.ChartAreas.Clear();
            chartLine.Titles.Clear();
            chartLine.Legends.Clear();

            chartLine.Titles.Add(new Title
            {
                Text = "Daily Revenue — Last 7 Days",
                Font = new Font("Segoe UI", 11F, FontStyle.Bold),
                ForeColor = Color.FromArgb(44, 62, 80)
            });

            var chartArea = new ChartArea("LineArea");
            chartArea.BackColor = Color.White;
            chartArea.AxisX.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            chartArea.AxisY.MajorGrid.LineColor = Color.FromArgb(220, 220, 220);
            chartArea.AxisX.LabelStyle.Font = new Font("Segoe UI", 8F);
            chartArea.AxisX.LabelStyle.Angle = -30;
            chartArea.AxisY.LabelStyle.Font = new Font("Segoe UI", 9F);
            chartArea.AxisY.LabelStyle.Format = "N0";
            chartLine.ChartAreas.Add(chartArea);

            var series = new Series("Revenue")
            {
                ChartType = SeriesChartType.Line,
                ChartArea = "LineArea",
                Color = Color.FromArgb(41, 128, 185),
                BorderWidth = 3,
                MarkerStyle = MarkerStyle.Circle,
                MarkerSize = 8,
                MarkerColor = Color.FromArgb(230, 126, 34),
                IsValueShownAsLabel = true,
                LabelFormat = "N0",
                Font = new Font("Segoe UI", 8F)
            };

            // Fill last 7 days — show 0 for days with no data
            Dictionary<string, decimal> data = _orderService.GetDailyRevenueLastWeek();
            for (int i = 6; i >= 0; i--)
            {
                string day = DateTime.Today.AddDays(-i).ToString("yyyy-MM-dd");
                string label = DateTime.Today.AddDays(-i).ToString("dd MMM");
                decimal revenue = data.ContainsKey(day) ? data[day] : 0;
                series.Points.AddXY(label, revenue);
            }

            chartLine.Series.Add(series);
            chartLine.BackColor = Color.White;
        }

        // ─────────────────────────────────────────
        // REFRESH BUTTON
        // ─────────────────────────────────────────
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                LoadStatCards();
                LoadBarChart();
                LoadPieChart();
                LoadLineChart();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error refreshing dashboard:\n{ex.Message}",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}