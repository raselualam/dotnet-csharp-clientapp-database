-- Data entry for client table

INSERT INTO Client (FirstName, LastName, BirthDate)
		VALUES ('Eric', 'Zambrano', '1982-12-09')

INSERT INTO Client (FirstName, LastName, BirthDate)
		VALUES ('John', 'Smith', '1997-10-19')

INSERT INTO Client (FirstName, LastName, BirthDate, Address)
		VALUES ('Diana', 'Amazon', '2001-02-18', 'Amazon')

-- ******************************************************

-- Data entry for Orders table

INSERT INTO Orders (Description, Created, Shipped, Client_Id)
VALUES ('Towels', GETDATE(), 1, 1) --Client Id 1 represent Eric

INSERT INTO Orders (Description, Created, Shipped, Client_Id)
VALUES ('Computer', GETDATE(), 1, 2) 

INSERT INTO Orders (Description, Created, Shipped, Client_Id)
VALUES ('Monitor', GETDATE(), 1, 2) 

INSERT INTO Orders (Description, Created, Shipped, Client_Id)
VALUES ('All New Car', GETDATE(), 0, 1) 