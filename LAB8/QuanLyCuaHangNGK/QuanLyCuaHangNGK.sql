IF DB_ID(N'QuanLyCuaHangNGK') IS NULL CREATE DATABASE QuanLyCuaHangNGK;
GO
USE QuanLyCuaHangNGK;
GO

SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO

-- =========================================================================
-- 1. XÓA CÁC BẢNG NẾU ĐÃ TỒN TẠI (THEO THỨ TỰ NGƯỢC RÀNG BUỘC KHÓA NGOẠI)
-- =========================================================================
IF OBJECT_ID('ChiTietThuNo','U') IS NOT NULL DROP TABLE ChiTietThuNo;
IF OBJECT_ID('PhieuGhiNo','U') IS NOT NULL DROP TABLE PhieuGhiNo;
IF OBJECT_ID('ChiTietPhieuHen','U') IS NOT NULL DROP TABLE ChiTietPhieuHen;
IF OBJECT_ID('PhieuHenGiaoHang','U') IS NOT NULL DROP TABLE PhieuHenGiaoHang;
IF OBJECT_ID('ChiTietHoaDon','U') IS NOT NULL DROP TABLE ChiTietHoaDon;
IF OBJECT_ID('HoaDon','U') IS NOT NULL DROP TABLE HoaDon;
IF OBJECT_ID('ChiTietPhieuGiao','U') IS NOT NULL DROP TABLE ChiTietPhieuGiao;
IF OBJECT_ID('PhieuGiaoHang','U') IS NOT NULL DROP TABLE PhieuGiaoHang;
IF OBJECT_ID('ChiTietDonDatHang','U') IS NOT NULL DROP TABLE ChiTietDonDatHang;
IF OBJECT_ID('DonDatHang','U') IS NOT NULL DROP TABLE DonDatHang;
IF OBJECT_ID('KhachHang','U') IS NOT NULL DROP TABLE KhachHang;
IF OBJECT_ID('NuocGiaiKhat','U') IS NOT NULL DROP TABLE NuocGiaiKhat;
IF OBJECT_ID('NhaCungUng','U') IS NOT NULL DROP TABLE NhaCungUng;
IF OBJECT_ID('NhanHieu','U') IS NOT NULL DROP TABLE NhanHieu;
IF OBJECT_ID('NhanVien','U') IS NOT NULL DROP TABLE NhanVien;
GO

-- =========================================================================
-- 2. TẠO CÁC BẢNG DỮ LIỆU & RÀNG BUỘC (CONSTRAINTS)
-- =========================================================================

-- 2.1 Bảng Nhân Viên
CREATE TABLE NhanVien(
    MaNV varchar(20) NOT NULL PRIMARY KEY,
    HoTen nvarchar(120) NOT NULL,
    VaiTro nvarchar(50) NOT NULL,
    SoDienThoai varchar(20) NULL,
    CONSTRAINT CK_NhanVien_VaiTro CHECK(VaiTro IN (N'Quản lý', N'Bán hàng', N'Thủ kho', N'Kế toán', N'Giao hàng'))
);
GO

-- 2.2 Bảng Nhãn Hiệu
CREATE TABLE NhanHieu(
    MaNhanHieu varchar(20) NOT NULL PRIMARY KEY,
    TenNhanHieu nvarchar(100) NOT NULL UNIQUE,
    XuatXu nvarchar(100) NULL
);
GO

-- 2.3 Bảng Nhà Cung Ứng
CREATE TABLE NhaCungUng(
    MaNCC varchar(20) NOT NULL PRIMARY KEY,
    TenNCC nvarchar(150) NOT NULL UNIQUE,
    DiaChi nvarchar(250) NOT NULL,
    SoDienThoai varchar(20) NOT NULL
);
GO

