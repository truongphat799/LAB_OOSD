# BÁO CÁO THỰC HÀNH LAB 6

## MÔN HỌC: PHƯƠNG PHÁP PHÁT TRIỂN HƯỚNG ĐỐI TƯỢNG (OOP DEVELOPMENT METHODS)

### ĐỀ TÀI: BÀI 5 - HỆ THỐNG QUẢN LÝ HỒ SƠ BỆNH ÁN BỆNH VIỆN ĐA KHOA QUỐC TẾ

---

## 1. THÔNG TIN SINH VIÊN THỰC HIỆN

- **Họ và Tên:** Trương Gia Phát
- **Mã số sinh viên (MSSV):** 1250080139
- **Email sinh viên:** 1250080139@sv.hcmunre.edu.vn
- **Lớp / Khóa:** Đại học Chính quy - Ngành Công nghệ Thông tin
- **Trường:** Đại học Tài nguyên và Môi trường TP.HCM (HCMUNRE)
- **Tên bài thực hành:** LAB 6 - Bài 5: Phân tích, Thiết kế CSDL & Lập trình Hệ thống Quản lý Hồ sơ Bệnh án Điện tử

---

## 2. MÔI TRƯỜNG & PHIÊN BẢN CÔNG NGHỆ SỬ DỤNG

- **Hệ điều hành:** Microsoft Windows 11 (64-bit)
- **Ngôn ngữ lập trình:** C# (.NET Framework 4.7.2 / C# 8.0)
- **Môi trường phát triển (IDE):** Microsoft Visual Studio 2022 (Community / Professional)
- **Hệ quản trị Cơ sở dữ liệu (DBMS):** Microsoft SQL Server 2019 / 2022
- **Công cụ quản trị CSDL:** SQL Server Management Studio (SSMS v19 / v20)
- **Công cụ thiết kế & mô hình hóa UML/ERD:** Draw.io (Diagrams.net Desktop v24+), PlantUML
- **Công cụ bảng tính & xuất báo cáo:** Microsoft Excel (Office 16 / Office 365), Python 3.13 (`openpyxl 3.1.5`, `pymupdf 1.28.2`)

---

## 3. NỘI DUNG ĐÃ THỰC HIỆN

Dự án đã giải quyết trọn vẹn và chuyên sâu toàn bộ các yêu cầu từ nghiệp vụ thực tế đến mô hình hóa, thiết kế CSDL và lập trình giao diện:

### 3.1. Phân tích nghiệp vụ 5 khối chức năng trọng tâm

1. **Đăng ký bệnh nhân & Thu lệ phí năm:** Bệnh nhân đến khám lần đầu bắt buộc chụp ảnh 3x4 tự động (lưu đường dẫn file ảnh), nộp lệ phí năm cố định 1.200.000 VNĐ. Hệ thống tự động cấp Mã Hồ sơ Bệnh án (HSBA) duy nhất và Thẻ năm (`THE2026-xxxx`). Ràng buộc mỗi bệnh nhân chỉ đóng phí năm 1 lần/năm.
2. **Tra cứu lịch sử bệnh án & Cảnh báo an toàn dược:** Tra cứu đa tiêu chí (Mã BN, SĐT, Họ tên, Mã HSBA). Hiển thị đầy đủ tiền sử bệnh nền và hộp cảnh báo nổi bật màu đỏ khi bệnh nhân có tiền sử dị ứng thuốc.
3. **Lịch khám định kỳ theo Quý & SMS Brandname:** Bệnh nhân có thẻ năm được phân bổ lịch hẹn khám định kỳ 4 quý (Quý 1, Quý 2, Quý 3, Quý 4). Ràng buộc duy nhất 1 lịch hẹn/quý/năm. Tự động kích hoạt thông báo SMS Brandname nhắc hẹn.
4. **Liên kết Cận lâm sàng & Lập toa thuốc (Transaction 2):** Phiếu khám đóng vai trò Master. Bác sĩ chỉ định các xét nghiệm (ECG, Sinh hóa, Huyết học) và lập toa thuốc. Hệ thống tự động kiểm tra đối chiếu hoạt chất thuốc với tiền sử dị ứng; khi xác nhận kê toa, hệ thống thực thi Transaction trừ tự động tồn kho dược, chống âm kho.
5. **Quyết toán viện phí & Hoàn tất khóa hồ sơ (Transaction 3):** Tính tổng viện phí (Khám + Xét nghiệm + Toa thuốc); tự động khấu trừ quyền lợi gói lệ phí năm (miễn phí tiền khám, giảm giá XN). CSKH/Điều dưỡng ghi nhận 3 trường bắt buộc: _Diễn biến sức khỏe_, _Phản ứng phụ của thuốc_, _Đánh giá hiệu quả điều trị_. Sau thanh toán, đợt khám chuyển sang trạng thái `"Đã khóa"`, cấm mọi hành vi sửa đổi.

