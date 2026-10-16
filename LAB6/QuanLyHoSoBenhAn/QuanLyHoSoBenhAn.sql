IF DB_ID(N'QuanLyHoSoBenhAn') IS NULL CREATE DATABASE QuanLyHoSoBenhAn;
GO
USE QuanLyHoSoBenhAn;
GO

-- =============================================================================
-- 1. XÓA BẢNG CŨ THEO THỨ TỰ PHỤ THUỘC KHÓA NGOẠI (CLEAN DROP TABLES)
-- =============================================================================
IF OBJECT_ID('TheoDoiSauDieuTri','U') IS NOT NULL DROP TABLE TheoDoiSauDieuTri;
IF OBJECT_ID('HoaDonVienPhi','U') IS NOT NULL DROP TABLE HoaDonVienPhi;
IF OBJECT_ID('ChiTietToaThuoc','U') IS NOT NULL DROP TABLE ChiTietToaThuoc;
IF OBJECT_ID('ToaThuoc','U') IS NOT NULL DROP TABLE ToaThuoc;
IF OBJECT_ID('ChiTietKetQuaXN','U') IS NOT NULL DROP TABLE ChiTietKetQuaXN;
IF OBJECT_ID('PhieuChiDinhXN','U') IS NOT NULL DROP TABLE PhieuChiDinhXN;
IF OBJECT_ID('DichVuXetNghiem','U') IS NOT NULL DROP TABLE DichVuXetNghiem;
IF OBJECT_ID('Thuoc','U') IS NOT NULL DROP TABLE Thuoc;
IF OBJECT_ID('PhieuKhamBenh','U') IS NOT NULL DROP TABLE PhieuKhamBenh;
IF OBJECT_ID('LichHenKhamDinhKy','U') IS NOT NULL DROP TABLE LichHenKhamDinhKy;
IF OBJECT_ID('HoSoBenhAn','U') IS NOT NULL DROP TABLE HoSoBenhAn;
IF OBJECT_ID('LePhiNam','U') IS NOT NULL DROP TABLE LePhiNam;
IF OBJECT_ID('PhieuDangKy','U') IS NOT NULL DROP TABLE PhieuDangKy;
IF OBJECT_ID('BenhNhan','U') IS NOT NULL DROP TABLE BenhNhan;
IF OBJECT_ID('NguoiDung','U') IS NOT NULL DROP TABLE NguoiDung;
IF OBJECT_ID('KhoaDieuTri','U') IS NOT NULL DROP TABLE KhoaDieuTri;
IF OBJECT_ID('VaiTro','U') IS NOT NULL DROP TABLE VaiTro;
GO

-- =============================================================================
-- 2. TẠO CÁC BẢNG DANH MỤC VÀ ĐỐI TƯỢNG CƠ BẢN (MASTER & CATALOG TABLES)
-- =============================================================================

-- Bảng Vai trò người dùng hệ thống
CREATE TABLE VaiTro (
    MaVaiTro varchar(20) NOT NULL PRIMARY KEY,
    TenVaiTro nvarchar(50) NOT NULL UNIQUE,
    MoTa nvarchar(255) NULL
);

-- Bảng Khoa phòng điều trị trong bệnh viện
CREATE TABLE KhoaDieuTri (
    MaKhoa varchar(20) NOT NULL PRIMARY KEY,
    TenKhoa nvarchar(100) NOT NULL UNIQUE,
    ViTri nvarchar(150) NOT NULL,
    TruongKhoa nvarchar(120) NULL,
    SoDienThoai varchar(20) NULL
);

-- Bảng Người dùng / Nhân viên y tế (Bác sĩ, Điều dưỡng, CSKH, Thu ngân, KTV)
CREATE TABLE NguoiDung (
    MaNguoiDung varchar(20) NOT NULL PRIMARY KEY,
    MaVaiTro varchar(20) NOT NULL,
    MaKhoa varchar(20) NULL,
    HoTen nvarchar(120) NOT NULL,
    TenDangNhap varchar(50) NOT NULL UNIQUE,
    MatKhau varchar(255) NOT NULL,
    Email varchar(100) NOT NULL UNIQUE,
    SoDienThoai varchar(20) NOT NULL,
    ChucDanh nvarchar(50) NULL,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Hoạt động',
    CONSTRAINT CK_NguoiDung_TrangThai CHECK (TrangThai IN (N'Hoạt động', N'Bị khóa', N'Tạm ngưng')),
    CONSTRAINT FK_NguoiDung_VaiTro FOREIGN KEY (MaVaiTro) REFERENCES VaiTro(MaVaiTro),
    CONSTRAINT FK_NguoiDung_Khoa FOREIGN KEY (MaKhoa) REFERENCES KhoaDieuTri(MaKhoa)
);

-- Bảng Bệnh nhân (Có lưu hình chân dung 3x4 khi đến khám lần đầu theo quy chế)
CREATE TABLE BenhNhan (
    MaBenhNhan varchar(20) NOT NULL PRIMARY KEY,
    HoTen nvarchar(120) NOT NULL,
    NgaySinh date NOT NULL,
    GioiTinh nvarchar(10) NOT NULL,
    DiaChi nvarchar(250) NOT NULL,
    SoDienThoai varchar(20) NOT NULL UNIQUE,
    AnhChup3x4 varchar(255) NULL, -- Đường dẫn file lưu trữ ảnh chân dung 3x4
    NgayDangKy date NOT NULL DEFAULT CAST(GETDATE() AS date),
    CONSTRAINT CK_BenhNhan_GioiTinh CHECK (GioiTinh IN (N'Nam', N'Nữ', N'Khác')),
    CONSTRAINT CK_BenhNhan_NgaySinh CHECK (NgaySinh <= CAST(GETDATE() AS date))
);

-- Bảng Phiếu đăng ký khám bệnh và theo dõi sức khỏe (Tiếp nhận hồ sơ ban đầu)
CREATE TABLE PhieuDangKy (
    MaPhieuDK varchar(30) NOT NULL PRIMARY KEY,
    MaBenhNhan varchar(20) NOT NULL,
    MaNguoiDungLap varchar(20) NOT NULL,
    NgayDangKy datetime NOT NULL DEFAULT GETDATE(),
    ThongTinKham nvarchar(255) NULL,
    TrangThai nvarchar(50) NOT NULL DEFAULT N'Đã tiếp nhận',
    CONSTRAINT CK_PhieuDangKy_TrangThai CHECK (TrangThai IN (N'Đã tiếp nhận', N'Đã cấp hồ sơ', N'Đã hủy')),
    CONSTRAINT FK_PhieuDangKy_BenhNhan FOREIGN KEY (MaBenhNhan) REFERENCES BenhNhan(MaBenhNhan),
    CONSTRAINT FK_PhieuDangKy_NguoiDung FOREIGN KEY (MaNguoiDungLap) REFERENCES NguoiDung(MaNguoiDung)
);

-- Bảng Lệ phí chăm sóc sức khỏe hằng năm (1 năm đóng 1 lần, bệnh nhân được khám định kỳ)
CREATE TABLE LePhiNam (
    MaBienLai varchar(30) NOT NULL PRIMARY KEY,
    MaBenhNhan varchar(20) NOT NULL,
    MaNguoiDungThu varchar(20) NOT NULL,
    SoTien decimal(18,2) NOT NULL CHECK(SoTien > 0),
    NgayDong date NOT NULL DEFAULT CAST(GETDATE() AS date),
    NgayHetHan date NOT NULL,
    NamApDung int NOT NULL,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Còn hiệu lực',
    CONSTRAINT CK_LePhiNam_NgayHan CHECK (NgayHetHan >= NgayDong),
    CONSTRAINT CK_LePhiNam_TrangThai CHECK (TrangThai IN (N'Còn hiệu lực', N'Hết hạn', N'Hủy biên lai')),
    CONSTRAINT FK_LePhiNam_BenhNhan FOREIGN KEY (MaBenhNhan) REFERENCES BenhNhan(MaBenhNhan),
    CONSTRAINT FK_LePhiNam_NguoiDung FOREIGN KEY (MaNguoiDungThu) REFERENCES NguoiDung(MaNguoiDung)
);

