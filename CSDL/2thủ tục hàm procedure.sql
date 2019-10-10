USE NhaHang
Go


						/*-- BANG NHAN VIEN  -- */
						
/*------------- Hien thi thong tin NhanVien -------------------*/
CREATE  PROCEDURE  spgetNhanVien
AS 
BEGIN 
	SELECT  * FROM NhanVien
	--IdNhanVien as 'Id Nhân Viên ',HoLot + + Ten as ' Họ Tên ',Ngaysinh as 'Ngày Sinh',GioiTinh as 'Giới Tính',DienThoai as 'Điện Thoại',Email,DiaChi as 'Địa chỉ' 
End
GO 
-- drop procedure spgetNhanVien
/*----------- Hien thi thong tin NhanVien bang IdNhanVien --------------*/
CREATE  PROCEDURE  spgetNhanVienByIdNhanVien
(
	@IdNhanVien  VARCHAR(10)
)
AS 
BEGIN 
	 SELECT *  FROM NhanVien  WHERE IdNhanVien =@IdNhanVien
End

GO 

/*-------------- Insert NhanVien -----------------------------*/
CREATE   PROCEDURE spInsertNhanVien
( 
		@IdNhanVien			 VARCHAR(10),
		@HoLot				 NVARCHAR(100),
		@Ten				 NVARCHAR(100),
		@Ngaysinh			 DATETIME,
		@GioiTinh			 NVARCHAR(10),
		@DienThoai			 VARCHAR(15),
		@Email				 VARCHAR(100),
		@DiaChi				 NVARCHAR(100)  
)
AS 
BEGIN 
	 INSERT  INTO NhanVien(IdNhanVien, HoLot, Ten, Ngaysinh, GioiTinh, DienThoai,Email,DiaChi)
	 VALUES(@IdNhanVien, @HoLot, @Ten, @Ngaysinh, @GioiTinh, @DienThoai,@Email,@DiaChi)
END 
GO 
/*------------------- Update NhanVien -----------------------*/
CREATE   PROCEDURE spUpdateNhanVien
(
		@IdNhanVien			 VARCHAR(10),
		@HoLot				 NVARCHAR(100),
		@Ten				 NVARCHAR(100),
		@Ngaysinh			 DATETIME,
		@GioiTinh			 NVARCHAR(10),
		@DienThoai			 VARCHAR(15),
		@Email				 VARCHAR(100),
		@DiaChi				 NVARCHAR(100)  	 
)
AS 
BEGIN 
	 UPDATE NhanVien  SET 
						HoLot = @HoLot,
						Ten =@Ten,
						Ngaysinh =@Ngaysinh,
						GioiTinh =@GioiTinh,
						DienThoai =@DienThoai,
						Email	=@Email,
						DiaChi	=@DiaChi
											 
		 WHERE IdNhanVien =@IdNhanVien
END 
GO 
/*--------------- Delete NhanVien ---------------------*/
CREATE   PROCEDURE spDeleteNhanVien
(
	@idNhanVien  VARCHAR (10)
)
AS 
BEGIN 
	 DELETE  FROM NhanVien  WHERE IdNhanVien=@idNhanVien
END 
GO 

/*--------------TIM KIEM NHAN VIEN THEO IDNHANVIEN -----------*/
CREATE  PROCEDURE  spSearchNVByIdNV
(
	@IdNhanVien  VARCHAR (10)
)
AS 
BEGIN 
	 SELECT * FROM NhanVien  WHERE IdNhanVien like  '%'+@IdNhanVien+'%'
End  
GO 

--drop  procedure spSearchNVByIdNV

/*--------------TIM KIEM NHAN VIEN THEO TEN -----------*/
CREATE   PROCEDURE spSearchNVByTenNV
(
	@Ten			 NVARCHAR(100)
)
AS 
BEGIN 
	 SELECT * FROM NhanVien  WHERE Ten like  N'%'+@Ten+'%'
End  
GO 
--drop  procedure spSearchNVByTenNV

						/*-- BANG KHACH HANG -- */
						
