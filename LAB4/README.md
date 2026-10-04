# BÁO CÁO BÀI TẬP LAB 4: PHÁT TRIỂN HỆ THỐNG CỬA HÀNG ONLINE "e-SHOPPING"

---

## 1. THÔNG TIN SINH VIÊN & BÀI BÁO CÁO
- **Môn học:** Phương pháp phát triển phần mềm hướng đối tượng
- **Tên bài Lab:** LAB 4 
- **Họ và tên sinh viên:** Trương Gia Phát
- **Mã số sinh viên (MSSV):** 1250080139
- **Lớp:** 12_ĐH_CNPM2
- **Giảng viên hướng dẫn:** Thầy Phạm Trọng Huynh

---

## 2. MÔI TRƯỜNG & PHIÊN BẢN CÔNG NGHỆ
- **Hệ điều hành:** Windows 10 / Windows 11 (64-bit)
- **Môi trường phát triển (IDE):** Microsoft Visual Studio 2022 (hoặc Visual Studio 2019)
- **Nền tảng công nghệ:** C# Windows Forms (.NET Framework 4.7.2)
- **Hệ quản trị cơ sở dữ liệu:** Microsoft SQL Server 2019 / 2022 (hoặc SQL Server LocalDB / Express)
- **Công cụ quản trị CSDL:** SQL Server Management Studio (SSMS) v19 / v20
- **Công cụ mô hình hóa UML:** PlantUML, Mermaid, Draw.io

---

## 3. NỘI DUNG ĐÃ THỰC HIỆN
Đề tài đã hoàn thành xuất sắc toàn bộ 4 mục tiêu trọng tâm của bài toán cửa hàng online "e-SHOPPING":

### 3.1. Phân tích nghiệp vụ & Xác định ranh giới hệ thống (Mục tiêu 1)
- Phân tích chi tiết quy trình mua sắm mùa Giáng Sinh và Năm Mới của cửa hàng ABC.
- Phân định rõ ràng chức năng nội bộ hệ thống e-Shopping với **3 hệ thống/dịch vụ bên ngoài**:
  1. **Hệ thống Quản lý Sản phẩm:** Cung cấp thông tin sản phẩm, mô tả, thông số và tồn kho.
  2. **Dịch vụ Thanh toán Trực tuyến (OPS):** Xác minh tính hợp lệ và hạn mức thanh toán của thẻ tín dụng.
  3. **Dịch vụ Email (EMS):** Gửi thư điện tử xác nhận đơn hàng thành công đến khách hàng.
- Xây dựng 10 quy tắc nghiệp vụ cốt lõi (**BR01 – BR10**) và các quyết định triển khai kỹ thuật.

### 3.2. Xây dựng trọn bộ mô hình UML pha Phân tích – Thiết kế (Mục tiêu 2)
1. **Biểu đồ Use Case:**
   - Biểu đồ Use Case tổng quát (Khách hàng là Primary Actor, 3 hệ thống ngoài là Secondary Actor).
   - Biểu đồ phân rã Use Case theo 4 gói phân hệ nghiệp vụ (`Quản lý giỏ hàng`, `Đặt mua hàng & tính tiền`...).
   - Bảng đặc tả chi tiết 6 Use Case chuẩn (`UC01` $\rightarrow$ `UC06`).
2. **Biểu đồ lớp phân tích (Analysis Class Diagram):** Mô hình hóa 12 lớp thực thể, chỉ rõ quan hệ hợp thành (`Composition` giữa Đơn hàng và Chi tiết đơn) và kết hợp bội số, không ghi khóa ngoại vào thuộc tính.
3. **Biểu đồ trạng thái (State Machine Diagram):**
   - Vòng đời Đơn đặt hàng (`DonDatHang`): *Chờ xác minh $\rightarrow$ Đã xác nhận $\rightarrow$ Đang giao $\rightarrow$ Hoàn tất / Đã hủy*.
   - Vòng đời Giao dịch thẻ (`ThanhToan`): *Khởi tạo $\rightarrow$ Đang xác thực $\rightarrow$ Thành công / Thất bại*.
