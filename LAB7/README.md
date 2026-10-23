# BÀI THỰC HÀNH SỐ 7: HỆ THỐNG QUẢN LÝ NHÂN SỰ & TIỀN LƯƠNG
### CÔNG TY TNHH SƠN ĐÔNG Á (DONG A PAINT CO., LTD)

---

## 1. THÔNG TIN SINH VIÊN & BÀI THỰC HÀNH
* **Môn học:** Phương pháp phát triển phần mềm hướng đối tượng
* **Tên bài Lab:** LAB 7
* **Họ và tên:** Trương Gia Phát
* **Mã số sinh viên (MSSV):** 1250080139
* **Lớp:** 12_ĐH_CNPM2
* **Giảng viên hướng dẫn:** Thầy Phạm Trọng Huynh

---

## 2. MÔI TRƯỜNG & PHIÊN BẢN (ENVIRONMENT & VERSIONS)
* **Hệ điều hành**: Microsoft Windows 10 / Windows 11 (64-bit)
* **Môi trường phát triển (IDE)**: Microsoft Visual Studio 2022 (Version 17.13+) / Visual Studio 2019
* **Nền tảng thực thi**: .NET Framework 4.7.2
* **Ngôn ngữ lập trình**: C# (Tương thích chuẩn C# 5.0 / 7.3)
* **Công nghệ giao diện**: Windows Forms (WinForms) thiết kế phẳng (Flat Design) đồng bộ 100% theo bản mẫu Excel
* **Hệ quản trị Cơ sở dữ liệu (DBMS)**: Microsoft SQL Server 2019 / 2022 (hỗ trợ SQL Server Express & LocalDB)
* **Công cụ phân tích thiết kế mô hình UML**: StarUML 5.x / 6.x & Draw.io
* **Build Engine**: Microsoft (R) Build Engine version 4.8 / 17.0

---

## 3. NỘI DUNG ĐÃ THỰC HIỆN

### 3.1. Phân tích thiết kế hệ thống theo chuẩn UML
1. **Xác định các Lớp (Class Diagram)**: Xác định đầy đủ 23 Class thực thể và liên kết, chỉ định rõ mã ID, các thuộc tính, kiểu dữ liệu, phương thức xử lý và bản số quan hệ (Multiplicity: 1-1, 1-n, n-n).
2. **Biểu đồ Use Case (Use Case Diagram)**:
   - Xây dựng **Use Case Diagram tổng quát** bao quát toàn bộ 5 nhóm Actor: Nhân viên Nhân sự, Trưởng phân xưởng/bộ phận, Kế toán tiền lương, Ban Giám đốc, Quản trị hệ thống.
   - Xây dựng **Use Case Diagram phân rã chi tiết** quy trình luân chuyển nhân sự từ khi nhận thử việc đến khi ký HĐLĐ chính thức.
3. **Biểu đồ Hoạt động (Activity Diagram)**: Trình bày chi tiết luồng xử lý: Tuyển dụng $\rightarrow$ Giao phân xưởng thử việc $\rightarrow$ Đánh giá sau 2 tháng $\rightarrow$ Ký HĐLĐ $\rightarrow$ Ban hành QĐ Lương & QĐ Chức vụ.
4. **Biểu đồ Tuần tự (Sequence Diagram)**: Mô hình hóa tương tác giữa Actor, Giao diện WinForms, Service nghiệp vụ và Database cho nghiệp vụ *"Lập quyết định khen thưởng và sinh phiếu chi thưởng"*.

### 3.2. Thiết kế Cơ sở dữ liệu chuẩn hóa (SQL Server)
* Xây dựng script `QuanLyNhanSu.sql` với **23 bảng dữ liệu** chuẩn hóa dạng 3NF:
  - Danh mục tổ chức: `PhongBan`, `ChucVu`, `HeThongThamSo`.
  - Quản lý nhân sự & hồ sơ: `NhanVien`, `NguoiDung`, `VaiTro`, `DeXuatTuyenDung`, `QuyetDinhTuyenDung`, `DanhGiaThuViec`, `HopDongLaoDong`, `HoSoBaoHiem`, `QuyetDinhLuong`, `QuyetDinhChucVu`.
  - Phân công & Chấm công: `KeHoachLamViecTuan`, `ChiTietKeHoachCa`, `BangChamCong`, `ChiTietChamCong`, `PhieuPhuTroi`, `ChiTietPhuTroi`.
  - Khen thưởng & Kỷ luật: `QuyetDinhKhenThuong`, `PhieuChiThuong`, `QuyetDinhKyLuat`, `PhieuThuPhat`.
  - Tiền lương: `BangLuongThang`, `ChiTietBangLuong`.