/*--------- Hien thi thong tin KhachHang ----------------*/
CREATE   PROCEDURE spgetKhachHang
AS 
BEGIN 
	 SELECT IdKhachHang, TenKhachHang,  DienThoai, Email,DiaChi
	 FROM Khachhang
END 
GO 
/*----------- Hien thi thong tin KhachHang bang IdKhachHang --------------*/
CREATE   PROCEDURE spgetKhachHangByIdKhachHang
(
	@IdKhachHang		 VARCHAR (10)
)
AS 
BEGIN 
	 SELECT *  FROM Khachhang  WHERE IdKhachHang = @IdKhachHang
END 
GO 
/*---------------- Insert KhachHang -------------------*/
CREATE   PROCEDURE spInsertKhachHang
( 
		@IdKhachHang			 VARCHAR(10),
		@TenKhachHang			 NVARCHAR(100),
		@DienThoai				 VARCHAR(15),
		@Email					 VARCHAR(100),
		@DiaChi					 NVARCHAR(100)
)
AS 
BEGIN 
	 INSERT  INTO KhachHang(IdKhachHang, TenKhachHang, DienThoai, Email, DiaChi)
	 VALUES(@IdKhachHang, @TenKhachHang, @DienThoai, @Email, @DiaChi)
END 
GO 


-- DROP PROCEDURE spgetKhachhang
/*---------------- Update KhachHang -----------------*/
CREATE  PROCEDURE spUpdateKhachHang
(
		@IdKhachHang			 VARCHAR(10),
		@TenKhachHang			 NVARCHAR(100),
		@DienThoai				 VARCHAR(15),
		@Email					 VARCHAR(100),
		@DiaChi					 NVARCHAR(100)
)
AS 
BEGIN 
	 UPDATE Khachhang  SET 
						TenKhachHang = @TenKhachHang,
						DienThoai =@DienThoai,
						Email	=@Email,
						DiaChi	=@DiaChi
											 
		where IdKhachHang =@IdKhachHang
END 
GO 
/*-------------------- Delete KhachHang -------------------*/
CREATE   PROCEDURE spDeleteKhachHang
(
	@IdKhachHang		 VARCHAR(10)
)
AS 
BEGIN 
	 DELETE Khachhang  WHERE IdKhachHang = @IdKhachHang
END 
GO 

						/*----------- BANG LOAITHUCDON --------------*/
						
/*--------- Hien thi thong tin LoaiThucDon ----------------*/
CREATE   PROCEDURE spgetLoaiThucDon
AS 
BEGIN 
	 SELECT *  FROM LoaiThucDon
END 
GO 
/*----------- Hien thi thong tin LoaiThucDon bang IdLoaiThucDon --------------*/
CREATE   PROCEDURE spgetLoaiThucDonByIdLoaiThucDon
(
	@IdLoaiThucDon			 VARCHAR (5)
)
AS 
BEGIN 
	 SELECT *  FROM LoaiThucDon  WHERE IdLoaiThucDon = @IdLoaiThucDon
END 
GO 
-- drop proc spgetLoaiThucDonByIdLoaiThucDon
/*---------------- Insert LoaiThucDon -------------------*/
CREATE   PROCEDURE spInsertLoaiThucDon
( 
		@IdLoaiThucDon			 VARCHAR (5),
		@TenLoaiThucDon			 NVARCHAR(100),
		@DienGiai				 NVARCHAR(100),
		@TrangThai				 NVARCHAR(30)
)
AS 
BEGIN 
	 INSERT  INTO LoaiThucDon(IdLoaiThucDon,TenLoaiThucDon,DienGiai,TrangThai)
	 VALUES(@IdLoaiThucDon,@TenLoaiThucDon,@DienGiai,@TrangThai)
END 
GO 

