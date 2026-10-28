# BÁO CÁO BÀI TẬP THỰC HÀNH LAB 8
## MÔN: PHÂN TÍCH THIẾT KẾ HƯỚNG ĐỐI TƯỢNG (OOAD)

---

### THÔNG TIN SINH VIÊN
* **Môn học:** Phương pháp phát triển phần mềm hướng đối tượng
* **Tên bài Lab:** LAB 8
* **Họ và tên:** Trương Gia Phát
* **Mã số sinh viên (MSSV):** 1250080139
* **Lớp:** 12_ĐH_CNPM2
* **Giảng viên hướng dẫn:** Thầy Phạm Trọng Huynh
---

### 1. MÔI TRƯỜNG & PHIÊN BẢN CÔNG NGHỆ (ENVIRONMENT & VERSIONS)
* **Hệ điều hành:** Microsoft Windows 10 / Windows 11 (64-bit)
* **Công cụ mô hình hóa (UML & ERD):** StarUML 5.x, Draw.io Desktop / Web (định dạng `.drawio` và `.png`)
* **Thiết kế giao diện Mockup:** Microsoft Excel 2016 / 2019 / Office 365, OpenPyXL 3.1.5 (Python 3.13)
* **Hệ quản trị cơ sở dữ liệu (DBMS):** Microsoft SQL Server 2016 / 2019 / 2022 hoặc SQL Server LocalDB (`(localdb)\MSSQLLocalDB`), SQLEXPRESS
* **Ngôn ngữ lập trình & Framework:** 
  * C# (.NET Framework 4.7.2, Windows Forms Architecture 3-tier)
  * Trình biên dịch: Microsoft MSBuild Engine v4.8 (`C:\Windows\Microsoft.NET\Framework64\v4.0.30319\MSBuild.exe`)
* **Môi trường phát triển:** Microsoft Visual Studio 2019 / 2022 Community

---

### 2. NỘI DUNG ĐÃ THỰC HIỆN

Hệ thống đã được phân tích, thiết kế và hiện thực hóa đầy đủ bám sát 100% đề bài:

1. **Câu 1 - Xác định Actor & Use Case tổng quát:**
   * Lập bảng 7 Actor (Khách hàng, Khách quen, Khách vãng lai, Nhân viên bán hàng, Nhân viên kho, Nhân viên kế toán, Nhà cung ứng).
   * Lập bảng 20 Use Case bao quát toàn bộ nghiệp vụ.
   * Xây dựng sơ đồ Use Case tổng quát: `Sơ đồ/UseCase_Diagram_TongQuat.drawio`.
2. **Câu 2 - Xác định danh sách Class, thuộc tính (có ID) và phương thức:**
   * Xác định 13 Class: `NhanVien`, `KhachHang`, `KhachQuen`, `KhachVangLai`, `NhaCungUng`, `NhanHieu`, `NuocGiaiKhat`, `DonDatHang`, `ChiTietDonDatHang`, `PhieuGiaoHang`, `HoaDon`, `PhieuHenGiaoHang`, `PhieuGhiNo`.
3. **Câu 3 - Tìm liên kết & Vẽ Class Diagram:**
   * Xác định rõ quan hệ phụ thuộc, kết hợp (Association), hợp thành (Composition giữa Master-Detail) và bản số (Multiplicity: `1..1`, `0..*`, `1..3`).
   * Xây dựng sơ đồ Class Diagram hoàn chỉnh: `Sơ đồ/Class_Diagram_CuaHangNuocGiaiKhat.drawio`.
4. **Câu 4 - Use Case phân rã chi tiết quy trình bán hàng:**
   * Phân rã chi tiết quy trình từ lúc khách đặt mua $\rightarrow$ kiểm tra kho $\rightarrow$ tách giao ngay/hẹn giao $\rightarrow$ thanh toán $\rightarrow$ giao đủ hàng: `Sơ đồ/UseCase_Diagram_PhanRa_BanNuocGiaiKhat.drawio`.