### 3.2. Thiết kế mô hình hóa UML & Bảng phân công giao diện

Đã xây dựng bộ sơ đồ chuẩn Draw.io (file `.drawio` và ảnh chất lượng cao 300 DPI `.png` trong thư mục `Sơ đồ/`):

- **UseCase_Diagram_TongQuat.drawio (.png):** Sơ đồ Use Case tổng quan phân quyền Actor.
- **UseCase_Diagram_PhanRa_QuyTrinhKhamBenh.drawio (.png):** Phân rã chi tiết từ tiếp nhận đến xuất viện.
- **Activity_Diagram_QuyTrinhKhamBenh.drawio (.png):** Sơ đồ hoạt động luồng quy trình nghiệp vụ khám chữa bệnh.
- **Sequence_Diagram_LapToaThuoc.drawio (.png):** Sơ đồ tuần tự nghiệp vụ Lập toa thuốc, đối chiếu dị ứng và trừ tồn kho.
- **Class_Diagram_QuanLyHoSoBenhAn.drawio (.png):** Sơ đồ lớp chi tiết với đầy đủ thuộc tính, phương thức, ID và Multiplicity.
- **ERD_QuanLyHoSoBenhAn.drawio (.png):** Sơ đồ quan hệ thực thể theo chuẩn CSDL quan hệ SQL Server.
- **SoDoPhanRaChucNangGiaoDien.drawio (.png):** Sơ đồ phân rã chức năng giao diện chuẩn 6 Forms khớp 100% với codebase C#.

### 3.3. Thiết kế CSDL SQL Server chuyên nghiệp (`QuanLyHoSoBenhAn.sql`)

- Xóa bảng an toàn theo thứ tự phụ thuộc khóa ngoại.
- 12 bảng chuẩn hóa 3NF: `Khoa`, `NguoiDung`, `BenhNhan`, `HoSoBenhAn`, `LePhiNam`, `PhieuKham`, `DichVuXetNghiem`, `KetQuaXetNghiem`, `Thuoc`, `ToaThuoc`, `ChiTietToaThuoc`, `HoaDonVienPhi`, `HoanTatDieuTri`, `LichHenDinhKy`.
- Đầy đủ ràng buộc: Khóa chính (PK), Khóa ngoại (FK), `UNIQUE`, `CHECK` (kiểm tra giới tính, sinh hiệu, trạng thái, giá tiền $\ge 0$, tồn kho $\ge 0$).
- Cột tính toán tự động lưu trữ (`PERSISTED computed column`): `ThanhTien = SoLuong * DonGia`, `TongThanhToan`.
- Tối ưu chỉ mục (Index) trên các cột thường xuyên tìm kiếm và lọc thời gian.
- Seed data mẫu phong phú, thực tế phản ánh đúng bệnh viện quốc tế.
- 3 Stored Procedures / Transactions đa bảng: Tiếp nhận cấp thẻ, Kê toa trừ kho, Quyết toán viện phí khóa hồ sơ.

### 3.4. Lập trình ứng dụng Windows Forms C# hoàn chỉnh (`QuanLyHoSoBenhAn`)

Xây dựng theo mô hình phân lớp rõ ràng (Forms, Services, DAL, Model), gồm 6 màn hình:

1. `FrmMain`: Trang chủ điều hướng trung tâm, phân quyền nhân viên y tế.
2. `FrmTiepNhan`: Tiếp nhận BN, chụp ảnh 3x4, thu phí năm 1.2tr, cấp mã HSBA & thẻ năm.
3. `FrmKhamBenh`: Khám lâm sàng, sinh hiệu, cảnh báo dị ứng, chỉ định CLS, lập toa thuốc & trừ kho dược.
4. `FrmXuatVienCSKH`: Quyết toán viện phí khấu trừ thẻ năm, CSKH đánh giá, đặt hẹn quý & gửi SMS, khóa hồ sơ.
5. `FrmDanhMuc`: Quản lý danh mục Khoa, Nhân sự/Bác sĩ, Bảng giá xét nghiệm, Danh mục thuốc & tồn kho.
6. `FrmThongKe`: Thống kê tổng hợp doanh thu viện phí, lượt khám, top thuốc sử dụng, cơ cấu ca bệnh theo khoa.