-- DROP PROCEDURE spInsertLoaiThucDon
/*---------------- Update LoaiThucDon -----------------*/
CREATE   PROCEDURE spUpdateLoaiThucDon
(
		@IdLoaiThucDon			 VARCHAR (5),
		@TenLoaiThucDon			 NVARCHAR(100),
		@DienGiai				 NVARCHAR(100),
		@TrangThai				 NVARCHAR(30)
)
AS 
BEGIN 
	 UPDATE LoaiThucDon  SET 
						TenLoaiThucDon=@TenLoaiThucDon,
						DienGiai=@DienGiai,
						TrangThai=@TrangThai						 
		 WHERE IdLoaiThucDon =@IdLoaiThucDon
END 
GO 
-- drop procedure spUpdateLoaiThucDon
/*-------------------- Delete LoaiThucDon -------------------*/
CREATE   PROCEDURE spDeleteLoaiThucDon
(
	@IdLoaiThucDon			 VARCHAR (5)
)
AS 
BEGIN 
	 DELETE LoaiThucDon  WHERE IdLoaiThucDon = @IdLoaiThucDon
END 
GO 
/* ----------------------- Get TenLoaiThucDon ----------------*/
CREATE   PROCEDURE spgetTenLoaiThucDon
AS 
BEGIN 
	 SELECT TenLoaiThucDon  FROM LoaiThucDon
END 
GO 
--   drop proc spgetTenLoaiThucDon
-- drop procedure spgetTenLoaiThucDonByIdThucDon


							/*-- BANG THUC DON -- */
							
/*--------- Hien thi thong tin ThucDon ----------------*/
CREATE   PROCEDURE spgetThucDon
AS 
BEGIN 
	 SELECT IdThucDon,TenLoaiThucDon,TenThucDon,DonViTinh,SoLuongTon,DonGiaTon,TonToiThieu,TrangThai	
	 FROM ThucDon
END 
GO 
-- drop proc spgetThucDon

/*--------- Hien thi thong tin ThucDon NOT TonToiThieu ----------------*/
CREATE   PROCEDURE spgetThucDonNotTTT
AS 
BEGIN 
	 SELECT IdThucDon,TenLoaiThucDon,TenThucDon,DonViTinh,SoLuongTon,DonGiaTon,TrangThai	
	 FROM ThucDon
END 
GO 
-- drop proc spgetThucDonNotTTT
/*----------- Hien thi thong tin ThucDon bang IdThucDon --------------*/
CREATE   PROCEDURE spgetThucDonByIdThucDon
(
	@IdThucDon		 VARCHAR (5)
)
AS 
BEGIN 
	 SELECT *  FROM ThucDon  WHERE IdThucDon = @IdThucDon
END 
GO 
/*---------------- Insert ThucDon -------------------*/
CREATE   PROCEDURE spInsertThucDon
( 
		@IdThucDon			 VARCHAR(5) ,
		@TenLoaiThucDon		 NVARCHAR(100),
		@TenThucDon			 NVARCHAR(100),
		@DonViTinh			 NVARCHAR(10),
		@SoLuongTon			 FLOAT,
		@DonGiaTon			 FLOAT,
		@TonToiThieu	 	 FLOAT,
		@TrangThai			 NVARCHAR(30)
)
AS 
BEGIN 
	 INSERT  INTO ThucDon(IdThucDon,TenLoaiThucDon,TenThucDon,DonViTinh,SoLuongTon,DonGiaTon,TonToiThieu,TrangThai)
	 VALUES(@IdThucDon,@TenLoaiThucDon,@TenThucDon,@DonViTinh,@SoLuongTon,@DonGiaTon,@TonToiThieu,@TrangThai)
END 
GO 

-- DROP PROCEDURE spgetThucDon
/*---------------- Update ThucDon -----------------*/
CREATE   procedure spUpdateThucDon
(
		@IdThucDon			 VARCHAR(5) ,
		@TenLoaiThucDon		 NVARCHAR(100),
		@TenThucDon			 NVARCHAR(100),
		@DonViTinh			 NVARCHAR(10),
		@SoLuongTon			 FLOAT,
		@DonGiaTon			 FLOAT,
		@TonToiThieu		 FLOAT,
		@TrangThai			 NVARCHAR(30)
)
AS 
BEGIN 
	 UPDATE ThucDon  SET 
						TenLoaiThucDon=@TenLoaiThucDon,
						TenThucDon=@TenThucDon,
						DonViTinh=@DonViTinh,
						SoLuongTon=@SoLuongTon,
						DonGiaTon=@DonGiaTon,
						TonToiThieu=@TonToiThieu,
						TrangThai=@TrangThai
											 
		 WHERE IdThucDon =@IdThucDon
