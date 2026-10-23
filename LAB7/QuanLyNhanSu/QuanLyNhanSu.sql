IF DB_ID(N'QuanLyNhanSu') IS NULL 
    CREATE DATABASE QuanLyNhanSu;
GO
USE QuanLyNhanSu;
GO
SET ANSI_NULLS ON;
GO
SET QUOTED_IDENTIFIER ON;
GO

-- ==============================================================================
-- 1. XÓA BẢNG CŨ THEO THỨ TỰ PHỤ THUỘC KHÓA NGOẠI (REVERSE DEPENDENCY)
-- ==============================================================================
IF OBJECT_ID('ChiTietBangLuong', 'U') IS NOT NULL DROP TABLE ChiTietBangLuong;
IF OBJECT_ID('BangLuongThang', 'U') IS NOT NULL DROP TABLE BangLuongThang;
IF OBJECT_ID('PhieuThuPhat', 'U') IS NOT NULL DROP TABLE PhieuThuPhat;
IF OBJECT_ID('QuyetDinhKyLuat', 'U') IS NOT NULL DROP TABLE QuyetDinhKyLuat;
IF OBJECT_ID('PhieuChiThuong', 'U') IS NOT NULL DROP TABLE PhieuChiThuong;
IF OBJECT_ID('QuyetDinhKhenThuong', 'U') IS NOT NULL DROP TABLE QuyetDinhKhenThuong;
IF OBJECT_ID('ChiTietPhuTroi', 'U') IS NOT NULL DROP TABLE ChiTietPhuTroi;
IF OBJECT_ID('PhieuPhuTroi', 'U') IS NOT NULL DROP TABLE PhieuPhuTroi;
IF OBJECT_ID('ChiTietChamCong', 'U') IS NOT NULL DROP TABLE ChiTietChamCong;
IF OBJECT_ID('BangChamCong', 'U') IS NOT NULL DROP TABLE BangChamCong;
IF OBJECT_ID('ChiTietKeHoachCa', 'U') IS NOT NULL DROP TABLE ChiTietKeHoachCa;
IF OBJECT_ID('KeHoachLamViecTuan', 'U') IS NOT NULL DROP TABLE KeHoachLamViecTuan;
IF OBJECT_ID('QuyetDinhLuong', 'U') IS NOT NULL DROP TABLE QuyetDinhLuong;
IF OBJECT_ID('QuyetDinhChucVu', 'U') IS NOT NULL DROP TABLE QuyetDinhChucVu;
IF OBJECT_ID('HoSoBaoHiem', 'U') IS NOT NULL DROP TABLE HoSoBaoHiem;
IF OBJECT_ID('HopDongLaoDong', 'U') IS NOT NULL DROP TABLE HopDongLaoDong;
IF OBJECT_ID('DanhGiaThuViec', 'U') IS NOT NULL DROP TABLE DanhGiaThuViec;
IF OBJECT_ID('QuyetDinhTuyenDung', 'U') IS NOT NULL DROP TABLE QuyetDinhTuyenDung;
IF OBJECT_ID('PhieuDeXuatTuyenDung', 'U') IS NOT NULL DROP TABLE PhieuDeXuatTuyenDung;
IF OBJECT_ID('NguoiDung', 'U') IS NOT NULL DROP TABLE NguoiDung;
IF OBJECT_ID('NhanVien', 'U') IS NOT NULL DROP TABLE NhanVien;
IF OBJECT_ID('ChucVu', 'U') IS NOT NULL DROP TABLE ChucVu;
IF OBJECT_ID('PhongBan', 'U') IS NOT NULL DROP TABLE PhongBan;
GO

-- ==============================================================================
-- 2. TẠO CÁC BẢNG DANH MỤC VÀ ĐỐI TƯỢNG CƠ BẢN
-- ==============================================================================

-- Bảng Phòng ban & Phân xưởng sản xuất sơn Đông Á
CREATE TABLE PhongBan(
    MaPhongBan varchar(20) NOT NULL PRIMARY KEY,
    TenPhongBan nvarchar(100) NOT NULL UNIQUE,
    DiaDiem nvarchar(150) NOT NULL,
    SoDienThoai varchar(20) NULL,
    TruongPhong nvarchar(100) NOT NULL
);

-- Bảng Chức vụ & Chức danh chuyên môn
CREATE TABLE ChucVu(
    MaChucVu varchar(20) NOT NULL PRIMARY KEY,
    TenChucVu nvarchar(100) NOT NULL UNIQUE,
    MoTaCongViec nvarchar(255) NULL
);

-- Bảng Hồ sơ nhân viên
CREATE TABLE NhanVien(
    MaNV varchar(20) NOT NULL PRIMARY KEY,
    MaPhongBan varchar(20) NOT NULL,
    HoTen nvarchar(120) NOT NULL,
    NgaySinh date NOT NULL,
    GioiTinh nvarchar(10) NOT NULL CHECK(GioiTinh IN (N'Nam', N'Nữ')),
    SoCCCD varchar(20) NOT NULL UNIQUE,
    DiaChi nvarchar(255) NOT NULL,
    SoDienThoai varchar(20) NOT NULL,
    Email varchar(100) NULL,
    NgayVaoLam date NOT NULL,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Thử việc',
    CONSTRAINT CK_NhanVien_TrangThai CHECK(TrangThai IN (N'Thử việc', N'Chính thức', N'Đã nghỉ việc')),
    CONSTRAINT FK_NhanVien_PhongBan FOREIGN KEY(MaPhongBan) REFERENCES PhongBan(MaPhongBan)
);

