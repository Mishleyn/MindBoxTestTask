CREATE TABLE Products (
    ProductID int PRIMARY KEY,
    ProductName nvarchar(100)
);

CREATE TABLE Categories (
    CategoryID int PRIMARY KEY,
    CategoryName nvarchar(100)
);

CREATE TABLE ProductCategories (
    ProductID int,
    CategoryID int,
    PRIMARY KEY (ProductID, CategoryID),
    FOREIGN KEY (ProductID) REFERENCES Products(ProductID),
    FOREIGN KEY (CategoryID) REFERENCES Categories(CategoryID)
);

SELECT 
    p.ProductName,
    c.CategoryName
FROM 
    Products p
LEFT JOIN 
    ProductCategories pc ON p.ProductID = pc.ProductID
LEFT JOIN 
    Categories c ON pc.CategoryID = c.CategoryID;