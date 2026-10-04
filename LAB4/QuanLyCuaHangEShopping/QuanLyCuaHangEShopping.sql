IF DB_ID(N'eShoppingDB') IS NULL CREATE DATABASE eShoppingDB;
GO
USE eShoppingDB;
GO

-- 1. XÓA BẢNG CŨ THEO THỨ TỰ PHỤ THUỘC KHÓA NGOẠI
IF OBJECT_ID('ThanhToan','U') IS NOT NULL DROP TABLE ThanhToan;
IF OBJECT_ID('ChiTietDonHang','U') IS NOT NULL DROP TABLE ChiTietDonHang;
IF OBJECT_ID('DonDatHang','U') IS NOT NULL DROP TABLE DonDatHang;
IF OBJECT_ID('ChinhSachMienPhi','U') IS NOT NULL DROP TABLE ChinhSachMienPhi;
IF OBJECT_ID('PhiGiaoHang','U') IS NOT NULL DROP TABLE PhiGiaoHang;
IF OBJECT_ID('KhuVucGiaoHang','U') IS NOT NULL DROP TABLE KhuVucGiaoHang;
IF OBJECT_ID('LoaiPhieuDatHang','U') IS NOT NULL DROP TABLE LoaiPhieuDatHang;
IF OBJECT_ID('LoaiTheTinDung','U') IS NOT NULL DROP TABLE LoaiTheTinDung;
IF OBJECT_ID('NguoiNhanHang','U') IS NOT NULL DROP TABLE NguoiNhanHang;
IF OBJECT_ID('KhachHang','U') IS NOT NULL DROP TABLE KhachHang;
IF OBJECT_ID('SanPham','U') IS NOT NULL DROP TABLE SanPham;
IF OBJECT_ID('NhomSanPham','U') IS NOT NULL DROP TABLE NhomSanPham;
GO

-- 2. TẠO CÁC BẢNG DANH MỤC VÀ ĐỐI TƯỢNG CƠ BẢN

-- Bảng Nhóm sản phẩm
CREATE TABLE NhomSanPham(
    MaNhom varchar(20) NOT NULL PRIMARY KEY,
    TenNhom nvarchar(100) NOT NULL UNIQUE
);

-- Bảng Sản phẩm (lấy từ Hệ thống Quản lý Sản phẩm)
CREATE TABLE SanPham(
    MaSP varchar(20) NOT NULL PRIMARY KEY,
    MaNhom varchar(20) NOT NULL,
    TenSP nvarchar(200) NOT NULL,
    NhaSanXuat nvarchar(100) NOT NULL,
    HinhAnh varchar(255) NULL,
    MoTa nvarchar(max) NULL,
    ThongSoKyThuat nvarchar(max) NULL,
    GiaHienHanh decimal(18,2) NOT NULL CHECK(GiaHienHanh >= 0),
    TinhTrang nvarchar(50) NOT NULL DEFAULT N'Còn hàng',
    CONSTRAINT CK_SanPham_TinhTrang CHECK(TinhTrang IN (N'Còn hàng', N'Hết hàng')),
    CONSTRAINT FK_SanPham_Nhom FOREIGN KEY(MaNhom) REFERENCES NhomSanPham(MaNhom)
);

-- Bảng Khách hàng (Tài khoản người mua)
CREATE TABLE KhachHang(
    MaKH varchar(20) NOT NULL PRIMARY KEY,
    HoTen nvarchar(120) NOT NULL,
    NgaySinh date NOT NULL,
    SoCMND varchar(30) NOT NULL UNIQUE,
    DiaChi nvarchar(250) NOT NULL,
    SoDienThoai varchar(20) NOT NULL,
    TenDangNhap varchar(50) NOT NULL UNIQUE,
    MatKhau varchar(100) NOT NULL,
    Email varchar(100) NULL -- Email là tùy chọn (BR14)
);