-- Bảng Người dùng hệ thống (Phân quyền 5 Actor chính)
CREATE TABLE NguoiDung(
    MaNguoiDung varchar(20) NOT NULL PRIMARY KEY,
    MaNV varchar(20) NOT NULL UNIQUE,
    TenDangNhap varchar(50) NOT NULL UNIQUE,
    MatKhau varchar(255) NOT NULL,
    HoTen nvarchar(120) NOT NULL,
    VaiTro varchar(30) NOT NULL,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Hoạt động',
    CONSTRAINT CK_NguoiDung_VaiTro CHECK(VaiTro IN (
        'GIAM_DOC',         -- 1. Giám đốc điều hành
        'NHAN_SU',          -- 2. Nhân viên Nhân sự
        'BAN_CHAM_CONG',    -- 3. Ban chấm công
        'KE_TOAN',          -- 4. Kế toán lương
        'TRUONG_PHONG'      -- 5. Trưởng phòng / Phân xưởng
    )),
    CONSTRAINT CK_NguoiDung_TrangThai CHECK(TrangThai IN (N'Hoạt động', N'Khóa tài khoản')),
    CONSTRAINT FK_NguoiDung_NhanVien FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

-- ==============================================================================
-- 3. TẠO CÁC BẢNG TUYỂN DỤNG, THỬ VIỆC, HỢP ĐỒNG & BẢO HIỂM
-- ==============================================================================

-- Bảng Phiếu đề xuất tuyển dụng nhân sự (xưởng sản xuất/phòng ban)
CREATE TABLE PhieuDeXuatTuyenDung(
    MaDeXuat varchar(30) NOT NULL PRIMARY KEY,
    MaPhongBan varchar(20) NOT NULL,
    NgayDeXuat date NOT NULL DEFAULT GETDATE(),
    SoLuongCanTuyen int NOT NULL CHECK(SoLuongCanTuyen > 0),
    YeuCauChuyenMon nvarchar(255) NOT NULL,
    LyDoTuyenDung nvarchar(255) NOT NULL,
    TrangThai nvarchar(50) NOT NULL DEFAULT N'Chờ duyệt',
    CONSTRAINT CK_DeXuat_TrangThai CHECK(TrangThai IN (N'Chờ duyệt', N'Đã duyệt', N'Từ chối')),
    CONSTRAINT FK_DeXuat_PhongBan FOREIGN KEY(MaPhongBan) REFERENCES PhongBan(MaPhongBan)
);

-- Bảng Quyết định tiếp nhận thử việc
CREATE TABLE QuyetDinhTuyenDung(
    SoQDTuyenDung varchar(30) NOT NULL PRIMARY KEY,
    MaNV varchar(20) NOT NULL,
    MaDeXuat varchar(30) NOT NULL,
    NgayBanHanh date NOT NULL DEFAULT GETDATE(),
    ThoiGianThuViecTu date NOT NULL,
    ThoiGianThuViecDen date NOT NULL,
    MucLuongThuViec decimal(18,2) NOT NULL CHECK(MucLuongThuViec >= 0),
    DieuKhoanThoaThuan nvarchar(500) NULL,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Đang thử việc',
    CONSTRAINT CK_QDTuyenDung_TrangThai CHECK(TrangThai IN (N'Đang thử việc', N'Đã hoàn thành', N'Chấm dứt')),
    CONSTRAINT FK_QDTuyenDung_NhanVien FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV),
    CONSTRAINT FK_QDTuyenDung_DeXuat FOREIGN KEY(MaDeXuat) REFERENCES PhieuDeXuatTuyenDung(MaDeXuat)
);

-- Bảng Đánh giá kết quả thử việc (Đạt / Không đạt)
CREATE TABLE DanhGiaThuViec(
    MaDanhGia varchar(30) NOT NULL PRIMARY KEY,
    SoQDTuyenDung varchar(30) NOT NULL UNIQUE,
    NgayDanhGia date NOT NULL DEFAULT GETDATE(),
    KetQuaDanhGia nvarchar(50) NOT NULL,
    NhanXetChuyenMon nvarchar(500) NOT NULL,
    DeXuatHopDong nvarchar(100) NOT NULL,
    CONSTRAINT CK_DanhGia_KetQua CHECK(KetQuaDanhGia IN (N'Đạt yêu cầu', N'Không đạt')),
    CONSTRAINT FK_DanhGia_QDTuyenDung FOREIGN KEY(SoQDTuyenDung) REFERENCES QuyetDinhTuyenDung(SoQDTuyenDung)
);

