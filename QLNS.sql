/****** To insert Vietnames:  ******/
/****** 1. make sure script in Unicode-16 ******/
/****** 2. Put N before Vietnames text ******/
/******    Example: N'Nguyễn Công Hoan' ******/

USE [master]
GO

WHILE EXISTS(select NULL from sys.databases where name='QLNS')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'QLNS') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [QLNS]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [QLNS]
GO

USE [QLNS]
GO

USE [QLNS]
GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblSach]    Script Date: 5/10/2018 6:20:53 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblSach](
	[STT] int IDENTITY NOT NULL,
	[MASACH] [nvarchar](8) NOT NULL,
	[TenSach] [nvarchar](50) NOT NULL,
	[MALOAISACH] [int] NOT NULL,
	[TacGia] [nvarchar](50) NOT NULL,
	[SoLuongTon] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tblSach] PRIMARY KEY CLUSTERED 
(
	[MASACH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblLoaiSach]    Script Date: 5/10/2018 6:24:24 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblLoaiSach](
	[MALOAISACH] [int] NOT NULL,
	[TENLOAISACH] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_tblLoaiSach] PRIMARY KEY CLUSTERED 
(
	[MALOAISACH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLNS]
GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblQuyDinh]    Script Date: 5/10/2018 9:11:43 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblQuyDinh](
	[ID] [int] NOT NULL,
	[LuongNhapToiThieu] [int] NOT NULL,
	[LuongTonToiDa] [int] NOT NULL,
	[TienNoToiDa] [int] NOT NULL,
	[LuongTonToiThieu] [int] NOT NULL,
 CONSTRAINT [PK_tblQuyDinh] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblPhieuNhap]    Script Date: 5/11/2018 12:36:54 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPhieuNhap](
	[MAPHIEUNHAP] [int] NOT NULL,
	[NgayNhap] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tblPhieuNhap] PRIMARY KEY CLUSTERED 
(
	[MAPHIEUNHAP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblCTPhieuNhap]    Script Date: 5/12/2018 4:45:21 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblCTPhieuNhap](
	[MACTPHIEUNHAP] [int] NOT NULL,
	[MAPHIEUNHAP] [int] NOT NULL,
	[MASACH] [int] NOT NULL,
	[SoLuongNhap] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tblCTPHIEUNHAP] PRIMARY KEY CLUSTERED 
(
	[MACTPHIEUNHAP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblBaoCaoTon]    Script Date: 5/11/2018 12:42:26 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblBaoCaoTon](
	[MABAOCAOTON] [int] NOT NULL,
	[ThangBaoCaoTon] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tblBaoCaoTon] PRIMARY KEY CLUSTERED 
(
	[MABAOCAOTON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblCTBaoCaoTon]    Script Date: 5/11/2018 12:47:41 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblCTBaoCaoTon](
	[MACTBAOCAOTON] [int] NOT NULL,
	[MASACH] [int] NOT NULL,
	[MABAOCAOTON] [int] NOT NULL,
	[SoLuongTonDau] [nchar](10) NOT NULL,
	[PhatSinh] [nchar](10) NOT NULL,
	[SoLuongTonCuoi] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tblCTBaoCaoTon] PRIMARY KEY CLUSTERED 
(
	[MACTBAOCAOTON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblHoaDon]    Script Date: 5/11/2018 12:49:08 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblHoaDon](
	[MAHD] [int] NOT NULL,
	[NgayHoaDon] [datetime2](7) NOT NULL,
	[MAKH] [int] NOT NULL,
	[TongTriGia] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tblHoaDon] PRIMARY KEY CLUSTERED 
(
	[MAHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblCTHoaDon]    Script Date: 5/11/2018 12:50:21 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblCTHoaDon](
	[MACTHD] [int] NOT NULL,
	[MAHD] [int] NOT NULL,
	[MASACH] [int] NOT NULL,
	[SoLuongBan] [nchar](10) NOT NULL,
	[DonGiaBan] [nchar](10) NOT NULL,
	[ThanhTien] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tblCTHoaDon] PRIMARY KEY CLUSTERED 
