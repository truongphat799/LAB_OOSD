# BÁO CÁO BÀI TẬP LAB 5: PHƯƠNG PHÁP PHÁT TRIỂN HƯỚNG ĐỐI TƯỢNG (OOD / OOAD)

---

## 📌 THÔNG TIN SINH VIÊN & BÀI LAB

* **Họ và tên:** Trương Gia Phát
* **Mã số sinh viên (MSSV):** 1250080139
* **Môn học:** Phương pháp phát triển hướng đối tượng
* **Tên bài Lab:** **Lab 5 – Bài 6: Quản lý công ty du lịch Văn Hóa Việt TP.HCM**
* **Đơn vị đào tạo:** Khoa Công nghệ Thông tin

---

## 💻 MÔI TRƯỜNG & PHIÊN BẢN CÔNG CỤ (ENVIRONMENT & VERSIONS)

| Thành phần | Công cụ / Nền tảng | Phiên bản (Version) | Ghi chú |
| :--- | :--- | :--- | :--- |
| **Hệ điều hành** | Microsoft Windows | Windows 10 / 11 (64-bit) | Môi trường phát triển & kiểm thử |
| **Môi trường phát triển (IDE)** | Microsoft Visual Studio Community | 2022 (v17.13+) | Biên dịch C# WinForms |
| **Trình biên dịch** | Microsoft MSBuild | MSBuild 17.13 / Roslyn 4.7 | Build tự động thành công (0 Lỗi, 0 Warning) |
| **Ngôn ngữ & Nền tảng** | C# / .NET Framework | C# 7.3 & .NET Framework 4.7.2 | Windows Forms Application (Mô hình 3 lớp) |
| **Hệ quản trị CSDL (DBMS)** | Microsoft SQL Server | SQL Server 2019 / 2022 / Express | Chạy script T-SQL `QuanLyDuLich.sql` |
| **Công cụ vẽ biểu đồ UML/ERD** | Draw.io / diagrams.net & PlantUML | v21.0+ | Định dạng XML `.drawio` mở trực tiếp trên app |
| **Bảng tính & Thiết kế Form** | Microsoft Excel / Python openpyxl | Excel 2019/365 & Python 3.13.9 | Sinh tự động 8 Sheet Form giao diện chuẩn |

---

## 📋 NỘI DUNG ĐÃ THỰC HIỆN

### 1. Phân tích Yêu cầu & Thiết kế Hệ thống
* **Phân tích nghiệp vụ toàn diện:** Xác định phạm vi hệ thống, mô hình IPO (Input - Process - Output), lập danh sách Actors, hệ thống 9 Quy tắc nghiệp vụ (**BR01 – BR09**), 7 Từ điển dữ liệu (**DD01 – DD07**), Yêu cầu chức năng (**FR01 – FR06**) và Yêu cầu phi chức năng (**NFR01 – NFR05**).
* **Mô hình hóa Hướng đối tượng (UML Diagrams):**
  1. **Biểu đồ Lớp (Class Diagram):** 16 Lớp đối tượng chi tiết (`TourDuLich`, `NoiDungChan`, `PhuongTien`, `DiemThamQuan`, `ChuyenDuLich`, `DiemDon`, `DiemBanVe`, `KhachHang`, `KhachDoan`, `PhieuDangKyDoan`, `ThanhVienDoan`, `VeDuLich`, `HuongDanVien`, `PhanCongHDV`, `PhieuKhaoSat`...) kèm đầy đủ thuộc tính, kiểu dữ liệu, quan hệ và phương thức.
  2. **Biểu đồ Use Case Tổng quát & Phân rã:** Bao quát toàn bộ quy trình từ giới thiệu tour, tiếp nhận khách đoàn, mở chuyến định kỳ, bán vé lẻ, phân công HDV, quyết toán tài chính đến khảo sát chất lượng.
  3. **Biểu đồ Hoạt động (Activity Diagrams):** Quy trình tour tổng thể, luồng bán vé khách lẻ và luồng khảo sát CSKH sau tour.
  4. **Biểu đồ Tuần tự (BCE Sequence Diagrams):** Lập phiếu đăng ký đoàn $\ge 12$ người, Bán vé khách lẻ $< 12$ người, Phân công HDV chống trùng lịch.

