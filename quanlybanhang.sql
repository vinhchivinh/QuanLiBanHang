USE [master]
GO
/****** Object:  Database [QuanLyBanHang]    Script Date: 12/10/2021 1:21:13 PM ******/
CREATE DATABASE [QuanLyBanHang]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuanLyBanHang', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyBanHang.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuanLyBanHang_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.SQLEXPRESS\MSSQL\DATA\QuanLyBanHang_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [QuanLyBanHang] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuanLyBanHang].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ARITHABORT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [QuanLyBanHang] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [QuanLyBanHang] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET  DISABLE_BROKER 
GO
ALTER DATABASE [QuanLyBanHang] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [QuanLyBanHang] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [QuanLyBanHang] SET  MULTI_USER 
GO
ALTER DATABASE [QuanLyBanHang] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [QuanLyBanHang] SET DB_CHAINING OFF 
GO
ALTER DATABASE [QuanLyBanHang] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [QuanLyBanHang] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [QuanLyBanHang] SET DELAYED_DURABILITY = DISABLED 
GO
USE [QuanLyBanHang]
GO
/****** Object:  Table [dbo].[ChiTietHoaDon]    Script Date: 12/10/2021 1:21:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChiTietHoaDon](
	[MaHD] [nvarchar](10) NOT NULL,
	[MaSP] [nvarchar](6) NOT NULL,
	[SoLuong] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDon]    Script Date: 12/10/2021 1:21:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDon](
	[MaHD] [nvarchar](10) NOT NULL,
	[MaKH] [nvarchar](10) NOT NULL,
	[MaNV] [nvarchar](6) NOT NULL,
	[NgayLapHD] [date] NOT NULL DEFAULT (getdate()),
	[NgayNhanHang] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[MaHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Khachhang]    Script Date: 12/10/2021 1:21:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Khachhang](
	[MaKH] [nvarchar](10) NOT NULL,
	[TenCty] [nvarchar](50) NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
	[ThanhPho] [nvarchar](2) NOT NULL,
	[DienThoai] [nvarchar](10) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 12/10/2021 1:21:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[NhanVien](
	[MaNV] [nvarchar](6) NOT NULL,
	[Ho] [nvarchar](30) NOT NULL,
	[Ten] [nvarchar](12) NOT NULL,
	[Nu] [int] NOT NULL DEFAULT ((0)),
	[NgayNV] [date] NOT NULL,
	[DiaChi] [nvarchar](100) NULL,
	[DienThoai] [nvarchar](10) NULL,
	[Hinh] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaNV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 12/10/2021 1:21:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SanPham](
	[MaSP] [nvarchar](6) NOT NULL,
	[TenSP] [nvarchar](50) NOT NULL,
	[DonViTinh] [nvarchar](10) NULL,
	[DonGia] [float] NOT NULL,
	[Hinh] [varbinary](max) NULL,
PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ThanhPho]    Script Date: 12/10/2021 1:21:13 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ThanhPho](
	[ThanhPho] [nvarchar](2) NOT NULL,
	[TenThanhPho] [nvarchar](50) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ThanhPho] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong]) VALUES (N'00001', N'0001', 20)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong]) VALUES (N'00001', N'0006', 50)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong]) VALUES (N'00002', N'0001', 10)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong]) VALUES (N'00003', N'0009', 12)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong]) VALUES (N'00004', N'0001', 12)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong]) VALUES (N'00005', N'0010', 12)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong]) VALUES (N'00005', N'0007', 12)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong]) VALUES (N'00006', N'0001', 1)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong]) VALUES (N'00007', N'0001', 100)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong]) VALUES (N'00007', N'0009', 100)
INSERT [dbo].[ChiTietHoaDon] ([MaHD], [MaSP], [SoLuong]) VALUES (N'00008', N'0005', 100)
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayNhanHang]) VALUES (N'00001', N'AGROMAS', N'0001', CAST(N'1999-06-28' AS Date), CAST(N'1999-07-10' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayNhanHang]) VALUES (N'00002', N'BUMEM', N'0002', CAST(N'1999-06-29' AS Date), CAST(N'1999-07-12' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayNhanHang]) VALUES (N'00003', N'ALSIMES', N'0001', CAST(N'1999-07-04' AS Date), CAST(N'1999-07-12' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayNhanHang]) VALUES (N'00004', N'AGROMAS', N'0004', CAST(N'1999-07-05' AS Date), CAST(N'1999-07-10' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayNhanHang]) VALUES (N'00005', N'COFIDEC', N'0003', CAST(N'1999-07-06' AS Date), CAST(N'1999-07-20' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayNhanHang]) VALUES (N'00006', N'ATC', N'0002', CAST(N'1999-07-07' AS Date), CAST(N'1999-07-21' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayNhanHang]) VALUES (N'00007', N'AGROMAS', N'0001', CAST(N'2000-01-01' AS Date), CAST(N'2000-02-01' AS Date))
INSERT [dbo].[HoaDon] ([MaHD], [MaKH], [MaNV], [NgayLapHD], [NgayNhanHang]) VALUES (N'00008', N'AGROMAS', N'0001', CAST(N'2010-10-10' AS Date), CAST(N'2010-10-10' AS Date))
INSERT [dbo].[Khachhang] ([MaKH], [TenCty], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'ABC', N'Ngân Hàng ABC z', N'3/2, Ninh Ki?u', N'06', N'0123456')
INSERT [dbo].[Khachhang] ([MaKH], [TenCty], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'AGROMAS', N'Cơ Điện Nông Nghiệp Q. 3', N'311 Hai Bà Trưng Q3', N'05', N'88970364')
INSERT [dbo].[Khachhang] ([MaKH], [TenCty], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'ALSIMES', N'Giày An Lạc', N'761 Trần Hưng Đạo P1', N'03', N'548456005')
INSERT [dbo].[Khachhang] ([MaKH], [TenCty], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'ASC', N'Du Lịch An Phú', N'233 Nguyễn Trãi P2', N'04', N'0588124780')
INSERT [dbo].[Khachhang] ([MaKH], [TenCty], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'ASECO', N'Giầy May 3/2', N'811 Trần Hưng Đạo P1', N'01', N'48951320')
INSERT [dbo].[Khachhang] ([MaKH], [TenCty], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'ATC', N'Sản Xuất Hàng Mỹ Thuật', N'7 Trang Tử P14', N'04', N'588512230')
INSERT [dbo].[Khachhang] ([MaKH], [TenCty], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'BUMEM', N'Xây Dựng Bình Minh', N'155 Tô Hiến Thành', N'06', N'718547896')
INSERT [dbo].[Khachhang] ([MaKH], [TenCty], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'CEMACO', N'Hóa Chất Vật Liệu', N'282 Trần Hưng Đạo P11', N'06', N'0718450057')
INSERT [dbo].[Khachhang] ([MaKH], [TenCty], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'CINOTEC', N'Điện Toán Sài Gòn', N'43 Yết Kiêu P9', N'06', N'718931752')
INSERT [dbo].[Khachhang] ([MaKH], [TenCty], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'CODACO', N'Cơ Khí Dân Dụng', N'534 Lê Văn Sĩ P14', N'04', N'588647207')
INSERT [dbo].[Khachhang] ([MaKH], [TenCty], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'COFIDEC', N'Phát Triển Kinh Té Duyên Hải', N'94 Điện Biên Phủ', N'01', N'48453710')
INSERT [dbo].[Khachhang] ([MaKH], [TenCty], [DiaChi], [ThanhPho], [DienThoai]) VALUES (N'LIPPHACO', N'Liên Phát', N'200 B?n Chuong Duong', N'04', N'0588321047')
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [Nu], [NgayNV], [DiaChi], [DienThoai], [Hinh]) VALUES (N'0001', N'Lê Văn', N'Tám', 0, CAST(N'1995-10-12' AS Date), N'45 Trần Phú Q7', N'86452345', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [Nu], [NgayNV], [DiaChi], [DienThoai], [Hinh]) VALUES (N'0002', N'Hà Vĩnh', N'Phát', 0, CAST(N'1991-07-12' AS Date), N'89 Đặng Khôi Q1', N'8352074', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [Nu], [NgayNV], [DiaChi], [DienThoai], [Hinh]) VALUES (N'0003', N'Trần Tuyết', N'Oanh', 1, CAST(N'1991-02-27' AS Date), N'26 Lê Quí Đôn P6 Q3', N'8557798', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [Nu], [NgayNV], [DiaChi], [DienThoai], [Hinh]) VALUES (N'0004', N'Nguyễn Kim', N'Ngọc', 1, CAST(N'1992-03-30' AS Date), N'178 Hậu Giang P6 Q6', N'8553278', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [Nu], [NgayNV], [DiaChi], [DienThoai], [Hinh]) VALUES (N'0005', N'Trương Duy ', N'Hùng', 0, CAST(N'1992-09-13' AS Date), N'77 Trương Định P6 Q3', N'8940295', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [Nu], [NgayNV], [DiaChi], [DienThoai], [Hinh]) VALUES (N'0006', N'Lương Bá ', N'Thắng', 0, CAST(N'1992-09-13' AS Date), N'92 Lê Thánh Tôn Q1', N'8940549', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [Nu], [NgayNV], [DiaChi], [DienThoai], [Hinh]) VALUES (N'0007', N'Trần thị', N'Lan', 1, CAST(N'2000-10-20' AS Date), N'15 Nguyễn Trãi Q5', N'85656634', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [Nu], [NgayNV], [DiaChi], [DienThoai], [Hinh]) VALUES (N'0008', N'Tạ thành', N'Tâm', 0, CAST(N'2005-10-12' AS Date), N'20 Võ thị Sáu Q3', N'85656666', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [Nu], [NgayNV], [DiaChi], [DienThoai], [Hinh]) VALUES (N'0009', N'Ngô Thanh', N'Sơn', 0, CAST(N'2010-12-20' AS Date), N'122 Trần Phú Q5', N'85654166', NULL)
INSERT [dbo].[NhanVien] ([MaNV], [Ho], [Ten], [Nu], [NgayNV], [DiaChi], [DienThoai], [Hinh]) VALUES (N'0010', N'Lê thị', N'Thủy', 1, CAST(N'2010-10-10' AS Date), N'25 Ngô Quyền Q10', N'97654123', NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonViTinh], [DonGia], [Hinh]) VALUES (N'0001', N'Bia 333', N'Thung', 220000, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonViTinh], [DonGia], [Hinh]) VALUES (N'0002', N'Bia Tiger', N'Thung', 310000, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonViTinh], [DonGia], [Hinh]) VALUES (N'0003', N'Bia Heineken', N'Thung', 380000, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonViTinh], [DonGia], [Hinh]) VALUES (N'0004', N'Rượu Bình tây', N'Chai', 150000, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonViTinh], [DonGia], [Hinh]) VALUES (N'0005', N'Rượu Napoleon', N'Chai', 430500, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonViTinh], [DonGia], [Hinh]) VALUES (N'0006', N'Gia vị', N'Thùng', 400000, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonViTinh], [DonGia], [Hinh]) VALUES (N'0007', N'Bánh kem', N'Cái', 200000, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonViTinh], [DonGia], [Hinh]) VALUES (N'0008', N'Bơ', N'Kg', 380000, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonViTinh], [DonGia], [Hinh]) VALUES (N'0009', N'Bánh mì', N'Cái', 10000, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonViTinh], [DonGia], [Hinh]) VALUES (N'0010', N'Nem', N'Kg', 83790, NULL)
INSERT [dbo].[SanPham] ([MaSP], [TenSP], [DonViTinh], [DonGia], [Hinh]) VALUES (N'0011', N'Táo', N'Kg', 15000, NULL)
INSERT [dbo].[ThanhPho] ([ThanhPho], [TenThanhPho]) VALUES (N'01', N'Hà Nội')
INSERT [dbo].[ThanhPho] ([ThanhPho], [TenThanhPho]) VALUES (N'02', N'Hải Phòng')
INSERT [dbo].[ThanhPho] ([ThanhPho], [TenThanhPho]) VALUES (N'03', N'Huế')
INSERT [dbo].[ThanhPho] ([ThanhPho], [TenThanhPho]) VALUES (N'04', N'Nha Trang')
INSERT [dbo].[ThanhPho] ([ThanhPho], [TenThanhPho]) VALUES (N'05', N'TP HCM')
INSERT [dbo].[ThanhPho] ([ThanhPho], [TenThanhPho]) VALUES (N'06', N'Cần Thơ')
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaHD])
REFERENCES [dbo].[HoaDon] ([MaHD])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[ChiTietHoaDon]  WITH CHECK ADD FOREIGN KEY([MaSP])
REFERENCES [dbo].[SanPham] ([MaSP])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[Khachhang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[Khachhang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[Khachhang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaKH])
REFERENCES [dbo].[Khachhang] ([MaKH])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[HoaDon]  WITH CHECK ADD FOREIGN KEY([MaNV])
REFERENCES [dbo].[NhanVien] ([MaNV])
GO
ALTER TABLE [dbo].[Khachhang]  WITH CHECK ADD FOREIGN KEY([ThanhPho])
REFERENCES [dbo].[ThanhPho] ([ThanhPho])
GO
ALTER TABLE [dbo].[Khachhang]  WITH CHECK ADD FOREIGN KEY([ThanhPho])
REFERENCES [dbo].[ThanhPho] ([ThanhPho])
GO
ALTER TABLE [dbo].[Khachhang]  WITH CHECK ADD FOREIGN KEY([ThanhPho])
REFERENCES [dbo].[ThanhPho] ([ThanhPho])
GO
ALTER TABLE [dbo].[Khachhang]  WITH CHECK ADD FOREIGN KEY([ThanhPho])
REFERENCES [dbo].[ThanhPho] ([ThanhPho])
GO
USE [master]
GO
ALTER DATABASE [QuanLyBanHang] SET  READ_WRITE 
GO