4. **Biểu đồ tuần tự (Sequence Diagram):** Xây dựng theo kiến trúc BCE (`Boundary` – `Control` – `Entity`) kết hợp các `Adapter` cho các ca sử dụng trọng tâm.
5. **Biểu đồ lớp thiết kế chi tiết (Design Class Diagram):** Định nghĩa đầy đủ kiểu dữ liệu C#, tầm vực truy cập (`private`/`public`), thuộc tính khóa chính/ngoại và các phương thức tính toán nghiệp vụ.
6. **Thiết kế theo chức năng (VOPC):** Phân rã mô hình lớp tham gia từng use case (`Frm...` $\rightarrow$ `...Service` $\rightarrow$ `...Entity`).
7. **Biểu đồ hoạt động (Activity Diagram):** Thiết kế phân 4 làn bơi (`Swimlanes`) thể hiện quy trình xử lý đơn hàng, tính cước miễn phí và xác minh thanh toán.

### 3.3. Thiết kế Cơ sở dữ liệu & Hiện thực Prototype C# WinForms (Mục tiêu 3)
- **Cơ sở dữ liệu SQL Server (`eShoppingDB`):**
  - Gồm 12 bảng chuẩn hóa: `NhomSanPham`, `SanPham`, `KhachHang`, `NguoiNhanHang`, `LoaiPhieuDatHang`, `KhuVucGiaoHang`, `PhiGiaoHang`, `ChinhSachMienPhi`, `DonDatHang`, `ChiTietDonHang`, `LoaiTheTinDung`, `ThanhToan`.
  - Cài đặt đầy đủ các ràng buộc toàn vẹn `PK`, `FK`, `CHECK`, `UNIQUE`, `DEFAULT` và cột tính toán tự động lưu vết `PERSISTED` (`ThanhTien`, `TongTriGia`).
  - Đánh chỉ mục (`INDEX`) tối ưu hóa tốc độ truy vấn.
- **Prototype C# WinForms:**
  - Áp dụng chuẩn kiến trúc 3 tầng: `UI` $\rightarrow$ `Service / Adapter` $\rightarrow$ `Data`.
  - Kết nối cơ sở dữ liệu qua ADO.NET (`SqlCommand`, `SqlTransaction`, `SqlDataAdapter`).
  - Xử lý giao dịch nhiều bảng bằng `SqlTransaction` đảm bảo tính toàn vẹn dữ liệu (Commit khi thành công, Rollback khi có lỗi).
  - Tích hợp các Adapter mô phỏng cổng thanh toán thẻ và dịch vụ gửi email.

### 3.4. Kiểm thử theo kịch bản & Truy vết hệ thống (Mục tiêu 4)
- Xây dựng **Bảng 9: Kiểm thử tổng thể** gồm 15 Test Cases (`TC01` $\rightarrow$ `TC15`) bao phủ toàn bộ các trường hợp thành công và các ca biên/ngoại lệ.
- Xây dựng **Bảng 10: Ma trận truy vết toàn bộ** kết nối thông suốt: `Yêu cầu` $\rightarrow$ `UML / Form` $\rightarrow$ `Service / Adapter` $\rightarrow$ `Bảng CSDL` $\rightarrow$ `Test Case`.

---

## 4. KẾT QUẢ ĐẠT ĐƯỢC
- [x] Script cơ sở dữ liệu chạy ổn định, tạo thành công 12 bảng và nạp sẵn dữ liệu mẫu thực tế.
- [x] Ứng dụng WinForms chạy mượt mà, giao diện trực quan, không phát sinh lỗi ngoại lệ chưa kiểm soát.
- [x] Tính toán chính xác chính sách miễn phí vận chuyển:
  - Đơn hàng $\ge$ 1.000.000 đ $\rightarrow$ Tự động miễn phí Chuyển phát nhanh (Cước = 0 đ).
  - Đơn hàng $\ge$ 5.000.000 đ $\rightarrow$ Tự động miễn phí CPN trong ngày (Cước = 0 đ).