-- Bảng Người nhận hàng (Có thể khác người mua - BR08)
CREATE TABLE NguoiNhanHang(
    MaNguoiNhan varchar(20) NOT NULL PRIMARY KEY,
    HoTen nvarchar(120) NOT NULL,
    DiaChi nvarchar(250) NOT NULL,
    SoDienThoai varchar(20) NOT NULL
);

-- Bảng Loại phiếu đặt hàng (3 loại phiếu - BR04)
CREATE TABLE LoaiPhieuDatHang(
    MaLoaiPhieu varchar(20) NOT NULL PRIMARY KEY,
    TenLoaiPhieu nvarchar(100) NOT NULL UNIQUE,
    DonGia decimal(18,2) NOT NULL CHECK(DonGia >= 0),
    ThoiGianXuLy nvarchar(100) NOT NULL,
    CONSTRAINT CK_LoaiPhieu_Ten CHECK(TenLoaiPhieu IN (
        N'Phiếu đặt hàng thường', 
        N'Phiếu đặt hàng chuyển phát nhanh', 
        N'Phiếu đặt hàng chuyển phát nhanh trong ngày'
    ))
);

-- Bảng Khu vực giao hàng (phục vụ tính phí theo địa chỉ - BR07)
CREATE TABLE KhuVucGiaoHang(
    MaKhuVuc varchar(20) NOT NULL PRIMARY KEY,
    TenKhuVuc nvarchar(100) NOT NULL UNIQUE
);

-- Bảng Phí giao hàng (Khu vực x Loại hình giao hàng)
CREATE TABLE PhiGiaoHang(
    MaPhi varchar(20) NOT NULL PRIMARY KEY,
    MaKhuVuc varchar(20) NOT NULL,
    MaLoaiPhieu varchar(20) NOT NULL,
    ChiPhi decimal(18,2) NOT NULL CHECK(ChiPhi >= 0),
    CONSTRAINT UQ_PhiGiaoHang_KV_Loai UNIQUE(MaKhuVuc, MaLoaiPhieu),
    CONSTRAINT FK_PhiGiaoHang_KhuVuc FOREIGN KEY(MaKhuVuc) REFERENCES KhuVucGiaoHang(MaKhuVuc),
    CONSTRAINT FK_PhiGiaoHang_LoaiPhieu FOREIGN KEY(MaLoaiPhieu) REFERENCES LoaiPhieuDatHang(MaLoaiPhieu)
);

-- Bảng Chính sách miễn phí vận chuyển (Ngưỡng 1tr và 5tr - BR05, BR06)
CREATE TABLE ChinhSachMienPhi(
    MaChinhSach varchar(20) NOT NULL PRIMARY KEY,
    MaLoaiPhieu varchar(20) NOT NULL,
    GiaTriToiThieu decimal(18,2) NOT NULL CHECK(GiaTriToiThieu >= 0),
    HinhThucMienPhi nvarchar(100) NOT NULL,
    CONSTRAINT UQ_ChinhSach_Loai_GiaTri UNIQUE(MaLoaiPhieu, GiaTriToiThieu),
    CONSTRAINT FK_ChinhSach_LoaiPhieu FOREIGN KEY(MaLoaiPhieu) REFERENCES LoaiPhieuDatHang(MaLoaiPhieu)
);

-- Bảng Cấu hình loại thẻ tín dụng (BR09, BR10, BR11)
CREATE TABLE LoaiTheTinDung(
    MaLoaiThe varchar(20) NOT NULL PRIMARY KEY,
    TenLoaiThe nvarchar(50) NOT NULL UNIQUE,
    DoDaiSoThe int NOT NULL,
    DoDaiCSV int NOT NULL,
    MucLePhi decimal(18,2) NOT NULL DEFAULT 0 CHECK(MucLePhi >= 0),
    CONSTRAINT CK_LoaiThe_QuyDinh CHECK(
        (TenLoaiThe = N'American Express' AND DoDaiSoThe = 15 AND DoDaiCSV = 4) OR
        (TenLoaiThe IN (N'VISA', N'MasterCard', N'Discover') AND DoDaiSoThe = 16 AND DoDaiCSV = 3)
    )
);