END 
GO 
----   drop proc spUpdateThucDon
/*-------------------- Delete ThucDon -------------------*/
CREATE   PROCEDURE spDeleteThucDon
(
	@IdThucDon		 VARCHAR (5)
)
AS 
BEGIN 
	 DELETE ThucDon  WHERE IdThucDon = @IdThucDon
END 
GO 
/*-------------------- get DonGiaTon tu TenThucDon -------------------*/
CREATE   procedure spgetDonGiaByTenThucDon
(
	@TenThucDon			 NVARCHAR(100)
)
AS 
BEGIN 
	 SELECT DonGiaTon  AS 'Đơn giá'  FROM ThucDon  WHERE TenThucDon=@TenThucDon
END  
							/*--- BANG KHU VUC ---*/
GO 
							
/*--------- Hien thi thong tin KhuVuc ----------------*/
CREATE   PROCEDURE spgetKhuVuc
AS 
BEGIN 
	 SELECT *  FROM KhuVuc
END 
GO 
/*----------- Hien thi thong tin KhuVuc bang IdKhuVuc --------------*/
CREATE   PROC spgetKhuVucByIdKhuVuc
(
	@IdKhuVuc		 VARCHAR (5)
)
AS 
BEGIN 
	 SELECT *  FROM KhuVuc  WHERE IdKhuVuc = @IdKhuVuc
END 
GO  
-- drop proc spgetKhuVucByIdKhuVuc
/*---------------- Insert KhuVuc -------------------*/
CREATE  PROCEDURE spInsertKhuVuc
( 
		@IdKhuVuc			 varchar (5),
		@TenKhuVuc			 NVARCHAR(100),
		@DienGiai			 NVARCHAR(100),
		@TrangThai			 NVARCHAR(30)
)
AS 
BEGIN 
	 INSERT  INTO KhuVuc(IdKhuVuc, TenKhuVuc, DienGiai, TrangThai)
	 VALUES(@IdKhuVuc, @TenKhuVuc, @DienGiai, @TrangThai)
END 
GO 

-- DROP PROCEDURE spInsertKhuVuc
/*---------------- Update KhuVuc -----------------*/
CREATE   PROCEDURE spUpdateKhuVuc
(
		@IdKhuVuc			 VARCHAR (5) ,
		@TenKhuVuc			 NVARCHAR(100),
		@DienGiai			 NVARCHAR(100),
		@TrangThai			 NVARCHAR(30)
)
AS 
BEGIN 
	 UPDATE KhuVuc  SET 
						TenKhuVuc=@TenKhuVuc,
						DienGiai=@DienGiai,
						TrangThai=@TrangThai						 
		 WHERE IdKhuVuc =@IdKhuVuc
END 
GO 
-- drop procedure spUpdateKhuVuc
/*-------------------- Delete KhuVuc -------------------*/
CREATE   PROCEDURE spDeleteKhuVuc
(
	@IdKhuVuc		 VARCHAR(5)
)
AS 
BEGIN 
	 DELETE KhuVuc  WHERE IdKhuVuc = @IdKhuVuc
END 
-- drop procedure spDeleteKhuVuc
GO 

						/*----------- BANG BAN --------------*/
						
/*--------- Hien thi thong tin Ban ----------------*/
CREATE   PROCEDURE spgetBan
AS 
BEGIN 
	 SELECT IdBan,TenBan,TenKhuVuc,DienGiai,TrangThai  FROM Ban