- [x] Kiểm tra chặt chẽ quy định thẻ tín dụng:
  - VISA / MasterCard / Discover: Đúng 16 chữ số và CSV 3 chữ số.
  - American Express: Đúng 15 chữ số và CSV 4 chữ số.
- [x] Bảo mật an toàn: Tuyệt đối không lưu mã CSV và chỉ lưu mặt nạ 4 số cuối của thẻ vào CSDL (`************1234`).
- [x] Cho phép người nhận hàng thực tế khác với người mua (thuận tiện cho việc tặng quà mùa lễ hội).

---

## 5. LỖI GẶP PHẢI VÀ CÁCH KHẮC PHỤC

| STT | Lỗi gặp phải | Nguyên nhân | Cách khắc phục |
|:---:|---|---|---|
| **1** | Báo lỗi `The name 'InitializeComponent' does not exist in the current context` | Tạo file Form bằng `Add -> Class` thay vì `Add -> Form (Windows Forms)`, dẫn đến Visual Studio không nhận diện file Designer. | Xóa file và tạo lại bằng `Add -> Form (Windows Forms)` hoặc tích hợp trực tiếp hàm `InitializeComponent()` vào file partial class. |
| **2** | Lỗi không kết nối được CSDL (`A network-related or instance-specific error...`) | Chuỗi kết nối trong `App.config` mặc định `Data Source=.`, trong khi máy tính sử dụng phiên bản SQL Server Express. | Sửa chuỗi kết nối trong file `App.config` thành `Data Source=.\SQLEXPRESS` phù hợp với cấu hình máy thực tế. |
| **3** | Lỗi vi phạm khóa ngoại khi chạy lại Script SQL tạo bảng | Thứ tự lệnh `DROP TABLE` cũ không đúng, xóa bảng cha trước khi xóa bảng con đang tham chiếu. | Sắp xếp lại thứ tự `DROP TABLE` theo đúng chiều ngược lại của cây quan hệ khóa ngoại (Xóa `ThanhToan` $\rightarrow$ `ChiTietDonHang` $\rightarrow$ `DonDatHang`... trước). |
| **4** | Lỗi sai định dạng số thẻ tín dụng và mã CSV | Chưa phân biệt quy cách giữa thẻ American Express (15 số, CSV 4) và các loại thẻ thông thường (16 số, CSV 3). | Hiện thực hàm kiểm tra quy cách trong `PaymentAdapter` và ràng buộc `CHECK (CK_LoaiThe_QuyDinh)` trong CSDL. |
| **5** | Lỗi hiển thị tiếng Việt có dấu bị biến thành dấu `?` trong CSDL | Quên tiền tố `N` trước chuỗi Unicode khi chèn dữ liệu bằng SQL. | Bổ sung tiền tố `N'...'` cho toàn bộ các trường chuỗi tiếng Việt (`nvarchar`) trong câu lệnh INSERT. |

---

## 6. HƯỚNG DẪN DÀNH CHO GIẢNG VIÊN ĐỂ KIỂM TRA & CHẠY LẠI DỰ ÁN

Để kiểm tra và chạy thử toàn bộ hệ thống, Quý Thầy/Cô vui lòng thực hiện theo các bước sau:

### Bước 1: Khởi tạo Cơ sở dữ liệu SQL Server
1. Mở phần mềm **SQL Server Management Studio (SSMS)**.
2. Mở file script `eShoppingDB.sql` (hoặc dán nội dung script tạo bảng đi kèm).
3. Bấm **Execute** (hoặc phím **F5**) để tạo CSDL `eShoppingDB` cùng các bảng và dữ liệu mẫu có sẵn.