-- 2.4 Bảng Nước Giải Khát
-- Lưu ý: Mỗi loại chỉ được nhập từ một nhà cung ứng theo đúng mô tả nghiệp vụ
CREATE TABLE NuocGiaiKhat(
    MaNGK varchar(20) NOT NULL PRIMARY KEY,
    TenNGK nvarchar(150) NOT NULL,
    MaNhanHieu varchar(20) NOT NULL,
    MaNCC varchar(20) NOT NULL,
    DonViTinh nvarchar(30) NOT NULL,
    SoLuongTon int NOT NULL DEFAULT 0 CHECK(SoLuongTon >= 0),
    DinhMucTonToiThieu int NOT NULL DEFAULT 10 CHECK(DinhMucTonToiThieu >= 0),
    DonGiaBan decimal(18,2) NOT NULL CHECK(DonGiaBan >= 0),
    CONSTRAINT FK_NGK_NhanHieu FOREIGN KEY(MaNhanHieu) REFERENCES NhanHieu(MaNhanHieu),
    CONSTRAINT FK_NGK_NCC FOREIGN KEY(MaNCC) REFERENCES NhaCungUng(MaNCC)
);
GO

-- 2.5 Bảng Khách Hàng (Phân biệt Khách quen và Khách vãng lai)
CREATE TABLE KhachHang(
    MaKH varchar(20) NOT NULL PRIMARY KEY,
    HoTen nvarchar(120) NOT NULL,
    SoDienThoai varchar(20) NULL,
    DiaChi nvarchar(250) NULL,
    LoaiKhach nvarchar(30) NOT NULL DEFAULT N'Vãng lai',
    HanMucNo decimal(18,2) NOT NULL DEFAULT 0 CHECK(HanMucNo >= 0),
    TongNoHienTai decimal(18,2) NOT NULL DEFAULT 0 CHECK(TongNoHienTai >= 0),
    CONSTRAINT CK_KhachHang_Loai CHECK(LoaiKhach IN (N'Khách quen', N'Vãng lai'))
);
GO

-- 2.6 Bảng Đơn Đặt Hàng (Cửa hàng gửi NCC, giao tối đa 3 đợt)
CREATE TABLE DonDatHang(
    MaDDH varchar(30) NOT NULL PRIMARY KEY,
    MaNCC varchar(20) NOT NULL,
    MaNVLap varchar(20) NOT NULL,
    NgayDat datetime NOT NULL,
    NgayNhanDuKien date NOT NULL,
    TongTienDat decimal(18,2) NOT NULL DEFAULT 0 CHECK(TongTienDat >= 0),
    SoDotGiaoDaNhan int NOT NULL DEFAULT 0 CHECK(SoDotGiaoDaNhan BETWEEN 0 AND 3),
    TrangThai nvarchar(50) NOT NULL DEFAULT N'Chưa giao',
    CONSTRAINT CK_DDH_Ngay CHECK(NgayNhanDuKien >= CAST(NgayDat AS date)),
    CONSTRAINT CK_DDH_TrangThai CHECK(TrangThai IN (N'Chưa giao', N'Đang giao', N'Đã hoàn tất', N'Hủy')),
    CONSTRAINT FK_DDH_NCC FOREIGN KEY(MaNCC) REFERENCES NhaCungUng(MaNCC),
    CONSTRAINT FK_DDH_NV FOREIGN KEY(MaNVLap) REFERENCES NhanVien(MaNV)
);
GO

-- 2.7 Bảng Chi Tiết Đơn Đặt Hàng
CREATE TABLE ChiTietDonDatHang(
    MaDDH varchar(30) NOT NULL,
    MaNGK varchar(20) NOT NULL,
    SoLuongDat int NOT NULL CHECK(SoLuongDat > 0),
    DonGiaDat decimal(18,2) NOT NULL CHECK(DonGiaDat >= 0),
    ThanhTien AS (CONVERT(decimal(18,2), SoLuongDat * DonGiaDat)) PERSISTED,
    PRIMARY KEY(MaDDH, MaNGK),
    CONSTRAINT FK_CTDDH_DDH FOREIGN KEY(MaDDH) REFERENCES DonDatHang(MaDDH),
    CONSTRAINT FK_CTDDH_NGK FOREIGN KEY(MaNGK) REFERENCES NuocGiaiKhat(MaNGK)
);
GO