END 
GO 
--drop  procedure spgetBan
/*----------- Hien thi thong tin Ban bang IdBan --------------*/
CREATE   PROCEDURE spgetBanByIdBan
(
	@IdBan	 VARCHAR (5)
)
AS 
BEGIN 
	 SELECT *  FROM Ban  WHERE IdBan = @IdBan
END 
GO 
-- drop proc spgetBanByIdBan
/*---------------- Insert Ban -------------------*/
CREATE   PROCEDURE spInsertBan
( 
		@IdBan			 VARCHAR (5) ,
		@TenKhuVuc		 NVARCHAR(100) ,
		@TenBan			 NVARCHAR(100),
		@DienGiai		 NVARCHAR(100),
		@TrangThai		 NVARCHAR(30)
)
AS 
Begin 
	 INSERT  INTO Ban(IdBan,TenKhuVuc, TenBan, DienGiai, TrangThai)
	 VALUES(@IdBan,@TenKhuVuc,@TenBan,@DienGiai,@TrangThai)
END 
GO

-- DROP PROCEDURE spInsertBan
/*---------------- Update Ban -----------------*/
CREATE   PROCEDURE spUpdateBan
(
		@IdBan			 VARCHAR (5) ,
		@TenKhuVuc		 NVARCHAR(100) ,
		@TenBan			 NVARCHAR(100),
		@DienGiai		 NVARCHAR(100),
		@TrangThai		 NVARCHAR(30)
)
AS 
BEGIN 
	 UPDATE Ban  SET		
						
						TenKhuVuc = @TenKhuVuc,
						TenBan=@TenBan,
						DienGiai=@DienGiai,
						TrangThai=@TrangThai						 
		 WHERE IdBan=@IdBan
END 
GO 
-- drop procedure spUpdateBan
/*-------------------- Delete Ban -------------------*/
CREATE   PROCEDURE spDeleteBan
(
	@IdBan		 VARCHAR(5)
)
AS 
BEGIN 
	 DELETE Ban  WHERE IdBan = @IdBan
END 
GO 
/*-------------------- get TenBan  -------------------*/
CREATE   PROCEDURE spgetTenBan
AS 
BEGIN 
	 SELECT TenBan  FROM Ban
END 
GO 
-- drop procedure spDeleteBan
/* ----------------------- Get TenKhuVuc ------------------- */
CREATE   PROCEDURE spgetTenKhuVuc
AS 
BEGIN 
	 select TenKhuVuc  FROM KhuVuc
END 
GO 

/*-------------------- get TenThucDon -------------------*/
CREATE   procedure spgetTenThucDon
AS 
BEGIN 
	 SELECT TenThucDon  FROM ThucDon
END 
GO 
/*-------------------- get DanhSachBan_GoiMon -------------------*/
CREATE   PROCEDURE spgetDanhSachBan_GoiMon
AS 
BEGIN 
	 SELECT  DISTINCT b.IdBan AS  'Id Bàn' , TenBan AS  'Tên Bàn',  TenKhuVuc AS  'Tên Khu Vực',DienGiai AS  'Diễn Giải'
	 FROM Ban b,GoiMon gm
	 WHERE b.IdBan = gm.IdBan
	 ORDER BY b.IdBan
END 
GO 
-- drop proc spgetDanhSachBan_GoiMon

/*-------------------- get DanhSachBan_ChuaGoiMon -------------------*/
CREATE  PROCEDURE  spgetDanhSachBan_ChuaGoiMon
AS 
BEGIN 
	SELECT   DISTINCT  IdBan AS  'Id Bàn',TenBan AS  'Tên Bàn',TenKhuVuc AS  'Tên Khu Vực',DienGiai AS  'Diễn Giải'
	from  Ban WHERE  IdBan not in (SELECT  IdBan FROM  GoiMon)
	ORDER BY IdBan,TenBan,TenKhuVuc,DienGiai
END 
-- drop proc spgetDanhSachBan_ChuaGoiMon

GO 
						/*----- BANG GOIMON-----*/