### 3.5. Thiết kế 6 Forms trực quan trên Excel (`QuanLyHoSoBenhAn.xlsx`)

- Tái hiện 1-1 layout, màu sắc, GroupBox, ô nhập liệu và bảng dữ liệu DataGridView của Windows Forms lên 6 Sheet Excel chuyên nghiệp.
- Xuất file PDF chuẩn khổ ngang A4 Fit 1 trang/form: `QuanLyHoSoBenhAn_GiaoDienForms_Fit.pdf`.

### 3.6. Xây dựng Kịch bản Kiểm thử Hệ thống (Test Cases)

- Thiết lập Ma trận kiểm thử nghiệp vụ (BR Matrix).
- 14 Kịch bản kiểm thử chi tiết bao phủ toàn bộ các trường hợp: Positive, Negative (chặn đóng trùng phí, chặn đặt trùng lịch quý, chặn kê thuốc dị ứng, chặn xuất kho âm), Boundary và Security (chặn sửa đổi khi đã khóa hồ sơ).
- Kịch bản T-SQL tự động hóa kiểm thử tính nguyên tố của Transaction.

---

## 4. KẾT QUẢ ĐẠT ĐƯỢC

- ✅ **Phần mềm biên dịch và thực thi hoàn hảo:** File chạy `QuanLyHoSoBenhAn.exe` trong thư mục `bin\Debug\` chạy ổn định, không phát sinh bất kỳ lỗi cú pháp hay cảnh báo nào (0 Errors, 0 Warnings).
- ✅ **Cơ sở dữ liệu toàn vẹn:** Script SQL Server chạy mượt mà, khởi tạo đầy đủ cấu trúc bảng, ràng buộc và dữ liệu mẫu.
- ✅ **Độ đồng bộ 100%:** Mã nguồn C#, sơ đồ Draw.io, file thiết kế Excel và bộ Test Cases hoàn toàn thống nhất về kiến trúc 6 Forms và luồng dữ liệu.
- ✅ **Tài liệu đầy đủ:** Sơ đồ trực quan, file Word báo cáo và bảng ma trận kiểm thử sẵn sàng để đánh giá.

---

## 5. CÁC LỖI GẶP PHẢI TRONG QUÁ TRÌNH PHÁT TRIỂN

Trong quá trình phân tích, thiết kế và cài đặt, nhóm đã ghi nhận các vấn đề kỹ thuật sau:

1. **Lỗi 1 (Lệ phí năm bị đóng trùng):** Bệnh nhân đã đóng phí năm cho năm 2026 nhưng nhân viên tiếp nhận có thể bấm thu thêm một lần nữa dẫn đến dư thừa bản ghi lệ phí.
2. **Lỗi 2 (Nguy cơ dị ứng thuốc khi kê đơn):** Bác sĩ có thể vô tình kê đơn loại thuốc có hoạt chất mà bệnh nhân bị dị ứng (ví dụ: bệnh nhân dị ứng nhóm Penicillin nhưng toa thuốc lại chọn Amoxicillin).
3. **Lỗi 3 (Lệch số liệu tồn kho dược khi có lỗi giữa chừng):** Khi kê toa nhiều loại thuốc, nếu một loại thuốc bị thiếu hàng hoặc lỗi mạng xảy ra sau khi đã trừ các thuốc trước đó, kho dược sẽ bị lệch số liệu (chưa áp dụng Transaction nguyên tố).
4. **Lỗi 4 (Không đồng nhất số lượng Forms):** Ban đầu sơ đồ phân rã chức năng giao diện có 8 Forms (do vẽ mô phỏng theo mẫu tour du lịch cũ), trong khi kiến trúc mã nguồn C# thực tế chỉ có 6 Forms.
5. **Lỗi 5 (Lỗi mã hóa tiếng Việt UTF-8 khi chạy script Python sinh file Excel):** Khi in thông báo ra console Windows CMD/PowerShell mặc định (code page 1252), phát sinh lỗi `UnicodeEncodeError: 'charmap' codec can't encode characters`.

