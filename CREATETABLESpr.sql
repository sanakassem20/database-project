CREATE TABLE Employee (
    SSN VARCHAR(15),
    FirstName NVARCHAR(50),
    LastName NVARCHAR(50),
    Username NVARCHAR(50),
    Password NVARCHAR(255),
    Role NVARCHAR(20),
    PRIMARY KEY (SSN)
);

CREATE TABLE Product (
    PID INT,
    Name NVARCHAR(100),
    Category NVARCHAR(50),
    Price DECIMAL(10,2),
    Brand NVARCHAR(50),
    Size NVARCHAR(20),
    StockQuantity INT,
    PRIMARY KEY (PID)
);

CREATE TABLE Sale (
    ID INT,
    Date DATETIME,
    EmployeeSSN VARCHAR(15),
    TotalAmount DECIMAL(10,2),
    PRIMARY KEY (ID)
);

CREATE TABLE Purchase (
    SaleID INT,
    PID INT,
    Quantity INT,
    PriceAtSale DECIMAL(10,2),
    PRIMARY KEY (SaleID, PID)
);

CREATE TABLE Feedback (
    ID INT,
    PID INT,
    EmployeeSSN VARCHAR(15),
    Rate INT,
    Comment NVARCHAR(255),
    Date DATETIME,
    PRIMARY KEY (ID)
);

ALTER TABLE Sale 
ADD CONSTRAINT Sale_Employee_FK FOREIGN KEY (EmployeeSSN) REFERENCES Employee (SSN);

ALTER TABLE Purchase 
ADD CONSTRAINT Purchase_Sale_FK FOREIGN KEY (SaleID) REFERENCES Sale (ID);

ALTER TABLE Purchase 
ADD CONSTRAINT Purchase_Product_FK FOREIGN KEY (PID) REFERENCES Product (PID);

ALTER TABLE Feedback 
ADD CONSTRAINT Feedback_Product_FK FOREIGN KEY (PID) REFERENCES Product (PID);

ALTER TABLE Feedback 
ADD CONSTRAINT Feedback_Employee_FK FOREIGN KEY (EmployeeSSN) REFERENCES Employee (SSN);