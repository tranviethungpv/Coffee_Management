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
GO
CREATE TABLE BillInfo
(
	ID INT IDENTITY PRIMARY KEY,
	BillID INT NOT NULL,
	FoodID INT NOT NULL,
	Amount INT NOT NULL DEFAULT 0
	FOREIGN KEY (BillID) REFERENCES Bill(ID),
	FOREIGN KEY (FoodID) REFERENCES Food(ID)
)
GO
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
INSERT INTO CategoryFood (Name) VALUES (N'Đồ uống có cồn')
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
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Bia Sài Gòn', 6, 13000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Bia Hà Nội', 6, 13000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Bia Tiger', 6, 17000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Bia Heineken', 6, 20000)
INSERT INTO Food (Name, CategoryID, Price) VALUES (N'Bia Budweiser', 6, 25000)
GO
-- ==================================================================================================================================
-- INSERT INTO Bill

-- ==================================================================================================================================
-- INSERT INTO BillInfo

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
CREATE PROC USP_InsertAccount
@UserName VARCHAR(100), @DisplayName NVARCHAR(100), @TypeID INT
AS
	INSERT dbo.Account ( UserName, DisplayName, TypeID )
	VALUES  ( @UserName, @DisplayName, @TypeID )
GO
-- Reset password
CREATE PROC USP_ResetPassword
@UserName VARCHAR(100)
AS
	UPDATE dbo.Account SET Password = '0' WHERE UserName = @UserName
GO
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
CREATE PROC USP_DeleteAccount
@UserName VARCHAR(100)
AS
	DELETE dbo.Account WHERE UserName = @UserName
GO

-- Search Account by Username
--CREATE PROC USP_SearchAccountByUserName
--@UserName VARCHAR(100)
--AS
--	SELECT * FROM dbo.Account WHERE dbo.fuConvertToUnsign1(UserName) LIKE N'%' + dbo.fuConvertToUnsign1(@UserName) + '%'
GO
-- End Account's Procedures
-- ==================================================================================================================================
-- Start Food's Procedures

-- Get all Food
CREATE PROC USP_GetAllFood
AS
	SELECT * FROM dbo.Food
GO
-- Get list Food by CategoryID
CREATE PROC USP_GetListFoodByCategoryID
@CategoryID INT
AS
	SELECT ID, Name, Price FROM dbo.Food WHERE CategoryID = @CategoryID
GO
-- Insert Food
CREATE PROC USP_InsertFood
@Name NVARCHAR(100), @CategoryID INT, @Price INT
AS
	INSERT dbo.Food( Name, CategoryID, Price )
	VALUES  ( @Name, @CategoryID, @Price )
GO
-- Update Food
CREATE PROC USP_UpdateFood
@ID INT, @Name NVARCHAR(100), @CategoryID INT, @Price INT
AS
	DECLARE @BillIDCount INT = 0
	SELECT @BillIDCount = COUNT(*) FROM Bill AS b, BillInfo AS bi WHERE FoodID = @ID AND b.ID = bi.BillID AND b.Status = 0

	IF (@BillIDCount = 0)
		UPDATE dbo.Food SET Name = @Name, CategoryID = @CategoryID, Price = @Price WHERE ID = @ID
GO
-- Delete Food
CREATE PROC USP_DeleteFood
@FoodID INT
AS
BEGIN
	DECLARE @BillIDCount INT = 0
	SELECT @BillIDCount = COUNT(*) FROM Bill AS b, BillInfo AS bi WHERE FoodID = @FoodID AND b.ID = bi.BillID AND b.Status = 0

	IF (@BillIDCount = 0)
	BEGIN
		DELETE BillInfo WHERE FoodID = @FoodID
		DELETE Food WHERE ID = @FoodID
	END
END
GO
-- Search Food by Name
--CREATE PROC USP_SearchFoodByName
--@Name NVARCHAR(100)
--AS
--	SELECT * FROM dbo.Food WHERE dbo.fuConvertToUnsign1(Name) LIKE N'%' + dbo.fuConvertToUnsign1(@Name) + '%'
--GO
-- End Food's Procedures
-- ==================================================================================================================================
-- Start Bill's Procedures

