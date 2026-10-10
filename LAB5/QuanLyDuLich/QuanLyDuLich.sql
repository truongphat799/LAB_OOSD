IF DB_ID(N'QuanLyDuLich') IS NULL 
    CREATE DATABASE QuanLyDuLich;
GO

USE QuanLyDuLich;
GO

-- ==============================================================================
-- 1. XÓA BẢNG CŨ THEO THỨ TỰ PHỤ THUỘC KHÓA NGOẠI (REVERSE DEPENDENCY ORDER)
-- ==============================================================================
IF OBJECT_ID('PhieuKhaoSat', 'U') IS NOT NULL DROP TABLE PhieuKhaoSat;
IF OBJECT_ID('PhanCongHDV', 'U') IS NOT NULL DROP TABLE PhanCongHDV;
IF OBJECT_ID('ThanhVienDoan', 'U') IS NOT NULL DROP TABLE ThanhVienDoan;
IF OBJECT_ID('VeDuLich', 'U') IS NOT NULL DROP TABLE VeDuLich;
IF OBJECT_ID('PhieuDangKyDoan', 'U') IS NOT NULL DROP TABLE PhieuDangKyDoan;
IF OBJECT_ID('Chuyen_DiemDon', 'U') IS NOT NULL DROP TABLE Chuyen_DiemDon;
IF OBJECT_ID('ChuyenDuLich', 'U') IS NOT NULL DROP TABLE ChuyenDuLich;
IF OBJECT_ID('Tour_DiemThamQuan', 'U') IS NOT NULL DROP TABLE Tour_DiemThamQuan;
IF OBJECT_ID('NoiDungChan', 'U') IS NOT NULL DROP TABLE NoiDungChan;
IF OBJECT_ID('DiemThamQuan', 'U') IS NOT NULL DROP TABLE DiemThamQuan;
IF OBJECT_ID('PhuongTien', 'U') IS NOT NULL DROP TABLE PhuongTien;
IF OBJECT_ID('TourDuLich', 'U') IS NOT NULL DROP TABLE TourDuLich;
IF OBJECT_ID('DiemBanVe', 'U') IS NOT NULL DROP TABLE DiemBanVe;
IF OBJECT_ID('DiemDon', 'U') IS NOT NULL DROP TABLE DiemDon;
IF OBJECT_ID('KhachDoan', 'U') IS NOT NULL DROP TABLE KhachDoan;
IF OBJECT_ID('KhachHang', 'U') IS NOT NULL DROP TABLE KhachHang;
IF OBJECT_ID('HuongDanVien', 'U') IS NOT NULL DROP TABLE HuongDanVien;
GO

-- ==============================================================================
-- 2. TẠO CÁC BẢNG DANH MỤC VÀ ĐỐI TƯỢNG CƠ BẢN (MASTER / DIMENSION TABLES)
-- ==============================================================================

-- Bảng 1: Phương tiện di chuyển
CREATE TABLE PhuongTien(
    MaPhuongTien varchar(20) NOT NULL PRIMARY KEY,
    TenPhuongTien nvarchar(50) NOT NULL,
    HangVanChuyen nvarchar(100) NOT NULL,
    GhiChu nvarchar(200) NULL
);

-- Bảng 2: Điểm tham quan (Di tích lịch sử, thắng cảnh văn hóa)
CREATE TABLE DiemThamQuan(
    MaDiemThamQuan varchar(20) NOT NULL PRIMARY KEY,
    TenDiemThamQuan nvarchar(150) NOT NULL UNIQUE,
    DiaDiem nvarchar(200) NOT NULL,
    NoiDung nvarchar(max) NULL,
    YNghia nvarchar(max) NULL
);

-- Bảng 3: Tour du lịch mẫu (Mọi tour bắt đầu và kết thúc tại TP.HCM)
CREATE TABLE TourDuLich(
    MaTour varchar(20) NOT NULL PRIMARY KEY,
    TenTour nvarchar(150) NOT NULL UNIQUE,
    SoNgay int NOT NULL CHECK(SoNgay > 0),
    SoDem int NOT NULL CHECK(SoDem >= 0),
    DonGiaKhach decimal(18,2) NOT NULL CHECK(DonGiaKhach >= 0),
    NoiKhoiHanh nvarchar(50) NOT NULL DEFAULT N'TP.HCM',
    NoiKetThuc nvarchar(50) NOT NULL DEFAULT N'TP.HCM',
    CONSTRAINT CK_Tour_KhoiHanh_KetThuc CHECK(NoiKhoiHanh = N'TP.HCM' AND NoiKetThuc = N'TP.HCM')
);