### Bước 2: Mở và cấu hình Project trong Visual Studio
1. Mở file Solution `QuanLyCuaHangEShopping.sln` bằng **Visual Studio 2022**.
2. Mở file **`App.config`**, kiểm tra dòng chuỗi kết nối:
   ```xml
   <connectionStrings>
     <add name="QuanLyCuaHangEShoppingDB" 
          connectionString="Data Source=.;Initial Catalog=eShoppingDB;Integrated Security=True" 
          providerName="System.Data.SqlClient" />
   </connectionStrings>
### Bước 3: Build và Khởi chạy ứng dụng
1. Nhấn `Ctrl + Shift + B` để **Build Solution** (Đảm bảo: *0 Errors, 0 Warnings*).
2. Nhấn `F5` (hoặc bấm nút **Start** màu xanh) để chạy ứng dụng.
3. Cửa sổ **FrmMain** (Trang chủ điều hướng) sẽ xuất hiện trên màn hình.

---

### Bước 4: Kịch bản kiểm thử mẫu (Demo luồng đặt hàng & thanh toán)

1. **Mở giao diện đặt hàng:**  
   Tại màn hình chính **FrmMain**, nhấn chọn nút:  
   👉 **`3. ĐẶT HÀNG & THANH TOÁN (Trọng tâm)`**

2. **Chọn sản phẩm vào giỏ:**  
   Tại bảng danh sách sản phẩm, chọn:  
   - Sản phẩm: **"Nồi chiên không dầu Philips"** *(Đơn giá: 2.200.000 đ)*  
   - Thao tác: Nhấn nút **`+ Thêm vào giỏ`**.

3. **Kiểm tra cơ chế tự động miễn phí vận chuyển (BR05):**  
   - Tại ô **Loại phiếu**, chọn: *"Phiếu đặt hàng chuyển phát nhanh"*.  
   - **Kết quả hiển thị:** Dòng cước giao hàng tự động hiển thị:  
     > **`0 đ (Miễn phí vận chuyển do đơn hàng >= 1.000.000 đ)`**

4. **Nhập thông tin người nhận hàng (BR08 - Khác người mua):**  
   - **Họ tên người nhận:** `Lê Hoàng Phúc`  
   - **Địa chỉ:** `789 Cách Mạng Tháng 8, Q.3, TP.HCM`  
   - **Số điện thoại:** `0933112233`

5. **Nhập thông tin thanh toán thẻ tín dụng (BR09, BR10):**  
   - **Mã đơn hàng:** `DH_DEMO`  
   - **Loại thẻ:** `VISA`  
   - **Số thẻ (đủ 16 số):** `4111111111111234`  
   - **Ngày hết hạn:** `12/28`  
   - **Mã CSV (đủ 3 số):** `123`  
   - **Tên chủ thẻ:** `NGUYEN VAN AN`

6. **Xác nhận đặt hàng & Kiểm tra kết quả:**  
   - Nhấn nút: **`XÁC NHẬN ĐẶT HÀNG`**.  
   - **Thông báo:** Popup xuất hiện thông báo: *"Đặt hàng thành công!"*.  
   - **Kiểm tra bảng Lịch sử đơn hàng:** Đơn hàng `DH_DEMO` xuất hiện ngay lập tức với trạng thái **"Đã xác nhận"** và chỉ hiển thị mặt nạ thẻ:  
     > **`************1234`** *(Bảo mật an toàn, không lưu mã CSV theo đúng chuẩn an ninh BR12)*.  
   - **Kiểm tra chi tiết:** Nhấp chọn dòng đơn hàng `DH_DEMO`, bảng chi tiết bên cạnh sẽ hiển thị ngay sản phẩm *"Nồi chiên không dầu Philips"* với số lượng `1` và snapshot đơn giá `2.200.000 đ`.