-- 3. TẠO CÁC BẢNG NGHIỆP VỤ GIAO DỊCH (MASTER - DETAIL - THANH TOÁN)

-- Bảng Đơn đặt hàng (Master)
CREATE TABLE DonDatHang(
    MaDonHang varchar(30) NOT NULL PRIMARY KEY,
    MaKH varchar(20) NOT NULL,
    MaNguoiNhan varchar(20) NOT NULL,
    MaLoaiPhieu varchar(20) NOT NULL,
    NgayDat datetime NOT NULL DEFAULT GETDATE(),
    TongTienHang decimal(18,2) NOT NULL CHECK(TongTienHang >= 0),
    ChiPhiGiaoHang decimal(18,2) NOT NULL DEFAULT 0 CHECK(ChiPhiGiaoHang >= 0),
    TongTriGia AS (CONVERT(decimal(18,2), TongTienHang + ChiPhiGiaoHang)) PERSISTED,
    TrangThai nvarchar(50) NOT NULL DEFAULT N'Chờ xác minh',
    CONSTRAINT CK_DonHang_TrangThai CHECK(TrangThai IN (
        N'Chờ xác minh',
        N'Đã xác nhận',
        N'Đang giao',
        N'Hoàn tất',
        N'Đã hủy'
    )),
    CONSTRAINT FK_DonHang_KhachHang FOREIGN KEY(MaKH) REFERENCES KhachHang(MaKH),
    CONSTRAINT FK_DonHang_NguoiNhan FOREIGN KEY(MaNguoiNhan) REFERENCES NguoiNhanHang(MaNguoiNhan),
    CONSTRAINT FK_DonHang_LoaiPhieu FOREIGN KEY(MaLoaiPhieu) REFERENCES LoaiPhieuDatHang(MaLoaiPhieu)
);

-- Bảng Chi tiết đơn hàng (Detail - Snapshot giá theo BR03)
CREATE TABLE ChiTietDonHang(
    MaDonHang varchar(30) NOT NULL,
    MaSP varchar(20) NOT NULL,
    SoLuong int NOT NULL CHECK(SoLuong > 0),
    DonGia decimal(18,2) NOT NULL CHECK(DonGia >= 0),
    ThanhTien AS (CONVERT(decimal(18,2), SoLuong * DonGia)) PERSISTED,
    PRIMARY KEY(MaDonHang, MaSP),
    CONSTRAINT FK_CTDH_DonHang FOREIGN KEY(MaDonHang) REFERENCES DonDatHang(MaDonHang),
    CONSTRAINT FK_CTDH_SanPham FOREIGN KEY(MaSP) REFERENCES SanPham(MaSP)
);

-- Bảng Thanh toán (Lưu vết giao dịch thẻ, tuyệt đối không lưu CSV - BR12)
CREATE TABLE ThanhToan(
    MaThanhToan varchar(30) NOT NULL PRIMARY KEY,
    MaDonHang varchar(30) NOT NULL UNIQUE,
    MaLoaiThe varchar(20) NOT NULL,
    NgayThanhToan datetime NOT NULL DEFAULT GETDATE(),
    SoTheAn varchar(30) NOT NULL, -- Chỉ lưu 4 số cuối: e.g. '************1234'
    TenChuThe nvarchar(120) NOT NULL,
    NgayHetHan varchar(10) NOT NULL,
    SoTien decimal(18,2) NOT NULL CHECK(SoTien > 0),
    TrangThai nvarchar(50) NOT NULL DEFAULT N'Thành công',
    CONSTRAINT CK_ThanhToan_TrangThai CHECK(TrangThai IN (N'Thành công', N'Thất bại')),
    CONSTRAINT FK_ThanhToan_DonHang FOREIGN KEY(MaDonHang) REFERENCES DonDatHang(MaDonHang),
    CONSTRAINT FK_ThanhToan_LoaiThe FOREIGN KEY(MaLoaiThe) REFERENCES LoaiTheTinDung(MaLoaiThe)
);
GO

