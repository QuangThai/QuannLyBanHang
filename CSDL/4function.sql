
	USE  NhaHang
	GO 

-- Bảng : NHÂN VIÊN
	GO 
		 CREATE  FUNCTION fcgetIdNhanVien()
		 RETURNS  VARCHAR(10)
		
		
		AS 
		BEGIN 
			 DECLARE @IdNhanVien  VARCHAR(10)
			 DECLARE @MaxIdNhanVien  VARCHAR(10)
			 DECLARE @Max FLOAT
			
			
			 SELECT @MaxIdNhanVien = MAX(IdNhanVien)  FROM NhanVien
			
			 IF  EXISTS ( SELECT IdNhanVien  FROM NhanVien)
						  SET @Max = CONVERT( FLOAT, SUBSTRING(@MaxIdNhanVien,3,8)) + 1
			 ELSE
						 SET @Max=1	
			 IF (@Max < 10)
						 SET @IdNhanVien='NV' + '0000000' +  CONVERT( VARCHAR(1),@Max)
			 ELSE
			 IF (@Max < 100)
						 SET @IdNhanVien='NV' + '000000' +  CONVERT( VARCHAR(2),@Max)
			 ELSE
			 IF (@Max < 1000)
						 SET @IdNhanVien='NV' + '00000' +  CONVERT( VARCHAR(3),@Max)
			 ELSE
			 IF (@Max < 10000)
						 SET @IdNhanVien='NV' + '0000' + CONVERT ( VARCHAR(4),@Max)
			 ELSE
			 IF (@Max < 100000)
						 SET @IdNhanVien ='NV' + '000' +  CONVERT ( VARCHAR(5),@Max)
			 ELSE
			  IF (@Max < 1000000)
						 SET @IdNhanVien  ='NV' + '00' +  CONVERT( VARCHAR(6),@Max)
			  ELSE	
			 IF (@Max < 10000000)
						 SET @IdNhanVien ='NV' + '0' +  CONVERT( VARCHAR(7),@Max)
			 ELSE
						SET @IdNhanVien ='NV' +  CONVERT(VARCHAR(8),@Max)
			 RETURN @IdNhanVien
	END 
	GO 
	-- select IdNhanVien=dbo.fcgetIdNhanVien()
 ---- BANG KHACHHANG ----------------
 GO 
		 CREATE FUNCTION fcgetIdKhachHang()
		 RETURNS  VARCHAR(10)
		
		
		AS 
		BEGIN
			 DECLARE @IdKhachHang  VARCHAR(10)
			 DECLARE @MaxIdKhachHang varchar(10)
			 DECLARE @Max  float
			
			
			 SELECT @MaxIdKhachHang = MAX(IdKhachHang)  FROM KhachHang
			
			 IF  EXISTS ( SELECT IdKhachHang  FROM KhachHang)
						 SET @Max = CONVERT( FLOAT, SUBSTRING(@MaxIdKhachHang,3,8)) + 1
			 ELSE
						 SET @Max=1	
			 IF (@Max < 10)
						 SET @IdKhachHang='KH' + '0000000' +  CONVERT( VARCHAR(1),@Max)
			 ELSE
			 IF (@Max < 100)
						 SET @IdKhachHang='KH' + '000000' +  CONVERT( VARCHAR(2),@Max)
			 ELSE
			 IF (@Max < 1000)
						 SET @IdKhachHang='KH' + '00000' +  CONVERT( VARCHAR(3),@Max)
			 ELSE
			 IF (@Max < 10000)
						 SET @IdKhachHang='KH' + '0000' +  CONVERT( VARCHAR(4),@Max)
			 ELSE
			 IF (@Max < 100000)
						 SET @IdKhachHang ='KH' + '000' +  CONVERT( VARCHAR(5),@Max)
			 ELSE
			 IF (@Max < 1000000)
						 SET @IdKhachHang  ='KH' + '00' +  CONVERT( VARCHAR(6),@Max)
			 ELSE	
			 IF (@Max < 10000000)
						 SET @IdKhachHang ='KH' + '0' +  Convert( VARCHAR(7),@Max)
			 ELSE
						 SET @IdKhachHang ='KH' +   CONVERT( VARCHAR(8),@Max)
			 RETURN @IdKhachHang
	END 
	GO 
	-- select IdKhachHang=dbo.fcgetIdKhachHang()
	
	/*--------------- BANG KHU VUC ------------*/
	
	CREATE   FUNCTION fcgetIdkhuVuc()
		 returns  VARCHAR(5)
		
		
		AS 
		BEGIN 
			 DECLARE @IdKhuVuc  VARCHAR(5)
			 DECLARE @MaxIdKhuVuc  VARCHAR(5)
			 DECLARE @Max  FLOAT
			
			
			 SELECT @MaxIdKhuVuc = MAX(IdKhuVuc)  FROM KhuVuc
			
			 IF  EXISTS ( select IdKhuVuc  FROM  KhuVuc)
						 SET @Max = CONVERT( FLOAT, SUBSTRING(@MaxIdKhuVuc,3,3)) + 1
			 ELSE
						 SET @Max=1	
			 IF (@Max < 10)
						SET @IdKhuVuc='KV' + '00' + CONVERT(VARCHAR(1),@Max)
			ELSE
			 IF (@Max < 100)
						set @IdKhuVuc='KV' + '0' +  CONVERT( VARCHAR(2),@Max)
			 ELSE
						set @IdKhuVuc ='KV' +   CONVERT( VARCHAR(3),@Max)
			 RETURN @IdKhuVuc
	END 
	GO 
	-- select IdKhachHang=dbo.fcgetIdKhuVuc()
	
					/*-------- BANG BAN ---------*/

	
	CREATE   FUNCTION fcgetIdBan()
		 RETURNS  VARCHAR(5)
		
		
		AS 
		BEGIN 
			 Declare @IdBan  VARCHAR(5)
			 DECLARE @MaxIdBan  VARCHAR(5)
			 DECLARE @Max  FLOAT
			
			
			 SELECT @MaxIdBan = MAX(IdBan)  FROM Ban
			
			 IF  EXISTS ( SELECT IdBan  FROM Ban)
						 SET @Max = CONVERT( FLOAT, SUBSTRING(@MaxIdBan,4,2)) + 1
			 ELSE
						 SET @Max=1	
			 IF (@Max < 10)
						 SET @IdBan='BAN' + '0' +  CONVERT( VARCHAR(1),@Max)
			 ELSE
						 SET @IdBan ='BAN' +   CONVERT( VARCHAR(3),@Max)
			 RETURN @IdBan
	END 
	GO 
	-- select IdBan=dbo.fcgetIdBan()
	
			/*----- BANG LOAITHUCDON ----------*/
			
		CREATE   FUNCTION fcgetIdLoaiThucDon()
		 RETURNS  VARCHAR(5)
		
		
		AS 
		BEGIN 
			 DECLARE @IdLoaiThucDon		 VARCHAR(5)
			 DECLARE @MaxIdLoaiThucDon	 VARCHAR(5)
			 DECLARE @Max  FLOAT
			
			
			 SELECT @MaxIdLoaiThucDon = MAX(IdLoaiThucDon)  FROM LoaiThucDon
			
			 IF  exists ( SELECT IdLoaiThucDon  FROM LoaiThucDon)
						 SET @Max = CONVERT( FLOAT, SUBSTRING(@MaxIdLoaiThucDon,4,2)) + 1
			 ELSE
						 SET @Max=1	
			 IF (@Max < 10)
						 SET @IdLoaiThucDon='LTD' + '0' + Convert(varchar(1),@Max)
			 ELSE
						 SET @IdLoaiThucDon ='LTD' +  Convert(varchar(3),@Max)
			 RETURN @IdLoaiThucDon
	END 
	GO 
	-- select IdLoaiThucDon=dbo.fcgetIdLoaiThucDon()
	
	
			/*----- BANG THUCDON ----------*/
			
		CREATE   FUNCTION fcgetIdThucDon()
		RETURNS   VARCHAR(5)
		
		
		AS 
		BEGIN 
			 DECLARE @IdThucDon		 VARCHAR(5)
			 DECLARE @MaxIdThucDon	 varchar(5)
			 DECLARE @Max FLOAT
			
			
			 SELECT @MaxIdThucDon = MAX(IdThucDon)  FROM ThucDon
			
			 IF  EXISTS ( SELECT IdThucDon  FROM ThucDon)
						 SET @Max = CONVERT( FLOAT, SUBSTRING(@MaxIdThucDon,3,3)) + 1
			 ELSE
						 SET @Max=1	
			 IF (@Max < 10)
						 SET @IdThucDon='TD' + '00' +  CONVERT( VARCHAR(1),@Max)
			 ELSE
			 IF (@Max < 100)
						 SET @IdThucDon='TD' + '0' +  Convert( VARCHAR(2),@Max)
			 ELSE
						 SET @IdThucDon ='TD' +   CONVERT( VARCHAR(3),@Max)
			 RETURN @IdThucDon
	END 
	GO 
	-- select IdThucDon=dbo.fcgetIdThucDon()