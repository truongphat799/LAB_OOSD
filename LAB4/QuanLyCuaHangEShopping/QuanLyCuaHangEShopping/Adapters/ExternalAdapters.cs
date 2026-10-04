using System;
using QuanLyCuaHangEShopping.Models;

namespace QuanLyCuaHangEShopping.Adapters
{
    // Adapter 1: Dịch vụ thanh toán trực tuyến bên ngoài (OPS)
    public class PaymentAdapter
    {
        public KetQuaXuLy XacMinhThe(string loaiThe, string soThe, string expDate, string csv, decimal soTien)
        {
            // BR09 & BR10: Validate định dạng theo quy định thẻ
            if (loaiThe == "American Express")
            {
                if (soThe.Length != 15 || csv.Length != 4)
                    return KetQuaXuLy.Fail("Thẻ American Express phải có đúng 15 chữ số và mã CSV 4 chữ số.");
            }
            else // VISA, MasterCard, Discover
            {
                if (soThe.Length != 16 || csv.Length != 3)
                    return KetQuaXuLy.Fail($"Thẻ {loaiThe} phải có đúng 16 chữ số và mã CSV 3 chữ số.");
            }

            if (soTien <= 0)
                return KetQuaXuLy.Fail("Số tiền thanh toán phải lớn hơn 0.");

            return KetQuaXuLy.Ok("Xác minh thẻ tín dụng thành công.");
        }
    }

    // Adapter 2: Dịch vụ Email bên ngoài (EMS)
    public class EmailAdapter
    {
        public KetQuaXuLy GuiEmailXacNhan(string toEmail, string maDonHang, decimal tongTien)
        {
            if (string.IsNullOrWhiteSpace(toEmail))
                return KetQuaXuLy.Ok("Khách hàng không cung cấp email, bỏ qua gửi email.");

            // BR12: Tuyệt đối không gửi thông tin thẻ tín dụng qua email vì lý do an ninh
            string noiDung = $"Cảm ơn bạn đã mua sắm tại e-Shopping! Đơn hàng {maDonHang} có tổng trị giá {tongTien:N0} đ đã được ghi nhận.";
            return KetQuaXuLy.Ok($"Đã gửi email xác nhận tới: {toEmail}");
        }
    }
}