5. **Câu 5 - Vẽ Activity Diagram quy trình bán nước giải khát:**
   * Mô hình hóa luồng hoạt động song song, rẽ nhánh kiểm tra tồn kho (đủ hàng vs thiếu hàng) và phân loại khách (khách quen vs vãng lai): `Sơ đồ/Activity_Diagram_QuyTrinhBanNuocGiaiKhat.drawio`.
6. **Câu 6 - Vẽ Sequence Diagram nghiệp vụ "Lập Phiếu ghi nợ":**
   * Mô hình hóa tương tác giữa Actor, Giao diện bán hàng, Controller/Service, CSDL và Khách quen: `Sơ đồ/Sequence_Diagram_LapPhieuGhiNo.drawio`.
7. **Thiết kế CSDL & Kịch bản SQL Server:**
   * Vẽ mô hình ERD với Crow's Foot Notation: `Sơ đồ/ERD_CuaHangNuocGiaiKhat.drawio`.
   * Lập từ điển dữ liệu 14 bảng chuẩn hóa 3NF.
   * Viết kịch bản SQL Server hoàn chỉnh `QuanLyCuaHangNGK.sql` với đầy đủ PK, FK, CHECK, UNIQUE, Computed Column (`PERSISTED`), Index và Data mẫu.
8. **Thiết kế giao diện các Form trên Excel:**
   * Vẽ Sơ đồ điều hướng Form: `Sơ đồ/SoDoDieuHuongHeThongForm.drawio`.
   * Tạo file Excel `GiaoDien_CuaHangNuocGiaiKhat.xlsx` gồm 9 sheet thiết kế chuẩn phong cách WinForms (tiêu đề, TabControl, DataGridView, nút điều hướng) bám sát các ảnh mẫu.
9. **Hiện thực hóa phần mềm C# WinForms (3-Tier):**
   * Tái cấu trúc toàn bộ source code từ template cũ sang `QuanLyCuaHangNGK`.
   * Lập trình 8 Service xử lý logic nghiệp vụ và 9 Windows Forms đồng bộ giao diện với file Excel.
   * Biên dịch thành công ra file thực thi `QuanLyCuaHangNGK.exe`.
10. **Kiểm thử & Truy vết (Traceability & Test Cases):**
    * Xây dựng Ma trận truy vết yêu cầu (RTM: Yêu cầu $\rightarrow$ UML $\rightarrow$ Form/Service $\rightarrow$ Bảng CSDL $\rightarrow$ Test Case).
    * Thiết kế bộ 6 kịch bản kiểm thử (TC01 - TC06) có dữ liệu đầu vào và kết quả kỳ vọng cụ thể.

---

### 3. KẾT QUẢ ĐẠT ĐƯỢC (DELIVERABLES)

Toàn bộ các tài nguyên và sản phẩm thực hiện được lưu trữ ngăn nắp trong thư mục `LAB8`:

