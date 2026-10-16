using System;
using QuanLyHoSoBenhAn.Models;

namespace QuanLyHoSoBenhAn.Adapters
{
    // Adapter 1: Dịch vụ Camera chụp ảnh chân dung 3x4 tại quầy tiếp đón
    public class CameraCaptureAdapter
    {
        public string ChupAnhChanDung(string maBN)
        {
            // Mô phỏng thiết bị webcam/camera chụp ảnh 3x4 bệnh nhân khi đăng ký mới
            string timestamp = DateTime.Now.ToString("yyyyMMdd_HHmmss");
            string relativePath = string.Format("/photos/3x4/{0}_{1}.jpg", maBN, timestamp);
            return relativePath;
        }
    }

    // Adapter 2: Cổng Giám định BHYT / Cổng Thanh toán Viện phí trực tuyến (OPS)
    public class BHYTAdapter
    {
        public KetQuaXuLy KiemTraTheBHYT(string soTheBHYT, string hoTen)
        {
            if (string.IsNullOrWhiteSpace(soTheBHYT))
                return KetQuaXuLy.Fail("Số thẻ BHYT không hợp lệ.");

            if (soTheBHYT.Length != 15)
                return KetQuaXuLy.Fail("Mã thẻ BHYT chuẩn quốc gia phải có đúng 15 ký tự.");

            return KetQuaXuLy.Ok(string.Format("Xác thực thẻ BHYT thành công cho bệnh nhân: {0}", hoTen));
        }
    }

    // Adapter 3: Dịch vụ gửi tin nhắn SMS Brandname nhắc lịch khám định kỳ theo quý
    public class SMSNotificationAdapter
    {
        public KetQuaXuLy GuiTinNhanNhacLichHen(string sdt, string hoTen, DateTime ngayHen, int quyKham, int namKham)
        {
            if (string.IsNullOrWhiteSpace(sdt))
                return KetQuaXuLy.Fail("Bệnh nhân không có số điện thoại để gửi tin nhắn.");

            string noiDung = string.Format("BV Đa Khoa Quốc Tế nhắc hẹn: Bệnh nhân {0} có lịch khám định kỳ Quý {1}/{2} vào ngày {3:dd/MM/yyyy HH:mm}. Vui lòng mang theo Mã Hồ Sơ khi đến khám.",
                hoTen, quyKham, namKham, ngayHen);

            return KetQuaXuLy.Ok(string.Format("Đã gửi SMS nhắc lịch tới {0}: \"{1}\"", sdt, noiDung));
        }

        public KetQuaXuLy GuiTinNhanToaThuoc(string sdt, string hoTen, string maToa)
        {
            if (string.IsNullOrWhiteSpace(sdt)) return KetQuaXuLy.Ok("Bỏ qua SMS.");
            string msg = string.Format("BV Đa Khoa Quốc Tế: Bệnh nhân {0} đã được cấp toa thuốc {1}. Xin vui lòng uống thuốc đúng liều lượng bác sĩ căn dặn.", hoTen, maToa);
            return KetQuaXuLy.Ok(string.Format("Đã gửi SMS toa thuốc tới {0}", sdt));
        }
    }
}
