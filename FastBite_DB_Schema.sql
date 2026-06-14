-- ============================================
-- FastBite POS - Database Schema
-- Advanced Programming (COSC-5136) | SP26
-- Islamia University of Bahawalpur
-- ============================================

-- Create and use the database
IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = 'FastBitePOS')
BEGIN
    CREATE DATABASE FastBitePOS;
END
GO

USE FastBitePOS;
GO

-- ============================================
-- TABLE 1: Customers
-- ============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Customers')
BEGIN
    CREATE TABLE Customers (
        Id          NVARCHAR(20)    NOT NULL PRIMARY KEY,
        Name        NVARCHAR(100)   NOT NULL,
        Phone       NVARCHAR(20)    NOT NULL,
        Email       NVARCHAR(100)   NULL,
        Address     NVARCHAR(250)   NULL
    );
END
GO

-- ============================================
-- TABLE 2: MenuItems
-- ============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'MenuItems')
BEGIN
    CREATE TABLE MenuItems (
        Id          NVARCHAR(20)    NOT NULL PRIMARY KEY,
        Name        NVARCHAR(100)   NOT NULL,
        Category    NVARCHAR(50)    NOT NULL,
        Price       DECIMAL(10,2)   NOT NULL,
        Status      NVARCHAR(50)    NOT NULL
    );
END
GO

-- ============================================
-- TABLE 3: Orders
-- ============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'Orders')
BEGIN
    CREATE TABLE Orders (
        Id              NVARCHAR(20)    NOT NULL PRIMARY KEY,
        CustomerId      NVARCHAR(20)    NOT NULL,
        CustomerName    NVARCHAR(100)   NOT NULL,
        OrderDate       DATETIME        NOT NULL,
        Status          NVARCHAR(50)    NOT NULL,
        PaymentMethod   NVARCHAR(50)    NOT NULL,
        TotalAmount     DECIMAL(10,2)   NOT NULL DEFAULT 0,

        CONSTRAINT FK_Orders_Customers
            FOREIGN KEY (CustomerId) REFERENCES Customers(Id)
    );
END
GO

-- ============================================
-- TABLE 4: OrderItems
-- ============================================
IF NOT EXISTS (SELECT * FROM sys.tables WHERE name = 'OrderItems')
BEGIN
    CREATE TABLE OrderItems (
        Id              INT             NOT NULL PRIMARY KEY IDENTITY(1,1),
        OrderId         NVARCHAR(20)    NOT NULL,
        MenuItemId      NVARCHAR(20)    NOT NULL,
        MenuItemName    NVARCHAR(100)   NOT NULL,
        UnitPrice       DECIMAL(10,2)   NOT NULL,
        Quantity        INT             NOT NULL,

        CONSTRAINT FK_OrderItems_Orders
            FOREIGN KEY (OrderId) REFERENCES Orders(Id) ON DELETE CASCADE,

        CONSTRAINT FK_OrderItems_MenuItems
            FOREIGN KEY (MenuItemId) REFERENCES MenuItems(Id)
    );
END
GO

-- ============================================
-- SEED DATA: Customers
-- ============================================
IF NOT EXISTS (SELECT 1 FROM Customers)
BEGIN
    INSERT INTO Customers (Id, Name, Phone, Email, Address) VALUES
    ('C-001', 'Ahmed Khan',     '0300-1234567', 'ahmed@email.com',   'House 5, Block A, Multan'),
    ('C-002', 'Sara Ali',       '0311-2345678', 'sara@email.com',    'Flat 3, Garden Town, Lahore'),
    ('C-003', 'Bilal Hassan',   '0321-3456789', 'bilal@email.com',   'Street 7, F-8, Islamabad'),
    ('C-004', 'Fatima Noor',    '0333-4567890', NULL,                'Gulshan-e-Iqbal, Karachi'),
    ('C-005', 'Usman Tariq',    '0345-5678901', 'usman@email.com',   'DHA Phase 2, Lahore');
END
GO