---

## 6. NGUYÊN NHÂN & CÁCH KHẮC PHỤC

| Lỗi gặp phải                   | Nguyên nhân kỹ thuật                                                                                         | Giải pháp khắc phục triệt để                                                                                                                                                                                                                                       |
| :----------------------------- | :----------------------------------------------------------------------------------------------------------- | :----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------- |
| **Lỗi 1: Đóng trùng phí năm**  | Thiếu ràng buộc nghiệp vụ duy nhất trên cặp dữ liệu `(MaBN, NamApDung)`.                                     | Bổ sung ràng buộc `CONSTRAINT UQ_LePhiNam_BN_Nam UNIQUE (MaBN, NamApDung)` trong CSDL và viết hàm kiểm tra tồn tại ở tầng nghiệp vụ C# trước khi cho phép bấm nút nộp phí.                                                                                         |
| **Lỗi 2: Kê thuốc dị ứng**     | Việc chọn thuốc và tiền sử dị ứng trong HSBA được xử lý độc lập, thiếu khâu đối soát chéo.                   | Xây dựng thuật toán kiểm tra chéo (Cross-check) chuỗi `TienSuDiUng` trong HSBA với trường `HoatChat` và `ChongChiDinh` của bảng `Thuoc`. Khi phát hiện trùng lặp, hệ thống lập tức bật MessageBox cảnh báo đỏ mức độ nguy hiểm cao và chặn không cho thêm vào toa. |
| **Lỗi 3: Lệch tồn kho dược**   | Thao tác `INSERT ChiTietToaThuoc` và `UPDATE Thuoc` diễn ra đơn lẻ, không được bọc trong một giao dịch ACID. | Đóng gói toàn bộ thao tác kê đơn và cập nhật kho vào `SqlTransaction` cấp độ cách ly `IsolationLevel.Serializable`. Nếu bất kỳ thuốc nào không đủ số lượng tồn kho (`SoLuongTon < 0`), hệ thống tự động kích hoạt `transaction.Rollback()` và báo lỗi.             |
| **Lỗi 4: Lệch số lượng Forms** | Sao chép layout từ sơ đồ mẫu bài tập khác chưa tinh chỉnh cho đúng bài toán bệnh viện.                       | Tái thiết kế toàn bộ sơ đồ Draw.io (`SoDoPhanRaChucNangGiaoDien.drawio`), xuất lại ảnh PNG 300 DPI, cập nhật mã PlantUML và thiết kế lại Excel chuẩn xác 6 Forms: `FrmMain`, `FrmTiepNhan`, `FrmKhamBenh`, `FrmXuatVienCSKH`, `FrmDanhMuc`, `FrmThongKe`.          |
| **Lỗi 5: UnicodeEncodeError**  | Bảng mã console Windows không hỗ trợ trực tiếp ký tự tiếng Việt Unicode trong hàm `print()`.                 | Thiết lập cấu hình đầu ra `sys.stdout = io.TextIOWrapper(sys.stdout.buffer, encoding='utf-8')` ở đầu script Python giúp chạy mượt mà trên mọi môi trường Windows.                                                                                                  |

---

## 7. HƯỚNG DẪN GIẢNG VIÊN KIỂM TRA VÀ CHẠY LẠI DỰ ÁN

Để Giảng viên có thể kiểm tra, nghiệm thu và chạy lại toàn bộ đồ án một cách thuận tiện nhất, vui lòng thực hiện theo các bước sau:

### Bước 1: Khởi tạo Cơ sở dữ liệu SQL Server

1. Mở phần mềm **SQL Server Management Studio (SSMS)** và kết nối vào SQL Server instance của máy (ví dụ: `.` hoặc `localhost` hoặc `(localdb)\MSSQLLocalDB`).
2. Mở file script SQL tại đường dẫn:
   ```text
   LAB6/QuanLyHoSoBenhAn/QuanLyHoSoBenhAn.sql
   ```
3. Nhấn **Execute (F5)** để thực thi. Script sẽ tự động:
   - Tạo mới CSDL `eShoppingDB` (nếu chưa có).
   - Xóa sạch bảng cũ theo đúng thứ tự phụ thuộc khóa ngoại.
   - Tạo toàn bộ 14 bảng, ràng buộc PK, FK, UNIQUE, CHECK, INDEX.
   - Nạp dữ liệu mẫu thực tế và thiết lập sẵn 3 Transaction nghiệp vụ.