### 2. Thiết kế & Cài đặt Cơ sở Dữ liệu (Database Design & SQL)
* **Sơ đồ ERD Vật lý (Physical ERD):** 17 bảng dữ liệu chuẩn hóa, quan hệ 1-N, N-N, chuẩn hóa khóa chính (PK), khóa ngoại (FK).
* **Kịch bản T-SQL hoàn chỉnh (`QuanLyDuLich.sql`):**
  * Tự động tạo cơ sở dữ liệu `QuanLyDuLich`.
  * Xóa bảng cũ theo đúng thứ tự phụ thuộc khóa ngoại ngược (Reverse Dependency Order).
  * Tạo 17 bảng với ràng buộc toàn vẹn dữ liệu chặt chẽ (`CHECK(SoNguoiDi >= 12)`, `CHECK(DaThanhToan = 1)`, `CHECK(NoiKhoiHanh = N'TP.HCM')`).
  * Cột tính toán tự động `TienConLai AS (TongKinhPhi - TienCoc) PERSISTED`.
  * Đánh chỉ mục (Indexes) tối ưu hóa tìm kiếm và chống trùng chéo lịch HDV.
  * Nạp dữ liệu mẫu (Seed Data) chuẩn xác, bám sát các địa danh du lịch và dữ liệu kinh doanh thực tế.

### 3. Thiết kế Giao diện Người dùng (UI Forms Mockup trên Excel)
* Tạo tập tin Excel **`Thiet_Ke_Form_QuanLyDuLich_DonGian.xlsx`** gồm 8 Sheet tương ứng với 8 Form chức năng:
  * `FrmMain`: Menu trung tâm điều hướng với phím tắt F1 – F7.
  * `FrmDanhMucTour`: Quản lý danh mục Tour, lộ trình, điểm dừng chân, điểm tham quan.
  * `FrmChuyenDuLich`: Mở chuyến định kỳ cho khách lẻ (xe 45 chỗ), điểm đón cố định.
  * `FrmDangKyDoan`: Phiếu đoàn $\ge 12$ người, đón tận nơi, cọc $30\%$, bảo hiểm du lịch.
  * `FrmBanVeKhachLe`: Bán vé lẻ $< 12$ người, thu 100% tiền vé tại chỗ, in vé du lịch.
  * `FrmPhanCongHDV`: Phân công HDV, kiểm tra và ngăn chặn trùng lịch thời gian thực.
  * `FrmQuyetToan`: Quyết toán đoàn sau tour & Bảng tính lương tháng của HDV.
  * `FrmKhaoSatThongKe`: Khảo sát ý kiến khách hàng (1-5 sao) & Báo cáo tỷ lệ hài lòng.
* Thiết kế tối giản, sạch đẹp theo **cấu trúc 4 phần kinh điển**: Banner Tiêu đề $\rightarrow$ Khối Nhập liệu (Input) $\rightarrow$ Dãy Nút Tác vụ (Buttons) $\rightarrow$ Lưới Dữ liệu (DataGridView).

### 4. Hiện thực hóa Phần mềm (C# Windows Forms Application)
* Xây dựng mã nguồn C# WinForms theo **kiến trúc 3 lớp (3-tier)** tại thư mục `LAB5/QuanLyDuLich`:
  * **Tầng Data:** `Db.cs` (ADO.NET Helper thực thi Query, Execute, Scalar bằng `SqlParameter`).
  * **Tầng Model:** `KetQuaXuLy.cs` (Result Pattern trả về trạng thái Thành công / Lỗi).
  * **Tầng Services:** 7 lớp Service xử lý nghiệp vụ (`TourService`, `ChuyenService`, `DangKyDoanService`, `BanVeKhachLeService`, `PhanCongHDVService`, `QuyetToanService`, `ThongKeService`).
  * **Tầng Forms:** 8 màn hình Windows Forms hoàn chỉnh (`.cs` + `.Designer.cs`).
* Đã cấu hình Solution `QuanLyDuLich.sln` và biên dịch ra tập tin thực thi `QuanLyDuLich.exe`.

