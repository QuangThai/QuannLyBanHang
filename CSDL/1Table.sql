
CREATE   DATABASE NhaHang
GO 
USE  NhaHang
GO 

/*---------------- Bang NhanVien ---------------*/
CREATE   TABLE NhanVien
(
		IdNhanVien			 VARCHAR(10) PRIMARY  KEY,
		HoLot				 NVARCHAR(100),
		Ten					 NVARCHAR(100),
		Ngaysinh			 DATETIME,
		GioiTinh			 NVARCHAR (10),
		DienThoai			 VARCHAR(15),
		Email				 VARCHAR(100),
		DiaChi				 NVARCHAR(100)
)
      
		

GO
/*------------------ Bang KhachHang ---------------------------- */
CREATE  TABLE KhachHang
(
		IdKhachHang				 VARCHAR(10) PRIMARY  KEY,
		TenKhachHang			 NVARCHAR(100),
		DienThoai				 VARCHAR(15),
		Email					 VARCHAR(100),
		DiaChi					 NVARCHAR(100)
)
	

GO
/*--------------- Bang KhuVuc ----------------------*/
CREATE   TABLE KhuVuc
(
		IdKhuVuc			 VARCHAR (5)  PRIMARY key,
		TenKhuVuc			 NVARCHAR(100) UNIQUE,
		DienGiai			 NVARCHAR(100),
		TrangThai			 NVARCHAR(30),
		 CONSTRAINT Unique_KhuVuc  UNIQUE(TenKhuVuc)
)
		
GO
/*------------------- Bang Ban -----------------------*/
CREATE   TABLE Ban
(
		STT				 INT IDENTITY(1,1),
		IdBan			 VARCHAR (5)  PRIMARY  KEY,
		TenKhuVuc		 NVARCHAR(100)  FOREIGN  KEY  REFERENCES KhuVuc(TenKhuVuc),
		TenBan			 NVARCHAR(100) UNIQUE,
		DienGiai		 NVARCHAR(100),
		TrangThai		 NVARCHAR(30),
		 CONSTRAINT Unique_Ban  UNIQUE(TenBan)
)

/*-------------------- Bang LoaiThucDon ------------*/
CREATE   TABLE LoaiThucDon
(
		IdLoaiThucDon			 VARCHAR (5)  PRIMARY key,
		TenLoaiThucDon			 NVARCHAR(100) UNIQUE,
		DienGiai				 NVARCHAR(100),
		TrangThai				 NVARCHAR(30),
)


/*-------------------- Bang ThucDon ------------*/
GO
CREATE   TABLE ThucDon
(
		IdThucDon			 VARCHAR(5)  primary  KEY,
		TenLoaiThucDon		 NVARCHAR(100) FOREIGN  KEY  REFERENCES LoaiThucDon(TenLoaiThucDon),
		TenThucDon			 NVARCHAR(100) UNIQUE,
		DonViTinh			 NVARCHAR(10),
		SoLuongTon			 FLOAT,
		DonGiaTon			 FLOAT,
		TonToiThieu			 FLOAT,
		TrangThai			 NVARCHAR(30)
)

/*---------------- Bang NguyenLieuThucDon --------------------*/	
CREATE   TABLE NguyenLieuThucDon
(
		IdNguyenLieuThucDon			 VARCHAR(5),
		IdThucDon					 VARCHAR(5)  FOREIGN  KEY  REFERENCES ThucDon(IdThucDon),
		SoLuong						 FLOAT,
		DienGiai					 NVARCHAR(100),
		TrangThai					 NVARCHAR(30)
)
	
/*---------------- Bang GoiMon --------------------*/	
GO
CREATE  TABLE GoiMon
(
	IdBan				 VARCHAR (5)  FOREIGN  KEY  REFERENCES Ban(IdBan),
	IdThucDon			 VARCHAR(5)  FOREIGN  KEY  REFERENCES ThucDon (IdThucDon),
	TenThucDon			 NVARCHAR(100),
	DonGiaTon			 DECIMAL ,
	SoLuong				 INT,
	ThoiGian			 DATETIME,
	ThanhTien			 DECIMAL
	--constraint KhoaChinh_GoiMon	primary key (IdBan)
)
 GO
 