### Bước 2: Cấu hình chuỗi kết nối CSDL (Connection String)

Nếu SQL Server trên máy Giảng viên sử dụng tên Server khác, vui lòng kiểm tra file:

```text
LAB6/QuanLyHoSoBenhAn/QuanLyHoSoBenhAn/App.config
```

Chuỗi kết nối mặc định:

```xml
<connectionStrings>
    <add name="BenhVienDB"
         connectionString="Data Source=.;Initial Catalog=eShoppingDB;Integrated Security=True;TrustServerCertificate=True"
         providerName="System.Data.SqlClient" />
</connectionStrings>
```

_(Chỉ cần đổi `Data Source=.` thành tên Server tương ứng nếu cần)._

### Bước 3: Mở và chạy chương trình C# Windows Forms

Giảng viên có thể chạy chương trình theo 1 trong 2 cách sau:

- **Cách 1 - Chạy trực tiếp file thực thi (Không cần mở Visual Studio):**
  - Vào thư mục: `LAB6/QuanLyHoSoBenhAn/QuanLyHoSoBenhAn/bin/Debug/`
  - Nhấp đúp chuột vào file: `QuanLyHoSoBenhAn.exe` để mở ứng dụng ngay lập tức.

- **Cách 2 - Mở bằng Visual Studio 2022 để xem mã nguồn:**
  - Nhấp đúp vào file solution: `LAB6/QuanLyHoSoBenhAn/QuanLyHoSoBenhAn.sln`.
  - Nhấn **Ctrl + Shift + B** để Build toàn bộ Solution (Kết quả: 0 Errors, 0 Warnings).
  - Nhấn **F5** (hoặc nút **Start**) để khởi chạy chương trình.

### Bước 4: Kiểm tra nhanh luồng nghiệp vụ trên phần mềm

1. **Tại `FrmMain`:** Nhấp vào nút _"Tiếp Nhận Bệnh Nhân, Thu Lệ Phí Năm & Cấp HSBA"_.
2. **Tại `FrmTiepNhan`:**
   - Kiểm tra bệnh nhân `BN0001` (đã nộp 1.2tr/2026).
   - Thử bấm thu phí năm 2026 một lần nữa để quan sát hệ thống chặn vi phạm UNIQUE.
   - Thử tìm kiếm nhanh bệnh nhân bằng số điện thoại `0918765432`.
3. **Tại `FrmKhamBenh`:**
   - Chọn hồ sơ `HSBA0001 - Nguyễn Văn An`. Quan sát **Hộp cảnh báo màu đỏ** hiển thị dị ứng Penicillin.
   - Thử chọn thuốc `Amoxicillin` và bấm thêm thuốc để kiểm tra tính năng **chặn kê đơn thuốc dị ứng**.
   - Kê thuốc `Amlodipine` (30 viên) và bấm _"Xác nhận kê toa & trừ tồn kho"_ để kiểm tra Transaction trừ kho dược.
4. **Tại `FrmXuatVienCSKH`:**
   - Chọn phiếu khám `PK0001`. Quan sát bảng viện phí tự động khấu trừ quyền lợi thẻ năm (miễn phí khám).
   - Nhập diễn biến, phản ứng và đánh giá CSKH $\rightarrow$ Bấm _"Thanh toán & Khóa hồ sơ"_.
   - Đặt lịch hẹn Quý 2/2026 và quan sát trạng thái gửi tin nhắn SMS Brandname.
5. **Tại `FrmThongKe`:**
   - Chọn khoảng ngày và bấm _"Xem Báo Cáo"_ để xem tổng hợp doanh thu viện phí và biểu đồ tỷ lệ bệnh nhân theo khoa.

### Bước 5: Kiểm tra tài liệu sơ đồ và thiết kế Excel

- **Sơ đồ Draw.io & Ảnh trực quan:** Mở thư mục `LAB6/Sơ đồ/` để xem toàn bộ sơ đồ Use Case, Activity, Sequence, Class, ERD và Phân rã giao diện.
- **Thiết kế giao diện trên Excel:** Mở file `LAB6/QuanLyHoSoBenhAn.xlsx` bằng Microsoft Excel để xem mô phỏng 6 Forms chuẩn thiết kế.

---
