-- ==================================================================================================================================
-- CREATE DATABASE
CREATE DATABASE Coffee_Management
GO
USE Coffee_Management
GO
-- ==================================================================================================================================
-- CREATE TABLE
CREATE TABLE AccountType
(
	ID INT IDENTITY PRIMARY KEY,
	TypeName NVARCHAR(50) NOT NULL
)
GO
CREATE TABLE Account
(
	UserName VARCHAR(100) PRIMARY KEY,
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Name',
	Password VARCHAR(500) NOT NULL DEFAULT 0,
	TypeID INT NOT NULL
	FOREIGN KEY (TypeID) REFERENCES AccountType(ID)
)
GO
CREATE TABLE TableCoffee
(
	ID INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	Status NVARCHAR(100) NOT NULL DEFAULT N'Trống'
)
GO
CREATE TABLE CategoryFood
(
	ID INT IDENTITY NOT NULL PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO
CREATE TABLE Food
(
	ID INT IDENTITY PRIMARY KEY,
	Name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	CategoryID INT NOT NULL,
	Price INT NOT NULL DEFAULT 0
	FOREIGN KEY (CategoryID) REFERENCES CategoryFood(id)
)
GO
CREATE TABLE Bill
(
	ID INT IDENTITY PRIMARY KEY,
	CheckIn Date NOT NULL DEFAULT GETDATE(),
	CheckOut Date,
	TableID INT NOT NULL,
	Discount INT NOT NULL DEFAULT 0,
	TotalPrice INT DEFAULT 0,
	Status INT NOT NULL DEFAULT 0 -- 1: Da thanh toan, 0: Chua thanh toan
	FOREIGN KEY (TableID) REFERENCES TableCoffee(ID)
)
CREATE TABLE BillInfo
(
	ID INT IDENTITY PRIMARY KEY,
	BillID INT NOT NULL,
	FoodID INT NOT NULL,
	Amount INT NOT NULL DEFAULT 0
	FOREIGN KEY (BillID) REFERENCES Bill(ID),
	FOREIGN KEY (FoodID) REFERENCES Food(ID)
)
-- ==================================================================================================================================
-- INSERT Account
INSERT AccountType (TypeName) VALUES (N'Quản lý')
INSERT AccountType (TypeName) VALUES (N'Nhân viên')

INSERT INTO Account (UserName, DisplayName, Password, TypeID)
VALUES ('admin', N'Quản lý', 'admin', 1)

INSERT INTO Account(UserName, DisplayName, Password, TypeID)
VALUES ('tvhung', N'Nhân viên (Việt Hưng)' ,'12345', 2)

INSERT INTO Account(UserName, DisplayName, Password, TypeID)
VALUES ('lcky', N'Nhân viên (Kỳ)' ,'12345', 2)

INSERT INTO Account(UserName, DisplayName, Password, TypeID)
VALUES ('tuprovip', N'Nhân viên (Tú)' ,'12345', 2)

INSERT INTO Account(UserName, DisplayName, Password, TypeID)
VALUES ('nhlong', N'Nhân viên (Long)' ,'12345', 2)

INSERT INTO Account(UserName, DisplayName, Password, TypeID)
VALUES ('butprovip', N'Nhân viên (Bút)' ,'12345', 2)
GO
-- ==================================================================================================================================
-- INSERT INTO TableCoffee
DECLARE @i INT = 1
WHILE @i <= 20
BEGIN
	INSERT INTO TableCoffee(Name)
	VALUES (N'Bàn ' + CAST(@i AS NVARCHAR(100)))
	SET @i = @i + 1
END
GO
-- ==================================================================================================================================
-- INSERT INTO Category
INSERT INTO CategoryFood (Name) VALUES (N'Cà phê')
INSERT INTO CategoryFood (Name) VALUES (N'Đồ ăn vặt')
INSERT INTO CategoryFood (Name) VALUES (N'Thức uống khác')
INSERT INTO CategoryFood (Name) VALUES (N'Nước ép trái cây')
INSERT INTO CategoryFood (Name) VALUES (N'Trà sữa')
GO
-- ==================================================================================================================================
-- INSERT INTO Food
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Cà phê đá', 1, 10000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Cà phê sữa', 1, 12000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Cà phê fin (đen)', 1, 8000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Cà phê fin (sữa)', 1, 10000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Mì cay', 2, 25000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Sushi', 2, 15000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Bò viên chiên', 2, 10000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Xúc xích chiên', 2, 10000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Ốc nhồi chiên', 2, 12000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Há cảo chiên', 2, 15000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'7up', 3, 16000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Sữa tươi', 3, 16000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Sinh tố cam', 4, 14000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Sinh tố dâu', 4, 10000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Trà sữa truyền thống', 5, 18000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Trà sữa Chocolate', 5, 22000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Trà sữa Matcha', 5, 20000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Trà sữa Việt quất', 5, 24000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Capuchino', 5, 25000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Macchiato', 5, 25000)
-- ==================================================================================================================================
-- INSERT INTO Bill
INSERT INTO Bill (CheckIn, TableID) VALUES (GETDATE(), 1)
INSERT INTO Bill (CheckIn, TableID) VALUES (GETDATE(), 2)
INSERT INTO Bill (CheckIn, TableID) VALUES (GETDATE(), 3)
GO
-- ==================================================================================================================================
-- INSERT INTO BillInfo
INSERT INTO BillInfo (BillID, FoodID, Amount) VALUES (1, 1, 2)
INSERT INTO BillInfo (BillID, FoodID, Amount) VALUES (1, 3, 3)
INSERT INTO BillInfo (BillID, FoodID, Amount) VALUES (2, 2, 1)
INSERT INTO BillInfo (BillID, FoodID, Amount) VALUES (3, 5, 1)
INSERT INTO BillInfo (BillID, FoodID, Amount) VALUES (2, 4, 2)
-- ==================================================================================================================================
-- Start Account's Procedures
-- Check Login
CREATE PROC USP_Login
@UserName NVARCHAR(100), @Password NVARCHAR(100)
AS
	SELECT *
	FROM dbo.Account
	WHERE UserName = @UserName AND Password = @Password
GO
-- Get Account by Username
CREATE PROC USP_GetAccountByUserName
@UserName VARCHAR(100)
AS
	SELECT *
	FROM dbo.Account
	WHERE UserName = @UserName
GO
--Get all Account
CREATE PROC USP_GetAllAccount
AS
	SELECT UserName, DisplayName, TypeID FROM dbo.Account
GO
-- Insert Account

-- Reset password

-- Update Account
CREATE PROC USP_UpdateAccount
@UserName VARCHAR(100), @DisplayName NVARCHAR(100), @Password VARCHAR(100), @NewPassword VARCHAR(100)
AS
BEGIN
	DECLARE @isRightPass INT = 0
	SELECT @isRightPass = COUNT(*) FROM Account WHERE UserName = @UserName and Password = @Password
	IF (@isRightPass = 1)
	BEGIN
		IF (@NewPassword = null or @NewPassword = '')
			UPDATE Account SET DisplayName = @DisplayName WHERE UserName = @UserName
		ELSE
			UPDATE Account SET DisplayName = @DisplayName, Password = @NewPassword WHERE UserName = @UserName
	END
END
GO
-- Delete Account

-- Search Account by Username

-- End Account's Procedures
-- ==================================================================================================================================
-- Start Food's Procedures

-- Get all Food

-- Get list Food by CategoryID

-- Insert Food

-- Update Food

-- Delete Food

-- Search Food by Name

-- End Food's Procedures
-- ==================================================================================================================================
-- Start Bill's Procedures

-- Insert Bill

-- Get Unchecked BillID by TableID

-- Get list Bill by Day

-- Delete Bill

-- Checkout

-- Get max BillID

-- End Bill's Procedures
-- ==================================================================================================================================
-- Start BillInfo's Procedures

-- Insert BillInfo

-- Delete BillInfo by ID

-- End BillInfo's Procedures
-- ==================================================================================================================================
--- ** Some Triggers, Functions

-- Update Bill

-- Delete BillInfo

-- Convert to Unsign

-- Get list Bill Day for Report

-- Delete Category
create proc USP_DeleteCategory
@ID int
as
begin
	declare @FoodCount int = 0
	select @FoodCount = COUNT(*) from Food where CategoryID = @ID

	if (@FoodCount = 0)
		delete CategoryFood where ID = @ID
end
go
-- ==================================================================================================================================
-- Start TableFood's Procedures
-- Delete Table's Food

-- Switch Table

-- Get all Table

-- Get list Table

-- Insert Table

-- Update Table

-- Get list TempBill by TableID

-- Merge Table

-- End TableFood's Procedures