-- Bảng Hồ sơ bệnh án điện tử (Core Master Record - Mỗi bệnh nhân có duy nhất 1 hồ sơ suốt đời)
CREATE TABLE HoSoBenhAn (
    MaHoSo varchar(30) NOT NULL PRIMARY KEY,
    MaBenhNhan varchar(20) NOT NULL UNIQUE, -- Ràng buộc 1 - 1 giữa Bệnh nhân và Hồ sơ
    MaNguoiDungTao varchar(20) NOT NULL,
    NgayTao date NOT NULL DEFAULT CAST(GETDATE() AS date),
    GhiChuTienSuBenh nvarchar(max) NULL,
    TienSuDiUngThuoc nvarchar(max) NULL,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Đang theo dõi',
    CONSTRAINT CK_HoSoBenhAn_TrangThai CHECK (TrangThai IN (N'Đang theo dõi', N'Tạm ngưng', N'Đã lưu trữ')),
    CONSTRAINT FK_HoSoBenhAn_BenhNhan FOREIGN KEY (MaBenhNhan) REFERENCES BenhNhan(MaBenhNhan),
    CONSTRAINT FK_HoSoBenhAn_NguoiDung FOREIGN KEY (MaNguoiDungTao) REFERENCES NguoiDung(MaNguoiDung)
);

-- Bảng Danh mục Dịch vụ Xét nghiệm / Cận lâm sàng
CREATE TABLE DichVuXetNghiem (
    MaDichVuXN varchar(20) NOT NULL PRIMARY KEY,
    TenDichVuXN nvarchar(150) NOT NULL UNIQUE,
    LoaiXN nvarchar(50) NOT NULL, -- Huyết học, Sinh hóa, Chẩn đoán hình ảnh, Thăm dò chức năng...
    DonGia decimal(18,2) NOT NULL CHECK(DonGia >= 0),
    PhongThucHien nvarchar(100) NULL
);

-- Bảng Danh mục Thuốc và Dược phẩm
CREATE TABLE Thuoc (
    MaThuoc varchar(20) NOT NULL PRIMARY KEY,
    TenThuoc nvarchar(150) NOT NULL UNIQUE,
    HoatChat nvarchar(150) NOT NULL,
    DonViTinh nvarchar(30) NOT NULL,
    DonGia decimal(18,2) NOT NULL CHECK(DonGia >= 0),
    ChongChiDinh nvarchar(500) NULL,
    PhanUngPhu nvarchar(500) NULL,
    SoLuongTon int NOT NULL DEFAULT 0 CHECK(SoLuongTon >= 0)
);
GO

-- =============================================================================
-- 3. TẠO CÁC BẢNG NGHIỆP VỤ GIAO DỊCH (MASTER - DETAIL - THANH TOÁN - CSKH)
-- =============================================================================

-- Bảng Phiếu khám bệnh (Trang khám trong hồ sơ bệnh án)
CREATE TABLE PhieuKhamBenh (
    MaPhieuKham varchar(30) NOT NULL PRIMARY KEY,
    MaHoSo varchar(30) NOT NULL,
    MaBacSi varchar(20) NOT NULL,
    MaKhoa varchar(20) NOT NULL,
    NgayGioKham datetime NOT NULL DEFAULT GETDATE(),
    TrieuChung nvarchar(500) NOT NULL,
    ThanNhiet decimal(4,1) NULL CHECK(ThanNhiet IS NULL OR (ThanNhiet >= 34.0 AND ThanNhiet <= 44.0)),
    HuyetAp varchar(20) NULL,
    Mach int NULL CHECK(Mach IS NULL OR (Mach > 0 AND Mach < 300)),
    ChieuCao decimal(5,1) NULL,
    CanNang decimal(5,1) NULL,
    ChanDoanSoBo nvarchar(255) NULL,
    ChanDoanXacDinh nvarchar(255) NULL,
    LoaiKham nvarchar(50) NOT NULL DEFAULT N'Khám bệnh',
    TrangThai nvarchar(50) NOT NULL DEFAULT N'Đang khám',
    CONSTRAINT CK_PhieuKham_LoaiKham CHECK (LoaiKham IN (N'Khám bệnh', N'Khám định kỳ theo quý', N'Tái khám')),
    CONSTRAINT CK_PhieuKham_TrangThai CHECK (TrangThai IN (N'Đang khám', N'Chờ xét nghiệm', N'Đã có kết quả', N'Đã kê toa', N'Đã xuất viện')),
    CONSTRAINT FK_PhieuKham_HoSo FOREIGN KEY (MaHoSo) REFERENCES HoSoBenhAn(MaHoSo),
    CONSTRAINT FK_PhieuKham_BacSi FOREIGN KEY (MaBacSi) REFERENCES NguoiDung(MaNguoiDung),
    CONSTRAINT FK_PhieuKham_Khoa FOREIGN KEY (MaKhoa) REFERENCES KhoaDieuTri(MaKhoa)
);

-- Bảng Phiếu chỉ định xét nghiệm (Cận lâm sàng do Bác sĩ yêu cầu)
CREATE TABLE PhieuChiDinhXN (
    MaPhieuCD varchar(30) NOT NULL PRIMARY KEY,
    MaPhieuKham varchar(30) NOT NULL,
    MaBacSi varchar(20) NOT NULL,
    NgayChiDinh datetime NOT NULL DEFAULT GETDATE(),
    YeuCauXN nvarchar(500) NULL,
    TrangThai nvarchar(50) NOT NULL DEFAULT N'Chờ thực hiện',
    CONSTRAINT CK_PhieuCD_TrangThai CHECK (TrangThai IN (N'Chờ thực hiện', N'Đang thực hiện', N'Đã hoàn thành', N'Hủy chỉ định')),
    CONSTRAINT FK_PhieuCD_PhieuKham FOREIGN KEY (MaPhieuKham) REFERENCES PhieuKhamBenh(MaPhieuKham),
    CONSTRAINT FK_PhieuCD_BacSi FOREIGN KEY (MaBacSi) REFERENCES NguoiDung(MaNguoiDung)
);

-- Bảng Chi tiết kết quả xét nghiệm (Detail - KTV cập nhật trị số đo và bác sĩ đọc kết quả)
CREATE TABLE ChiTietKetQuaXN (
    MaKetQua varchar(30) NOT NULL PRIMARY KEY,
    MaPhieuCD varchar(30) NOT NULL,
    MaDichVuXN varchar(20) NOT NULL,
    MaKTVThucHien varchar(20) NULL,
    NgayGioTraKQ datetime NULL,
    TriSoDo nvarchar(100) NULL,
    KhoangThamChieu nvarchar(100) NULL,
    KetLuan nvarchar(500) NULL,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Chưa có kết quả',
    CONSTRAINT CK_ChiTietKQ_TrangThai CHECK (TrangThai IN (N'Chưa có kết quả', N'Đã có kết quả', N'Đã duyệt')),
    CONSTRAINT UQ_ChiTietKQ_Phieu_DichVu UNIQUE (MaPhieuCD, MaDichVuXN),
    CONSTRAINT FK_ChiTietKQ_PhieuCD FOREIGN KEY (MaPhieuCD) REFERENCES PhieuChiDinhXN(MaPhieuCD),
    CONSTRAINT FK_ChiTietKQ_DichVu FOREIGN KEY (MaDichVuXN) REFERENCES DichVuXetNghiem(MaDichVuXN),
    CONSTRAINT FK_ChiTietKQ_KTV FOREIGN KEY (MaKTVThucHien) REFERENCES NguoiDung(MaNguoiDung)
);