-- ============================================
-- SEED DATA: Menu Items
-- ============================================
IF NOT EXISTS (SELECT 1 FROM MenuItems)
BEGIN
    INSERT INTO MenuItems (Id, Name, Category, Price, Status) VALUES
    -- Burgers
    ('M-001', 'Classic Burger',         'Burger',   350.00,  'Available'),
    ('M-002', 'Double Smash Burger',    'Burger',   550.00,  'Available'),
    ('M-003', 'Zinger Burger',          'Burger',   480.00,  'Available'),
    -- Pizza
    ('M-004', 'Margherita Pizza',       'Pizza',    900.00,  'Available'),
    ('M-005', 'BBQ Chicken Pizza',      'Pizza',    1100.00, 'Available'),
    -- Drinks
    ('M-006', 'Coca Cola (Regular)',    'Drink',    120.00,  'Available'),
    ('M-007', 'Mineral Water',          'Drink',    60.00,   'Available'),
    ('M-008', 'Fresh Lemonade',         'Drink',    180.00,  'Available'),
    -- Sides
    ('M-009', 'French Fries (Regular)', 'Sides',    220.00,  'Available'),
    ('M-010', 'Coleslaw',               'Sides',    150.00,  'Available'),
    ('M-011', 'Onion Rings',            'Sides',    200.00,  'OutOfStock'),
    -- Desserts
    ('M-012', 'Chocolate Lava Cake',    'Dessert',  320.00,  'Available'),
    ('M-013', 'Ice Cream Scoop',        'Dessert',  150.00,  'Available'),
    ('M-014', 'Brownie',                'Dessert',  280.00,  'Unavailable');
END
GO

-- ============================================
-- SEED DATA: Orders
-- ============================================
IF NOT EXISTS (SELECT 1 FROM Orders)
BEGIN
    INSERT INTO Orders (Id, CustomerId, CustomerName, OrderDate, Status, PaymentMethod, TotalAmount) VALUES
    ('O-001', 'C-001', 'Ahmed Khan',   DATEADD(day, -6, GETDATE()), 'Completed',  'Cash',   700.00),
    ('O-002', 'C-002', 'Sara Ali',     DATEADD(day, -5, GETDATE()), 'Completed',  'Card',   1220.00),
    ('O-003', 'C-003', 'Bilal Hassan', DATEADD(day, -4, GETDATE()), 'Completed',  'Online', 920.00),
    ('O-004', 'C-001', 'Ahmed Khan',   DATEADD(day, -3, GETDATE()), 'Cancelled',  'Cash',   480.00),
    ('O-005', 'C-004', 'Fatima Noor',  DATEADD(day, -2, GETDATE()), 'Completed',  'Card',   1650.00),
    ('O-006', 'C-005', 'Usman Tariq',  DATEADD(day, -1, GETDATE()), 'Completed',  'Cash',   570.00),
    ('O-007', 'C-002', 'Sara Ali',     GETDATE(),                   'Pending',    'Card',   900.00);

    INSERT INTO OrderItems (OrderId, MenuItemId, MenuItemName, UnitPrice, Quantity) VALUES
    -- O-001: Classic Burger + Fries + Coke
    ('O-001', 'M-001', 'Classic Burger',        350.00, 1),
    ('O-001', 'M-009', 'French Fries (Regular)',220.00, 1),
    ('O-001', 'M-006', 'Coca Cola (Regular)',   120.00, 1),
    -- O-002: BBQ Pizza + Coke
    ('O-002', 'M-005', 'BBQ Chicken Pizza',     1100.00, 1),
    ('O-002', 'M-006', 'Coca Cola (Regular)',   120.00,  1),
    -- O-003: Margherita + Water
    ('O-003', 'M-004', 'Margherita Pizza',      900.00, 1),
    ('O-003', 'M-007', 'Mineral Water',         60.00,  1),
    -- O-004: Zinger Burger
    ('O-004', 'M-003', 'Zinger Burger',         480.00, 1),
    -- O-005: Double Smash x2 + Pizza + Lemonade
    ('O-005', 'M-002', 'Double Smash Burger',   550.00, 2),
    ('O-005', 'M-004', 'Margherita Pizza',      900.00, 1),
    ('O-005', 'M-008', 'Fresh Lemonade',        180.00, 1),
    -- O-006: Zinger + Fries
    ('O-006', 'M-003', 'Zinger Burger',         480.00, 1),
    ('O-006', 'M-009', 'French Fries (Regular)',220.00, 1),
    -- O-007: Margherita Pizza (pending)
    ('O-007', 'M-004', 'Margherita Pizza',      900.00, 1);
END
GO

PRINT 'FastBitePOS database created and seeded successfully.';
GO