-- Insert Bill
GO
CREATE PROC USP_InsertBill
@TableID INT
AS
	INSERT dbo.Bill (CheckIn, TableID, status, discount) VALUES (GETDATE(), @TableID, 0, 0)
GO
-- Get Unchecked BillID by TableID
GO
CREATE PROC GetUnCheckBillIDByTableID
@TableID INT
AS
	SELECT * FROM dbo.Bill WHERE TableID = @TableID AND Status = 0
GO
-- Get list Bill by Day
GO
CREATE PROC USP_GetListBillByDay
@FromDate DATE, @ToDate DATE
AS
BEGIN
	SELECT b.ID, t.Name, CheckIn, discount, TotalPrice
	FROM Bill AS b, TableCoffee AS t
	WHERE CheckIn >= @FromDate AND CheckIn <= @ToDate AND b.status = 1 AND t.ID = b.TableID
END
GO
GO
--CREATE PROC USP_GetListBillByDay
--@FromDate DATE, @ToDate DATE
--AS
--BEGIN
--	declare @frDate nvarchar(30);
--	set @frDate = (select cast( (select CAST(month(@FromDate) as varchar)+'-'+CAST(day(@fromdate) as nvarchar )+'-'+CAST(@FromDate as nvarchar)) as datetime ))
--	declare @tDate nvarchar(30);
--	set @tDate = (select cast( (select CAST(month(@ToDate) as varchar)+'-'+CAST(day(@ToDate) as nvarchar )+'-'+CAST(@ToDate as nvarchar)) as datetime ))
--	SELECT b.ID, t.Name, CheckIn, discount, TotalPrice
--	FROM Bill AS b, TableCoffee AS t
--	WHERE CheckIn>= @frDate and CheckIn< @tDate and b.status = 1 AND t.ID = b.TableID
--END
--	declare @FromDate datetime;
--	set @FromDate = '10/13/2022 12:00:00 AM'
--	declare @frDate nvarchar(30);
--	set @frDate = (select cast( (select CAST(month(@FromDate) as varchar)+'-'+CAST(day(@fromdate) as nvarchar )+'-'+CAST(@FromDate as nvarchar)) as datetime ))
--	declare @tDate nvarchar(30);
--	set @tDate = (select cast( (select CAST(month(@ToDate) as varchar)+'-'+CAST(day(@ToDate) as nvarchar )+'-'+CAST(@ToDate as nvarchar)) as datetime ))
GO
-- Delete Bill
GO
CREATE PROC USP_DeleteBill
@ID INT
AS
	DELETE dbo.Bill WHERE ID = @ID
GO
-- Checkout
GO
CREATE PROC USP_CheckOut
@ID INT, @Discount INT, @TotalPrice INT
AS
	UPDATE dbo.Bill SET Status = 1, Discount = @Discount, TotalPrice = @TotalPrice WHERE ID = @ID
GO
-- Get max BillID
GO
CREATE PROC USP_GetMaxBillID
AS
	SELECT MAX(ID) FROM dbo.Bill
GO
-- End Bill's Procedures
-- ==================================================================================================================================
-- Start BillInfo's Procedures
-- Insert BillInfo
GO
CREATE PROC USP_InsertBillInfo
@BillID INT, @FoodID INT, @Amount INT
AS
BEGIN
	DECLARE @isExistBillInfo INT
	DECLARE @foodAmount INT = 1

	SELECT @isExistBillInfo = ID, @foodAmount = Amount
	FROM BillInfo
	WHERE BillID = @BillID AND FoodID = @FoodID

	IF (@isExistBillInfo > 0)
	BEGIN
		DECLARE @newAmount INT = @foodAmount + @Amount
		IF (@newAmount > 0)
			UPDATE BillInfo SET Amount = @newAmount WHERE FoodID = @FoodID
		ELSE IF (@newAmount <= 0)
			DELETE BillInfo WHERE BillID = @BillID AND FoodID = @FoodID
	END
	ELSE
		IF (@Amount > 0)
			INSERT INTO BillInfo (BillID, FoodID, Amount) VALUES (@BillID, @FoodID, @Amount)