-- Bảng 4: Bảng trung gian Tour - Điểm tham quan (Quan hệ N - N)
CREATE TABLE Tour_DiemThamQuan(
    MaTour varchar(20) NOT NULL,
    MaDiemThamQuan varchar(20) NOT NULL,
    GhiChu nvarchar(150) NULL,
    PRIMARY KEY(MaTour, MaDiemThamQuan),
    CONSTRAINT FK_Tour_DTQ_Tour FOREIGN KEY(MaTour) REFERENCES TourDuLich(MaTour) ON DELETE CASCADE,
    CONSTRAINT FK_Tour_DTQ_Diem FOREIGN KEY(MaDiemThamQuan) REFERENCES DiemThamQuan(MaDiemThamQuan)
);

-- Bảng 5: Nơi dừng chân trên lộ trình tour (Đổi phương tiện, ăn uống, lưu trú KS)
CREATE TABLE NoiDungChan(
    MaNoiDungChan varchar(20) NOT NULL PRIMARY KEY,
    MaTour varchar(20) NOT NULL,
    ThuTuDung int NOT NULL CHECK(ThuTuDung > 0),
    TenDiaDiem nvarchar(100) NOT NULL,
    CoDoiPhuongTien bit NOT NULL DEFAULT 0,
    CoNoiAn bit NOT NULL DEFAULT 1,
    CoKhachSan bit NOT NULL DEFAULT 0,
    LoaiKhachSan int NULL CHECK(LoaiKhachSan IS NULL OR LoaiKhachSan BETWEEN 1 AND 5),
    MaPhuongTien varchar(20) NULL,
    CONSTRAINT UQ_NoiDungChan_Tour_ThuTu UNIQUE(MaTour, ThuTuDung),
    CONSTRAINT FK_NoiDungChan_Tour FOREIGN KEY(MaTour) REFERENCES TourDuLich(MaTour) ON DELETE CASCADE,
    CONSTRAINT FK_NoiDungChan_PhuongTien FOREIGN KEY(MaPhuongTien) REFERENCES PhuongTien(MaPhuongTien)
);

-- Bảng 6: Điểm đón quy định cố định (Gom khách lẻ theo quy định của công ty - BR02)
CREATE TABLE DiemDon(
    MaDiemDon varchar(20) NOT NULL PRIMARY KEY,
    TenDiemDon nvarchar(100) NOT NULL UNIQUE,
    DiaChiDon nvarchar(200) NOT NULL,
    GioDonQuyDinh time NOT NULL
);

-- Bảng 7: Điểm / Văn phòng bán vé gần nơi ở của khách lẻ (BR03)
CREATE TABLE DiemBanVe(
    MaDiemBanVe varchar(20) NOT NULL PRIMARY KEY,
    TenDiemBanVe nvarchar(100) NOT NULL UNIQUE,
    DiaChi nvarchar(200) NOT NULL,
    SoDienThoai varchar(20) NOT NULL
);

-- Bảng 8: Hướng dẫn viên du lịch (Quản lý hồ sơ, lương căn bản - BR06, BR07)
CREATE TABLE HuongDanVien(
    MaHDV varchar(20) NOT NULL PRIMARY KEY,
    HoTen nvarchar(120) NOT NULL,
    SoDienThoai varchar(20) NOT NULL UNIQUE,
    LuongCanBan decimal(18,2) NOT NULL DEFAULT 0 CHECK(LuongCanBan >= 0),
    ChuyenMon nvarchar(100) NOT NULL
);

-- Bảng 9: Khách hàng chung (Định danh người mua vé hoặc đại diện đoàn)
CREATE TABLE KhachHang(
    MaKhachHang varchar(20) NOT NULL PRIMARY KEY,
    HoTen nvarchar(120) NOT NULL,
    SoDienThoai varchar(20) NOT NULL,
    DiaChi nvarchar(200) NOT NULL,
    LoaiKhach varchar(10) NOT NULL CHECK(LoaiKhach IN ('DOAN', 'LE'))
);