-- 2.8 Bảng Phiếu Giao Hàng (Mỗi ĐĐH tối đa 3 đợt giao)
CREATE TABLE PhieuGiaoHang(
    MaPGH varchar(30) NOT NULL PRIMARY KEY,
    MaDDH varchar(30) NOT NULL,
    SoPhieuGiaoNCC varchar(50) NULL,
    DotGiao int NOT NULL CHECK(DotGiao BETWEEN 1 AND 3),
    NgayGiao datetime NOT NULL,
    MaNVNhan varchar(20) NOT NULL,
    TongTienPhaiTra decimal(18,2) NOT NULL DEFAULT 0 CHECK(TongTienPhaiTra >= 0),
    TrangThai nvarchar(50) NOT NULL DEFAULT N'Đã nhập kho',
    CONSTRAINT UQ_PhieuGiao_DDH_Dot UNIQUE(MaDDH, DotGiao),
    CONSTRAINT FK_PGH_DDH FOREIGN KEY(MaDDH) REFERENCES DonDatHang(MaDDH),
    CONSTRAINT FK_PGH_NV FOREIGN KEY(MaNVNhan) REFERENCES NhanVien(MaNV)
);
GO

-- 2.9 Bảng Chi Tiết Phiếu Giao
CREATE TABLE ChiTietPhieuGiao(
    MaPGH varchar(30) NOT NULL,
    MaNGK varchar(20) NOT NULL,
    SoLuongGiao int NOT NULL CHECK(SoLuongGiao > 0),
    DonGiaGiao decimal(18,2) NOT NULL CHECK(DonGiaGiao >= 0),
    ThanhTien AS (CONVERT(decimal(18,2), SoLuongGiao * DonGiaGiao)) PERSISTED,
    PRIMARY KEY(MaPGH, MaNGK),
    CONSTRAINT FK_CTPG_PGH FOREIGN KEY(MaPGH) REFERENCES PhieuGiaoHang(MaPGH),
    CONSTRAINT FK_CTPG_NGK FOREIGN KEY(MaNGK) REFERENCES NuocGiaiKhat(MaNGK)
);
GO

-- 2.10 Bảng Hóa Đơn Bán Hàng
CREATE TABLE HoaDon(
    MaHD varchar(30) NOT NULL PRIMARY KEY,
    MaKH varchar(20) NOT NULL,
    MaNVLap varchar(20) NOT NULL,
    NgayLap datetime NOT NULL,
    TongTien decimal(18,2) NOT NULL DEFAULT 0 CHECK(TongTien >= 0),
    TienKhachTra decimal(18,2) NOT NULL DEFAULT 0 CHECK(TienKhachTra >= 0),
    TienConLai AS (CONVERT(decimal(18,2), CASE WHEN TongTien > TienKhachTra THEN TongTien - TienKhachTra ELSE 0 END)) PERSISTED,
    HinhThucThanhToan nvarchar(50) NOT NULL,
    TrangThai nvarchar(50) NOT NULL DEFAULT N'Chưa thanh toán đủ',
    CONSTRAINT CK_HoaDon_HinhThuc CHECK(HinhThucThanhToan IN (N'Tiền mặt', N'Chuyển khoản', N'Trả chậm / Ghi nợ')),
    CONSTRAINT CK_HoaDon_TrangThai CHECK(TrangThai IN (N'Đã thanh toán', N'Chưa thanh toán đủ', N'Hủy')),
    CONSTRAINT FK_HoaDon_KhachHang FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH),
    CONSTRAINT FK_HoaDon_NV FOREIGN KEY(MaNVLap) REFERENCES NhanVien(MaNV)
);
GO