-- Bảng Toa thuốc điều trị (Master)
CREATE TABLE ToaThuoc (
    MaToaThuoc varchar(30) NOT NULL PRIMARY KEY,
    MaPhieuKham varchar(30) NOT NULL UNIQUE, -- Mỗi phiếu khám tương ứng duy nhất 1 toa thuốc
    MaBacSi varchar(20) NOT NULL,
    NgayKeToa datetime NOT NULL DEFAULT GETDATE(),
    ChanDoan nvarchar(255) NOT NULL,
    LoiDanBacSi nvarchar(500) NULL,
    NgayTaiKham date NULL,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Chưa xuất thuốc',
    CONSTRAINT CK_ToaThuoc_TrangThai CHECK (TrangThai IN (N'Chưa xuất thuốc', N'Đã xuất thuốc', N'Đã hủy')),
    CONSTRAINT FK_ToaThuoc_PhieuKham FOREIGN KEY (MaPhieuKham) REFERENCES PhieuKhamBenh(MaPhieuKham),
    CONSTRAINT FK_ToaThuoc_BacSi FOREIGN KEY (MaBacSi) REFERENCES NguoiDung(MaNguoiDung)
);

-- Bảng Chi tiết toa thuốc (Detail - Khóa chính phức hợp, Snapshot đơn giá & Thành tiền PERSISTED)
CREATE TABLE ChiTietToaThuoc (
    MaToaThuoc varchar(30) NOT NULL,
    MaThuoc varchar(20) NOT NULL,
    SoLuong int NOT NULL CHECK(SoLuong > 0),
    DonGia decimal(18,2) NOT NULL CHECK(DonGia >= 0),
    ThanhTien AS (CONVERT(decimal(18,2), SoLuong * DonGia)) PERSISTED,
    LieuDung nvarchar(100) NOT NULL, -- Ví dụ: Sáng 1 viên, Chiều 1 viên
    CachDung nvarchar(150) NOT NULL, -- Ví dụ: Uống sau khi ăn no
    PRIMARY KEY (MaToaThuoc, MaThuoc),
    CONSTRAINT FK_ChiTietToa_Toa FOREIGN KEY (MaToaThuoc) REFERENCES ToaThuoc(MaToaThuoc),
    CONSTRAINT FK_ChiTietToa_Thuoc FOREIGN KEY (MaThuoc) REFERENCES Thuoc(MaThuoc)
);

-- Bảng Hóa đơn viện phí & Xuất viện (Master - Tổng thanh toán PERSISTED tự động trừ Lệ phí năm nếu có)
CREATE TABLE HoaDonVienPhi (
    MaHoaDon varchar(30) NOT NULL PRIMARY KEY,
    MaPhieuKham varchar(30) NOT NULL UNIQUE, -- Mỗi phiếu khám có 1 hóa đơn xuất viện duy nhất
    MaThuNgan varchar(20) NOT NULL,
    NgayThanhToan datetime NOT NULL DEFAULT GETDATE(),
    TongTienKham decimal(18,2) NOT NULL DEFAULT 0 CHECK(TongTienKham >= 0),
    TongTienXN decimal(18,2) NOT NULL DEFAULT 0 CHECK(TongTienXN >= 0),
    TongTienThuoc decimal(18,2) NOT NULL DEFAULT 0 CHECK(TongTienThuoc >= 0),
    GiamTruLePhi decimal(18,2) NOT NULL DEFAULT 0 CHECK(GiamTruLePhi >= 0),
    TongThanhToan AS (CONVERT(decimal(18,2), TongTienKham + TongTienXN + TongTienThuoc - GiamTruLePhi)) PERSISTED,
    PhuongThucTT nvarchar(50) NOT NULL DEFAULT N'Tiền mặt',
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Đã thanh toán',
    CONSTRAINT CK_HoaDon_TrangThai CHECK (TrangThai IN (N'Chờ thanh toán', N'Đã thanh toán', N'Đã hủy')),
    CONSTRAINT FK_HoaDon_PhieuKham FOREIGN KEY (MaPhieuKham) REFERENCES PhieuKhamBenh(MaPhieuKham),
    CONSTRAINT FK_HoaDon_ThuNgan FOREIGN KEY (MaThuNgan) REFERENCES NguoiDung(MaNguoiDung)
);

-- Bảng Lịch hẹn khám định kỳ theo quý (Chăm sóc khách hàng tự động lên lịch)
CREATE TABLE LichHenKhamDinhKy (
    MaLichHen varchar(30) NOT NULL PRIMARY KEY,
    MaHoSo varchar(30) NOT NULL,
    MaNVCSKH varchar(20) NOT NULL,
    NgayGioHen datetime NOT NULL,
    QuyKham int NOT NULL CHECK(QuyKham BETWEEN 1 AND 4),
    NamKham int NOT NULL,
    GhiChu nvarchar(255) NULL,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Đã đặt lịch',
    CONSTRAINT CK_LichHen_TrangThai CHECK (TrangThai IN (N'Đã đặt lịch', N'Đã đến khám', N'Hủy hẹn', N'Quá hạn')),
    CONSTRAINT FK_LichHen_HoSo FOREIGN KEY (MaHoSo) REFERENCES HoSoBenhAn(MaHoSo),
    CONSTRAINT FK_LichHen_CSKH FOREIGN KEY (MaNVCSKH) REFERENCES NguoiDung(MaNguoiDung)
);

-- Bảng Theo dõi & Đánh giá đợt điều trị (Phòng CSKH ghi nhận diễn biến, hiệu quả, quy trách nhiệm bác sĩ và khóa hồ sơ)
CREATE TABLE TheoDoiSauDieuTri (
    MaTheoDoi varchar(30) NOT NULL PRIMARY KEY,
    MaHoSo varchar(30) NOT NULL,
    MaPhieuKham varchar(30) NOT NULL UNIQUE, -- Mỗi đợt khám tương ứng 1 bản đánh giá hoàn tất
    MaNVCSKH varchar(20) NOT NULL,
    NgayGhiNhan datetime NOT NULL DEFAULT GETDATE(),
    DienBienSucKhoe nvarchar(max) NULL,
    PhanUngPhuThuoc nvarchar(max) NULL,
    DanhGiaHieuQua nvarchar(255) NULL,
    TrachNhiemBacSi varchar(20) NULL,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Đã khóa hồ sơ',
    CONSTRAINT FK_TheoDoi_HoSo FOREIGN KEY (MaHoSo) REFERENCES HoSoBenhAn(MaHoSo),
    CONSTRAINT FK_TheoDoi_PhieuKham FOREIGN KEY (MaPhieuKham) REFERENCES PhieuKhamBenh(MaPhieuKham),
    CONSTRAINT FK_TheoDoi_CSKH FOREIGN KEY (MaNVCSKH) REFERENCES NguoiDung(MaNguoiDung),
    CONSTRAINT FK_TheoDoi_BacSi FOREIGN KEY (TrachNhiemBacSi) REFERENCES NguoiDung(MaNguoiDung)
);
GO