* **Stored Procedure `sp_TinhLuongNhanVienThang`**: Tự động hóa 100% công thức tính toán:
  - Công chuẩn tháng: 26 ngày; Đơn giá giờ = $\frac{\text{Lương cơ bản}}{26 \times 8}$.
  - Phụ trội tăng ca x1.5 ngày thường, x2.0 cuối tuần, x3.0 lễ tết.
  - Phụ cấp độc hại hóa chất sơn (1.8 triệu) và phụ cấp chức vụ.
  - Trích nộp BHXH/BHYT đúng 10.5% đối với HĐLĐ dài hạn ($\ge 3$ tháng) và 0% đối với HĐLĐ ngắn hạn.
  - Tự động cộng thưởng từ phiếu chi và trừ tiền phạt từ quyết định kỷ luật.

### 3.3. Xây dựng phần mềm C# WinForms (Mô hình 3 lớp)
* **Tầng Data Access Layer (DAL)**: `Db.cs` quản lý kết nối `SqlConnection`, `SqlCommand`, `SqlTransaction` an toàn chống SQL Injection.
* **Tầng Business Logic Layer (BLL - 6 Services)**:
  - `NhanSuService.cs`: Nghiệp vụ tuyển dụng, đánh giá thử việc, ký HĐLĐ, ban hành QĐ lương & chức vụ.
  - `ChamCongService.cs`: Lập kế hoạch tuần, chốt chấm công tháng, ghi nhận giờ phụ trội.
  - `KhenThuongKyLuatService.cs`: Quyết định khen thưởng + chi thưởng, quyết định kỷ luật trừ phạt.
  - `TinhLuongService.cs`: Khởi tạo kỳ lương, thực thi Stored Procedure tính lương, khóa bảng lương.
  - `DanhMucService.cs`: Quản lý phòng ban, phân xưởng, chức vụ, nhân sự và tài khoản phân quyền.
  - `ThongKeService.cs`: Báo cáo nhân sự, biến động lao động, quỹ lương và tổng giờ làm thêm.
* **Tầng Presentation (GUI - 7 Forms)**:
  - `FrmMain`: Điều hướng trung tâm Sidebar Accordion phẳng, hiển thị quyền người dùng.
  - `FrmTuyenDungHopDong`: Quản lý tuyển dụng, đánh giá thử việc và ký hợp đồng.
  - `FrmChamCongPhuTroi`: Phân ca tuần, bảng chấm công 26 ngày và phiếu phụ trội tăng ca x1.5.
  - `FrmKhenThuongKyLuat`: Ban hành quyết định khen thưởng, phiếu chi và quyết định kỷ luật.
  - `FrmTinhLuong`: Bảng tính lương tự động, xuất phiếu lương, hiển thị chi tiết 18 cột lương.
  - `FrmDanhMuc`: Quản trị danh mục hệ thống.
  - `FrmThongKe`: Thống kê trực quan số liệu nhân sự, quỹ lương và giờ phụ trội.

---

## 4. KẾT QUẢ ĐẠT ĐƯỢC
* **Biên dịch**: Rebuild Solution đạt **0 Error, 0 Warning** (file thực thi `bin\Debug\QuanLyNhanSu.exe` hoàn chỉnh).
* **Kiểm thử đồng bộ CSDL**: Kiểm thử tự động qua script `verify_sync.ps1` kiểm tra 100% câu lệnh SQL ở cả 6 Services và 7 Forms đối chiếu trực tiếp trên SQL Server database `QuanLyNhanSu` đạt **PASS 100% (22/22 kịch bản thành công)**.
* **Kiểm thử kịch bản nghiệp vụ (Test Cases)**: 12 ca kiểm thử cụ thể (TC_TD01, TC_HD01, TC_HD02, TC_CC01, TC_PT01, TC_KT01, TC_KL01, TC_TL01, TC_TL02, TC_TK01) đều đạt kết quả mong đợi với độ chính xác đến từng đơn vị đồng.
* **Đồng bộ giao diện**: Giao diện các Form WinForms được bố cục, phối màu (Navy Blue `#1A2530`, Slate Gray) và sắp xếp lưới đúng chuẩn 100% theo bản vẽ thiết kế trong file Excel `QuanLyNhanSu.xlsx`.

---

