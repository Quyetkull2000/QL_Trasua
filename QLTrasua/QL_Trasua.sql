CREATE DATABASE QLTraSua
GO

USE QLTraSua
GO

-- Food
-- Table
-- FoodCategory
-- Account
-- Bill
-- BillInfo

CREATE TABLE TableFood
(
	id INT IDENTITY(1,1) PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Bàn chưa có tên',
	status NVARCHAR(100) NOT NULL DEFAULT N'Trống'	-- Trống || Có người
)
GO

go
Insert into TableFood values 
	(N'Bàn 1',N'Trống'),
	(N'Bàn 2',N'Trống'),
	(N'Bàn 3',N'Trống'),
	(N'Bàn 4',N'Trống'),
	(N'Bàn 5',N'Trống'),
	(N'Bàn 6',N'Trống'),
	(N'Bàn 7',N'Trống'),
	(N'Bàn 8',N'Trống'),
	(N'Bàn 9',N'Trống'),
	(N'Bàn 10',N'Trống')

	
GO
select * from TableFood
CREATE TABLE Account
(
	UserName NVARCHAR(100) PRIMARY KEY,	
	DisplayName NVARCHAR(100) NOT NULL DEFAULT N'Qkull',
	PassWord NVARCHAR(1000) NOT NULL DEFAULT 0,
	Type INT NOT NULL  DEFAULT 0 -- 1: admin && 0: staff
)
GO

Insert into Account values 
	('admin','Admin','admin123',1),
	('Quyetkull',N'Quản lý','Quyetkull2000',0),
	('Quangbess',N'Nhân viên','Quangbees2000',0)
	
GO

CREATE TABLE FoodCategory
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên'
)
GO

Insert into FoodCategory values
	(N'Hồng Trà'),
	(N'Trà sữa'),
	(N'Sinh Tố'),
	(N'Đồ ăn kèm')



CREATE TABLE Food
(
	id INT IDENTITY PRIMARY KEY,
	name NVARCHAR(100) NOT NULL DEFAULT N'Chưa đặt tên',
	idCategory INT NOT NULL,
	price FLOAT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idCategory) REFERENCES dbo.FoodCategory(id)
)
GO

Insert into Food values
	(N'Trà sữa trân châu Hoàng Gia','2','25000'),
	(N'Trà sữa Dâu Pha Lê Tuyết','2','45000'),
	(N'Trà sữa khoai môn','2','42000'),
	(N'Trà sữa Xoài','2','42000'),
	(N'Trà sữa trân châu kem cheese','2','36000'),
	(N'Trà sữa Thạch Đào Tiên Tử','2','50000'),
	(N'Trà sữa Matcha','2','27000'),
	(N'Trà sữa Socola','2','27000'),
	(N'Sinh Tố Xoài','3','32000'),
	(N'Sinh Tố Dâu','3','39000'),
	(N'Sinh Tố Dưa Hấu','3','29000'),
	(N'Sinh Tố Dứa','3','45000'),
	(N'Hồng Trà cam xả','1','22000'),
	(N'Hồng Trà Xoài','1','20000'),
	(N'Hồng Trà Hoàng Gia','1','18000'),
	(N'Hướng dương','4','10000'),
	(N'Cá viên chiên','4','25000'),
	(N'Khoai Tây Chiên','4','25000'),
	(N'Bắp xào tép','4','25000')

GO

CREATE TABLE Bill
(
	id INT IDENTITY PRIMARY KEY,
	DateCheckIn DATE NOT NULL DEFAULT GETDATE(),
	DateCheckOut DATE,
	idTable INT NOT NULL,
	status INT NOT NULL DEFAULT 0 -- 1: đã thanh toán && 0: chưa thanh toán
	
	FOREIGN KEY (idTable) REFERENCES dbo.TableFood(id)
)
GO

Insert into Bill values
	(GETDATE(),null,1,0), --Checkin/Checkout/idTable/status(1-Checkout rồi/0-Chưa Checkout)
	(GETDATE(),null,2,0),
	(GETDATE(),null,2,1)

GO

CREATE TABLE BillInfo
(
	id INT IDENTITY PRIMARY KEY,
	idBill INT NOT NULL,
	idFood INT NOT NULL,
	count INT NOT NULL DEFAULT 0
	
	FOREIGN KEY (idBill) REFERENCES dbo.Bill(id),
	FOREIGN KEY (idFood) REFERENCES dbo.Food(id)
)
GO

Insert into BillInfo values
	(1,6,2),  --idBill / idFood / count(SL)
	(2,8,3), 
	(3,7,4) 


--Test Bảng
	select * from Account
	select * from Food
	select * from FoodCategory
	select * from Bill
	select * from BillInfo

GO

--Lấy thông tin người dùng có username là giá trị nhập vào
CREATE PROC sp_GetAccount @username nvarchar(100)
AS
	BEGIN
		Select * from Account where UserName= @username
	END
GO

EXEC sp_GetAccount @username= N'Quyetkull' 
Select * from Account where UserName= N'Quyetkull' and PassWord= '1'

GO

--Lấy thông tin đăng nhập(Lấy tất cả thông tin từ bảng Account khi đúng username và password)
Create Proc sp_Login  @userName nvarchar(100), @passWord nvarchar(100)
As
Begin
	Select * from Account Where UserName= @userName and PassWord= @passWord
End

Go

--In ra danh sách tất cả thông tin của TableFood
Create Proc sp_GetTableList
As
	Select * from TableFood

Go

Update TableFood set status= N'Có người' where id= 8

Exec sp_GetTableList

Go

select * from Bill where idTable=3 and status =1

Select Food.name, BillInfo.count, Food.price, Food.price*BillInfo.count as totalPrice from BillInfo, Bill, Food where BillInfo.idBill = Bill.id and BillInfo.idFood = Food.id and Bill.idTable= 2

--Select f.name , bi.count , f.price, f.price*bi.count as totalPrice from BillInfo as bi, Bill as b, Food as f where bi.idBill = b.id and bi.idFood = f.id and b.idTable= 2

GO

select * from Food

go

select * from Food where idCategory = 2

go

select * from FoodCategory

Go
-- Thêm món vào Bill
create proc sp_InsertBill @idTable int
As
Begin
	Insert Bill(DateCheckIn,DateCheckOut,idTable,status) values (GETDATE(),null,@idTable,0)
End

Go

Create Proc sp_BillInfo 
@idBill int, @idFood int, @count int
As
Begin
	Insert BillInfo(idBill,idFood,count) Values (@idBill,@idFood,@count)
End

SELECT ID, Name AS Tên FROM FoodCategory