-- =============================================================================
-- 4. TẠO INDEXES TỐI ƯU TRUY VẤN (QUERY OPTIMIZATION)
-- =============================================================================
CREATE NONCLUSTERED INDEX IX_BenhNhan_SDT ON BenhNhan(SoDienThoai);
CREATE NONCLUSTERED INDEX IX_PhieuKhamBenh_HoSo_Ngay ON PhieuKhamBenh(MaHoSo, NgayGioKham);
CREATE NONCLUSTERED INDEX IX_PhieuChiDinh_PhieuKham ON PhieuChiDinhXN(MaPhieuKham);
CREATE NONCLUSTERED INDEX IX_ToaThuoc_PhieuKham ON ToaThuoc(MaPhieuKham);
CREATE NONCLUSTERED INDEX IX_ChiTietToa_Thuoc ON ChiTietToaThuoc(MaThuoc);
CREATE NONCLUSTERED INDEX IX_LichHen_HoSo_Quy ON LichHenKhamDinhKy(MaHoSo, NamKham, QuyKham);
CREATE NONCLUSTERED INDEX IX_Thuoc_Ten ON Thuoc(TenThuoc);
GO

-- =============================================================================
-- 5. DỮ LIỆU MẪU (SEED DATA BÁM SÁT KỊCH BẢN BÀI 5 LAB 6)
-- =============================================================================

-- Danh mục vai trò
INSERT INTO VaiTro (MaVaiTro, TenVaiTro, MoTa) VALUES
('VT_ADMIN',    N'Quản trị hệ thống',     N'Quản trị tài khoản, cấu hình và phân quyền toàn viện'),
('VT_BACSI',    N'Bác sĩ điều trị',       N'Khám bệnh, chỉ định xét nghiệm, lập toa thuốc và theo dõi bệnh án'),
('VT_CSKH',     N'Chăm sóc khách hàng',   N'Tiếp nhận bệnh nhân, đặt lịch định kỳ theo quý, khóa đợt điều trị'),
('VT_THUNGAN',  N'Thu ngân viện phí',     N'Thu lệ phí thường niên, lập hóa đơn viện phí xuất viện'),
('VT_KTV',      N'Kỹ thuật viên xét nghiệm', N'Thực hiện cận lâm sàng và cập nhật trả kết quả xét nghiệm');

-- Danh mục khoa phòng
INSERT INTO KhoaDieuTri (MaKhoa, TenKhoa, ViTri, TruongKhoa, SoDienThoai) VALUES
('K_NOI',      N'Khoa Nội Tổng Quát',   N'Tầng 2 - Tòa nhà A', N'BS.CKII Nguyễn Văn Toàn', '02838123001'),
('K_NGOAI',    N'Khoa Ngoại Tổng Quát', N'Tầng 3 - Tòa nhà A', N'TS.BS Trần Hoàng Giang',  '02838123002'),
('K_TIMMACH',  N'Khoa Tim Mạch',        N'Tầng 4 - Tòa nhà B', N'PGS.TS Lê Hồng Phong',    '02838123003'),
('K_XETNGHIEM',N'Khoa Xét Nghiệm Cận Lâm Sàng', N'Tầng trệt - Tòa nhà B', N'BS.CKI Đặng Văn Hưng', '02838123004');

-- Danh mục người dùng / Nhân viên y tế
INSERT INTO NguoiDung (MaNguoiDung, MaVaiTro, MaKhoa, HoTen, TenDangNhap, MatKhau, Email, SoDienThoai, ChucDanh) VALUES
('ND_ADMIN',  'VT_ADMIN',   NULL,           N'Hệ Thống Admin',       'admin',       'Admin@123', 'admin@benhvienquocte.vn',  '0901000001', N'Kỹ sư hệ thống'),
('ND_BS_MINH','VT_BACSI',   'K_NOI',        N'BS.CKI Nguyễn Văn Minh', 'bsminh',    'Minh@123',  'minh.nv@benhvienquocte.vn', '0902111222', N'Bác sĩ CKI'),
('ND_BS_MAI', 'VT_BACSI',   'K_TIMMACH',    N'ThS.BS Trần Thị Mai',    'bsmai',     'Mai@123',   'mai.tt@benhvienquocte.vn',  '0903222333', N'Thạc sĩ Bác sĩ'),
('ND_CSKH_LAN','VT_CSKH',   NULL,           N'Lê Thị Hương Lan',      'cskhlan',    'Lan@123',   'lan.lth@benhvienquocte.vn', '0904333444', N'Chuyên viên CSKH'),
('ND_TN_BICH', 'VT_THUNGAN',NULL,           N'Phạm Thị Ngọc Bích',    'thunganbich','Bich@123',  'bich.ptn@benhvienquocte.vn','0905444555', N'Nhân viên Thu ngân'),
('ND_KTV_NAM', 'VT_KTV',    'K_XETNGHIEM',  N'Đặng Hoàng Nam',        'ktvnam',     'Nam@123',   'nam.dh@benhvienquocte.vn',  '0906555666', N'Kỹ thuật viên Y học');

-- Danh mục Dịch vụ Xét nghiệm
INSERT INTO DichVuXetNghiem (MaDichVuXN, TenDichVuXN, LoaiXN, DonGia, PhongThucHien) VALUES
('XN01', N'Tổng phân tích tế bào máu ngoại vi (24 thông số)', N'Huyết học',           150000, N'Phòng XN 101 - Lầu 1'),
('XN02', N'Sinh hóa máu (Glucose, Ure, Creatinine, AST, ALT)',  N'Sinh hóa',            220000, N'Phòng XN 102 - Lầu 1'),
('XN03', N'Chụp X-quang ngực thẳng kỹ thuật số',              N'Chẩn đoán hình ảnh',  200000, N'Phòng CĐHA 105 - Trệt'),
('XN04', N'Siêu âm ổ bụng tổng quát màu Doppler',              N'Thăm dò chức năng',   250000, N'Phòng Siêu âm 108 - Trệt'),
('XN05', N'Điện tâm đồ (ECG) 12 đạo trình tiêu chuẩn',        N'Tim mạch',            120000, N'Phòng Đo điện tim 201');

-- Danh mục Thuốc và Dược phẩm
INSERT INTO Thuoc (MaThuoc, TenThuoc, HoatChat, DonViTinh, DonGia, ChongChiDinh, PhanUngPhu, SoLuongTon) VALUES
('TH01', N'Paracetamol 500mg (Hapacol)',   N'Paracetamol',   N'Viên',  2500,  N'Người suy gan nặng, mẫn cảm paracetamol',       N'Dị ứng da nhẹ, buồn nôn hiếm gặp', 1000),
('TH02', N'Amoxicillin 500mg (Augmentin)',  N'Amoxicillin',   N'Viên',  8500,  N'Dị ứng nhóm Beta-lactam, dị ứng Penicillin',    N'Tiêu chảy nhẹ, phát ban ngứa',       800),
('TH03', N'Amlodipine 5mg (Amlor)',         N'Amlodipine',    N'Viên',  6500,  N'Huyết áp thấp nặng, sốc tim, phụ nữ có thai',   N'Phù mắt cá chân, đỏ bừng mặt',       600),
('TH04', N'Esomeprazole 40mg (Nexium)',     N'Esomeprazole',  N'Viên',  18000, N'Mẫn cảm với dẫn chất benzimidazol',             N'Nhức đầu, đầy hơi, táo bón nhẹ',     500),
('TH05', N'Vitamin C 1000mg',               N'Acid Ascorbic', N'Viên',  3000,  N'Sỏi thận oxalat, tăng oxalat niệu',             N'Ợ nóng nhẹ khi uống lúc đói',        1200);