-- Bảng Hợp đồng lao động (Ngắn hạn dưới 3 tháng / Dài hạn từ 1 năm trở lên)
CREATE TABLE HopDongLaoDong(
    SoHopDong varchar(30) NOT NULL PRIMARY KEY,
    MaNV varchar(20) NOT NULL,
    LoaiHopDong nvarchar(50) NOT NULL,
    NgayKy date NOT NULL,
    NgayHieuLuc date NOT NULL,
    NgayHetHan date NULL,
    DiaDiemLamViec nvarchar(200) NOT NULL,
    QuyenLoiNghiaVu nvarchar(max) NULL,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Hiệu lực',
    CONSTRAINT CK_HopDong_Loai CHECK(LoaiHopDong IN (
        N'HĐLĐ ngắn hạn dưới 3 tháng',
        N'HĐLĐ xác định thời hạn 1 năm',
        N'HĐLĐ xác định thời hạn 3 năm',
        N'HĐLĐ không xác định thời hạn'
    )),
    CONSTRAINT CK_HopDong_TrangThai CHECK(TrangThai IN (N'Hiệu lực', N'Hết hạn', N'Đã thanh lý')),
    CONSTRAINT FK_HopDong_NhanVien FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

-- Bảng Hồ sơ BHYT & BHXH (Chỉ áp dụng với HĐ dài hạn, trích 10.5% lương cơ bản)
CREATE TABLE HoSoBaoHiem(
    MaHoSoBH varchar(30) NOT NULL PRIMARY KEY,
    SoHopDong varchar(30) NOT NULL UNIQUE,
    MaNV varchar(20) NOT NULL,
    MaSoBHXH varchar(30) NOT NULL UNIQUE,
    SoTheBHYT varchar(30) NOT NULL UNIQUE,
    NoiKhamChuaBenh nvarchar(200) NOT NULL,
    NgayBatDauBH date NOT NULL,
    TyLeDongNV decimal(5,2) NOT NULL DEFAULT 10.50 CHECK(TyLeDongNV >= 0),
    TyLeDongCongTy decimal(5,2) NOT NULL DEFAULT 21.50 CHECK(TyLeDongCongTy >= 0),
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Đang tham gia',
    CONSTRAINT CK_HoSoBH_TrangThai CHECK(TrangThai IN (N'Đang tham gia', N'Tạm dừng', N'Đã chốt sổ')),
    CONSTRAINT FK_HoSoBH_HopDong FOREIGN KEY(SoHopDong) REFERENCES HopDongLaoDong(SoHopDong),
    CONSTRAINT FK_HoSoBH_NhanVien FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

-- Bảng Quyết định bổ nhiệm chức vụ & Phụ cấp chức vụ
CREATE TABLE QuyetDinhChucVu(
    SoQDChucVu varchar(30) NOT NULL PRIMARY KEY,
    MaNV varchar(20) NOT NULL,
    MaChucVu varchar(20) NOT NULL,
    NgayBanHanh date NOT NULL DEFAULT GETDATE(),
    NgayHieuLuc date NOT NULL,
    PhuCapChucVu decimal(18,2) NOT NULL DEFAULT 0 CHECK(PhuCapChucVu >= 0),
    LyDoBoNhiem nvarchar(255) NOT NULL,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Hiệu lực',
    CONSTRAINT CK_QDChucVu_TrangThai CHECK(TrangThai IN (N'Hiệu lực', N'Bãi nhiệm', N'Điều chuyển')),
    CONSTRAINT FK_QDChucVu_NhanVien FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV),
    CONSTRAINT FK_QDChucVu_ChucVu FOREIGN KEY(MaChucVu) REFERENCES ChucVu(MaChucVu)
);

-- Bảng Quyết định lương & Phụ cấp độc hại hóa chất sơn
CREATE TABLE QuyetDinhLuong(
    SoQDLuong varchar(30) NOT NULL PRIMARY KEY,
    MaNV varchar(20) NOT NULL,
    NgayBanHanh date NOT NULL DEFAULT GETDATE(),
    NgayHieuLuc date NOT NULL,
    LuongCoBan decimal(18,2) NOT NULL CHECK(LuongCoBan >= 0),
    PhuCapLuong decimal(18,2) NOT NULL DEFAULT 0 CHECK(PhuCapLuong >= 0),
    PhuCapDocHai decimal(18,2) NOT NULL DEFAULT 0 CHECK(PhuCapDocHai >= 0), -- Phụ cấp độc hại sơn
    LyDoDieuChinh nvarchar(255) NOT NULL,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Hiệu lực',
    CONSTRAINT CK_QDLuong_TrangThai CHECK(TrangThai IN (N'Hiệu lực', N'Hết hiệu lực')),
    CONSTRAINT FK_QDLuong_NhanVien FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

-- ==============================================================================
-- 4. TẠO CÁC BẢNG KẾ HOẠCH TUẦN, CHẤM CÔNG & PHỤ TRỘI
-- ==============================================================================

-- Bảng Kế hoạch làm việc tuần
CREATE TABLE KeHoachLamViecTuan(
    MaKeHoach varchar(30) NOT NULL PRIMARY KEY,
    MaPhongBan varchar(20) NOT NULL,
    TuanThu int NOT NULL CHECK(TuanThu BETWEEN 1 AND 53),
    NamKeHoach int NOT NULL CHECK(NamKeHoach >= 2020),
    TuNgay date NOT NULL,
    DenNgay date NOT NULL,
    NgayLap date NOT NULL DEFAULT GETDATE(),
    GhiChuPhuTroiDuKien nvarchar(255) NULL,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Dự thảo',
    CONSTRAINT CK_KeHoach_TrangThai CHECK(TrangThai IN (N'Dự thảo', N'Đã duyệt', N'Đang thực hiện', N'Hoàn tất')),
    CONSTRAINT FK_KeHoach_PhongBan FOREIGN KEY(MaPhongBan) REFERENCES PhongBan(MaPhongBan)
);

-- Bảng Chi tiết kế hoạch ca kíp xưởng sản xuất sơn
CREATE TABLE ChiTietKeHoachCa(
    MaChiTietCa varchar(30) NOT NULL PRIMARY KEY,
    MaKeHoach varchar(30) NOT NULL,
    MaNV varchar(20) NOT NULL,
    NgayTrongTuan date NOT NULL,
    CaLamViec nvarchar(50) NOT NULL,
    NhiemVuPhanCong nvarchar(255) NOT NULL,
    CONSTRAINT CK_ChiTietCa_Ca CHECK(CaLamViec IN (
        N'Ca 1 (Sáng)',
        N'Ca 2 (Chiều)',
        N'Ca 3 (Đêm)',
        N'Ca hành chính'
    )),
    CONSTRAINT FK_ChiTietCa_KeHoach FOREIGN KEY(MaKeHoach) REFERENCES KeHoachLamViecTuan(MaKeHoach),
    CONSTRAINT FK_ChiTietCa_NhanVien FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

-- Bảng Chấm công máy tính tháng (26 công chuẩn)
CREATE TABLE BangChamCong(
    MaBangChamCong varchar(30) NOT NULL PRIMARY KEY,
    MaPhongBan varchar(20) NOT NULL,
    ThangChamCong int NOT NULL CHECK(ThangChamCong BETWEEN 1 AND 12),
    NamChamCong int NOT NULL CHECK(NamChamCong >= 2020),
    NgayChotCong date NOT NULL,
    SoCongChuan int NOT NULL DEFAULT 26 CHECK(SoCongChuan > 0), -- 26 công chuẩn
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Đang chấm',
    CONSTRAINT UQ_BangChamCong_Phong_Thang UNIQUE(MaPhongBan, ThangChamCong, NamChamCong),
    CONSTRAINT CK_BangChamCong_TrangThai CHECK(TrangThai IN (N'Đang chấm', N'Đã chốt công', N'Đã chuyển kế toán')),
    CONSTRAINT FK_BangChamCong_PhongBan FOREIGN KEY(MaPhongBan) REFERENCES PhongBan(MaPhongBan)
);

-- Bảng Chi tiết chấm công từng nhân viên
CREATE TABLE ChiTietChamCong(
    MaCTCC varchar(30) NOT NULL PRIMARY KEY,
    MaBangChamCong varchar(30) NOT NULL,
    MaNV varchar(20) NOT NULL,
    SoNgayDiLamThucTe decimal(4,1) NOT NULL DEFAULT 0 CHECK(SoNgayDiLamThucTe >= 0),
    SoNgayNghiPhep decimal(4,1) NOT NULL DEFAULT 0 CHECK(SoNgayNghiPhep >= 0),
    SoNgayNghiOm decimal(4,1) NOT NULL DEFAULT 0 CHECK(SoNgayNghiOm >= 0),
    SoNgayNghiKhongPhep decimal(4,1) NOT NULL DEFAULT 0 CHECK(SoNgayNghiKhongPhep >= 0),
    GhiChu nvarchar(255) NULL,
    CONSTRAINT UQ_CTCC_Bang_NV UNIQUE(MaBangChamCong, MaNV),
    CONSTRAINT FK_CTCC_BangChamCong FOREIGN KEY(MaBangChamCong) REFERENCES BangChamCong(MaBangChamCong),
    CONSTRAINT FK_CTCC_NhanVien FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

-- Bảng Phiếu phụ trội làm việc ngoài giờ (Hệ số 1.5)
CREATE TABLE PhieuPhuTroi(
    SoPhieuPhuTroi varchar(30) NOT NULL PRIMARY KEY,
    MaPhongBan varchar(20) NOT NULL,
    NgayPhuTroi date NOT NULL,
    HinhThucPhuTroi nvarchar(100) NOT NULL,
    HeSoPhuTroi decimal(3,2) NOT NULL DEFAULT 1.50 CHECK(HeSoPhuTroi >= 1.00), -- Hệ số 1.5
    LyDoPhuTroi nvarchar(255) NOT NULL,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Chờ duyệt',
    CONSTRAINT CK_PhieuPhuTroi_TrangThai CHECK(TrangThai IN (N'Chờ duyệt', N'Đã duyệt', N'Đã chốt giờ')),
    CONSTRAINT FK_PhieuPhuTroi_PhongBan FOREIGN KEY(MaPhongBan) REFERENCES PhongBan(MaPhongBan)
);

-- Bảng Chi tiết giờ phụ trội nhân viên
CREATE TABLE ChiTietPhuTroi(
    MaCTPhuTroi varchar(30) NOT NULL PRIMARY KEY,
    SoPhieuPhuTroi varchar(30) NOT NULL,
    MaNV varchar(20) NOT NULL,
    SoGioPhuTroi decimal(4,1) NOT NULL CHECK(SoGioPhuTroi > 0),
    NhiemVuCuThe nvarchar(255) NOT NULL,
    CONSTRAINT UQ_CTPT_Phieu_NV UNIQUE(SoPhieuPhuTroi, MaNV),
    CONSTRAINT FK_CTPT_PhieuPhuTroi FOREIGN KEY(SoPhieuPhuTroi) REFERENCES PhieuPhuTroi(SoPhieuPhuTroi),
    CONSTRAINT FK_CTPT_NhanVien FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

-- ==============================================================================
-- 5. TẠO CÁC BẢNG KHEN THƯỞNG & KỶ LUẬT
-- ==============================================================================

-- Bảng Quyết định khen thưởng (Tiền mặt hoặc Chuyển Bảng lương)
CREATE TABLE QuyetDinhKhenThuong(
    SoQDKhenThuong varchar(30) NOT NULL PRIMARY KEY,
    MaNV varchar(20) NOT NULL,
    NgayBanHanh date NOT NULL DEFAULT GETDATE(),
    LoaiKhenThuong nvarchar(100) NOT NULL,
    LyDoKhenThuong nvarchar(255) NOT NULL,
    SoTienKhenThuong decimal(18,2) NOT NULL CHECK(SoTienKhenThuong >= 0),
    HinhThucChiTra nvarchar(50) NOT NULL,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Chờ duyệt',
    CONSTRAINT CK_QDKhenThuong_HinhThuc CHECK(HinhThucChiTra IN (N'Tiền mặt', N'Chuyển vào Bảng lương')),
    CONSTRAINT CK_QDKhenThuong_TrangThai CHECK(TrangThai IN (
        N'Chờ duyệt',
        N'Đã ban hành',
        N'Đã chi tiền mặt',
        N'Đã kết chuyển lương'
    )),
    CONSTRAINT FK_QDKhenThuong_NhanVien FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

-- Bảng Phiếu chi tiền thưởng mặt tại quỹ
CREATE TABLE PhieuChiThuong(
    SoPhieuChi varchar(30) NOT NULL PRIMARY KEY,
    SoQDKhenThuong varchar(30) NOT NULL UNIQUE,
    NgayChi date NOT NULL DEFAULT GETDATE(),
    SoTienChi decimal(18,2) NOT NULL CHECK(SoTienChi > 0),
    NguoiNhanTien nvarchar(120) NOT NULL,
    LyDoChi nvarchar(255) NOT NULL,
    CONSTRAINT FK_PhieuChi_QDKhenThuong FOREIGN KEY(SoQDKhenThuong) REFERENCES QuyetDinhKhenThuong(SoQDKhenThuong)
);

-- Bảng Quyết định kỷ luật
CREATE TABLE QuyetDinhKyLuat(
    SoQDKyLuat varchar(30) NOT NULL PRIMARY KEY,
    MaNV varchar(20) NOT NULL,
    NgayBanHanh date NOT NULL DEFAULT GETDATE(),
    LoaiKyLuat nvarchar(100) NOT NULL,
    LyDoKyLuat nvarchar(255) NOT NULL,
    SoTienNopPhat decimal(18,2) NOT NULL DEFAULT 0 CHECK(SoTienNopPhat >= 0),
    HinhThucNopPhat nvarchar(50) NOT NULL,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Chờ duyệt',
    CONSTRAINT CK_QDKyLuat_HinhThuc CHECK(HinhThucNopPhat IN (N'Nộp tiền mặt', N'Trừ vào Bảng lương', N'Khiển trách không phạt')),
    CONSTRAINT CK_QDKyLuat_TrangThai CHECK(TrangThai IN (
        N'Chờ duyệt',
        N'Đã ban hành',
        N'Đã thu tiền',
        N'Đã trừ lương'
    )),
    CONSTRAINT FK_QDKyLuat_NhanVien FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);

-- Bảng Phiếu thu tiền nộp phạt mặt
CREATE TABLE PhieuThuPhat(
    SoPhieuThu varchar(30) NOT NULL PRIMARY KEY,
    SoQDKyLuat varchar(30) NOT NULL UNIQUE,
    NgayThu date NOT NULL DEFAULT GETDATE(),
    SoTienThu decimal(18,2) NOT NULL CHECK(SoTienThu > 0),
    NguoiNopTien nvarchar(120) NOT NULL,
    LyDoThu nvarchar(255) NOT NULL,
    CONSTRAINT FK_PhieuThu_QDKyLuat FOREIGN KEY(SoQDKyLuat) REFERENCES QuyetDinhKyLuat(SoQDKyLuat)
);

-- ==============================================================================
-- 6. TẠO CÁC BẢNG QUYẾT TOÁN & BẢNG LƯƠNG THÁNG
-- ==============================================================================

-- Bảng Bảng thanh toán lương tháng (Master)
CREATE TABLE BangLuongThang(
    MaBangLuong varchar(30) NOT NULL PRIMARY KEY,
    ThangLuong int NOT NULL CHECK(ThangLuong BETWEEN 1 AND 12),
    NamLuong int NOT NULL CHECK(NamLuong >= 2020),
    NgayLap date NOT NULL DEFAULT GETDATE(),
    TongQuyLuong decimal(18,2) NOT NULL DEFAULT 0 CHECK(TongQuyLuong >= 0),
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Bản thảo',
    CONSTRAINT UQ_BangLuong_Thang_Nam UNIQUE(ThangLuong, NamLuong),
    CONSTRAINT CK_BangLuong_TrangThai CHECK(TrangThai IN (
        N'Bản thảo',
        N'Chờ Giám đốc duyệt',
        N'Đã phê duyệt',
        N'Đã thanh toán lương'
    ))
);

-- Bảng Chi tiết lương nhân viên (Detail - Snapshot tính toán tự động)
CREATE TABLE ChiTietBangLuong(
    MaCTL varchar(30) NOT NULL PRIMARY KEY,
    MaBangLuong varchar(30) NOT NULL,
    MaNV varchar(20) NOT NULL,
    LuongCoBan decimal(18,2) NOT NULL CHECK(LuongCoBan >= 0),
    PhuCapChucVu decimal(18,2) NOT NULL DEFAULT 0 CHECK(PhuCapChucVu >= 0),
    PhuCapLuong decimal(18,2) NOT NULL DEFAULT 0 CHECK(PhuCapLuong >= 0),
    PhuCapDocHai decimal(18,2) NOT NULL DEFAULT 0 CHECK(PhuCapDocHai >= 0),
    SoCongThucTe decimal(4,1) NOT NULL DEFAULT 0 CHECK(SoCongThucTe >= 0),
    LuongThoiGian decimal(18,2) NOT NULL DEFAULT 0 CHECK(LuongThoiGian >= 0),
    DonGiaGioChuan decimal(18,2) NOT NULL DEFAULT 0 CHECK(DonGiaGioChuan >= 0),
    TongGioPhuTroi decimal(4,1) NOT NULL DEFAULT 0 CHECK(TongGioPhuTroi >= 0),
    TienPhuTroi decimal(18,2) NOT NULL DEFAULT 0 CHECK(TienPhuTroi >= 0),
    TienKhenThuong decimal(18,2) NOT NULL DEFAULT 0 CHECK(TienKhenThuong >= 0),
    TienTrichBaoHiem decimal(18,2) NOT NULL DEFAULT 0 CHECK(TienTrichBaoHiem >= 0),
    TienKyLuatPhat decimal(18,2) NOT NULL DEFAULT 0 CHECK(TienKyLuatPhat >= 0),
    
    -- Cột tính toán tự động (Persisted Computed Columns)
    TongThuNhap AS (CONVERT(decimal(18,2), 
        LuongThoiGian + PhuCapChucVu + PhuCapLuong + PhuCapDocHai + TienPhuTroi + TienKhenThuong
    )) PERSISTED,
    
    TongTrichTru AS (CONVERT(decimal(18,2), 
        TienTrichBaoHiem + TienKyLuatPhat
    )) PERSISTED,
    
    LuongThucLanh AS (CONVERT(decimal(18,2), 
        (LuongThoiGian + PhuCapChucVu + PhuCapLuong + PhuCapDocHai + TienPhuTroi + TienKhenThuong) - 
        (TienTrichBaoHiem + TienKyLuatPhat)
    )) PERSISTED,
    
    CONSTRAINT UQ_CTBL_Bang_NV UNIQUE(MaBangLuong, MaNV),
    CONSTRAINT FK_CTBL_BangLuong FOREIGN KEY(MaBangLuong) REFERENCES BangLuongThang(MaBangLuong),
    CONSTRAINT FK_CTBL_NhanVien FOREIGN KEY(MaNV) REFERENCES NhanVien(MaNV)
);
GO

-- ==============================================================================
-- 7. TẠO INDEXES TỐI ƯU HÓA HIỆU NĂNG TRUY VẤN
-- ==============================================================================
CREATE INDEX IX_NhanVien_PhongBan ON NhanVien(MaPhongBan, TrangThai);
CREATE INDEX IX_HopDong_NhanVien ON HopDongLaoDong(MaNV, LoaiHopDong, TrangThai);
CREATE INDEX IX_HoSoBaoHiem_HopDong ON HoSoBaoHiem(SoHopDong, MaNV);
CREATE INDEX IX_QDLuong_NhanVien ON QuyetDinhLuong(MaNV, TrangThai);
CREATE INDEX IX_QDChucVu_NhanVien ON QuyetDinhChucVu(MaNV, TrangThai);
CREATE INDEX IX_BangChamCong_Thang ON BangChamCong(ThangChamCong, NamChamCong, MaPhongBan);
CREATE INDEX IX_CTCC_NhanVien ON ChiTietChamCong(MaNV, MaBangChamCong);
CREATE INDEX IX_CTPT_NhanVien ON ChiTietPhuTroi(MaNV, SoPhieuPhuTroi);
CREATE INDEX IX_QDKhenThuong_NhanVien ON QuyetDinhKhenThuong(MaNV, TrangThai);
CREATE INDEX IX_QDKyLuat_NhanVien ON QuyetDinhKyLuat(MaNV, TrangThai);
CREATE INDEX IX_BangLuong_ThangNam ON BangLuongThang(ThangLuong, NamLuong, TrangThai);
CREATE INDEX IX_CTBL_NhanVien ON ChiTietBangLuong(MaNV, MaBangLuong);
GO

-- ==============================================================================
-- 8. DỮ LIỆU MẪU (SEED DATA BÁM SÁT MÔ TẢ ĐẶC THÙ CÔNG TY SƠN ĐÔNG Á)
-- ==============================================================================

-- 1. Danh mục Phòng ban & Phân xưởng sản xuất sơn
INSERT INTO PhongBan(MaPhongBan, TenPhongBan, DiaDiem, SoDienThoai, TruongPhong) VALUES
('PX01', N'Phân xưởng Pha màu hóa chất sơn', N'Khu B - Dãy nhà xưởng 1', '028.3831.01', N'KS. Trần Văn Thắng'),
('PX02', N'Phân xưởng Đóng thùng & Hoàn thiện', N'Khu B - Dãy nhà xưởng 2', '028.3831.02', N'Ông Lê Hoàng Long'),
('PX03', N'Xưởng Cơ điện & Bảo trì công nghiệp', N'Khu C - Trạm kỹ thuật', '028.3831.03', N'KS. Phạm Văn Bình'),
('PB01', N'Phòng Nghiên cứu phát triển (R&D)', N'Tầng 2 - Tòa nhà Điều hành', '028.3831.04', N'ThS. Vũ Hoàng Nam'),
('PB02', N'Phòng Kế toán tài vụ', N'Tầng 1 - Tòa nhà Điều hành', '028.3831.05', N'Bà Đặng Thùy Linh'),
('PB03', N'Phòng Tổ chức Hành chính - Nhân sự', N'Tầng 1 - Tòa nhà Điều hành', '028.3831.06', N'Bà Hoàng Kim Oanh'),
('BGD',  N'Ban Giám đốc', N'Tầng 3 - Tòa nhà Điều hành', '028.3831.00', N'Ông Đỗ Đông Á');

-- 2. Danh mục Chức vụ
INSERT INTO ChucVu(MaChucVu, TenChucVu, MoTaCongViec) VALUES
('CV01', N'Giám đốc điều hành', N'Lãnh đạo toàn diện hoạt động sản xuất kinh doanh sơn'),
('CV02', N'Trưởng phòng / Quản đốc xưởng', N'Quản lý điều hành sản xuất, nhân sự phòng ban/xưởng'),
('CV03', N'Kỹ thuật viên pha màu sơn', N'Chịu trách nhiệm công thức pha dung môi, màu sơn theo chuẩn'),
('CV04', N'Công nhân vận hành máy', N'Vận hành nồi hấp, bồn khuấy hóa chất sơn'),
('CV05', N'Công nhân đóng thùng sơn', N'Đóng thùng, dán nhãn an toàn hóa chất và bốc xếp'),
('CV06', N'Kế toán tiền lương', N'Tổng hợp chấm công, phụ trội và lập bảng lương tháng'),
('CV07', N'Chuyên viên nhân sự', N'Tuyển dụng, quản lý hợp đồng, bảo hiểm xã hội');

-- 3. Hồ sơ Nhân viên mẫu (Bao quát 5 Actor chính & Công nhân sản xuất)
INSERT INTO NhanVien(MaNV, MaPhongBan, HoTen, NgaySinh, GioiTinh, SoCCCD, DiaChi, SoDienThoai, Email, NgayVaoLam, TrangThai) VALUES
('NV0001', 'BGD',  N'Đỗ Đông Á', '1975-04-12', N'Nam', '079075000001', N'120 Nguyễn Văn Trỗi, Phú Nhuận, TP.HCM', '0903888999', 'giamdoc@sondonga.com.vn', '2015-01-01', N'Chính thức'),
('NV0002', 'PB03', N'Hoàng Kim Oanh', '1988-09-20', N'Nữ', '079088000002', N'45 Lê Văn Sỹ, Q.3, TP.HCM', '0918112233', 'oanh.hk@sondonga.com.vn', '2018-03-15', N'Chính thức'),
('NV0003', 'PB02', N'Đặng Thùy Linh', '1990-11-05', N'Nữ', '079090000003', N'78 Hai Bà Trưng, Q.1, TP.HCM', '0909556677', 'linh.dt@sondonga.com.vn', '2019-07-01', N'Chính thức'),
('NV0004', 'PX01', N'Trần Văn Thắng', '1982-06-18', N'Nam', '079082000004', N'90 Điện Biên Phủ, Bình Thạnh, TP.HCM', '0988776655', 'thang.tv@sondonga.com.vn', '2016-05-10', N'Chính thức'),
('NV0005', 'PB03', N'Nguyễn Thanh Tùng', '1993-02-14', N'Nam', '079093000005', N'15 CMT8, Q.10, TP.HCM', '0977223344', 'tung.nt@sondonga.com.vn', '2020-09-01', N'Chính thức'),
('NV0101', 'PX01', N'Trần Quốc Toàn', '1992-08-15', N'Nam', '079092000101', N'25 Bình Lợi, Bình Thạnh, TP.HCM', '0903123456', 'toan.tq@sondonga.com.vn', '2021-02-15', N'Chính thức'),
('NV0102', 'PX01', N'Lê Văn Hùng', '1995-10-22', N'Nam', '079095000102', N'34 Kha Vạn Cân, Thủ Đức, TP.HCM', '0918765432', 'hung.lv@sondonga.com.vn', '2022-04-01', N'Chính thức'),
('NV0103', 'PX02', N'Nguyễn Thị Mai', '2001-03-12', N'Nữ', '079201000103', N'56 Nguyễn Oanh, Gò Vấp, TP.HCM', '0933445566', 'mai.nt@sondonga.com.vn', '2026-08-01', N'Thử việc');

-- 4. Tài khoản người dùng (5 Actor)
INSERT INTO NguoiDung(MaNguoiDung, MaNV, TenDangNhap, MatKhau, HoTen, VaiTro, TrangThai) VALUES
('ND01', 'NV0001', 'giamdoc', '123456', N'Đỗ Đông Á', 'GIAM_DOC', N'Hoạt động'),
('ND02', 'NV0002', 'nhansu', '123456', N'Hoàng Kim Oanh', 'NHAN_SU', N'Hoạt động'),
('ND03', 'NV0003', 'ketoanluong', '123456', N'Đặng Thùy Linh', 'KE_TOAN', N'Hoạt động'),
('ND04', 'NV0004', 'truongxuong_px01', '123456', N'Trần Văn Thắng', 'TRUONG_PHONG', N'Hoạt động'),
('ND05', 'NV0005', 'banchamcong', '123456', N'Nguyễn Thanh Tùng', 'BAN_CHAM_CONG', N'Hoạt động');

-- 5. Phiếu đề xuất tuyển dụng & Quyết định thử việc
INSERT INTO PhieuDeXuatTuyenDung(MaDeXuat, MaPhongBan, NgayDeXuat, SoLuongCanTuyen, YeuCauChuyenMon, LyDoTuyenDung, TrangThai) VALUES
('DX2026-08', 'PX02', '2026-07-20', 2, N'Sức khỏe tốt, cẩn thận, chịu được môi trường sơn', N'Bổ sung nhân sự đóng thùng dây chuyền mới', N'Đã duyệt');

INSERT INTO QuyetDinhTuyenDung(SoQDTuyenDung, MaNV, MaDeXuat, NgayBanHanh, ThoiGianThuViecTu, ThoiGianThuViecDen, MucLuongThuViec, DieuKhoanThoaThuan, TrangThai) VALUES
('QĐTV-2026-08', 'NV0103', 'DX2026-08', '2026-07-28', '2026-08-01', '2026-10-31', 5950000, N'Hưởng 85% lương bậc 1 công nhân đóng gói', N'Đang thử việc');

-- 6. Hợp đồng lao động & Hồ sơ bảo hiểm (Ngắn hạn / Dài hạn)
INSERT INTO HopDongLaoDong(SoHopDong, MaNV, LoaiHopDong, NgayKy, NgayHieuLuc, NgayHetHan, DiaDiemLamViec, TrangThai) VALUES
('HĐ2021-0101', 'NV0101', N'HĐLĐ xác định thời hạn 3 năm', '2021-02-15', '2021-02-15', '2024-02-15', N'Xưởng Pha màu hóa chất sơn', N'Hiệu lực'),
('HĐ2022-0102', 'NV0102', N'HĐLĐ xác định thời hạn 1 năm', '2022-04-01', '2022-04-01', '2023-04-01', N'Xưởng Sản xuất Pha màu', N'Hiệu lực'),
('HĐ2026-0103', 'NV0103', N'HĐLĐ ngắn hạn dưới 3 tháng', '2026-08-01', '2026-08-01', '2026-10-31', N'Phân xưởng Đóng thùng & Kho', N'Hiệu lực');

-- Hồ sơ bảo hiểm (Chỉ đóng cho NV0101, NV0102; NV0103 là HĐ ngắn hạn dưới 3 tháng không trích)
INSERT INTO HoSoBaoHiem(MaHoSoBH, SoHopDong, MaNV, MaSoBHXH, SoTheBHYT, NoiKhamChuaBenh, NgayBatDauBH, TyLeDongNV, TyLeDongCongTy, TrangThai) VALUES
('BH0101', 'HĐ2021-0101', 'NV0101', '7921010101', 'DN47921010101', N'Bệnh viện Đa khoa Quốc tế Đông Á', '2021-03-01', 10.50, 21.50, N'Đang tham gia'),
('BH0102', 'HĐ2022-0102', 'NV0102', '7922010202', 'DN47922010202', N'Bệnh viện Quận Thủ Đức', '2022-05-01', 10.50, 21.50, N'Đang tham gia');

-- 7. Quyết định Chức vụ & Quyết định Lương (Phụ cấp độc hại hóa chất sơn)
INSERT INTO QuyetDinhChucVu(SoQDChucVu, MaNV, MaChucVu, NgayBanHanh, NgayHieuLuc, PhuCapChucVu, LyDoBoNhiem, TrangThai) VALUES
('QĐCV-0001', 'NV0001', 'CV01', '2015-01-01', '2015-01-01', 5000000, N'Đại hội đồng cổ đông bổ nhiệm', N'Hiệu lực'),
('QĐCV-0101', 'NV0101', 'CV03', '2021-02-15', '2021-02-15', 500000, N'Bổ nhiệm Kỹ thuật viên trưởng ca pha màu', N'Hiệu lực'),
('QĐCV-0102', 'NV0102', 'CV04', '2022-04-01', '2022-04-01', 0, N'Bổ nhiệm Công nhân vận hành máy', N'Hiệu lực');

INSERT INTO QuyetDinhLuong(SoQDLuong, MaNV, NgayBanHanh, NgayHieuLuc, LuongCoBan, PhuCapLuong, PhuCapDocHai, LyDoDieuChinh, TrangThai) VALUES
('QĐL-0101', 'NV0101', '2026-01-01', '2026-01-01', 10500000, 0, 1800000, N'Nâng bậc thợ pha màu sơn & hưởng PC độc hại mức 1', N'Hiệu lực'),
('QĐL-0102', 'NV0102', '2026-01-01', '2026-01-01', 8500000,  0, 1800000, N'Công nhân trực tiếp vận hành bồn sơn hóa chất', N'Hiệu lực'),
('QĐL-0103', 'NV0103', '2026-08-01', '2026-08-01', 7000000,  0, 800000,  N'Công nhân đóng thùng tiếp xúc sơn hoàn thiện mức 3', N'Hiệu lực');

-- 8. Kế hoạch tuần & Chấm công tháng (26 công chuẩn)
INSERT INTO KeHoachLamViecTuan(MaKeHoach, MaPhongBan, TuanThu, NamKeHoach, TuNgay, DenNgay, NgayLap, GhiChuPhuTroiDuKien, TrangThai) VALUES
('KH2026-W42', 'PX01', 42, 2026, '2026-10-12', '2026-10-18', '2026-10-10', N'Dự kiến tăng ca mẻ sơn tàu biển 16 giờ', N'Hoàn tất');

INSERT INTO BangChamCong(MaBangChamCong, MaPhongBan, ThangChamCong, NamChamCong, NgayChotCong, SoCongChuan, TrangThai) VALUES
('BCC-2026-10-PX01', 'PX01', 10, 2026, '2026-10-31', 26, N'Đã chốt công');

INSERT INTO ChiTietChamCong(MaCTCC, MaBangChamCong, MaNV, SoNgayDiLamThucTe, SoNgayNghiPhep, SoNgayNghiOm, SoNgayNghiKhongPhep, GhiChu) VALUES
('CTCC01', 'BCC-2026-10-PX01', 'NV0101', 26.0, 0.0, 0.0, 0.0, N'Đủ 26 công chuẩn'),
('CTCC02', 'BCC-2026-10-PX01', 'NV0102', 25.0, 1.0, 0.0, 0.0, N'Nghỉ phép 1 ngày có đơn');

-- 9. Phiếu phụ trội ngoài giờ (Hệ số 1.5)
INSERT INTO PhieuPhuTroi(SoPhieuPhuTroi, MaPhongBan, NgayPhuTroi, HinhThucPhuTroi, HeSoPhuTroi, LyDoPhuTroi, TrangThai) VALUES
('PT2026-10-01', 'PX01', '2026-10-16', N'Tăng ca ngoài giờ ban đêm', 1.50, N'Kịp tiến độ giao 5000 thùng sơn công nghiệp', N'Đã chốt giờ');

INSERT INTO ChiTietPhuTroi(MaCTPhuTroi, SoPhieuPhuTroi, MaNV, SoGioPhuTroi, NhiemVuCuThe) VALUES
('CTPT01', 'PT2026-10-01', 'NV0101', 16.0, N'Giám sát pha màu mẻ sơn epoxy công nghiệp số 8'),
('CTPT02', 'PT2026-10-01', 'NV0102', 12.0, N'Vận hành bồn khuấy mẻ sơn epoxy số 8');

-- 10. Khen thưởng & Kỷ luật
INSERT INTO QuyetDinhKhenThuong(SoQDKhenThuong, MaNV, NgayBanHanh, LoaiKhenThuong, LyDoKhenThuong, SoTienKhenThuong, HinhThucChiTra, TrangThai) VALUES
('QĐKT-2026-10', 'NV0101', '2026-10-20', N'Thưởng năng suất chất lượng', N'Hoàn thành vượt 120% định mức mẻ sơn chất lượng cao', 2000000, N'Chuyển vào Bảng lương', N'Đã kết chuyển lương');

INSERT INTO QuyetDinhKyLuat(SoQDKyLuat, MaNV, NgayBanHanh, LoaiKyLuat, LyDoKyLuat, SoTienNopPhat, HinhThucNopPhat, TrangThai) VALUES
('QĐKL-2026-03', 'NV0102', '2026-10-15', N'Kỷ luật an toàn lao động', N'Không đeo mặt nạ phòng độc khi pha dung môi hóa chất sơn', 500000, N'Trừ vào Bảng lương', N'Đã trừ lương');

-- 11. Bảng thanh toán tiền lương tháng & Chi tiết tính toán
INSERT INTO BangLuongThang(MaBangLuong, ThangLuong, NamLuong, NgayLap, TongQuyLuong, TrangThai) VALUES
('BL-2026-10', 10, 2026, '2026-10-31', 24225192, N'Đã phê duyệt');

-- Nhân viên NV0101: 
-- Lương CB: 10,500,000 | PC Chức vụ: 500,000 | PC Độc hại: 1,800,000
-- Đủ 26 công -> Lương thời gian = 10,500,000
-- Giờ chuẩn = 26 * 8 = 208h -> Đơn giá giờ = 10,500,000 / 208 = 50,480.77 đ/h
-- Phụ trội: 16h * 50,480.77 * 1.5 = 1,211,538 đ
-- Thưởng: 2,000,000 đ | Phạt: 0 đ
-- Trích BHXH (10.5% * 10,500,000) = 1,102,500 đ
-- Thu nhập = 10,500,000 + 500,000 + 1,800,000 + 1,211,538 + 2,000,000 = 16,011,538 đ
-- Thực lãnh = 16,011,538 - 1,102,500 = 14,909,038 đ

INSERT INTO ChiTietBangLuong(MaCTL, MaBangLuong, MaNV, LuongCoBan, PhuCapChucVu, PhuCapLuong, PhuCapDocHai, SoCongThucTe, LuongThoiGian, DonGiaGioChuan, TongGioPhuTroi, TienPhuTroi, TienKhenThuong, TienTrichBaoHiem, TienKyLuatPhat) VALUES
('CTL2026-10-01', 'BL-2026-10', 'NV0101', 10500000, 500000, 0, 1800000, 26.0, 10500000, 50481, 16.0, 1211538, 2000000, 1102500, 0),
('CTL2026-10-02', 'BL-2026-10', 'NV0102', 8500000,  0,      0, 1800000, 25.0, 8173077,  40865, 12.0, 735577,  0,       892500,  500000);
GO