-- 4. TẠO INDEXES TỐI ƯU TRUY VẤN
CREATE INDEX IX_DonDatHang_NgayDat ON DonDatHang(NgayDat, TrangThai);
CREATE INDEX IX_ChiTietDonHang_SP ON ChiTietDonHang(MaSP, MaDonHang);
CREATE INDEX IX_SanPham_Nhom ON SanPham(MaNhom, TinhTrang);
CREATE INDEX IX_PhiGiaoHang_KV ON PhiGiaoHang(MaKhuVuc, MaLoaiPhieu);
GO

-- 5. DỮ LIỆU MẪU (SEED DATA BÁM SÁT MÔ TẢ ĐỀ BÀI)

-- Nhóm sản phẩm
INSERT INTO NhomSanPham(MaNhom, TenNhom) VALUES
('NSP01', N'Máy chụp hình kỹ thuật số'),
('NSP02', N'Đồ chơi'),
('NSP03', N'Thiết bị điện gia dụng'),
('NSP04', N'Thiết bị máy tính');

-- Sản phẩm
INSERT INTO SanPham(MaSP, MaNhom, TenSP, NhaSanXuat, GiaHienHanh, TinhTrang, MoTa, ThongSoKyThuat) VALUES
('SP01', 'NSP01', N'Máy ảnh Canon EOS R50', N'Canon', 18500000, N'Còn hàng', N'Máy ảnh mirrorless nhỏ gọn mùa Giáng Sinh', N'24.2MP, 4K 30p'),
('SP02', 'NSP01', N'Máy ảnh Sony Alpha A6400', N'Sony', 21000000, N'Còn hàng', N'Lấy nét cực nhanh, quay phim 4K HDR', N'24.2MP, Real-time AF'),
('SP03', 'NSP02', N'Bộ xếp hình Lego Giáng Sinh', N'Lego', 1250000, N'Còn hàng', N'Quà tặng mô hình cây thông và ông già Noel', N'1445 chi tiết'),
('SP04', 'NSP02', N'Robot thông minh điều khiển từ xa', N'Bandai', 650000, N'Còn hàng', N'Robot nhảy và phát nhạc vui nhộn', N'Pin sạc 1200mAh'),
('SP05', 'NSP03', N'Nồi chiên không dầu Philips HD9252', N'Philips', 2200000, N'Còn hàng', N'Nấu nướng tiệc năm mới không dầu mỡ', N'Dung tích 4.1L, 1400W'),
('SP06', 'NSP04', N'Chuột không dây Logitech MX Master 3S', N'Logitech', 2450000, N'Còn hàng', N'Chuột công thái học cao cấp', N'8000 DPI, Quiet Clicks');

-- 3 Loại phiếu đặt hàng (BR04)
INSERT INTO LoaiPhieuDatHang(MaLoaiPhieu, TenLoaiPhieu, DonGia, ThoiGianXuLy) VALUES
('LP01', N'Phiếu đặt hàng thường', 30000, N'3 - 5 ngày làm việc'),
('LP02', N'Phiếu đặt hàng chuyển phát nhanh', 50000, N'1 - 2 ngày làm việc'),
('LP03', N'Phiếu đặt hàng chuyển phát nhanh trong ngày', 100000, N'Trong vòng 24 giờ');

-- Khu vực giao hàng
INSERT INTO KhuVucGiaoHang(MaKhuVuc, TenKhuVuc) VALUES
('KV01', N'Nội thành TP.HCM'),
('KV02', N'Ngoại thành TP.HCM'),
('KV03', N'Các tỉnh thành khác');

