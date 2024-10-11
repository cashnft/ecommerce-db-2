CREATE TABLE ProductRatings (
    Id INT PRIMARY KEY AUTOINCREMENT,
    ProductId INT,
    Rating INT CHECK (Rating >= 1 AND Rating <= 5),
    FOREIGN KEY (ProductId) REFERENCES Products(Id)
);
