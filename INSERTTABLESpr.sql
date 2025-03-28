INSERT INTO Employee (SSN, FirstName, LastName, Username, Password, Role)
VALUES 
('123-45-6789', 'Emma', 'Williams', 'emma_w', 'securepass1', 'Manager'),
('987-65-4321', 'Sophia', 'Brown', 'sophia_b', 'securepass2', 'Cashier'),
('456-78-9012', 'Liam', 'Miller', 'liam_m', 'securepass3', 'Stock Keeper');


INSERT INTO Product (PID, Name, Category, Price, Brand, Size, StockQuantity)
VALUES 
(1, 'Summer Dress', 'Clothing', 49.99, 'Zara', 'M', 15),
(2, 'Leather Handbag', 'Accessories', 89.99, 'Michael Kors', 'One-size', 10),
(3, 'Foundation Cream', 'Beauty', 29.99, 'Maybelline', '50ml', 25),
(4, 'Silver Necklace', 'Accessories', 39.99, 'Pandora', 'One-size', 20),
(5, 'High Heels', 'Footwear', 79.99, 'Gucci', '38', 12);


INSERT INTO Sale (ID, Date, EmployeeSSN, TotalAmount)
VALUES 
(101, '2024-03-01 10:00:00', '123-45-6789', 139.98),
(102, '2024-03-02 14:30:00', '987-65-4321', 49.99);


INSERT INTO Purchase (SaleID, PID, Quantity, PriceAtSale)
VALUES 
(101, 1, 1, 49.99),  
(101, 2, 1, 89.99),  
(102, 3, 1, 29.99);

INSERT INTO Feedback (ID, PID, EmployeeSSN, Rate, Comment, Date)
VALUES 
(1, 1, '123-45-6789', 5, 'Beautiful dress, perfect for summer!', '2024-03-05 12:00:00'),
(2, 2, '987-65-4321', 4, 'Elegant handbag, but a bit pricey.', '2024-03-06 15:20:00'),
(3, 3, '456-78-9012', 5, 'Great foundation, smooth coverage.', '2024-03-07 18:00:00');