-- Bảng 10: Khách đoàn mở rộng (Lưu vết CRM phục vụ CSKH lâu dài)
CREATE TABLE KhachDoan(
    MaKhachHang varchar(20) NOT NULL PRIMARY KEY,
    TenCoQuan nvarchar(150) NOT NULL,
    DiaChiCoQuan nvarchar(200) NOT NULL,
    DienThoaiCoQuan varchar(20) NOT NULL,
    NguoiDaiDien nvarchar(120) NOT NULL,
    ChucVu nvarchar(50) NOT NULL,
    CONSTRAINT FK_KhachDoan_KhachHang FOREIGN KEY(MaKhachHang) REFERENCES KhachHang(MaKhachHang) ON DELETE CASCADE
);
GO

-- ==============================================================================
-- 3. TẠO CÁC BẢNG NGHIỆP VỤ GIAO DỊCH (TRANSACTION, MASTER-DETAIL, PHÂN CÔNG)
-- ==============================================================================

-- Bảng 11: Chuyến du lịch định kỳ (Gom khách lẻ theo lịch cố định)
CREATE TABLE ChuyenDuLich(
    MaChuyen varchar(20) NOT NULL PRIMARY KEY,
    MaTour varchar(20) NOT NULL,
    NgayDi date NOT NULL,
    NgayVe date NOT NULL,
    SoChoToiDa int NOT NULL DEFAULT 45 CHECK(SoChoToiDa > 0),
    SoChoDaDat int NOT NULL DEFAULT 0 CHECK(SoChoDaDat >= 0),
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Còn chỗ',
    CONSTRAINT CK_Chuyen_NgayVe CHECK(NgayVe >= NgayDi),
    CONSTRAINT CK_Chuyen_SoCho CHECK(SoChoDaDat <= SoChoToiDa),
    CONSTRAINT CK_Chuyen_TrangThai CHECK(TrangThai IN (N'Còn chỗ', N'Hết chỗ', N'Đang đi', N'Hoàn tất', N'Đã hủy')),
    CONSTRAINT FK_ChuyenDuLich_Tour FOREIGN KEY(MaTour) REFERENCES TourDuLich(MaTour)
);

-- Bảng 12: Bảng trung gian Chuyến - Điểm đón quy định (Quan hệ N - N)
CREATE TABLE Chuyen_DiemDon(
    MaChuyen varchar(20) NOT NULL,
    MaDiemDon varchar(20) NOT NULL,
    PRIMARY KEY(MaChuyen, MaDiemDon),
    CONSTRAINT FK_CDD_Chuyen FOREIGN KEY(MaChuyen) REFERENCES ChuyenDuLich(MaChuyen) ON DELETE CASCADE,
    CONSTRAINT FK_CDD_DiemDon FOREIGN KEY(MaDiemDon) REFERENCES DiemDon(MaDiemDon)
);

-- Bảng 13: Phiếu đăng ký tour theo đoàn (Đoàn >= 12 người, đón tận nơi, cọc 30% - BR01, BR05)
CREATE TABLE PhieuDangKyDoan(
    SoPhieuDK varchar(30) NOT NULL PRIMARY KEY,
    MaKhachHang varchar(20) NOT NULL,
    MaTour varchar(20) NOT NULL,
    NgayLap datetime NOT NULL DEFAULT GETDATE(),
    NgayDiYeuCau date NOT NULL,
    DiaDiemDon nvarchar(200) NOT NULL, -- Đón tận nơi theo yêu cầu của đoàn
    SoNguoiDi int NOT NULL CHECK(SoNguoiDi >= 12), -- BR01: Đoàn phải từ 12 người trở lên
    CoBaoHiem bit NOT NULL DEFAULT 1,
    TongKinhPhi decimal(18,2) NOT NULL CHECK(TongKinhPhi > 0),
    TienCoc decimal(18,2) NOT NULL CHECK(TienCoc >= 0),
    -- Cột tính toán: Tiền còn lại phải thu sau tour (BR05)
    TienConLai AS (CONVERT(decimal(18,2), TongKinhPhi - TienCoc)) PERSISTED,
    TrangThai nvarchar(30) NOT NULL DEFAULT N'Đã đặt cọc',
    CONSTRAINT CK_PDK_TrangThai CHECK(TrangThai IN (
        N'Đã đặt cọc', 
        N'Đang đi tour', 
        N'Đã quyết toán', 
        N'Hủy tour (Mất cọc)' -- BR05: Hủy tour mất cọc
    )),
    CONSTRAINT FK_PDK_KhachHang FOREIGN KEY(MaKhachHang) REFERENCES KhachHang(MaKhachHang),
    CONSTRAINT FK_PDK_Tour FOREIGN KEY(MaTour) REFERENCES TourDuLich(MaTour)
);

