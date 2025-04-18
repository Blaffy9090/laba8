-- Set global settings for database consistency
SET ANSI_NULLS ON;                  -- Ensures that comparisons to NULL values work as expected
SET ANSI_WARNINGS ON;               -- Ensures proper error handling for certain operations
SET QUOTED_IDENTIFIER ON;           -- Allows the use of double quotes for identifiers (optional)
SET ARITHABORT ON;                  -- Terminates a query when it encounters an overflow/underflow

-- Create the Category table with constraints
CREATE TABLE Category (
    Id INT IDENTITY(1,1) PRIMARY KEY,  -- KodKat is primary key and auto-incremented
    Name NVARCHAR(255) NOT NULL,        -- Name of the category
    CONSTRAINT CK_Category_Name CHECK (LEN(Name) > 0) -- Ensures name is not empty
);

-- Create the Product table with constraints
CREATE TABLE Product (
    Id INT IDENTITY(1,1) PRIMARY KEY,   -- KodTovara (Product ID) with auto-increment
    Name NVARCHAR(255) NOT NULL,         -- Name of the product
    Description NVARCHAR(1000) NULL,     -- Description of the product (optional)
    Price FLOAT NOT NULL,                -- Price of the product
    CategoryId INT NULL,                 -- KodCategory (Foreign key to Category table)
    
    -- Foreign Key to Category table
    CONSTRAINT FK_Product_Category FOREIGN KEY (CategoryId) REFERENCES Category(Id)
        ON DELETE SET NULL,              -- If a category is deleted, set the CategoryId to NULL

    -- Check constraint to ensure Name length is > 0 and Price > 0
    CONSTRAINT CK_Product_Name CHECK (LEN(Name) > 0),
    CONSTRAINT CK_Product_Price CHECK (Price > 0)
);

-- Create the Order table with constraints
CREATE TABLE [Order] (
    Id INT IDENTITY(1,1) PRIMARY KEY,  -- KodZakaza (Order ID) with auto-increment
    ProductId INT,                      -- KodTovara (Foreign key to Product table)
    Amount INT NOT NULL CHECK (Amount > 0),  -- Amount must be greater than 0
    OrderDate DATE NOT NULL,             -- Date of the order
    Sum FLOAT NOT NULL CHECK (Sum > 0),  -- Sum must be greater than 0

    -- Foreign Key to Product table
    CONSTRAINT FK_Order_Product FOREIGN KEY (ProductId) REFERENCES Product(Id)
        ON DELETE CASCADE,              -- If a product is deleted, delete the related orders

    -- Check constraints for Amount and Sum
    CONSTRAINT CK_Order_Amount CHECK (Amount > 0),
    CONSTRAINT CK_Order_Sum CHECK (Sum > 0)
);

-- Create indexes for performance optimization
-- Index for fast lookups on ProductId in the Order table
CREATE INDEX IX_Order_ProductId ON [Order](ProductId);

-- Index for fast lookups on CategoryId in the Product table
CREATE INDEX IX_Product_CategoryId ON Product(CategoryId);

-- Optional: Create index for fast lookups on OrderDate in the Order table
CREATE INDEX IX_Order_OrderDate ON [Order](OrderDate);

-- Optional: Create a unique index on Product Name if needed (to avoid duplicates)
CREATE UNIQUE INDEX IX_Product_Name ON Product(Name);

-- Optional: Create a check for valid order dates (no future orders allowed)
ALTER TABLE [Order] ADD CONSTRAINT CK_Order_FutureDate CHECK (OrderDate <= GETDATE());