-- Danh mục Bệnh nhân mẫu (Bệnh nhân mới và Bệnh nhân tái khám có ảnh chân dung 3x4)
INSERT INTO BenhNhan (MaBenhNhan, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, AnhChup3x4, NgayDangKy) VALUES
('BN001', N'Nguyễn Văn An', '1985-05-14', N'Nam', N'Số 123 Nguyễn Văn Cừ, Quận 5, TP.HCM',  '0903123456', '/photos/3x4/bn001_nguyenvanan.jpg', '2026-01-10'),
('BN002', N'Trần Thị Bích', '1992-08-22', N'Nữ',  N'Số 45 Lê Duẩn, Quận 1, TP.HCM',          '0918765432', '/photos/3x4/bn002_tranthibich.jpg', '2026-03-15'),
('BN003', N'Lê Văn Cường',  '1978-11-30', N'Nam', N'Số 78 Hoàng Hoa Thám, Tân Bình, TP.HCM', '0989333444', '/photos/3x4/bn003_levancuong.jpg',  '2026-06-20');

-- Phiếu đăng ký khám
INSERT INTO PhieuDangKy (MaPhieuDK, MaBenhNhan, MaNguoiDungLap, NgayDangKy, ThongTinKham, TrangThai) VALUES
('PDK001', 'BN001', 'ND_CSKH_LAN', '2026-01-10 08:00:00', N'Khám sức khỏe tổng quát và đăng ký hồ sơ bệnh án định kỳ', N'Đã cấp hồ sơ'),
('PDK002', 'BN002', 'ND_CSKH_LAN', '2026-03-15 08:30:00', N'Đau dạ dày, buồn nôn, đăng ký dịch vụ chăm sóc cả năm',    N'Đã cấp hồ sơ'),
('PDK003', 'BN003', 'ND_CSKH_LAN', '2026-06-20 09:00:00', N'Tăng huyết áp, kiểm tra sức khỏe tim mạch định kỳ',         N'Đã cấp hồ sơ');

-- Lệ phí chăm sóc hằng năm (Đóng 1.200.000 VNĐ/năm, hiệu lực 1 năm)
INSERT INTO LePhiNam (MaBienLai, MaBenhNhan, MaNguoiDungThu, SoTien, NgayDong, NgayHetHan, NamApDung, TrangThai) VALUES
('LPN001', 'BN001', 'ND_TN_BICH', 1200000, '2026-01-10', '2027-01-10', 2026, N'Còn hiệu lực'),
('LPN002', 'BN002', 'ND_TN_BICH', 1200000, '2026-03-15', '2027-03-15', 2026, N'Còn hiệu lực'),
('LPN003', 'BN003', 'ND_TN_BICH', 1200000, '2026-06-20', '2027-06-20', 2026, N'Còn hiệu lực');

-- Hồ sơ bệnh án điện tử (Mã hồ sơ duy nhất phục vụ tra cứu suốt đời)
INSERT INTO HoSoBenhAn (MaHoSo, MaBenhNhan, MaNguoiDungTao, NgayTao, GhiChuTienSuBenh, TienSuDiUngThuoc, TrangThai) VALUES
('HSBA_BN001', 'BN001', 'ND_CSKH_LAN', '2026-01-10', N'Tiền sử trào ngược dạ dày thực quản nhẹ', N'Không có tiền sử dị ứng', N'Đang theo dõi'),
('HSBA_BN002', 'BN002', 'ND_CSKH_LAN', '2026-03-15', N'Viêm loét dạ dày tá tràng tá phát',       N'DỊ ỨNG PENICILLIN (CHỐNG CHỈ ĐỊNH BETA-LACTAM)', N'Đang theo dõi'),
('HSBA_BN003', 'BN003', 'ND_CSKH_LAN', '2026-06-20', N'Tăng huyết áp nguyên phát giai đoạn 1',    N'Không có dị ứng thuốc', N'Đang theo dõi');

-- Đợt khám bệnh (Các trang khám trong hồ sơ bệnh án)
INSERT INTO PhieuKhamBenh (MaPhieuKham, MaHoSo, MaBacSi, MaKhoa, NgayGioKham, TrieuChung, ThanNhiet, HuyetAp, Mach, ChieuCao, CanNang, ChanDoanSoBo, ChanDoanXacDinh, LoaiKham, TrangThai) VALUES
('PK001', 'HSBA_BN001', 'ND_BS_MINH', 'K_NOI',     '2026-10-15 08:30:00', N'Đau rát vùng thượng vị sau ăn, ợ chua, sốt nhẹ', 37.5, '120/80', 78, 170.0, 68.5, N'Theo dõi Viêm dạ dày cấp', N'Viêm loét dạ dày - tá tràng', N'Khám bệnh', N'Đã xuất viện'),
('PK002', 'HSBA_BN002', 'ND_BS_MINH', 'K_NOI',     '2026-10-16 09:15:00', N'Đau đầu từng cơn, chóng mặt, nghẹt mũi kéo dài', 36.8, '115/75', 72, 158.0, 50.0, N'Theo dõi Viêm xoang cấp',  N'Viêm mũi xoang xuất tiết',   N'Khám bệnh', N'Đã kê toa'),
('PK003', 'HSBA_BN003', 'ND_BS_MAI',  'K_TIMMACH', '2026-10-16 10:00:00', N'Đến hẹn khám định kỳ quý 4/2026, hồi hộp nhẹ',  36.6, '138/88', 84, 165.0, 72.0, N'Tái khám huyết áp định kỳ', N'Tăng huyết áp độ 1 ổn định', N'Khám định kỳ theo quý', N'Đang khám');

-- Phiếu chỉ định xét nghiệm
INSERT INTO PhieuChiDinhXN (MaPhieuCD, MaPhieuKham, MaBacSi, NgayChiDinh, YeuCauXN, TrangThai) VALUES
('PCD001', 'PK001', 'ND_BS_MINH', '2026-10-15 08:45:00', N'Kiểm tra công thức máu và siêu âm vùng bụng trên', N'Đã hoàn thành'),
('PCD002', 'PK003', 'ND_BS_MAI',  '2026-10-16 10:15:00', N'Đo điện tâm đồ và sinh hóa đường máu theo dõi',      N'Chờ thực hiện');

-- Chi tiết kết quả xét nghiệm
INSERT INTO ChiTietKetQuaXN (MaKetQua, MaPhieuCD, MaDichVuXN, MaKTVThucHien, NgayGioTraKQ, TriSoDo, KhoangThamChieu, KetLuan, TrangThai) VALUES
('KQ001', 'PCD001', 'XN01', 'ND_KTV_NAM', '2026-10-15 09:30:00', N'WBC: 7.8 K/uL, RBC: 4.5 M/uL', N'WBC: 4.0 - 10.0, RBC: 4.0 - 5.5', N'Công thức máu bình thường', N'Đã duyệt'),
('KQ002', 'PCD001', 'XN04', 'ND_KTV_NAM', '2026-10-15 09:45:00', N'Niêm mạc dạ dày phù nề nhẹ',    N'Các tạng ổ bụng kích thước chuẩn', N'Viêm niêm mạc dạ dày',       N'Đã duyệt');

-- Toa thuốc của đợt khám PK001
INSERT INTO ToaThuoc (MaToaThuoc, MaPhieuKham, MaBacSi, NgayKeToa, ChanDoan, LoiDanBacSi, NgayTaiKham, TrangThai) VALUES
('TT001', 'PK001', 'ND_BS_MINH', '2026-10-15 10:15:00', N'Viêm loét dạ dày tá tràng cấp tính', N'Ăn đúng bữa, kiêng đồ chua cay, tránh thức khuya', '2026-11-15', N'Đã xuất thuốc');

-- Chi tiết các loại thuốc trong toa (Tự động tính Thành tiền PERSISTED)
INSERT INTO ChiTietToaThuoc (MaToaThuoc, MaThuoc, SoLuong, DonGia, LieuDung, CachDung) VALUES
('TT001', 'TH04', 28, 18000, N'Sáng 1 viên, Chiều 1 viên', N'Uống trước bữa ăn 30 phút'),
('TT001', 'TH01', 10, 2500,  N'1 viên khi sốt trên 38.5 độ', N'Uống cách nhau tối thiểu 4 - 6 giờ');