/*--------- Hien thi thong tin GoiMon ----------------*/
CREATE  PROCEDURE  spgetGoiMon
AS 
BEGIN 
	SELECT  IdBan,TenThucDon,DonGiaTon,SoLuong,ThoiGian,(SoLuong*DonGiaTon)AS  ThanhTien
	FROM  GoiMon
	ORDER BY IdBan
End
GO 
-- drop procedure spgetGoiMon
/*----------- Hien thi thong tin GoiMon bang IdBan --------------*/
CREATE  PROCEDURE  spgetGoiMonByIdBan
(
	@IdBan	 VARCHAR (5)
)
AS 
BEGIN 
	SELECT   IdBan AS  'Id Bàn', TenThucDon AS  'Tên Thực Đơn',DonGiaTon AS  'Đơn Giá',SoLuong AS  'Số Lượng ',ThoiGian AS  'Thời Gian',(SoLuong*DonGiaTon)AS  'Thành Tiền'
	FROM  GoiMon WHERE  IdBan = @IdBan
END 
GO 
-- drop proc spgetGoiMonByIdBan
/*---------------- Insert GoiMon -------------------*/
CREATE  PROCEDURE  spInsertGoiMon
( 
		@IdBan				 VARCHAR (5),
		@TenThucDon			 NVARCHAR(100),
		@DonGiaTon			 DECIMAL ,
		@SoLuong			 INT,
		@ThoiGian			 DATETIME,
		@ThanhTien			 DECIMAL
)
AS 
BEGIN 
	 INSERT  INTO GoiMon(IdBan,TenThucDon, DonGiaTon, SoLuong, ThoiGian,ThanhTien)
	 VALUES(@IdBan,@TenThucDon, @DonGiaTon, @SoLuong, @ThoiGian,@ThanhTien )
END 
GO 

-- DROP PROCEDURE spInsertGoiMon
/*---------------- Update GoiMon -----------------*/
CREATE PROCEDURE  spUpdateGoiMon
(		
		@IdBan				 VARCHAR (5),
		@TenThucDon			 NVARCHAR(100),
		@DonGiaTon			 DECIMAL ,
		@SoLuong			 INT,
		@ThoiGian			 DATETIME,
		@ThanhTien			 DECIMAL
)
AS 
BEGIN 
	UPDATE  GoiMon SET 	
						TenThucDon = @TenThucDon,
						DonGiaTon=@DonGiaTon,
						SoLuong=@SoLuong,
						ThoiGian=@ThoiGian,
						ThanhTien=@ThanhTien
	WHERE  IdBan = @IdBan			 
End
GO 
-- drop procedure spUpdateGoiMon
/*-------------------- Delete GoiMon -------------------*/
CREATE  PROCEDURE  spDeleteGoiMon
(
	@IdBan				 VARCHAR (5)
)
AS 
BEGIN 
	DELETE  GoiMon WHERE  IdBan = @IdBan
END 
GO 




/*---------- TRIGER RANG BUOC SO LUONG THUC DON ---------- */

CREATE  TRIGGER  trigger_Valid_insertUpdateGoiMon
ON  GoiMon FOR INSERT
AS 
BEGIN 
	IF  UPDATE  (SoLuong)
	BEGIN 
		 DECLARE @SoLuongBan  INT 
		 DECLARE @SoLuongCon  INT
		 DECLARE @TenThucDon  NVARCHAR(100)
		 SELECT @SoLuongBan = SoLuong,@TenThucDon = TenThucDon   FROM INSERTED
		 SELECT @SoLuongCon= SoLuongTon  FROM ThucDon 
			 WHERE TenThucDon = @TenThucDon 
			 IF((@SoLuongCon-@SoLuongBan)<0)
			 BEGIN
				PRINT ('So Luong Thuc Don Khong Du!')
				 ROLLBACK  TRANSACTION
			 END
			 ELSE 
				 UPDATE ThucDon  SET SoLuongTon = @SoLuongCon -  @SoLuongBan 
					 WHERE TenThucDon = @TenThucDon 
	 END			
END 
GO 
-- drop trigger  trigger_Valid_insertUpdateGoiMon