## 5. LỖI GẶP PHẢI TRONG QUÁ TRÌNH THỰC HIỆN
1. **Lỗi 1 - Solution không tải được project (Path Mismatch)**:
   - *Thông báo*: Visual Studio báo popup *"One or more projects in the solution were not loaded correctly"* và Output ghi lỗi: `The project file could not be loaded. Could not find a part of the path ...\QuanLyHoSoBenhAn\QuanLyHoSoBenhAn.csproj`.
   - *Nguyên nhân*: Thư mục LAB7 ban đầu được tạo dựa trên mẫu của bài LAB6 (`QuanLyHoSoBenhAn`), dòng khai báo trong file `QuanLyNhanSu.sln` vẫn còn trỏ đến đường dẫn project cũ thay vì `QuanLyNhanSu\QuanLyNhanSu.csproj`.
2. **Lỗi 2 - Sai lệch tên cột & cấu trúc quan hệ giữa Code C# và CSDL**:
   - *Thông báo*: Ngoại lệ `SqlException: Invalid column name ...` xuất hiện ở các câu truy vấn.
   - *Nguyên nhân*: Schema vật lý trong SQL Server đã chuẩn hóa quan hệ (phòng ban được liên kết qua `NhanVien.MaPhongBan`, chức danh chuẩn hóa qua `QuyetDinhChucVu`), dẫn đến các cột tạm như `MaPhongBanThuViec` (trong `QuyetDinhTuyenDung`), `NguoiLap` (trong `PhieuPhuTroi`, `BangLuongThang`), `GhiChu` thay vì `LyDoChi` (trong `PhieuChiThuong`) không tồn tại trong database.
3. **Lỗi 3 - Xung đột phiên bản trình biên dịch MSBuild .NET 4.0 với cú pháp C# 6+**:
   - *Thông báo*: Trình biên dịch `Csc.exe` tích hợp trong .NET Framework 4.0 báo lỗi cú pháp khi gặp toán tử null-conditional (`?.`) và chuỗi nội suy (`$""`).
   - *Nguyên nhân*: Khi biên dịch qua command-line MSBuild của .NET Framework mà không có Roslyn Compiler, các tính năng của C# 6.0 trở lên không được hỗ trợ.

---

## 6. CÁCH KHẮC PHỤC
1. **Khắc phục Lỗi 1**:
   - Mở file `QuanLyNhanSu.sln` bằng trình soạn thảo và sửa dòng số 5 thành:
     ```text
     Project("{FAE04EC0-301F-11D3-BF4B-00C04F79EFBC}") = "QuanLyNhanSu", "QuanLyNhanSu\QuanLyNhanSu.csproj", "{CFFEF8CA-84C1-4A05-9932-2949D6DC9DBC}"
     ```
   - Cập nhật thông tin định danh sản phẩm trong `AssemblyInfo.cs` thành `QuanLyNhanSu`.
   - Xóa thư mục bộ nhớ đệm ẩn `.vs` để Visual Studio không lưu lại cache lỗi cũ.
2. **Khắc phục Lỗi 2**:
   - Rà soát toàn bộ 23 bảng trong SQL Server, xuất schema chi tiết và viết script `verify_sync.ps1` để tự động hóa việc đối chiếu.
   - Sửa toàn bộ các câu lệnh SQL trong 6 Service: Chuyển sang `JOIN PhongBan pb ON nv.MaPhongBan = pb.MaPhongBan`, đổi tên cột `LyDoChi`, loại bỏ các cột không có trong schema vật lý.
   - Tối ưu điều kiện lọc nhân viên trong `FrmChamCongPhuTroi.cs` sang `WHERE nv.TrangThai != N'Đã nghỉ việc'` để đảm bảo tải dữ liệu đồng nhất.
3. **Khắc phục Lỗi 3**:
   - Chuẩn hóa toàn bộ mã nguồn C# về cú pháp C# 5.0 chuẩn (`string.Format()`, toán tử 3 ngôi điều kiện `obj != null ? obj.ToString() : ""`).
   - Đảm bảo dự án có thể biên dịch thành công 100% trên bất kỳ máy nào có cài .NET Framework hoặc Visual Studio.

---

## 7. HƯỚNG DẪN DÀNH CHO GIẢNG VIÊN ĐỂ KIỂM TRA & CHẠY LẠI