END
GO
-- Delete BillInfo by ID
GO
CREATE PROC USP_DeleteBillInfoByBillID
@BillID INT
AS
	DELETE dbo.BillInfo WHERE BillID = @BillID
GO
-- End BillInfo's Procedures
-- ==================================================================================================================================
--- ** Some Triggers, Functions
-- Update Bill
GO
CREATE TRIGGER UTG_UpdateBill
ON Bill FOR update
AS
BEGIN
	DECLARE @billID INT
	SELECT @billID = ID FROM inserted
	DECLARE @tableID INT
	SELECT @tableID = TableID FROM Bill WHERE ID = @billID
	DECLARE @amount INT = 0
	SELECT @amount = COUNT(*) FROM Bill WHERE TableID = @tableID AND Status = 0
	if (@amount = 0)
		UPDATE TableCoffee SET Status = N'Trống' WHERE ID = @tableID
END
GO
-- Update BillInfo
GO
CREATE TRIGGER UTG_UpdateBillInfo
ON BillInfo FOR INSERT
AS
BEGIN
	DECLARE @billID INT
	SELECT @billID = BillID FROM inserted

	DECLARE @tableID INT
	SELECT @tableID = TableID FROM Bill WHERE ID = @billID AND Status = 0

	DECLARE @count INT
	SELECT @count = COUNT(*) FROM BillInfo WHERE BillID = @billID

	IF (@count > 0)
		UPDATE TableCoffee SET Status = N'Có người' WHERE ID = @tableID
	else
		UPDATE TableCoffee SET Status = N'Trống' WHERE ID = @tableID
END
GO
-- Delete BillInfo
GO
CREATE TRIGGER UTG_DeleteBillInfo
ON BillInfo FOR DELETE
AS
BEGIN
	DECLARE @IDBillInfo INT
	DECLARE @BillID INT
	SELECT @IDBillInfo = id, @BillID = BillID FROM deleted

	DECLARE @TableID INT
	SELECT @TableID = TableID FROM Bill WHERE ID = @BillID

	DECLARE @count INT = 0
	SELECT @count = COUNT(*) FROM BillInfo AS bi, Bill AS b WHERE b.ID = bi.BillID AND b.ID = @BillID AND b.status = 0

	IF (@count = 0)
		UPDATE TableCoffee SET Status = N'Trống' WHERE ID = @TableID
END
GO
-- Convert to Unsign
-- Get list Bill Day for Report
GO
CREATE PROC USP_GetListBillByDayForReport
@FromDate Date, @ToDate Date
AS
BEGIN
	SELECT t.Name, CheckIn, Discount, TotalPrice
	FROM Bill AS b, TableCoffee AS t
	WHERE CheckIn >= @FromDate AND CheckIn <= @ToDate AND b.status = 1 AND t.ID = b.TableID
END
GO
-- Delete Category
CREATE PROC USP_DeleteCategory
@ID int
AS
BEGIN
	DECLARE @FoodCount int = 0
	SELECT @FoodCount = COUNT(*) FROM Food WHERE CategoryID = @ID

	IF (@FoodCount = 0)
		DELETE CategoryFood WHERE ID = @ID
END
GO
-- ==================================================================================================================================
-- Start TableFood's Procedures
-- Delete Table's Food
CREATE PROC USP_DeleteTableFood
@ID int
AS BEGIN
	DECLARE @count int = 0
	SELECT @count = COUNT(*) FROM TableCoffee WHERE ID = @ID AND Status = N'Trống'

	IF (@count <> 0)
	BEGIN
		DECLARE @BillID int
		SELECT @BillID = b.ID FROM Bill AS b, TableCoffee AS t WHERE b.TableID = t.ID

		DELETE BillInfo WHERE BillID = @BillID
		DELETE Bill WHERE ID = @BillID
		DELETE TableCoffee WHERE ID = @ID
	END