-- 2.11 Bảng Chi Tiết Hóa Đơn (Phân chia hàng giao ngay và hàng hẹn giao)
CREATE TABLE ChiTietHoaDon(
    MaHD varchar(30) NOT NULL,
    MaNGK varchar(20) NOT NULL,
    SoLuongMua int NOT NULL CHECK(SoLuongMua > 0),
    DonGiaBan decimal(18,2) NOT NULL CHECK(DonGiaBan >= 0),
    SoLuongGiaoNgay int NOT NULL DEFAULT 0 CHECK(SoLuongGiaoNgay >= 0),
    SoLuongHenGiao AS (CONVERT(int, CASE WHEN SoLuongMua > SoLuongGiaoNgay THEN SoLuongMua - SoLuongGiaoNgay ELSE 0 END)) PERSISTED,
    ThanhTien AS (CONVERT(decimal(18,2), SoLuongMua * DonGiaBan)) PERSISTED,
    PRIMARY KEY(MaHD, MaNGK),
    CONSTRAINT CK_CTHD_SoLuong CHECK(SoLuongGiaoNgay <= SoLuongMua),
    CONSTRAINT FK_CTHD_HoaDon FOREIGN KEY(MaHD) REFERENCES HoaDon(MaHD),
    CONSTRAINT FK_CTHD_NGK FOREIGN KEY(MaNGK) REFERENCES NuocGiaiKhat(MaNGK)
);
GO

-- 2.12 Bảng Phiếu Hẹn Giao Hàng (Lập khi kho thiếu hàng cho khách quen, giao nhiều đợt)
CREATE TABLE PhieuHenGiaoHang(
    MaPhieuHen varchar(30) NOT NULL PRIMARY KEY,
    MaHD varchar(30) NOT NULL,
    MaNVLap varchar(20) NOT NULL,
    DotHen int NOT NULL DEFAULT 1 CHECK(DotHen > 0),
    NgayLap datetime NOT NULL,
    NgayHenGiao date NOT NULL,
    NgayGiaoThucTe datetime NULL,
    TrangThai nvarchar(50) NOT NULL DEFAULT N'Chờ giao',
    CONSTRAINT CK_PhieuHen_TrangThai CHECK(TrangThai IN (N'Chờ giao', N'Đang giao', N'Đã giao đủ', N'Hủy')),
    CONSTRAINT FK_PhieuHen_HoaDon FOREIGN KEY(MaHD) REFERENCES HoaDon(MaHD),
    CONSTRAINT FK_PhieuHen_NV FOREIGN KEY(MaNVLap) REFERENCES NhanVien(MaNV)
);
GO

-- 2.13 Bảng Chi Tiết Phiếu Hẹn
CREATE TABLE ChiTietPhieuHen(
    MaPhieuHen varchar(30) NOT NULL,
    MaNGK varchar(20) NOT NULL,
    SoLuongHen int NOT NULL CHECK(SoLuongHen > 0),
    SoLuongDaGiao int NOT NULL DEFAULT 0 CHECK(SoLuongDaGiao >= 0),
    GhiChu nvarchar(250) NULL,
    PRIMARY KEY(MaPhieuHen, MaNGK),
    CONSTRAINT CK_CTPH_SoLuong CHECK(SoLuongDaGiao <= SoLuongHen),
    CONSTRAINT FK_CTPH_PhieuHen FOREIGN KEY(MaPhieuHen) REFERENCES PhieuHenGiaoHang(MaPhieuHen),
    CONSTRAINT FK_CTPH_NGK FOREIGN KEY(MaNGK) REFERENCES NuocGiaiKhat(MaNGK)
);
GO