-- Hóa đơn viện phí xuất viện (Tự động tính TongThanhToan PERSISTED)
INSERT INTO HoaDonVienPhi (MaHoaDon, MaPhieuKham, MaThuNgan, NgayThanhToan, TongTienKham, TongTienXN, TongTienThuoc, GiamTruLePhi, PhuongThucTT, TrangThai) VALUES
('HD001', 'PK001', 'ND_TN_BICH', '2026-10-15 11:00:00', 150000, 400000, 529000, 0, N'Chuyển khoản QR', N'Đã thanh toán');

-- Lịch hẹn khám định kỳ theo quý do CSKH quản lý
INSERT INTO LichHenKhamDinhKy (MaLichHen, MaHoSo, MaNVCSKH, NgayGioHen, QuyKham, NamKham, GhiChu, TrangThai) VALUES
('LH001', 'HSBA_BN001', 'ND_CSKH_LAN', '2026-11-15 08:30:00', 4, 2026, N'Khám kiểm tra lại tình trạng dạ dày và sức khỏe quý 4', N'Đã đặt lịch'),
('LH002', 'HSBA_BN002', 'ND_CSKH_LAN', '2026-12-10 09:00:00', 4, 2026, N'Khám tầm soát định kỳ quý 4 theo gói chăm sóc cả năm',   N'Đã đặt lịch');

-- CSKH theo dõi sau điều trị và khóa đợt khám PK001
INSERT INTO TheoDoiSauDieuTri (MaTheoDoi, MaHoSo, MaPhieuKham, MaNVCSKH, NgayGhiNhan, DienBienSucKhoe, PhanUngPhuThuoc, DanhGiaHieuQua, TrachNhiemBacSi, TrangThai) VALUES
('TD001', 'HSBA_BN001', 'PK001', 'ND_CSKH_LAN', '2026-10-15 11:30:00', N'Bệnh nhân giảm đau bụng sau khi uống liều đầu tiên', N'Không phát hiện tác dụng phụ', N'Điều trị tích cực, hiệu quả đạt tốt', 'ND_BS_MINH', N'Đã khóa hồ sơ');
GO

-- =============================================================================
-- 6. CÁC STORED PROCEDURES & MULTI-TABLE TRANSACTIONS
-- =============================================================================

-- =============================================================================
-- TRANSACTION 1: ĐĂNG KÝ BỆNH NHÂN MỚI, THU LỆ PHÍ NĂM & CẤP HỒ SƠ BỆNH ÁN
-- Thao tác đồng thời trên 4 bảng: BenhNhan, PhieuDangKy, LePhiNam, HoSoBenhAn
-- Đảm bảo tính toàn vẹn (ACID): Bệnh nhân chỉ được cấp hồ sơ khi đã thu phí hợp lệ
-- =============================================================================
CREATE OR ALTER PROCEDURE sp_DangKyBenhNhanVaCapHoSo
    @MaBenhNhan     varchar(20),
    @HoTen          nvarchar(120),
    @NgaySinh       date,
    @GioiTinh       nvarchar(10),
    @DiaChi         nvarchar(250),
    @SoDienThoai    varchar(20),
    @AnhChup3x4     varchar(255),
    @MaNguoiDungLap varchar(20),
    @SoTienLePhi    decimal(18,2),
    @NamApDung      int,
    @MaPhieuDK      varchar(30),
    @MaBienLai      varchar(30),
    @MaHoSo         varchar(30)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- 1. Kiểm tra số điện thoại hoặc mã bệnh nhân đã tồn tại
        IF EXISTS (SELECT 1 FROM BenhNhan WHERE MaBenhNhan = @MaBenhNhan OR SoDienThoai = @SoDienThoai)
        BEGIN
            THROW 50001, N'Mã bệnh nhân hoặc Số điện thoại này đã tồn tại trong hệ thống!', 1;
        END

        -- 2. Thêm bệnh nhân mới (Bao gồm file ảnh chân dung 3x4)
        INSERT INTO BenhNhan (MaBenhNhan, HoTen, NgaySinh, GioiTinh, DiaChi, SoDienThoai, AnhChup3x4, NgayDangKy)
        VALUES (@MaBenhNhan, @HoTen, @NgaySinh, @GioiTinh, @DiaChi, @SoDienThoai, @AnhChup3x4, CAST(GETDATE() AS date));

        -- 3. Tạo phiếu đăng ký tiếp nhận ban đầu
        INSERT INTO PhieuDangKy (MaPhieuDK, MaBenhNhan, MaNguoiDungLap, NgayDangKy, ThongTinKham, TrangThai)
        VALUES (@MaPhieuDK, @MaBenhNhan, @MaNguoiDungLap, GETDATE(), N'Đăng ký chăm sóc thường niên & cấp hồ sơ mới', N'Đã cấp hồ sơ');

        -- 4. Ghi nhận biên lai thu lệ phí năm (Hiệu lực tròn 1 năm tính từ ngày nộp)
        DECLARE @NgayDong date = CAST(GETDATE() AS date);
        DECLARE @NgayHetHan date = DATEADD(YEAR, 1, @NgayDong);

        INSERT INTO LePhiNam (MaBienLai, MaBenhNhan, MaNguoiDungThu, SoTien, NgayDong, NgayHetHan, NamApDung, TrangThai)
        VALUES (@MaBienLai, @MaBenhNhan, @MaNguoiDungLap, @SoTienLePhi, @NgayDong, @NgayHetHan, @NamApDung, N'Còn hiệu lực');

        -- 5. Khởi tạo Hồ sơ bệnh án điện tử cốt lõi
        INSERT INTO HoSoBenhAn (MaHoSo, MaBenhNhan, MaNguoiDungTao, NgayTao, GhiChuTienSuBenh, TienSuDiUngThuoc, TrangThai)
        VALUES (@MaHoSo, @MaBenhNhan, @MaNguoiDungLap, @NgayDong, N'Bệnh nhân đăng ký mới, hồ sơ mở lần đầu', N'Không phát hiện tiền sử dị ứng thuốc', N'Đang theo dõi');

        COMMIT TRANSACTION;
        PRINT N'>> [THÀNH CÔNG] Đăng ký bệnh nhân mới, thu lệ phí năm và khởi tạo Hồ sơ bệnh án: ' + @MaHoSo;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        DECLARE @ErrorMsg1 nvarchar(4000) = ERROR_MESSAGE();
        RAISERROR(N'>> [LỖI TRANSACTION ĐĂNG KÝ]: %s', 16, 1, @ErrorMsg1);
    END CATCH
END;
GO