-- Bảng phí giao hàng theo khu vực và loại phiếu (BR07)
INSERT INTO PhiGiaoHang(MaPhi, MaKhuVuc, MaLoaiPhieu, ChiPhi) VALUES
('P01', 'KV01', 'LP01', 30000),
('P02', 'KV01', 'LP02', 50000),
('P03', 'KV01', 'LP03', 100000),
('P04', 'KV02', 'LP01', 40000),
('P05', 'KV02', 'LP02', 70000),
('P06', 'KV02', 'LP03', 150000),
('P07', 'KV03', 'LP01', 50000),
('P08', 'KV03', 'LP02', 90000),
('P09', 'KV03', 'LP03', 200000);

-- Chính sách miễn cước vận chuyển (BR05, BR06)
INSERT INTO ChinhSachMienPhi(MaChinhSach, MaLoaiPhieu, GiaTriToiThieu, HinhThucMienPhi) VALUES
('CS01', 'LP02', 1000000, N'Miễn phí chuyển phát nhanh cho đơn từ 1.000.000 đ'),
('CS02', 'LP03', 5000000, N'Miễn phí chuyển phát nhanh trong ngày cho đơn từ 5.000.000 đ');

-- Cấu hình 4 loại thẻ tín dụng (BR09, BR10, BR11)
INSERT INTO LoaiTheTinDung(MaLoaiThe, TenLoaiThe, DoDaiSoThe, DoDaiCSV, MucLePhi) VALUES
('THE01', N'VISA', 16, 3, 15000),
('THE02', N'MasterCard', 16, 3, 15000),
('THE03', N'Discover', 16, 3, 20000),
('THE04', N'American Express', 15, 4, 30000);

-- Khách hàng mẫu
INSERT INTO KhachHang(MaKH, HoTen, NgaySinh, SoCMND, DiaChi, SoDienThoai, TenDangNhap, MatKhau, Email) VALUES
('KH01', N'Nguyễn Văn An', '1995-10-15', '079095001234', N'123 Lê Lợi, Q.1, TP.HCM', '0909123456', 'nguyenan', '123456', 'an.nguyen@gmail.com'),
('KH02', N'Trần Thị Bích', '1998-05-20', '079098005678', N'456 Nguyễn Huệ, Q.1, TP.HCM', '0918765432', 'bichtran', '123456', 'bich.tran@yahoo.com');

-- Người nhận hàng mẫu (BR08: Khác người mua khi mua quà tặng)
INSERT INTO NguoiNhanHang(MaNguoiNhan, HoTen, DiaChi, SoDienThoai) VALUES
('NN01', N'Lê Hoàng Phúc', N'789 Cách Mạng Tháng 8, Q.3, TP.HCM', '0933112233'),
('NN02', N'Nguyễn Văn An', N'123 Lê Lợi, Q.1, TP.HCM', '0909123456');

-- Đơn đặt hàng mẫu
-- Đơn 1: Giá trị 2.200.000đ (>= 1tr) chọn CPN LP02 -> Miễn phí giao hàng (ChiPhiGiaoHang = 0)
INSERT INTO DonDatHang(MaDonHang, MaKH, MaNguoiNhan, MaLoaiPhieu, NgayDat, TongTienHang, ChiPhiGiaoHang, TrangThai) VALUES
('DH01', 'KH01', 'NN01', 'LP02', '2026-12-24 10:30:00', 2200000, 0, N'Đã xác nhận');

INSERT INTO ChiTietDonHang(MaDonHang, MaSP, SoLuong, DonGia) VALUES
('DH01', 'SP05', 1, 2200000);

INSERT INTO ThanhToan(MaThanhToan, MaDonHang, MaLoaiThe, NgayThanhToan, SoTheAn, TenChuThe, NgayHetHan, SoTien, TrangThai) VALUES
('TT01', 'DH01', 'THE01', '2026-12-24 10:32:00', '************4321', N'NGUYEN VAN AN', '12/28', 2200000, N'Thành công');
GO