-- 2.14 Bảng Phiếu Ghi Nợ (Dành cho khách quen trả chậm)
CREATE TABLE PhieuGhiNo(
    MaPhieuNo varchar(30) NOT NULL PRIMARY KEY,
    MaHD varchar(30) NOT NULL UNIQUE,
    MaKH varchar(20) NOT NULL,
    MaNVLap varchar(20) NOT NULL,
    NgayLap datetime NOT NULL,
    SoTienNo decimal(18,2) NOT NULL CHECK(SoTienNo > 0),
    SoTienDaTra decimal(18,2) NOT NULL DEFAULT 0 CHECK(SoTienDaTra >= 0),
    SoTienConLai AS (CONVERT(decimal(18,2), CASE WHEN SoTienNo > SoTienDaTra THEN SoTienNo - SoTienDaTra ELSE 0 END)) PERSISTED,
    NgayDuKienTra date NOT NULL,
    LyDoNo nvarchar(250) NOT NULL,
    TrangThai nvarchar(50) NOT NULL DEFAULT N'Đang nợ',
    CONSTRAINT CK_PhieuNo_TrangThai CHECK(TrangThai IN (N'Đang nợ', N'Đã thanh toán', N'Quá hạn')),
    CONSTRAINT CK_PhieuNo_SoTien CHECK(SoTienDaTra <= SoTienNo),
    CONSTRAINT FK_PhieuNo_HoaDon FOREIGN KEY(MaHD) REFERENCES HoaDon(MaHD),
    CONSTRAINT FK_PhieuNo_KhachHang FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH),
    CONSTRAINT FK_PhieuNo_NV FOREIGN KEY(MaNVLap) REFERENCES NhanVien(MaNV)
);
GO

-- 2.15 Bảng Chi Tiết Thu Nợ (Ghi nhận từng lần khách thanh toán nợ)
CREATE TABLE ChiTietThuNo(
    MaPhieuThu varchar(30) NOT NULL PRIMARY KEY,
    MaPhieuNo varchar(30) NOT NULL,
    NgayThu datetime NOT NULL,
    SoTienThu decimal(18,2) NOT NULL CHECK(SoTienThu > 0),
    HinhThuc nvarchar(30) NOT NULL,
    MaNVThu varchar(20) NOT NULL,
    GhiChu nvarchar(250) NULL,
    CONSTRAINT CK_ThuNo_HinhThuc CHECK(HinhThuc IN (N'Tiền mặt', N'Chuyển khoản', N'Ví điện tử')),
    CONSTRAINT FK_ThuNo_PhieuNo FOREIGN KEY(MaPhieuNo) REFERENCES PhieuGhiNo(MaPhieuNo),
    CONSTRAINT FK_ThuNo_NV FOREIGN KEY(MaNVThu) REFERENCES NhanVien(MaNV)
);
GO

-- =========================================================================
-- 3. TẠO INDEXES TỐI ƯU HÓA TRUY VẤN
-- =========================================================================
CREATE INDEX IX_DonDatHang_NCC_Ngay ON DonDatHang(MaNCC, NgayDat, TrangThai);
CREATE INDEX IX_HoaDon_Khach_Ngay ON HoaDon(MaKH, NgayLap, TrangThai);
CREATE INDEX IX_PhieuHen_HoaDon ON PhieuHenGiaoHang(MaHD, NgayHenGiao, TrangThai);
CREATE INDEX IX_PhieuGhiNo_Khach_HanTra ON PhieuGhiNo(MaKH, NgayDuKienTra, TrangThai);
CREATE INDEX IX_NuocGiaiKhat_TonKho ON NuocGiaiKhat(SoLuongTon, DinhMucTonToiThieu);
GO

-- =========================================================================
-- 4. INSERT DỮ LIỆU MẪU THỰC TẾ CHO HỆ THỐNG CỬA HÀNG NƯỚC GIẢI KHÁT
-- =========================================================================

-- 4.1 Thêm Nhân Viên
INSERT INTO NhanVien(MaNV, HoTen, VaiTro, SoDienThoai) VALUES
('NV01', N'Trần Văn An', N'Quản lý', '0901000001'),
('NV02', N'Lê Thị Mai', N'Bán hàng', '0901000002'),
('NV03', N'Nguyễn Văn Tuấn', N'Thủ kho', '0901000003'),
('NV04', N'Phạm Quốc Hùng', N'Giao hàng', '0901000004');

-- 4.2 Thêm Nhãn Hiệu
INSERT INTO NhanHieu(MaNhanHieu, TenNhanHieu, XuatXu) VALUES
('PEPSI', N'PepsiCo', N'Mỹ'),
('COCA', N'Coca-Cola', N'Mỹ'),
('THP', N'Tân Hiệp Phát', N'Việt Nam'),
('REDBULL', N'Red Bull', N'Thái Lan'),
('SABECO', N'Bia Sài Gòn (Sabeco)', N'Việt Nam');