### 5. Kiểm thử Hệ thống & Ma trận Truy vết Yêu cầu (Testing & RTM)
* Xây dựng **Ma trận truy vết yêu cầu (RTM)** nối kết xuyên suốt: $\text{Yêu cầu (BR)} \rightarrow \text{UML} \rightarrow \text{Form/Service} \rightarrow \text{Bảng CSDL} \rightarrow \text{Test Case}$.
* Thiết kế đầy đủ 4 nhóm kiểm thử: **Chức năng (Functional)**, **Tải & Hiệu năng (Load/Performance - chống Overbooking)**, **Bảo mật (Security - chống SQLi, RBAC)**, **Đơn vị (Unit Test C# MSTest)**.
* Kiểm thử thành công 5 kịch bản toàn trình End-to-End với bộ dữ liệu cụ thể (SC01 – SC05).

---

## 🏆 KẾT QUẢ ĐẠT ĐƯỢC (DELIVERABLES)

| STT | Tập tin / Thư mục | Định dạng | Mô tả nội dung |
| :---: | :--- | :---: | :--- |
| **1** | `LAB5/1250080139_TruongGiaPhat_Bai6.docx` | Word | Báo cáo thuyết minh bài tập lớn Lab 5 đầy đủ lý thuyết và sơ đồ |
| **2** | `LAB5/QuanLyDuLich.sql` | SQL Script | Kịch bản tạo CSDL `QuanLyDuLich` (17 bảng, Constraints, Seed Data) |
| **3** | `LAB5/Thiet_Ke_Form_QuanLyDuLich_DonGian.xlsx` | Excel | Thiết kế giao diện 8 Form tối giản chuẩn mực môn học |
| **4** | `LAB5/Class_Diagram_QuanLyCongTyDuLich.drawio` | Draw.io XML | Sơ đồ Lớp (Class Diagram) 16 Class |
| **5** | `LAB5/UseCase_Diagram_TongQuat.drawio` | Draw.io XML | Sơ đồ Use Case tổng quát hệ thống |
| **6** | `LAB5/UseCase_Diagram_PhanRa_QuyTrinhTour.drawio` | Draw.io XML | Sơ đồ Use Case phân rã chi tiết |
| **7** | `LAB5/Activity_Diagram_QuyTrinhTour.drawio` | Draw.io XML | Sơ đồ Hoạt động quy trình tour |
| **8** | `LAB5/Sequence_Diagram_LapPhieuDangKyDoan.drawio` | Draw.io XML | Sơ đồ Tuần tự (BCE) Lập phiếu đăng ký đoàn |
| **9** | `LAB5/Sequence_Diagram_BanVeKhachLe.drawio` | Draw.io XML | Sơ đồ Tuần tự Bán vé khách lẻ |
| **10** | `LAB5/Sequence_Diagram_PhanCongHDV.drawio` | Draw.io XML | Sơ đồ Tuần tự Phân công HDV |
| **11** | `LAB5/ERD_QuanLyCongTyDuLich_ChuanMau.drawio` | Draw.io XML | Sơ đồ ERD vật lý 17 bảng |
| **12** | `LAB5/QuanLyDuLich/QuanLyDuLich.sln` | Visual Studio | Solution mã nguồn C# Windows Forms |
| **13** | `LAB5/QuanLyDuLich/QuanLyDuLich/bin/Debug/QuanLyDuLich.exe` | Executable | **Ứng dụng Windows Forms đã biên dịch chạy trực tiếp** |

---

## ⚠️ CÁC LỖI GẶP PHẢI & CÁCH KHẮC PHỤC (ISSUES & SOLUTIONS)

### 1. Lỗi đường dẫn Project khi mở Solution (`MSB3202: The project file was not found`)
* **Nguyên nhân:** Khi sao chép thư mục khung từ bài Lab trước, tập tin `QuanLyDuLich.sln` vẫn trỏ tới đường dẫn project cũ (`QuanLyCuaHangEShopping\QuanLyCuaHangEShopping.csproj`).
* **Cách khắc phục:** Sửa trực tiếp nội dung `QuanLyDuLich.sln` để tham chiếu chính xác đến `QuanLyDuLich\QuanLyDuLich.csproj`; đồng thời đổi tên file project và namespace thành `QuanLyDuLich`.

### 2. Lỗi trùng chéo lịch Hướng dẫn viên (Nghiệp vụ BR06)
* **Nguyên nhân:** Thuật toán kiểm tra lịch ban đầu chỉ so sánh bằng ngày khởi hành hoặc ngày kết thúc, dẫn đến bỏ sót trường hợp tour mới bị lồng vào giữa khoảng thời gian của tour cũ (hoặc giao nhau một phần).
* **Cách khắc phục:** Nâng cấp thuật toán kiểm tra giao nhau giữa hai khoảng thời gian $[A, B]$ và $[C, D]$:
  $$\text{Điều kiện trùng lịch} \iff (\text{NgayBatDau} \le \text{DenNgay}) \land (\text{NgayKetThuc} \ge \text{TuNgay})$$
  Đồng thời thêm chỉ mục `CREATE INDEX IX_PhanCongHDV_LichBan ON PhanCongHDV(MaHDV, NgayBatDau, NgayKetThuc)` trên SQL Server để tối ưu tốc độ kiểm tra.

### 3. Lỗi khóa tệp tin Excel khi sinh tự động (`PermissionError: [Errno 13]`)
* **Nguyên nhân:** Hệ điều hành Windows áp dụng cơ chế khóa độc quyền (Exclusive Lock) khi người dùng đang mở xem tập tin `Thiet_Ke_Giao_Dien_Form_QuanLyDuLich.xlsx` trong Microsoft Excel, khiến script Python không thể ghi đè.
* **Cách khắc phục:** Thiết kế script tự động lưu ra tập tin độc lập `Thiet_Ke_Form_QuanLyDuLich_DonGian.xlsx` và thêm khối `try-except` an toàn.

### 4. Lỗi vi phạm khóa ngoại (FK Constraint Violation) khi thực thi kịch bản SQL
* **Nguyên nhân:** Thứ tự xóa bảng cũ (`DROP TABLE`) ban đầu xóa bảng cha trước bảng con, gây lỗi vì bảng con vẫn đang giữ khóa ngoại tham chiếu.
* **Cách khắc phục:** Sắp xếp lại danh sách xóa bảng theo thứ tự nghịch đảo (Reverse Dependency Order): Xóa các bảng giao dịch con trước (`PhieuKhaoSat`, `PhanCongHDV`, `ThanhVienDoan`, `VeDuLich`...) rồi mới xóa các bảng danh mục cha (`TourDuLich`, `KhachHang`, `HuongDanVien`...).

---

## 🚀 HƯỚNG DẪN GIẢNG VIÊN KIỂM TRA & CHẠY LẠI DỰ ÁN

Giảng viên có thể kiểm tra và chạy lại hệ thống theo các bước đơn giản sau:

### Cách 1: Chạy trực tiếp chương trình đã biên dịch sẵn (Nhanh nhất - Không cần mở Visual Studio)
1. Mở SQL Server Management Studio (SSMS).
2. Mở file [QuanLyDuLich.sql](file:///d:/Hoc/Phương%20pháp%20PT%20hướng%20đối%20tượng/LAB5/QuanLyDuLich.sql) và nhấn **Execute (F5)** để tạo CSDL và nạp dữ liệu mẫu.
3. Chạy trực tiếp file thực thi:
   👉 **[QuanLyDuLich.exe](file:///d:/Hoc/Phương%20pháp%20PT%20hướng%20đối%20tượng/LAB5/QuanLyDuLich/QuanLyDuLich/bin/Debug/QuanLyDuLich.exe)**
4. Màn hình Menu chính `FrmMain` sẽ xuất hiện, cho phép nhấp vào 7 nút chức năng hoặc dùng phím tắt **F1 đến F7** để kiểm tra từng form.

### Cách 2: Mở và chạy từ mã nguồn Visual Studio
1. Nhấp đúp mở tập tin Solution:
   👉 **[QuanLyDuLich.sln](file:///d:/Hoc/Phương%20pháp%20PT%20hướng%20đối%20tượng/LAB5/QuanLyDuLich/QuanLyDuLich.sln)**
2. Kiểm tra chuỗi kết nối trong file `App.config`:
   ```xml
   <connectionStrings>
       <add name="QuanLyDuLichDB"
            connectionString="Data Source=.;Initial Catalog=QuanLyDuLich;Integrated Security=True"
            providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```
   *(Nếu SQL Server của Thầy/Cô dùng tên Instance khác dấu chấm `.`, vui lòng đổi `Data Source` tương ứng).*
3. Nhấn **F5** (hoặc nút **Start**) để biên dịch và chạy ứng dụng.

### Cách 3: Kiểm tra thiết kế Form trên Excel & Sơ đồ UML
* Mở file Excel thiết kế Form:
  👉 **[Thiet_Ke_Form_QuanLyDuLich_DonGian.xlsx](file:///d:/Hoc/Phương%20pháp%20PT%20hướng%20đối%20tượng/LAB5/Thiet_Ke_Form_QuanLyDuLich_DonGian.xlsx)**
* Để xem sơ đồ UML/ERD, truy cập trang web [app.diagrams.net](https://app.diagrams.net/) (Draw.io), chọn **File $\rightarrow$ Open From $\rightarrow$ Device** và chọn các file `.drawio` trong thư mục `LAB5`.

---

*Báo cáo được hoàn thành vào ngày 10/10/2026 bởi sinh viên **Trương Gia Phát (MSSV: 1250080139)**.*