-- =============================================================================
-- TRANSACTION 2: LẬP TOA THUỐC, KIỂM TRA DỊ ỨNG & CẬP NHẬT TRỪ TỒN KHO DƯỢC
-- Thao tác đồng thời trên 5 bảng: HoSoBenhAn, PhieuKhamBenh, ToaThuoc, ChiTietToaThuoc, Thuoc
-- Nghiệp vụ then chốt: Ngăn ngừa sốc phản vệ nếu thuốc kê trùng tiền sử dị ứng
-- =============================================================================
CREATE OR ALTER PROCEDURE sp_LapToaThuocVaTruTonKho
    @MaToaThuoc     varchar(30),
    @MaPhieuKham    varchar(30),
    @MaBacSi        varchar(20),
    @ChanDoan       nvarchar(255),
    @LoiDan         nvarchar(500),
    @NgayTaiKham    date,
    @MaThuoc        varchar(20),
    @SoLuong        int,
    @LieuDung       nvarchar(100),
    @CachDung       nvarchar(150)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- 1. Kiểm tra tồn tại đợt khám và lấy mã hồ sơ bệnh án
        DECLARE @MaHoSo varchar(30);
        SELECT @MaHoSo = MaHoSo 
        FROM PhieuKhamBenh WITH (UPDLOCK) 
        WHERE MaPhieuKham = @MaPhieuKham;

        IF @MaHoSo IS NULL
            THROW 50002, N'Không tìm thấy thông tin phiếu khám bệnh!', 1;

        -- 2. Kiểm tra an toàn y khoa: Kiểm tra tiền sử dị ứng thuốc của bệnh nhân
        DECLARE @TienSuDiUng nvarchar(max);
        SELECT @TienSuDiUng = TienSuDiUngThuoc FROM HoSoBenhAn WHERE MaHoSo = @MaHoSo;

        DECLARE @TenThuoc nvarchar(150);
        DECLARE @HoatChat nvarchar(150);
        DECLARE @TonKhoHienTai int;
        DECLARE @DonGiaHienHanh decimal(18,2);

        SELECT @TenThuoc = TenThuoc, 
               @HoatChat = HoatChat, 
               @TonKhoHienTai = SoLuongTon, 
               @DonGiaHienHanh = DonGia
        FROM Thuoc WITH (UPDLOCK, ROWLOCK)
        WHERE MaThuoc = @MaThuoc;

        IF @TenThuoc IS NULL
            THROW 50003, N'Mã thuốc yêu cầu không tồn tại trong danh mục dược!', 1;

        -- Cảnh báo chặn sốc phản vệ: Ví dụ bệnh nhân dị ứng Penicillin mà kê Amoxicillin
        IF (@TienSuDiUng LIKE N'%Penicillin%' OR @TienSuDiUng LIKE N'%Beta-lactam%') 
           AND (@TenThuoc LIKE N'%Amoxicillin%' OR @HoatChat LIKE N'%Amoxicillin%')
        BEGIN
            THROW 50004, N'CẢNH BÁO AN TOÀN Y TẾ: Bệnh nhân có tiền sử dị ứng với nhóm thuốc này!', 1;
        END

        -- 3. Kiểm tra số lượng tồn kho dược
        IF @TonKhoHienTai < @SoLuong
        BEGIN
            DECLARE @BaoLoiTon nvarchar(255) = N'Thuốc ' + @TenThuoc + N' không đủ tồn kho (Còn: ' + CAST(@TonKhoHienTai AS nvarchar(20)) + N', Cần: ' + CAST(@SoLuong AS nvarchar(20)) + N')!';
            THROW 50005, @BaoLoiTon, 1;
        END

        -- 4. Tạo Toa thuốc (Master) nếu chưa có
        IF NOT EXISTS (SELECT 1 FROM ToaThuoc WHERE MaToaThuoc = @MaToaThuoc)
        BEGIN
            INSERT INTO ToaThuoc (MaToaThuoc, MaPhieuKham, MaBacSi, NgayKeToa, ChanDoan, LoiDanBacSi, NgayTaiKham, TrangThai)
            VALUES (@MaToaThuoc, @MaPhieuKham, @MaBacSi, GETDATE(), @ChanDoan, @LoiDan, @NgayTaiKham, N'Chưa xuất thuốc');
        END

        -- 5. Thêm chi tiết thuốc vào toa (Detail)
        INSERT INTO ChiTietToaThuoc (MaToaThuoc, MaThuoc, SoLuong, DonGia, LieuDung, CachDung)
        VALUES (@MaToaThuoc, @MaThuoc, @SoLuong, @DonGiaHienHanh, @LieuDung, @CachDung);

        -- 6. Trừ tồn kho dược phẩm
        UPDATE Thuoc
        SET SoLuongTon = SoLuongTon - @SoLuong
        WHERE MaThuoc = @MaThuoc;

        -- 7. Cập nhật phiếu khám: Chẩn đoán xác định và trạng thái
        UPDATE PhieuKhamBenh
        SET ChanDoanXacDinh = @ChanDoan,
            TrangThai = N'Đã kê toa'
        WHERE MaPhieuKham = @MaPhieuKham;

        COMMIT TRANSACTION;
        PRINT N'>> [THÀNH CÔNG] Kê đơn thuốc ' + @TenThuoc + N' vào toa ' + @MaToaThuoc + N' và đã trừ tồn kho thành công.';
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        DECLARE @ErrorMsg2 nvarchar(4000) = ERROR_MESSAGE();
        RAISERROR(N'>> [LỖI TRANSACTION KÊ TOA THUỐC]: %s', 16, 1, @ErrorMsg2);
    END CATCH
END;
GO

-- =============================================================================
-- TRANSACTION 3: THANH TOÁN VIỆN PHÍ, HOÀN TẤT XUẤT VIỆN & CSKH KHÓA HỒ SƠ
-- Thao tác đồng thời trên 4 bảng: HoaDonVienPhi, PhieuKhamBenh, ToaThuoc, TheoDoiSauDieuTri
-- Nghiệp vụ: Tự động miễn tiền khám nếu là khám định kỳ hoặc có đóng lệ phí năm
-- =============================================================================
CREATE OR ALTER PROCEDURE sp_ThanhToanXuatVienVaKhoaHoSo
    @MaHoaDon       varchar(30),
    @MaPhieuKham    varchar(30),
    @MaThuNgan      varchar(20),
    @MaNVCSKH       varchar(20),
    @PhuongThucTT   nvarchar(50),
    @MaTheoDoi      varchar(30),
    @DienBien       nvarchar(max),
    @PhanUngPhu     nvarchar(max),
    @DanhGiaHieuQua nvarchar(255)