-- 4.3 Thêm Nhà Cung Ứng
INSERT INTO NhaCungUng(MaNCC, TenNCC, DiaChi, SoDienThoai) VALUES
('NCC01', N'Công ty TNHH NGK Suntory PepsiCo Việt Nam', N'Cao ốc Sheraton, 88 Đồng Khởi, Q.1, TP.HCM', '028.3824.1234'),
('NCC02', N'Công ty TNHH Nước Giải Khát Coca-Cola VN', N'Xa lộ Hà Nội, P. Linh Trung, TP. Thủ Đức', '028.3896.2222'),
('NCC03', N'Tập đoàn Nước Giải Khát Tân Hiệp Phát', N'219 Đại Lộ Bình Dương, Thuận An, Bình Dương', '0274.375.5678'),
('NCC04', N'Công ty TNHH Red Bull (Việt Nam)', N'KCN Mỹ Phước, Bến Cát, Bình Dương', '0274.356.7890');

-- 4.4 Thêm Nước Giải Khát (Mỗi loại chỉ thuộc 1 NCC)
INSERT INTO NuocGiaiKhat(MaNGK, TenNGK, MaNhanHieu, MaNCC, DonViTinh, SoLuongTon, DinhMucTonToiThieu, DonGiaBan) VALUES
('NGK01', N'Pepsi Chai Thủy Tinh 390ml', 'PEPSI', 'NCC01', N'Két (24 chai)', 120, 30, 195000),
('NGK02', N'Sting Dâu Chai Pet 330ml', 'PEPSI', 'NCC01', N'Thùng (24 chai)', 15, 30, 210000),
('NGK03', N'7Up Lon 330ml', 'PEPSI', 'NCC01', N'Thùng (24 lon)', 60, 20, 205000),
('NGK04', N'Coca-Cola Lon 330ml', 'COCA', 'NCC02', N'Thùng (24 lon)', 85, 25, 215000),
('NGK05', N'Trà Xanh Không Độ 455ml', 'THP', 'NCC03', N'Thùng (24 chai)', 70, 20, 190000),
('NGK06', N'Nước Tăng Lực Red Bull 250ml', 'REDBULL', 'NCC04', N'Thùng (24 lon)', 45, 20, 265000);

-- 4.5 Thêm Khách Hàng (Gồm Khách quen có hạn mức nợ và Khách vãng lai)
INSERT INTO KhachHang(MaKH, HoTen, SoDienThoai, DiaChi, LoaiKhach, HanMucNo, TongNoHienTai) VALUES
('KQ01', N'Đại lý Tạp hóa Hoàng Mai', '0903888999', N'142 Võ Văn Ngân, TP. Thủ Đức', N'Khách quen', 20000000, 6500000),
('KQ02', N'Cửa hàng Tiện Lợi Minh Tâm', '0918456789', N'45 An Dương Vương, Q.5, TP.HCM', N'Khách quen', 15000000, 0),
('VL01', N'Nguyễn Văn Bình (Khách lẻ)', '0933111222', N'Q. Bình Thạnh, TP.HCM', N'Vãng lai', 0, 0);

-- 4.6 Đơn Đặt Hàng & Chi Tiết Đặt Hàng
INSERT INTO DonDatHang(MaDDH, MaNCC, MaNVLap, NgayDat, NgayNhanDuKien, TongTienDat, SoDotGiaoDaNhan, TrangThai) VALUES
('DDH01', 'NCC01', 'NV01', '2026-10-20 08:30:00', '2026-10-25', 48500000, 2, N'Đang giao');

INSERT INTO ChiTietDonDatHang(MaDDH, MaNGK, SoLuongDat, DonGiaDat) VALUES
('DDH01', 'NGK01', 100, 150000),
('DDH01', 'NGK02', 80, 165000),
('DDH01', 'NGK03', 60, 160000),
('DDH01', 'NGK04', 50, 165000);

