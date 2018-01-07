-- single line comment
/* multiple
line
of comment */

-- Relational DataBase
-- Create a 2 tables, Client and Order

-- Client

CREATE TABLE Client
(
	Id INT PRIMARY KEY IDENTITY(1,1), -- PK = Primary Key
	FirstName VARCHAR(max) NOT NULL,
	LastName VARCHAR(max) NOT NULL,
	BirthDate DATE NOT NULL,
	Address VARCHAR(max) , 
)

-- Order

CREATE TABLE Orders
(
	Id INT PRIMARY KEY IDENTITY(1,1), -- PK
	Description VARCHAR(max) NOT NULL,
	Created DATE NOT NULL,
	Shipped BIT NOT NULL, --boolean 0= false 1=true

	Client_Id INT FOREIGN KEY REFERENCES Client(Id)--FK = Foreign Key from Client table
)