```
d:\Hoc\Phương pháp PT hướng đối tượng\LAB8\
│
├── 1250080139_TruongGiaPhat_Bai2.docx             --> File bài làm báo cáo Word tổng hợp
├── Bai_2_Cua_hang_nuoc_giai_khat.docx              --> Đề bài gốc Lab 8
├── GiaoDien_CuaHangNuocGiaiKhat.xlsx              --> Bản vẽ thiết kế UI 9 Form trên Excel
├── QuanLyCuaHangNGK.sql                           --> Kịch bản khởi tạo CSDL SQL Server & Data mẫu
├── README.md                                      --> Tài liệu hướng dẫn và báo cáo tổng kết
│
├── Sơ đồ/                                         --> Thư mục chứa toàn bộ mô hình thiết kế
│   ├── UseCase_Diagram_TongQuat.drawio (.png)     --> Sơ đồ Use Case tổng quát (Câu 1)
│   ├── Class_Diagram_CuaHangNuocGiaiKhat.drawio   --> Sơ đồ Lớp chi tiết (Câu 3)
│   ├── UseCase_Diagram_PhanRa_BanNuocGiaiKhat     --> Sơ đồ Use Case phân rã bán hàng (Câu 4)
│   ├── Activity_Diagram_QuyTrinhBanNuocGiaiKhat   --> Sơ đồ Hoạt động quy trình bán hàng (Câu 5)
│   ├── Sequence_Diagram_LapPhieuGhiNo.drawio      --> Sơ đồ Tuần tự lập phiếu ghi nợ (Câu 6)
│   ├── ERD_CuaHangNuocGiaiKhat.drawio (.png)      --> Sơ đồ Thực thể Mối quan hệ ERD
│   └── SoDoDieuHuongHeThongForm.drawio (.png)     --> Sơ đồ cấu trúc điều hướng các Form
│
└── QuanLyCuaHangNGK/                              --> Thư mục Solution mã nguồn phần mềm C#
    ├── QuanLyCuaHangNGK.sln                       --> Visual Studio Solution file
    └── QuanLyCuaHangNGK/
        ├── App.config                             --> Cấu hình kết nối CSDL (hỗ trợ LocalDB, SQLEXPRESS)
        ├── Program.cs                             --> Điểm bắt đầu ứng dụng
        ├── QuanLyCuaHangNGK.csproj                --> File cấu hình dự án C#
        ├── Data/
        │   └── Db.cs                              --> Lớp truy xuất CSDL SQL Server tập trung
        ├── Service/                               --> Tầng xử lý nghiệp vụ (Business Logic Layer)
        │   ├── KetQuaXuLy.cs
        │   ├── ChiTietItemModels.cs
        │   ├── DanhMucService.cs
        │   ├── NuocGiaiKhatService.cs
        │   ├── KhachHangService.cs
        │   ├── NhapHangService.cs
        │   ├── BanHangService.cs
        │   ├── PhieuHenService.cs
        │   ├── CongNoService.cs
        │   └── ThongKeService.cs
        ├── Forms/                                 --> Tầng giao diện người dùng (Presentation Layer)
        │   ├── FrmMain.cs / .Designer.cs
        │   ├── FrmDanhMuc.cs / .Designer.cs
        │   ├── FrmNuocGiaiKhat.cs / .Designer.cs
        │   ├── FrmKhachHang.cs / .Designer.cs
        │   ├── FrmNhapHang.cs / .Designer.cs
        │   ├── FrmBanHang.cs / .Designer.cs
        │   ├── FrmPhieuHen.cs / .Designer.cs
        │   ├── FrmPhieuGhiNo.cs / .Designer.cs
        │   └── FrmThongKe.cs / .Designer.cs
        └── bin/Debug/
            ├── QuanLyCuaHangNGK.exe               --> FILE THỰC THI CHƯƠNG TRÌNH ĐÃ BUILD
            └── QuanLyCuaHangNGK.exe.config
```

---

### 4. CÁC LỖI GẶP PHẢI & CÁCH KHẮC PHỤC (TROUBLESHOOTING)

Trong quá trình phân tích, thiết kế và lập trình hệ thống, một số vấn đề kỹ thuật đã phát sinh và được xử lý triệt để:

