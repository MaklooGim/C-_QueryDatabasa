--CREATE DATABASE Product_Category
--GO
--USE Product_Category

CREATE TABLE Product 
(
	ID INT IDENTITY PRIMARY KEY,
	ProductName NVARCHAR(30) NOT NULL
)

CREATE TABLE Category
(
	ID INT IDENTITY PRIMARY KEY,
	CategoryName NVARCHAR(30) NOT NULL
)

CREATE TABLE Pro_Categ
(
	Product_id INT,
	Category_id INT
)

INSERT INTO Product 
VALUES 
('Ром'),('Джедайский меч'),('Сапоги'),('Ручка'),('Ноутбук'),('Вешалка')

INSERT INTO Category 
VALUES 
('Продукты'),('Вещи'),('Концелярия')

INSERT INTO Pro_Categ
VALUES 
(1,2),
(2,3),
(4,3),
(5,3),
(6, NULL)

SELECT  Product.ProductName, Category.CategoryName
FROM Category
INNER JOIN Pro_Categ ON Pro_Categ.Category_id = Category.Id
RIGHT OUTER JOIN Product On Product.ID = Pro_Categ.Product_id
