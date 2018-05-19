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
	[ApDung][text] NOT NULL,
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
	[SoLuongTonDau] [int] NOT NULL,
	[PhatSinh] [int] NOT NULL,
	[SoLuongTonCuoi] [int] NOT NULL,
 CONSTRAINT [PK_tblCTBaoCaoTon] PRIMARY KEY CLUSTERED 
(
	[MACTBAOCAOTON] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

USE [QLNS]
GO

/****** Object:  Table [dbo].[tblHoaDon]    Script Date: 5/19/2018 1:23:10 PM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblHoaDon](
	[MAHD] [int] NOT NULL,
	[NgayHoaDon] [datetime2](7) NOT NULL,
	[MAKH] [int] NOT NULL,
	[TongTriGiaHD] [int] NOT NULL,
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
	[SoLuongBan] [int] NOT NULL,
	[DonGiaBan] [int] NOT NULL,
	[ThanhTien] [int] NOT NULL,
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
	[SoTienThu] [int] NOT NULL,
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

INSERT INTO [dbo].[tblQuyDinh]([ID],[LuongNhapToiThieu],[LuongTonToiDa],[TienNoToiDa],[LuongTonToiThieu],[ApDung])VALUES(1,150,300,20000,20,N'0')
GO

/******insert phieu nhap sach******/
USE [QLNS]
GO

INSERT INTO [dbo].[tblPhieuNhap]([MAPHIEUNHAP],[NgayNhap])VALUES(1,convert(datetime,'05/10/2018',101))
GO
INSERT INTO [dbo].[tblPhieuNhap]([MAPHIEUNHAP],[NgayNhap])VALUES(2,convert(datetime,'05/11/2018',101))
GO

/******insert chi tiet phieu nhap sach******/
USE [QLNS]
GO

INSERT INTO [dbo].[tblCTPhieuNhap]([MACTPHIEUNHAP],[MAPHIEUNHAP],[MASACH],[SoLuongNhap])VALUES(1,1,1,150)
GO
INSERT INTO [dbo].[tblCTPhieuNhap]([MACTPHIEUNHAP],[MAPHIEUNHAP],[MASACH],[SoLuongNhap])VALUES(2,1,10,150)
GO

/******insert sach******/
USE [QLNS]
GO

INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(1,N'Hành trình chính trị của tôi',1,N'Tony Blair',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(2,N'Bush và quyền lực Nước Mỹ',1,N'XXX',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(3,N'Chính trị thế giới sau 1945',1,N'Peter Calvocoressi',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(4,N'Chế độ chính trị Trung Quốc',1,N'XXX',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(5,N'Hồi ký chính trị',1,N'XXX',50)
Go 

INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(6,N'The Selfish Gene',2,N'Richard Dawkins',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(7,N'The structure of scientific revolutions',2,N'Thomas Kuhn',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(8,N'Origin of species',2,N'Charles Darwin',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(9,N'Guns germs and steel',2,N'Jared Diamond',50)
Go 
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(10,N'The grand design',2,N'Stephen Hawking',50)
GO

INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(11,N'Sinh học',3,N'XXX',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(12,N'Toán',3,N'XXX',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(13,N'Anh văn',3,N'XXX',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(14,N'Hóa học',3,N'XXX',50)
Go 
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(15,N'Địa lý',3,N'XXX',50)
GO

INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(16,N'Những tấm lòng cao cả',4,N'Edomondo De Amicis',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(17,N'Không gia đình',4,N'Hector Malot',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(18,N'Nếp gấp thời gian',4,N'Madeleine Engel',50)
GO
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(19,N'Cô bé bên cửa sổ',4,N'Tetsuko Kuroyanagy',50)
Go 
INSERT INTO [dbo].[tblSach]([MASACH],[TenSach],[MALOAISACH],[TacGia],[SoLuongTon])VALUES(20,N'Những cuộc phiêu lưu của Pinocchio',4,N'Carlo Collodi',50)
GO

/******insert khach hang******/
USE [QLNS]
GO

INSERT INTO [dbo].[tblKhachHang]([MAKH],[HoTenKH],[TienNoKH],[DiaChi],[Email],[SDT])VALUES(1,N'Nguyễn Thúy Vy','100000',N'15/96 Võ Duy Ninh, P.22, Q.Bình Thạnh, TP.HCM',N'thuyvy123@gmail.com','0123456789')
GO
INSERT INTO [dbo].[tblKhachHang]([MAKH],[HoTenKH],[TienNoKH],[DiaChi],[Email],[SDT])VALUES(2,N'Nguyễn Anh Tú','0',N'15/96 Võ Duy Ninh, P.22, Q.Bình Thạnh, TP.HCM',N'anhtu26396@gmail.com','0123456789')
GO

/******insert bao cao ton******/
USE [QLNS]
GO

INSERT INTO [dbo].[tblBaoCaoTon]([MABAOCAOTON],[ThangBaoCaoTon])VALUES(1,convert(datetime,'03/19/2018',101))
GO
INSERT INTO [dbo].[tblBaoCaoTon]([MABAOCAOTON],[ThangBaoCaoTon])VALUES(2,convert(datetime,'04/19/2018',101))
GO
INSERT INTO [dbo].[tblBaoCaoTon]([MABAOCAOTON],[ThangBaoCaoTon])VALUES(3,convert(datetime,'05/19/2018',101))
GO

/******insert hoa don******/
USE [QLNS]
GO

INSERT INTO [dbo].[tblHoaDon]([MAHD],[NgayHoaDon],[MAKH],[TongTriGiaHD])VALUES(1,convert(datetime,'05/14/2018',101),1,0)
GO
INSERT INTO [dbo].[tblHoaDon]([MAHD],[NgayHoaDon],[MAKH],[TongTriGiaHD])VALUES(2,convert(datetime,'05/15/2018',101),2,0)
GO

/******insert chi tiet hoa don******/
USE [QLNS]
GO

INSERT INTO [dbo].[tblCTHoaDon]([MACTHD],[MAHD],[MASACH],[SoLuongBan],[DonGiaBan],[ThanhTien])VALUES(1,1,1,3,15000,45000)
GO

/******insert phieu thu tien******/
USE [QLNS]
GO

INSERT INTO [dbo].[tblPhieuThuTien]([MAPHIEUTHU],[MAKH],[NgayThuTien],[SoTienThu])VALUES(1,1,convert(datetime,'05/15/2018',101),500000)
GO
INSERT INTO [dbo].[tblPhieuThuTien]([MAPHIEUTHU],[MAKH],[NgayThuTien],[SoTienThu])VALUES(2,2,convert(datetime,'05/18/2018',101),198000)
GO

/******insert CT Bao Cao Ton******/
USE [QLNS]
GO

INSERT INTO [dbo].[tblCTBaoCaoTon]([MACTBAOCAOTON],[MASACH],[MABAOCAOTON],[SoLuongTonDau],[PhatSinh],[SoLuongTonCuoi])VALUES(1,10,1,300,1,30)
GO
INSERT INTO [dbo].[tblCTBaoCaoTon]([MACTBAOCAOTON],[MASACH],[MABAOCAOTON],[SoLuongTonDau],[PhatSinh],[SoLuongTonCuoi])VALUES(2,11,1,300,0,31)
GO
INSERT INTO [dbo].[tblCTBaoCaoTon]([MACTBAOCAOTON],[MASACH],[MABAOCAOTON],[SoLuongTonDau],[PhatSinh],[SoLuongTonCuoi])VALUES(3,12,1,300,2,50)
GO
INSERT INTO [dbo].[tblCTBaoCaoTon]([MACTBAOCAOTON],[MASACH],[MABAOCAOTON],[SoLuongTonDau],[PhatSinh],[SoLuongTonCuoi])VALUES(4,13,1,300,3,22)
GO

INSERT INTO [dbo].[tblCTBaoCaoTon]([MACTBAOCAOTON],[MASACH],[MABAOCAOTON],[SoLuongTonDau],[PhatSinh],[SoLuongTonCuoi])VALUES(5,11,2,300,0,31)
GO
INSERT INTO [dbo].[tblCTBaoCaoTon]([MACTBAOCAOTON],[MASACH],[MABAOCAOTON],[SoLuongTonDau],[PhatSinh],[SoLuongTonCuoi])VALUES(6,12,2,300,2,50)
GO
INSERT INTO [dbo].[tblCTBaoCaoTon]([MACTBAOCAOTON],[MASACH],[MABAOCAOTON],[SoLuongTonDau],[PhatSinh],[SoLuongTonCuoi])VALUES(7,13,2,300,3,22)
GO

INSERT INTO [dbo].[tblCTBaoCaoTon]([MACTBAOCAOTON],[MASACH],[MABAOCAOTON],[SoLuongTonDau],[PhatSinh],[SoLuongTonCuoi])VALUES(8,17,3,300,0,31)
GO
INSERT INTO [dbo].[tblCTBaoCaoTon]([MACTBAOCAOTON],[MASACH],[MABAOCAOTON],[SoLuongTonDau],[PhatSinh],[SoLuongTonCuoi])VALUES(9,19,3,300,2,50)
GO

/******insert CT Bao Cao Cong No******/
USE [QLNS]
GO

INSERT INTO [dbo].[tblBaoCaoCongNo]([MABAOCAOCONGNO],[ThangBaoCaoCongNo])VALUES(1,convert(datetime,'01/19/2018',101))
GO
INSERT INTO [dbo].[tblBaoCaoCongNo]([MABAOCAOCONGNO],[ThangBaoCaoCongNo])VALUES(2,convert(datetime,'02/19/2018',101))
GO
INSERT INTO [dbo].[tblBaoCaoCongNo]([MABAOCAOCONGNO],[ThangBaoCaoCongNo])VALUES(3,convert(datetime,'03/19/2018',101))
GO
INSERT INTO [dbo].[tblBaoCaoCongNo]([MABAOCAOCONGNO],[ThangBaoCaoCongNo])VALUES(4,convert(datetime,'04/19/2018',101))
GO

select *
from tblBaoCaoCongNo 
where month(ThangBaoCaoCongNo) = '4'