-- Bảng 14: Danh sách thành viên đoàn cùng đi (Bắt buộc khi có mua bảo hiểm - BR04)
CREATE TABLE ThanhVienDoan(
    MaThanhVien varchar(30) NOT NULL PRIMARY KEY,
    SoPhieuDK varchar(30) NOT NULL,
    HoTen nvarchar(120) NOT NULL,
    NgaySinh date NOT NULL,
    SoCCCD varchar(20) NOT NULL,
    GioiTinh nvarchar(10) NOT NULL CHECK(GioiTinh IN (N'Nam', N'Nữ')),
    SoDienThoai varchar(20) NULL,
    CONSTRAINT FK_ThanhVien_PhieuDK FOREIGN KEY(SoPhieuDK) REFERENCES PhieuDangKyDoan(SoPhieuDK) ON DELETE CASCADE
);

-- Bảng 15: Vé du lịch bán cho khách lẻ (< 12 khách, đón tại điểm cố định, trả 100% - BR01, BR05)
CREATE TABLE VeDuLich(
    SoVe varchar(30) NOT NULL PRIMARY KEY,
    MaChuyen varchar(20) NOT NULL,
    MaKhachHang varchar(20) NOT NULL,
    MaDiemBanVe varchar(20) NOT NULL,
    MaDiemDon varchar(20) NOT NULL, -- Đón tại điểm cố định theo quy định
    NgayXuatVe datetime NOT NULL DEFAULT GETDATE(),
    GiaVe decimal(18,2) NOT NULL CHECK(GiaVe > 0),
    DaThanhToan bit NOT NULL DEFAULT 1 CHECK(DaThanhToan = 1), -- BR05: Khách lẻ phải trả 100% ngay
    CONSTRAINT FK_Ve_Chuyen FOREIGN KEY(MaChuyen) REFERENCES ChuyenDuLich(MaChuyen),
    CONSTRAINT FK_Ve_KhachHang FOREIGN KEY(MaKhachHang) REFERENCES KhachHang(MaKhachHang),
    CONSTRAINT FK_Ve_DiemBanVe FOREIGN KEY(MaDiemBanVe) REFERENCES DiemBanVe(MaDiemBanVe),
    CONSTRAINT FK_Ve_DiemDon FOREIGN KEY(MaDiemDon) REFERENCES DiemDon(MaDiemDon)
);

-- Bảng 16: Phân công Hướng dẫn viên (Chống trùng lịch, lương tour - BR06, BR07)
CREATE TABLE PhanCongHDV(
    MaPhanCong varchar(20) NOT NULL PRIMARY KEY,
    MaHDV varchar(20) NOT NULL,
    MaChuyen varchar(20) NULL,   -- Gán cho chuyến lẻ (hoặc SoPhieuDK nếu là đoàn)
    SoPhieuDK varchar(30) NULL,  -- Gán cho đoàn
    NgayPhanCong date NOT NULL DEFAULT GETDATE(),
    NgayBatDau date NOT NULL,
    NgayKetThuc date NOT NULL,
    LuongTour decimal(18,2) NOT NULL DEFAULT 0 CHECK(LuongTour >= 0),
    VaiTro nvarchar(50) NOT NULL DEFAULT N'Hướng dẫn viên chính',
    CONSTRAINT CK_PhanCong_DoiTuong CHECK(
        (MaChuyen IS NOT NULL AND SoPhieuDK IS NULL) OR 
        (MaChuyen IS NULL AND SoPhieuDK IS NOT NULL)
    ),
    CONSTRAINT CK_PhanCong_NgayKetThuc CHECK(NgayKetThuc >= NgayBatDau),
    CONSTRAINT FK_PhanCong_HDV FOREIGN KEY(MaHDV) REFERENCES HuongDanVien(MaHDV),
    CONSTRAINT FK_PhanCong_Chuyen FOREIGN KEY(MaChuyen) REFERENCES ChuyenDuLich(MaChuyen),
    CONSTRAINT FK_PhanCong_Doan FOREIGN KEY(SoPhieuDK) REFERENCES PhieuDangKyDoan(SoPhieuDK)
);