| STT | Vấn Đề / Lỗi Gặp Phải | Nguyên Nhân Kỹ Thuật | Giải Pháp & Cách Khắc Phục |
| :---: | :--- | :--- | :--- |
| **1** | Lỗi hiển thị tiếng Việt trên Console: `UnicodeEncodeError: 'charmap' codec can't encode...` | Môi trường Windows PowerShell mặc định sử dụng Code Page `cp1252` thay vì `UTF-8`. | Cấu hình ép buộc đầu ra `sys.stdout.reconfigure(encoding='utf-8')` trong các script Python đọc/ghi file. |
| **2** | Lỗi MSBuild không tìm thấy dự án: `MSB3202: The project file ... QuanLyKhachSan.csproj was not found`. | File `QuanLyCuaHangNGK.sln` ban đầu sao chép từ dự án mẫu khách sạn vẫn còn lưu đường dẫn thư mục cũ `QuanLyKhachSan\QuanLyKhachSan.csproj`. | Chỉnh sửa trực tiếp file `.sln`, cập nhật đường dẫn chính xác: `"QuanLyCuaHangNGK\QuanLyCuaHangNGK.csproj"`. |
| **3** | Lỗi biên dịch C# khi chạy MSBuild: `error CS1056: Unexpected character '$'`, `error CS1002: ; expected` tại cú pháp `=>` và `?.`. | Trình biên dịch C# tích hợp trong .NET Framework 4.0 (`Csc.exe`) chỉ hỗ trợ cú pháp chuẩn C# 5.0; các tính năng mới của C# 6.0 (`$"..."`, Expression-bodied `=>`, Null-conditional `?.`) không được nhận diện. | Chuẩn hóa toàn bộ mã nguồn về C# 5.0: thay thế nội suy chuỗi bằng `string.Format()`, thay Expression property bằng getter thông thường `{ get { return ...; } }`, và thay `?.` bằng kiểm tra `!= null`. Sau khi chuẩn hóa, dự án Build thành công 100% với 0 Warning, 0 Error. |
| **4** | Lỗi xung đột cú pháp tiền tố `N'...'` trong code C#: `error CS1003: Syntax error, ':' expected`. | Do nhầm lẫn cú pháp chuỗi Unicode của SQL (`N'...'`) vào toán tử điều kiện ba ngôi của C#. | Loại bỏ ký tự `N` thừa trong code C#, chuỗi tiếng Việt trong C# mặc định đã hỗ trợ Unicode nguyên bản. |
| **5** | Lỗi vi phạm ràng buộc Foreign Key khi tạo mới hoặc xóa bảng trong SQL Server. | Thứ tự tạo bảng và xóa bảng không tuân theo quy tắc phụ thuộc khóa ngoại (ví dụ: xóa bảng cha trước bảng con). | Viết lại câu lệnh `DROP TABLE` theo đúng thứ tự đảo ngược của ràng buộc Khóa ngoại (bảng con trước, bảng cha sau) và `CREATE TABLE` theo thứ tự từ bảng độc lập đến bảng phụ thuộc. |

---

### 5. HƯỚNG DẪN DÀNH CHO GIẢNG VIÊN ĐỂ KIỂM TRA & CHẠY LẠI DỰ ÁN

Giảng viên có thể kiểm tra sản phẩm theo 2 cách: chạy trực tiếp file `.exe` hoặc mở qua Visual Studio.

#### Bước 1: Khởi tạo Cơ sở dữ liệu SQL Server
1. Mở công cụ **SQL Server Management Studio (SSMS)** (hoặc Azure Data Studio).
2. Kết nối tới SQL Server cục bộ (ví dụ: `(localdb)\MSSQLLocalDB`, `localhost` hoặc `.\SQLEXPRESS`).
3. Mở file script: **`d:\Hoc\Phương pháp PT hướng đối tượng\LAB8\QuanLyCuaHangNGK.sql`**.
4. Bấm **Execute (F5)**. Kịch bản sẽ tự động tạo CSDL `QuanLyCuaHangNGK`, các bảng, ràng buộc và nạp sẵn bộ dữ liệu mẫu thực tế.

#### Bước 2: Chạy ứng dụng

* **Cách 1: Chạy trực tiếp (Nhanh nhất - Không cần cài Visual Studio):**
  * Nhấp đúp chuột vào file:  
    👉 **`d:\Hoc\Phương pháp PT hướng đối tượng\LAB8\QuanLyCuaHangNGK\QuanLyCuaHangNGK\bin\Debug\QuanLyCuaHangNGK.exe`**
  * Chương trình sẽ tự động mở giao diện Trang chủ `FrmMain`. Lớp `Db.cs` đã được lập trình sẵn cơ chế tự động tìm chuỗi kết nối phù hợp giữa LocalDB và SQLEXPRESS.

* **Cách 2: Mở và chạy từ mã nguồn Visual Studio:**
  * Mở file Solution: **`d:\Hoc\Phương pháp PT hướng đối tượng\LAB8\QuanLyCuaHangNGK\QuanLyCuaHangNGK.sln`**.
  * Chọn cấu hình `Debug | Any CPU`.
  * Nhấn **F5** (hoặc nút **Start**) để biên dịch và chạy.

---

### 6. KỊCH BẢN KIỂM TRA NGHIỆP VỤ NHANH (DEMO WALKTHROUGH)