AS
BEGIN
    SET NOCOUNT ON;
    SET XACT_ABORT ON;

    BEGIN TRY
        BEGIN TRANSACTION;

        -- 1. Kiểm tra đợt khám
        DECLARE @MaHoSo varchar(30);
        DECLARE @MaBacSi varchar(20);
        DECLARE @LoaiKham nvarchar(50);

        SELECT @MaHoSo = MaHoSo, @MaBacSi = MaBacSi, @LoaiKham = LoaiKham
        FROM PhieuKhamBenh WITH (UPDLOCK)
        WHERE MaPhieuKham = @MaPhieuKham;

        IF @MaHoSo IS NULL
            THROW 50006, N'Không tìm thấy phiếu khám bệnh chỉ định!', 1;

        -- 2. Tính toán viện phí tự động từ Xét nghiệm và Toa thuốc
        DECLARE @TongTienKham decimal(18,2) = 150000; -- Tiền khám tiêu chuẩn
        DECLARE @TongTienXN decimal(18,2) = 0;
        DECLARE @TongTienThuoc decimal(18,2) = 0;
        DECLARE @GiamTruLePhi decimal(18,2) = 0;

        -- Tính tổng tiền xét nghiệm
        SELECT @TongTienXN = ISNULL(SUM(dv.DonGia), 0)
        FROM PhieuChiDinhXN cd
        JOIN ChiTietKetQuaXN ct ON cd.MaPhieuCD = ct.MaPhieuCD
        JOIN DichVuXetNghiem dv ON ct.MaDichVuXN = dv.MaDichVuXN
        WHERE cd.MaPhieuKham = @MaPhieuKham;

        -- Tính tổng tiền thuốc
        SELECT @TongTienThuoc = ISNULL(SUM(ct.ThanhTien), 0)
        FROM ToaThuoc tt
        JOIN ChiTietToaThuoc ct ON tt.MaToaThuoc = ct.MaToaThuoc
        WHERE tt.MaPhieuKham = @MaPhieuKham;

        -- Áp dụng quyền lợi miễn tiền khám nếu khám định kỳ theo quý
        IF @LoaiKham = N'Khám định kỳ theo quý'
        BEGIN
            SET @GiamTruLePhi = @TongTienKham;
            SET @TongTienKham = 0;
        END

        -- 3. Tạo Hóa đơn viện phí xuất viện (TongThanhToan được tính tự động PERSISTED)
        INSERT INTO HoaDonVienPhi (MaHoaDon, MaPhieuKham, MaThuNgan, NgayThanhToan, TongTienKham, TongTienXN, TongTienThuoc, GiamTruLePhi, PhuongThucTT, TrangThai)
        VALUES (@MaHoaDon, @MaPhieuKham, @MaThuNgan, GETDATE(), @TongTienKham, @TongTienXN, @TongTienThuoc, @GiamTruLePhi, @PhuongThucTT, N'Đã thanh toán');

        -- 4. Chuyển trạng thái phiếu khám sang Đã xuất viện
        UPDATE PhieuKhamBenh
        SET TrangThai = N'Đã xuất viện'
        WHERE MaPhieuKham = @MaPhieuKham;

        -- 5. Cập nhật trạng thái Toa thuốc sang Đã xuất thuốc
        UPDATE ToaThuoc
        SET TrangThai = N'Đã xuất thuốc'
        WHERE MaPhieuKham = @MaPhieuKham;

        -- 6. Phòng CSKH nhập đánh giá hiệu quả, quy trách nhiệm bác sĩ và khóa hồ sơ điều trị
        INSERT INTO TheoDoiSauDieuTri (MaTheoDoi, MaHoSo, MaPhieuKham, MaNVCSKH, NgayGhiNhan, DienBienSucKhoe, PhanUngPhuThuoc, DanhGiaHieuQua, TrachNhiemBacSi, TrangThai)
        VALUES (@MaTheoDoi, @MaHoSo, @MaPhieuKham, @MaNVCSKH, GETDATE(), @DienBien, @PhanUngPhu, @DanhGiaHieuQua, @MaBacSi, N'Đã khóa hồ sơ');

        COMMIT TRANSACTION;
        PRINT N'>> [THÀNH CÔNG] Thanh toán viện phí xuất viện và CSKH đã khóa đợt điều trị cho Hồ sơ: ' + @MaHoSo;
    END TRY
    BEGIN CATCH
        IF @@TRANCOUNT > 0
            ROLLBACK TRANSACTION;

        DECLARE @ErrorMsg3 nvarchar(4000) = ERROR_MESSAGE();
        RAISERROR(N'>> [LỖI TRANSACTION XUẤT VIỆN]: %s', 16, 1, @ErrorMsg3);
    END CATCH
END;
GO

-- =============================================================================
-- 7. DEMO THỰC THI KIỂM CHỨNG CÁC TRANSACTION TRÊN CƠ SỞ DỮ LIỆU
-- =============================================================================

PRINT N'-----------------------------------------------------------------------------';
PRINT N'DEMO 1: TIẾP NHẬN BỆNH NHÂN MỚI (BN004) VÀ THU LỆ PHÍ NĂM';
PRINT N'-----------------------------------------------------------------------------';
EXEC sp_DangKyBenhNhanVaCapHoSo
    @MaBenhNhan     = 'BN004',
    @HoTen          = N'Vũ Hoàng Quân',
    @NgaySinh       = '1995-12-05',
    @GioiTinh       = N'Nam',
    @DiaChi         = N'Số 89 Nguyễn Oanh, Gò Vấp, TP.HCM',
    @SoDienThoai    = '0977112233',
    @AnhChup3x4     = '/photos/3x4/bn004_vuhoangquan.jpg',
    @MaNguoiDungLap = 'ND_CSKH_LAN',
    @SoTienLePhi    = 1200000,
    @NamApDung      = 2026,
    @MaPhieuDK      = 'PDK004',
    @MaBienLai      = 'LPN004',
    @MaHoSo         = 'HSBA_BN004';
GO

PRINT N'-----------------------------------------------------------------------------';
PRINT N'DEMO 2: BÁC SĨ KÊ TOA THUỐC VÀ TỰ ĐỘNG TRỪ TỒN KHO DƯỢC';
PRINT N'-----------------------------------------------------------------------------';
-- Kê thuốc Paracetamol (TH01) số lượng 20 viên cho phiếu khám PK002
EXEC sp_LapToaThuocVaTruTonKho
    @MaToaThuoc     = 'TT002',
    @MaPhieuKham    = 'PK002',
    @MaBacSi        = 'ND_BS_MINH',
    @ChanDoan       = N'Viêm xoang cấp có sốt nhẹ',
    @LoiDan         = N'Uống thuốc sau ăn, tái khám sau 7 ngày',
    @NgayTaiKham    = '2026-10-23',
    @MaThuoc        = 'TH01',
    @SoLuong        = 20,
    @LieuDung       = N'Sáng 1 viên, Tối 1 viên',
    @CachDung       = N'Uống sau ăn no';
GO

PRINT N'-----------------------------------------------------------------------------';
PRINT N'DEMO 3: THỬ NGHIỆM CẢNH BÁO AN TOÀN Y KHOA (CHẶN KÊ THUỐC DỊ ỨNG PENICILLIN CHO BN002)';
PRINT N'-----------------------------------------------------------------------------';
-- BN002 có tiền sử dị ứng Penicillin trong hồ sơ HSBA_BN002. Cố tình kê Amoxicillin (TH02) để kiểm chứng Transaction tự hủy (ROLLBACK):
BEGIN TRY
    EXEC sp_LapToaThuocVaTruTonKho
        @MaToaThuoc     = 'TT002',
        @MaPhieuKham    = 'PK002',
        @MaBacSi        = 'ND_BS_MINH',
        @ChanDoan       = N'Thử kê Amoxicillin',
        @LoiDan         = N'Kiểm tra dị ứng',
        @NgayTaiKham    = '2026-10-23',
        @MaThuoc        = 'TH02', -- Amoxicillin thuộc nhóm Beta-lactam/Penicillin
        @SoLuong        = 10,
        @LieuDung       = N'Sáng 1 viên',
        @CachDung       = N'Uống sau ăn';
END TRY
BEGIN CATCH
    PRINT N'>> [KẾT QUẢ KIỂM CHỨNG]: Hệ thống đã bắt lỗi an toàn y khoa thành công: ' + ERROR_MESSAGE();
END CATCH
GO

PRINT N'-----------------------------------------------------------------------------';
PRINT N'DEMO 4: THANH TOÁN VIỆN PHÍ, HOÀN TẤT XUẤT VIỆN & CSKH KHÓA HỒ SƠ';
PRINT N'-----------------------------------------------------------------------------';
EXEC sp_ThanhToanXuatVienVaKhoaHoSo
    @MaHoaDon       = 'HD002',
    @MaPhieuKham    = 'PK002',
    @MaThuNgan      = 'ND_TN_BICH',
    @MaNVCSKH       = 'ND_CSKH_LAN',
    @PhuongThucTT   = N'Thẻ ATM nội địa',
    @MaTheoDoi      = 'TD002',
    @DienBien       = N'Bệnh nhân giảm đau đầu rõ rệt, thân nhiệt ổn định',
    @PhanUngPhu     = N'Không có phản ứng phụ',
    @DanhGiaHieuQua = N'Phục hồi tốt';
GO

PRINT N'=============================================================================';
PRINT N'KHỞI TẠO CƠ SỞ DỮ LIỆU QuanLyHoSoBenhAnDB HOÀN TẤT VÀ KIỂM CHỨNG THÀNH CÔNG!';
PRINT N'=============================================================================';