-- Bảng 17: Phiếu khảo sát chất lượng sau chuyến đi (Chăm sóc khách hàng)
CREATE TABLE PhieuKhaoSat(
    SoPhieuKhaoSat varchar(30) NOT NULL PRIMARY KEY,
    MaTour varchar(20) NOT NULL,
    MaKhachHang varchar(20) NOT NULL,
    MaChuyen varchar(20) NULL,
    SoPhieuDK varchar(30) NULL,
    NgayKhaoSat date NOT NULL DEFAULT GETDATE(),
    DiemDichVu int NOT NULL CHECK(DiemDichVu BETWEEN 1 AND 5),
    DiemHDV int NOT NULL CHECK(DiemHDV BETWEEN 1 AND 5),
    DiemAnO int NOT NULL CHECK(DiemAnO BETWEEN 1 AND 5),
    YKienGopY nvarchar(max) NULL,
    CONSTRAINT CK_KhaoSat_DoiTuong CHECK(
        (MaChuyen IS NOT NULL AND SoPhieuDK IS NULL) OR 
        (MaChuyen IS NULL AND SoPhieuDK IS NOT NULL)
    ),
    CONSTRAINT FK_KhaoSat_Tour FOREIGN KEY(MaTour) REFERENCES TourDuLich(MaTour),
    CONSTRAINT FK_KhaoSat_KhachHang FOREIGN KEY(MaKhachHang) REFERENCES KhachHang(MaKhachHang),
    CONSTRAINT FK_KhaoSat_Chuyen FOREIGN KEY(MaChuyen) REFERENCES ChuyenDuLich(MaChuyen),
    CONSTRAINT FK_KhaoSat_Doan FOREIGN KEY(SoPhieuDK) REFERENCES PhieuDangKyDoan(SoPhieuDK)
);
GO

-- ==============================================================================
-- 4. TẠO INDEXES TỐI ƯU TRUY VẤN TÌM KIẾM & CHỐNG TRÙNG LỊCH HDV
-- ==============================================================================
CREATE INDEX IX_ChuyenDuLich_NgayDi ON ChuyenDuLich(NgayDi, TrangThai);
CREATE INDEX IX_PhieuDangKyDoan_NgayDi ON PhieuDangKyDoan(NgayDiYeuCau, TrangThai);
CREATE INDEX IX_PhanCongHDV_LichBan ON PhanCongHDV(MaHDV, NgayBatDau, NgayKetThuc);
CREATE INDEX IX_VeDuLich_Chuyen_Khach ON VeDuLich(MaChuyen, MaKhachHang);
CREATE INDEX IX_NoiDungChan_Tour ON NoiDungChan(MaTour, ThuTuDung);
CREATE INDEX IX_PhieuKhaoSat_Tour ON PhieuKhaoSat(MaTour, DiemDichVu);
GO

-- ==============================================================================
-- 5. DỮ LIỆU MẪU (SEED DATA BÁM SÁT MÔ TẢ ĐỀ BÀI VÀ QUY TẮC BR01 - BR07)
-- ==============================================================================

-- 5.1 Danh mục Phương tiện
INSERT INTO PhuongTien(MaPhuongTien, TenPhuongTien, HangVanChuyen, GhiChu) VALUES
('PT01', N'Xe du lịch 45 chỗ Universe', N'Công ty Vận Tải Văn Hóa Việt', N'Xe ghế ngả cao cấp, điều hòa, wifi'),
('PT02', N'Tàu hỏa du lịch 5 sao', N'Đường Sắt Việt Nam (VNR)', N'Toa giường nằm máy lạnh khoang 4'),
('PT03', N'Máy bay Airbus A321', N'Vietnam Airlines', N'Bao gồm 23kg hành lý ký gửi'),
('PT04', N'Tàu cao tốc Superdong', N'Hãng tàu Superdong Kiên Giang', N'Tuyến Rạch Giá - Phú Quốc');