Khi chương trình chạy, giảng viên có thể kiểm tra nhanh các nghiệp vụ cốt lõi theo thứ tự sau:

1. **Kiểm tra Danh mục & Nước giải khát:**
   * Bấm **1. Quản Lý Danh Mục** $\rightarrow$ Kiểm tra các Tab Nhà cung ứng, Nhãn hiệu, Nhân viên.
   * Bấm **2. Quản Lý Nước Giải Khát & Tồn Kho** $\rightarrow$ Kiểm tra danh sách mặt hàng, số lượng tồn kho. Bấm Tab *Cảnh Báo Tồn Kho* để thấy các mặt hàng sắp hết hàng (Sting dâu, 7Up).
2. **Kiểm tra nghiệp vụ Nhập hàng NCC (Tối đa 3 đợt):**
   * Bấm **4. Quản Lý Nhập Hàng** $\rightarrow$ Chọn Tab *Đơn Đặt Hàng* để xem `DDH01` đã giao đợt 2/3.
   * Chuyển sang Tab *Phiếu Giao Hàng* để kiểm tra lịch sử nhập kho đợt 1 và đợt 2 (mỗi lần nhập tồn kho tự động cộng dồn).
3. **Kiểm tra nghiệp vụ Bán hàng - Tự động tách Phiếu hẹn khi thiếu tồn:**
   * Bấm **5. Tiếp Nhận Mua Hàng & Bán Hàng**.
   * Chọn khách hàng: `KQ01 - Đại lý Hoàng Mai`.
   * Chọn NGK: `Pepsi Chai Thủy Tinh 390ml` (hiện có tồn 120 két).
   * Nhập số lượng mua: `150` két $\rightarrow$ Bấm **+ Thêm HĐ**.
   * **Quan sát kết quả:** Lưới giỏ hàng tự động tách: `SL Giao Ngay = 120`, `SL Hẹn Giao = 30`.
4. **Kiểm tra nghiệp vụ Bán hàng - Kiểm soát hạn mức nợ & Tự sinh Phiếu nợ:**
   * Chọn hình thức thanh toán: `Trả chậm / Ghi nợ`.
   * Nhập tiền trả ngay: `25.000.000 đ` (Số tiền ghi nợ tự tính: `14.750.000 đ`).
   * Bấm **🖨 Lưu & Lập HĐ**.
   * **Quan sát kết quả:** Hệ thống kiểm tra hạn mức nợ hợp lệ, thông báo lưu hóa đơn thành công, đồng thời **tự động sinh Phiếu Hẹn Giao Hàng** (giao 30 két thiếu) và **tự động sinh Phiếu Ghi Nợ** (nợ 14.75tr).
5. **Kiểm tra Quản lý Phiếu hẹn:**
   * Bấm **6. Quản Lý Phiếu Hẹn Giao Hàng** $\rightarrow$ Thấy ngay phiếu hẹn vừa được tạo cho khách `KQ01`, chi tiết còn thiếu 30 két Pepsi. Bấm *Giao hàng đợt này* khi kho có hàng bổ sung.
6. **Kiểm tra Quản lý Công nợ & Thu nợ từng lần:**
   * Bấm **7. Quản Lý Công Nợ** $\rightarrow$ Thấy phiếu ghi nợ vừa lập.
   * Tại cụm thu nợ: Nhập số tiền thu `5.000.000 đ`, chọn `Chuyển khoản`, bấm **Thu nợ**.
   * **Quan sát kết quả:** Tiền nợ còn lại giảm từ 14.75tr xuống còn 9.75tr, cập nhật đồng bộ sang tổng nợ của khách hàng.
7. **Kiểm tra Báo cáo thống kê:**
   * Bấm **8. Báo Cáo Thống Kê & Doanh Thu** $\rightarrow$ Bấm **Xem Báo Cáo**.
   * Quan sát các thẻ KPI cập nhật tức thời (Tổng doanh thu, số hóa đơn, tổng công nợ chưa thu) và bảng phân tích doanh thu chi tiết từng mặt hàng NGK.