-- 4.7 Phiếu Giao Hàng NCC (Đợt 1 và Đợt 2 trong tối đa 3 đợt)
INSERT INTO PhieuGiaoHang(MaPGH, MaDDH, SoPhieuGiaoNCC, DotGiao, NgayGiao, MaNVNhan, TongTienPhaiTra, TrangThai) VALUES
('PGH01', 'DDH01', 'PG-PEPSI-101', 1, '2026-10-22 09:00:00', 'NV03', 25000000, N'Đã nhập kho'),
('PGH02', 'DDH01', 'PG-PEPSI-102', 2, '2026-10-25 14:00:00', 'NV03', 15000000, N'Đã nhập kho');

INSERT INTO ChiTietPhieuGiao(MaPGH, MaNGK, SoLuongGiao, DonGiaGiao) VALUES
('PGH01', 'NGK01', 50, 150000),
('PGH01', 'NGK02', 40, 165000),
('PGH02', 'NGK01', 30, 150000),
('PGH02', 'NGK02', 40, 165000);

-- 4.8 Hóa Đơn Bán Hàng & Chi Tiết Hóa Đơn
-- Khách quen mua hàng, kho chỉ đủ giao 1 phần, phần còn lại hẹn giao đợt sau
INSERT INTO HoaDon(MaHD, MaKH, MaNVLap, NgayLap, TongTien, TienKhachTra, HinhThucThanhToan, TrangThai) VALUES
('HD01', 'KQ01', 'NV02', '2026-10-28 10:00:00', 39750000, 25000000, N'Trả chậm / Ghi nợ', N'Chưa thanh toán đủ');

INSERT INTO ChiTietHoaDon(MaHD, MaNGK, SoLuongMua, DonGiaBan, SoLuongGiaoNgay) VALUES
('HD01', 'NGK01', 150, 195000, 120),  -- Hẹn giao: 30 két
('HD01', 'NGK02', 50, 210000, 15);    -- Hẹn giao: 35 thùng

-- 4.9 Phiếu Hẹn Giao Hàng & Chi Tiết Phiếu Hẹn
INSERT INTO PhieuHenGiaoHang(MaPhieuHen, MaHD, MaNVLap, DotHen, NgayLap, NgayHenGiao, NgayGiaoThucTe, TrangThai) VALUES
('PH01', 'HD01', 'NV02', 1, '2026-10-28 10:15:00', '2026-10-30', NULL, N'Chờ giao');

INSERT INTO ChiTietPhieuHen(MaPhieuHen, MaNGK, SoLuongHen, SoLuongDaGiao, GhiChu) VALUES
('PH01', 'NGK01', 30, 0, N'Chờ NCC giao đợt 3 về bổ sung kho'),
('PH01', 'NGK02', 35, 0, N'Giao tận nơi trước 10h sáng ngày 30/10');

-- 4.10 Phiếu Ghi Nợ (Khách quen trả chậm số tiền còn thiếu)
INSERT INTO PhieuGhiNo(MaPhieuNo, MaHD, MaKH, MaNVLap, NgayLap, SoTienNo, SoTienDaTra, NgayDuKienTra, LyDoNo, TrangThai) VALUES
('PGN01', 'HD01', 'KQ01', 'NV02', '2026-10-28 10:20:00', 14750000, 5000000, '2026-11-15', N'Khách quen thanh toán đợt đầu, còn lại hẹn trả sau', N'Đang nợ');

-- 4.11 Chi Tiết Thu Nợ (Ghi nhận lần khách thanh toán nợ đầu tiên)
INSERT INTO ChiTietThuNo(MaPhieuThu, MaPhieuNo, NgayThu, SoTienThu, HinhThuc, MaNVThu, GhiChu) VALUES
('PTN01', 'PGN01', '2026-10-28 16:30:00', 5000000, N'Chuyển khoản', 'NV01', N'Khách chuyển khoản ngân hàng Vietcombank đợt 1');
GO