-- 5.2 Danh mục Điểm tham quan (Di tích lịch sử, văn hóa)
INSERT INTO DiemThamQuan(MaDiemThamQuan, TenDiemThamQuan, DiaDiem, NoiDung, YNghia) VALUES
('DTQ01', N'Tháp Bà Ponagar', N'Đường 2/4, Vĩnh Phước, TP. Nha Trang', N'Chiêm ngưỡng quần thể đền tháp, xem biểu diễn múa Chăm', N'Quần thể kiến trúc đền tháp Chăm Pa cổ kính thế kỷ VIII - XIII'),
('DTQ02', N'Viện Hải Dương Học Nha Trang', N'Số 1 Cầu Đá, TP. Nha Trang', N'Tham quan hồ nuôi sinh vật biển, bộ xương cá voi khổng lồ', N'Cơ sở nghiên cứu biển đầu tiên và lớn nhất Đông Dương thành lập 1922'),
('DTQ03', N'Dinh III Bảo Đại', N'Số 1 Triệu Việt Vương, TP. Đà Lạt', N'Tham quan nơi sinh hoạt và làm việc của vua Bảo Đại', N'Biệt điện mùa hè đậm nét kiến trúc châu Âu của vị vua cuối cùng triều Nguyễn'),
('DTQ04', N'Nhà tù Phú Quốc', N'Xã An Thới, TP. Phú Quốc', N'Tham quan các phân khu giam giữ, tái hiện chuồng cọp', N'Di tích lịch sử quốc gia đặc biệt minh chứng tinh thần kiên cường yêu nước');

-- 5.3 Danh mục Tour du lịch (Mọi tour xuất phát và kết thúc tại TP.HCM)
INSERT INTO TourDuLich(MaTour, TenTour, SoNgay, SoDem, DonGiaKhach, NoiKhoiHanh, NoiKetThuc) VALUES
('T001', N'Nha Trang - Hòn Ngọc Biển Xanh', 3, 2, 3500000, N'TP.HCM', N'TP.HCM'),
('T002', N'Đà Lạt - Thành Phố Ngàn Hoa', 3, 3, 2800000, N'TP.HCM', N'TP.HCM'),
('T003', N'Phú Quốc - Thiên Đường Nghỉ Dưỡng', 4, 3, 4900000, N'TP.HCM', N'TP.HCM');

-- 5.4 Liên kết Tour - Điểm tham quan
INSERT INTO Tour_DiemThamQuan(MaTour, MaDiemThamQuan, GhiChu) VALUES
('T001', 'DTQ01', N'Tham quan vào buổi chiều ngày thứ 2'),
('T001', 'DTQ02', N'Tham quan vào sáng ngày thứ 3'),
('T002', 'DTQ03', N'Tham quan vào sáng ngày thứ 2'),
('T003', 'DTQ04', N'Tham quan vào chiều ngày thứ 2');

-- 5.5 Nơi dừng chân (Lộ trình: đổi xe, ăn uống, khách sạn)
INSERT INTO NoiDungChan(MaNoiDungChan, MaTour, ThuTuDung, TenDiaDiem, CoDoiPhuongTien, CoNoiAn, CoKhachSan, LoaiKhachSan, MaPhuongTien) VALUES
('NDC01', 'T001', 1, N'Phan Thiết (Mũi Né)', 0, 1, 0, NULL, NULL),
('NDC02', 'T001', 2, N'TP. Phan Rang - Tháp Chàm', 0, 1, 0, NULL, NULL),
('NDC03', 'T001', 3, N'TP. Nha Trang (Bãi biển Trần Phú)', 1, 1, 1, 4, 'PT02'),
('NDC04', 'T002', 1, N'TP. Bảo Lộc', 0, 1, 0, NULL, NULL),
('NDC05', 'T002', 2, N'TP. Đà Lạt (Hồ Xuân Hương)', 0, 1, 1, 3, NULL);

