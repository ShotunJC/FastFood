CREATE TABLE Orders(
ID int NOT NULL IDENTITY(1,1),
OrderNum int NOT NULL,
CustName VARCHAR(32) NOT NULL,
CustAddress VARCHAR(50) NOT NULL,
ContactNum VARCHAR(12) NOT NULL,
TotalPrice INT NOT NULL,
PRIMARY KEY (ID)
);

CREATE TABLE Delivery(
ID int NOT NULL IDENTITY(1,1),
DNum int NOT NULL,
DName VARCHAR(32) NOT NULL,
DriverNum int NOT NULL,
OrderNum INT NOT NULL FOREIGN KEY REFERENCES Orders(ID),
PRIMARY KEY (ID)
);


CREATE TABLE OrderItems(
ID int NOT NULL IDENTITY(1,1),
LineItem int NOT NULL,
Descr VARCHAR(50) NOT NULL,
QTY int NOT NULL,
Price int NOT NULL,
OrderNum INT NOT NULL FOREIGN KEY REFERENCES Orders(ID),
PRIMARY KEY (ID)
);