(
	[MACTHD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblKhachHang]    Script Date: 5/11/2018 12:51:38 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblKhachHang](
	[MAKH] [int] NOT NULL,
	[HoTenKH] [nvarchar](50) NOT NULL,
	[TienNoKH] [text] NOT NULL,
	[DiaChi] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[SDT] [text] NOT NULL,
 CONSTRAINT [PK_tblKhachHang] PRIMARY KEY CLUSTERED 
(
	[MAKH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblPhieuThuTien]    Script Date: 5/11/2018 12:53:36 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblPhieuThuTien](
	[MAPHIEUTHU] [int] NOT NULL,
	[MAKH] [int] NOT NULL,
	[NgayThuTien] [datetime2](7) NOT NULL,
	[SoTienThu] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tblPhieuThuTien] PRIMARY KEY CLUSTERED 
(
	[MAPHIEUTHU] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblBaoCaoCongNo]    Script Date: 5/11/2018 12:54:34 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblBaoCaoCongNo](
	[MABAOCAOCONGNO] [int] NOT NULL,
	[ThangBaoCaoCongNo] [datetime2](7) NOT NULL,
 CONSTRAINT [PK_tblBaoCaoCongNo] PRIMARY KEY CLUSTERED 
(
	[MABAOCAOCONGNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblCTBaoCaoCongNo]    Script Date: 5/11/2018 12:56:06 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblCTBaoCaoCongNo](
	[MACTBAOCAOCONGNO] [int] NOT NULL,
	[MAKH] [int] NOT NULL,
	[MABAOCAOCONGNO] [int] NOT NULL,
	[SoTienNoDau] [nchar](10) NOT NULL,
	[SoTienPhatSinh] [nchar](10) NOT NULL,
	[SoTienNoCuoi] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tblCTBaoCaoCongNo] PRIMARY KEY CLUSTERED 
(
	[MACTBAOCAOCONGNO] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


/******insert loai sach ******/
INSERT INTO [dbo].[tblLoaiSach]([MALOAISACH],[TENLOAISACH])VALUES(1,N'Chính trị')
GO
INSERT INTO [dbo].[tblLoaiSach]([MALOAISACH],[TENLOAISACH])VALUES(2,N'Khoa Học')
GO
INSERT INTO [dbo].[tblLoaiSach]([MALOAISACH],[TENLOAISACH])VALUES(3,N'Giáo Khoa')
GO
INSERT INTO [dbo].[tblLoaiSach]([MALOAISACH],[TENLOAISACH])VALUES(4,N'Thiếu nhi')
GO

/******insert quy dinh ******/
USE [QLNS]
GO

INSERT INTO [dbo].[tblQuyDinh]([ID],[LuongNhapToiThieu],[LuongTonToiDa],[TienNoToiDa],[LuongTonToiThieu])VALUES(1,150,300,20000,20)
GO

/******insert phieu nhap sach******/
USE [QLNS]
GO

INSERT INTO [dbo].[tblPhieuNhap]([MAPHIEUNHAP],[NgayNhap])VALUES(1,convert(datetime,'05/10/2018 00:00:00',101))
GO
INSERT INTO [dbo].[tblPhieuNhap]([MAPHIEUNHAP],[NgayNhap])VALUES(2,convert(datetime,'05/11/2018 00:00:00',101))
GO

/******insert chi tiet phieu nhap sach******/
USE [QLNS]
GO

INSERT INTO [dbo].[tblCTPhieuNhap]([MACTPHIEUNHAP],[MAPHIEUNHAP],[MASACH],[SoLuongNhap])VALUES(1,1,14000001,160)
GO
INSERT INTO [dbo].[tblCTPhieuNhap]([MACTPHIEUNHAP],[MAPHIEUNHAP],[MASACH],[SoLuongNhap])VALUES(2,1,14000010,150)
GO

/******insert sach******/
USE [QLNS]
GO

INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(14000001,N'Hành trình chính trị của tôi',1,N'Tony Blair',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(14000002,N'Bush và quyền lực Nước Mỹ',1,N'XXX',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(14000003,N'Chính trị thế giới sau 1945',1,N'Peter Calvocoressi',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(14000004,N'Chế độ chính trị Trung Quốc',1,N'XXX',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(14000005,N'Hồi ký chính trị',1,N'XXX',50)
Go 

INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(14000006,N'The Selfish Gene',2,N'Richard Dawkins',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(14000007,N'The structure of scientific revolutions',2,N'Thomas Kuhn',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(14000008,N'Origin of species',2,N'Charles Darwin',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(14000009,N'Guns germs and steel',2,N'Jared Diamond',50)
Go 
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(14000010,N'The grand design',2,N'Stephen Hawking',50)
GO

INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(14000011,N'Sinh học',3,N'XXX',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(14000012,N'Toán',3,N'XXX',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(14000013,N'Anh văn',3,N'XXX',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(14000014,N'Hóa học',3,N'XXX',50)
Go 
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(14000015,N'Địa lý',3,N'XXX',50)
GO

INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(14000016,N'Những tấm lòng cao cả',4,N'Edomondo De Amicis',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(14000017,N'Không gia đình',4,N'Hector Malot',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(14000018,N'Nếp gấp thời gian',4,N'Madeleine Engel',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(14000019,N'Cô bé bên cửa sổ',4,N'Tetsuko Kuroyanagy',50)
Go 
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(14000020,N'Những cuộc phiêu lưu của Pinocchio',4,N'Carlo Collodi',50)
GO

/******insert chi tiet phieu nhap sach******/
USE [QLNS]
GO

INSERT INTO [dbo].[tblKhachHang]([MAKH],[HoTenKH],[TienNoKH],[DiaChi],[Email],[SDT])VALUES(24000001,N'Nguyễn Thúy Vy','100000',N'15/96 Võ Duy Ninh, P.22, Q.Bình Thạnh, TP.HCM',N'thuyvy123@gmail.com','0123456789')
GO
INSERT INTO [dbo].[tblKhachHang]([MAKH],[HoTenKH],[TienNoKH],[DiaChi],[Email],[SDT])VALUES(24000002,N'Nguyễn Anh Tú','0',N'15/96 Võ Duy Ninh, P.22, Q.Bình Thạnh, TP.HCM',N'anhtu26396@gmail.com','0123456789')
GO

/******insert bao cao ton******/
USE [QLNS]
GO

INSERT INTO [dbo].[tblBaoCaoTon]([MABAOCAOTON],[ThangBaoCaoTon])VALUES(1,convert(datetime,'03/12/2018 00:00:00',101))
GO
INSERT INTO [dbo].[tblBaoCaoTon]([MABAOCAOTON],[ThangBaoCaoTon])VALUES(2,convert(datetime,'04/13/2018 00:00:00',101))
GO
INSERT INTO [dbo].[tblBaoCaoTon]([MABAOCAOTON],[ThangBaoCaoTon])VALUES(3,convert(datetime,'05/14/2018 00:00:00',101))
GO