-- 5.6 Điểm đón quy định cố định (Gom khách lẻ - BR02)
INSERT INTO DiemDon(MaDiemDon, TenDiemDon, DiaChiDon, GioDonQuyDinh) VALUES
('DD01', N'Bến xe Miền Đông (cũ)', N'292 Đinh Bộ Lĩnh, Phường 26, Quận Bình Thạnh', '05:00:00'),
('DD02', N'Nhà Văn Hóa Thanh Niên', N'Số 4 Phạm Ngọc Thạch, Phường Bến Nghé, Quận 1', '05:30:00'),
('DD03', N'Cây xăng Comeco Hàng Xanh', N'178 Điện Biên Phủ, Phường 21, Quận Bình Thạnh', '05:45:00');

-- 5.7 Điểm / Văn phòng bán vé (Gần nơi ở của khách - BR03)
INSERT INTO DiemBanVe(MaDiemBanVe, TenDiemBanVe, DiaChi, SoDienThoai) VALUES
('BV01', N'Trụ sở chính Văn Hóa Việt', N'123 Nguyễn Thị Minh Khai, Phường 6, Quận 3', '028.38221144'),
('BV02', N'Văn phòng Chi nhánh Gò Vấp', N'45 Quang Trung, Phường 10, Quận Gò Vấp', '028.38992233'),
('BV03', N'Văn phòng Chi nhánh Quận 5', N'88 Nguyễn Trãi, Phường 3, Quận 5', '028.38556677');

-- 5.8 Hướng dẫn viên du lịch
INSERT INTO HuongDanVien(MaHDV, HoTen, SoDienThoai, LuongCanBan, ChuyenMon) VALUES
('HDV01', N'Nguyễn Văn Hùng', '0903.111.222', 6500000, N'Tuyến biển đảo, thuyết minh tiếng Anh'),
('HDV02', N'Lê Minh Tú', '0908.333.444', 6000000, N'Tuyến Miền Trung - Nha Trang, tiếng Pháp'),
('HDV03', N'Phạm Thị Mai', '0913.555.666', 5800000, N'Tuyến Đà Lạt - Tây Nguyên, văn hóa bản địa'),
('HDV04', N'Hoàng Kim Trọng', '0988.777.888', 7000000, N'Tuyến Tây Bắc, tiếng Trung');

-- 5.9 Khách hàng
INSERT INTO KhachHang(MaKhachHang, HoTen, SoDienThoai, DiaChi, LoaiKhach) VALUES
('KH01', N'Công ty CP Công Nghệ Tân Tiến', '0908.123.456', N'15 Lê Duẩn, Bến Nghé, Quận 1, TP.HCM', 'DOAN'),
('KH02', N'Phạm Quốc Tuấn', '0913.999.888', N'45 Hai Bà Trưng, Quận 1, TP.HCM', 'LE'),
('KH03', N'Nguyễn Minh Hòa', '0909.112.233', N'78 Nơ Trang Long, Bình Thạnh, TP.HCM', 'LE');

-- 5.10 Khách đoàn (Chi tiết CRM)
INSERT INTO KhachDoan(MaKhachHang, TenCoQuan, DiaChiCoQuan, DienThoaiCoQuan, NguoiDaiDien, ChucVu) VALUES
('KH01', N'Công ty CP Công Nghệ Tân Tiến', N'15 Lê Duẩn, Bến Nghé, Quận 1, TP.HCM', '028.38229988', N'Trần Minh Quang', N'Chủ tịch Công đoàn');

-- 5.11 Chuyến du lịch định kỳ (Gom khách lẻ)
INSERT INTO ChuyenDuLich(MaChuyen, MaTour, NgayDi, NgayVe, SoChoToiDa, SoChoDaDat, TrangThai) VALUES
('CH01', 'T001', '2026-10-15', '2026-10-17', 45, 3, N'Còn chỗ'),
('CH02', 'T002', '2026-10-20', '2026-10-22', 45, 0, N'Còn chỗ');

-- Chuyến đi đón tại 3 điểm đón cố định
INSERT INTO Chuyen_DiemDon(MaChuyen, MaDiemDon) VALUES
('CH01', 'DD01'),
('CH01', 'DD02'),
('CH01', 'DD03');