### Bước 1: Khởi tạo Cơ sở dữ liệu SQL Server
1. Mở công cụ **SQL Server Management Studio (SSMS)** hoặc **Azure Data Studio**.
2. Kết nối vào SQL Server trên máy (Server name: `.` hoặc `localhost` hoặc `(localdb)\MSSQLLocalDB`).
3. Mở file script:
   ```text
   D:\Hoc\Phương pháp PT hướng đối tượng\LAB7\QuanLyNhanSu\QuanLyNhanSu.sql
   ```
4. Nhấn **Execute (F5)** để chạy script. Script sẽ tự động:
   - Tạo Database `QuanLyNhanSu`.
   - Khởi tạo đầy đủ 23 bảng và các ràng buộc khóa ngoại PK/FK.
   - Tạo Stored Procedure `sp_TinhLuongNhanVienThang`.
   - Nạp toàn bộ dữ liệu mẫu (nhân viên, chức vụ, bảng chấm công, phiếu phụ trội, bảng lương tháng 10/2026).

### Bước 2: Kiểm tra cấu hình kết nối CSDL (Nếu cần)
Mở file `App.config` tại đường dẫn:
```text
D:\Hoc\Phương pháp PT hướng đối tượng\LAB7\QuanLyNhanSu\QuanLyNhanSu\App.config
```
Chuỗi kết nối mặc định:
```xml
<connectionStrings>
    <add name="QuanLyNhanSu" 
         connectionString="Data Source=.;Initial Catalog=QuanLyNhanSu;Integrated Security=True" 
         providerName="System.Data.SqlClient" />
</connectionStrings>
```
*(Nếu máy Giảng viên sử dụng SQL Express có tên instance khác, chỉ cần sửa `Data Source=.\SQLEXPRESS`).*

### Bước 3: Mở và khởi chạy chương trình
Thầy/Cô có thể lựa chọn 1 trong 3 cách sau:
* **Cách 1 - Mở bằng Visual Studio (Khuyên dùng)**:
  1. Nhấp đúp mở file `QuanLyNhanSu.sln` tại:
     ```text
     D:\Hoc\Phương pháp PT hướng đối tượng\LAB7\QuanLyNhanSu\QuanLyNhanSu.sln
     ```
  2. Visual Studio sẽ tải Solution với đầy đủ các Form và Service.
  3. Nhấn **F5** (hoặc nút **Start**) để chạy chương trình.

* **Cách 2 - Chạy trực tiếp file thực thi (.exe)**:
  Nhấp đúp chuột chạy trực tiếp file đã biên dịch sẵn tại:
  ```text
  D:\Hoc\Phương pháp PT hướng đối tượng\LAB7\QuanLyNhanSu\QuanLyNhanSu\bin\Debug\QuanLyNhanSu.exe
  ```

* **Cách 3 - Biên dịch lại từ dòng lệnh PowerShell/CMD**:
  ```powershell
  & "C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe" "D:\Hoc\Phương pháp PT hướng đối tượng\LAB7\QuanLyNhanSu\QuanLyNhanSu.sln" /t:Rebuild /p:Configuration=Debug
  ```

---

## 8. DANH SÁCH TÀI KHOẢN ĐĂNG NHẬP DEMO THEO PHÂN QUYỀN

| STT | Tài khoản đăng nhập | Mật khẩu | Họ và tên | Chức vụ & Đơn vị | Vai trò (Actor) trong hệ thống |
| :---: | :---: | :---: | :--- | :--- | :--- |
| **1** | `dong_a` | `123456` | Đỗ Đông Á | Tổng Giám đốc (Ban Giám đốc) | Phê duyệt QĐ tuyển dụng, ký HĐLĐ, duyệt khen thưởng, ký duyệt bảng lương. |
| **2** | `kim_oanh` | `123456` | Hoàng Kim Oanh | Trưởng phòng Tổ chức HC - NS | Lập đề xuất, lập QĐ tuyển dụng thử việc, đánh giá thử việc, soạn thảo hợp đồng. |
| **3** | `thuy_linh` | `123456` | Đặng Thúy Linh | Kế toán Tiền lương (Phòng Kế toán) | Khởi tạo kỳ lương tháng, chạy tính lương tự động, xuất phiếu chi khen thưởng. |
| **4** | `van_thang` | `123456` | Trần Văn Thắng | Trưởng phân xưởng pha màu hóa chất | Lập kế hoạch công việc tuần, chốt bảng chấm công tháng, lập phiếu phụ trội tăng ca. |
| **5** | `admin` | `admin@123` | Quản Trị Viên | Bộ phận Công nghệ Thông tin | Toàn quyền quản trị hệ thống, quản lý danh mục, tài khoản và phân quyền. |

---