END
GO
-- Switch Table
CREATE PROC USP_SwitchTable
@TableID1 INT, @TableID2 INT
AS
BEGIN
	DECLARE @isTable1Null INT = 0
	DECLARE @isTable2Null INT = 0
	SELECT @isTable1Null = ID FROM dbo.Bill WHERE TableID = @TableID1 AND Status = 0
	SELECT @isTable2Null = ID FROM dbo.Bill WHERE TableID = @TableID2 AND Status = 0

	IF (@isTable1Null = 0 AND @isTable2Null > 0)
		BEGIN
			UPDATE dbo.Bill SET TableID = @TableID1 WHERE ID = @isTable2Null
			UPDATE dbo.TableCoffee SET Status = N'Có người' WHERE ID = @TableID1
			UPDATE dbo.TableCoffee SET Status = N'Trống' WHERE ID = @TableID2
        END
	ELSE IF (@isTable1Null > 0 AND @isTable2Null = 0)
		BEGIN
			UPDATE dbo.Bill SET TableID = @TableID2 WHERE Status = 0 AND ID = @isTable1Null
			UPDATE dbo.TableCoffee SET Status = N'Có người' WHERE ID = @TableID2
			UPDATE dbo.TableCoffee SET Status = N'Trống' WHERE ID = @TableID1
        END
    ELSE IF (@isTable1Null > 0 AND @isTable2Null > 0)
		BEGIN
			UPDATE dbo.Bill SET TableID = @TableID2 WHERE ID = @isTable1Null
			UPDATE dbo.Bill SET TableID = @TableID1 WHERE ID = @isTable2Null
        END
END
GO
-- Get all Table
CREATE PROC USP_GetAllTable
AS
	SELECT ID, Name FROM dbo.TableCoffee
GO
-- Get list Table
CREATE PROC USP_GetListTable
AS
	SELECT * FROM dbo.TableCoffee
GO
-- Insert Table
CREATE PROC USP_InsertTable
@Name NVARCHAR(100)
AS
	INSERT dbo.TableCoffee ( Name )
	VALUES  ( @Name )
GO
-- Update Table
CREATE PROC USP_UpdateTable
@ID INT, @Name NVARCHAR(100)
AS
	UPDATE dbo.TableCoffee SET Name = @Name WHERE ID = @ID
GO
-- Get list TempBill by TableID
CREATE PROC USP_GetListTempBillByTableID
@TableID INT
AS
	SELECT f.Name, bi.Amount, f.Price, f.Price * bi.Amount AS totalPrice
	FROM dbo.BillInfo bi, dbo.Bill b, dbo.Food f
	WHERE b.ID = bi.BillID AND bi.FoodID = f.ID AND b.Status = 0 AND b.TableID = @TableID
GO
-- Merge Table
CREATE PROC USP_MergeTable
@TableID1 INT, @TableID2 INT
AS
	BEGIN
		DECLARE @UnCheckBillID1 INT = -1
		DECLARE @UnCheckBillID2 INT = -1
		SELECT @UnCheckBillID1 = ID FROM dbo.Bill WHERE TableID = @TableID1 AND Status = 0
		SELECT @UnCheckBillID2 = ID FROM dbo.Bill WHERE TableID = @TableID2 AND Status = 0

		IF (@UnCheckBillID1 != -1 AND @UnCheckBillID2 != -1)
			BEGIN
				DECLARE @BillInfoID INT
				SELECT @BillInfoID = ID FROM dbo.BillInfo WHERE BillID = @UnCheckBillID1

				UPDATE dbo.BillInfo SET BillID = @UnCheckBillID2 WHERE ID = @BillInfoID
				DELETE dbo.Bill WHERE ID = @UnCheckBillID1

				UPDATE dbo.TableCoffee SET STATUS = N'Trống' WHERE ID = @TableID1
			END
    END
GO
-- End TableFood's Procedures

-- Start Statistics'Procedures
-- Get CategoryWithPrice
GO
CREATE VIEW CategoryWithPrice 
AS
SELECT CategoryFood.Name, ISNULL(SUM(Bill.TotalPrice),0) AS TotalPrice
FROM CategoryFood JOIN Food ON CategoryFood.ID = Food.CategoryID
JOIN BillInfo ON Food.ID = BillInfo.FoodID
JOIN Bill ON BillInfo.BillID = Bill.ID
GROUP BY CategoryFood.Name
GO
-- End Statistics'Procedures