-- 5.12 Bán vé cho khách lẻ (< 12 khách, đón tại điểm cố định, trả 100% tiền - BR01, BR05)
INSERT INTO VeDuLich(SoVe, MaChuyen, MaKhachHang, MaDiemBanVe, MaDiemDon, NgayXuatVe, GiaVe, DaThanhToan) VALUES
('VE01', 'CH01', 'KH02', 'BV01', 'DD02', '2026-10-10 09:30:00', 3500000, 1),
('VE02', 'CH01', 'KH02', 'BV01', 'DD02', '2026-10-10 09:30:00', 3500000, 1),
('VE03', 'CH01', 'KH02', 'BV01', 'DD02', '2026-10-10 09:30:00', 3500000, 1);

-- Cập nhật số chỗ đã đặt cho chuyến lẻ
UPDATE ChuyenDuLich SET SoChoDaDat = 3 WHERE MaChuyen = 'CH01';

-- 5.13 Phiếu đăng ký tour theo đoàn (25 khách >= 12, đón tận nơi, cọc 30tr >= 30% - BR01, BR05)
-- Tổng kinh phí: 25 khách x 3.500.000đ = 87.500.000đ. Cọc: 30.000.000đ. Còn lại tự tính: 57.500.000đ
INSERT INTO PhieuDangKyDoan(SoPhieuDK, MaKhachHang, MaTour, NgayLap, NgayDiYeuCau, DiaDiemDon, SoNguoiDi, CoBaoHiem, TongKinhPhi, TienCoc, TrangThai) VALUES
('PDK01', 'KH01', 'T001', '2026-10-10 14:00:00', '2026-10-20', N'Trụ sở công ty Tân Tiến - 15 Lê Duẩn, Q.1', 25, 1, 87500000, 30000000, N'Đã đặt cọc');

-- 5.14 Danh sách thành viên đoàn cùng đi để mua bảo hiểm (BR04)
INSERT INTO ThanhVienDoan(MaThanhVien, SoPhieuDK, HoTen, NgaySinh, SoCCCD, GioiTinh, SoDienThoai) VALUES
('TV01', 'PDK01', N'Trần Minh Quang', '1980-05-15', '079080001234', N'Nam', '0908.123.456'),
('TV02', 'PDK01', N'Lê Thị Bích Hạnh', '1985-11-20', '079185005678', N'Nữ', '0918.555.777'),
('TV03', 'PDK01', N'Nguyễn Văn Dũng', '1992-03-12', '079092009988', N'Nam', '0933.222.111');

-- 5.15 Phân công Hướng dẫn viên (BR06: Đúng 1 HDV cho chuyến lẻ, lịch không chồng chéo)
-- Phân công HDV02 dẫn chuyến lẻ CH01 (15/10 - 17/10)
INSERT INTO PhanCongHDV(MaPhanCong, MaHDV, MaChuyen, SoPhieuDK, NgayPhanCong, NgayBatDau, NgayKetThuc, LuongTour, VaiTro) VALUES
('PC01', 'HDV02', 'CH01', NULL, '2026-10-10', '2026-10-15', '2026-10-17', 1500000, N'Hướng dẫn viên chính');

-- Phân công HDV01 dẫn đoàn khách PDK01 (20/10 - 23/10) -> Không hề trùng lịch với tour trước!
INSERT INTO PhanCongHDV(MaPhanCong, MaHDV, MaChuyen, SoPhieuDK, NgayPhanCong, NgayBatDau, NgayKetThuc, LuongTour, VaiTro) VALUES
('PC02', 'HDV01', NULL, 'PDK01', '2026-10-10', '2026-10-20', '2026-10-23', 2500000, N'Trưởng đoàn hướng dẫn');

-- 5.16 Phiếu khảo sát chất lượng sau chuyến đi (Đánh giá dịch vụ)
INSERT INTO PhieuKhaoSat(SoPhieuKhaoSat, MaTour, MaKhachHang, MaChuyen, SoPhieuDK, NgayKhaoSat, DiemDichVu, DiemHDV, DiemAnO, YKienGopY) VALUES
('KS01', 'T001', 'KH01', NULL, 'PDK01', '2026-10-24', 5, 5, 4, N'Chuyến đi rất chu đáo, HDV nhiệt tình thuyết minh hay. Khách sạn 4 sao sạch đẹp gần biển.');
GO
