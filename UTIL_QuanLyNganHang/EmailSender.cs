using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;


namespace UTIL_QuanLyNganHang
{
    public class EmailSender
    {
        private readonly string senderEmail = "colv51614@gmail.com"; // Gmail của bạn
        private readonly string appPassword = "lhrr sheb polh lgni"; // App Password

        public bool SendVerificationCode(string toEmail, string maXacMinh, out string errorMessage)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(senderEmail, "Ngân hàng VanCoBanking"); // 👈 Đặt tên hiển thị chuyên nghiệp
                mail.To.Add(toEmail);
                mail.Subject = "🔐 Mã xác minh đặt lại mật khẩu";
                mail.IsBodyHtml = true;

                mail.Body =
                $"<div style='font-family:Segoe UI, sans-serif;font-size:14px'>" +
                $"<img src='https://raw.githubusercontent.com/VanCo-IT/Logo/refs/heads/main/Ng%C3%A2n%20h%C3%A0ng%20V%C4%83n%20C%C3%B3.png' alt='Logo' style='height:50px; margin-bottom:10px;' />" +
                $"<p>Xin chào,</p>" +
                $"<p>Bạn vừa yêu cầu <b>đặt lại mật khẩu</b> trên hệ thống.</p>" +
                $"<p><b>Mã xác minh của bạn là: <span style='color:red;font-size:18px'>{maXacMinh}</span></b></p>" +
                $"<p>Mã có hiệu lực trong vòng <b>5 phút</b>.</p>" +
                $"<br><p style='font-size:12px;color:#888'>Nếu bạn không thực hiện yêu cầu này, vui lòng bỏ qua email này.</p>" +
                $"<p style='font-size:12px;color:#888'><i>Ngân hàng 123 - Bảo mật là ưu tiên hàng đầu.</i></p>" +
                $"</div>";


                SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential(senderEmail, appPassword);
                smtp.Send(mail);

                errorMessage = "";
                return true;
            }
            catch (Exception ex)
            {
                errorMessage = ex.Message;
                return false;
            }
        }
    }
}
    //public static void SendEmail(string toEmail, string subject, string body)
    //{
    //    string fromEmail = "colv51614@gmail.com";         // ← Gmail của bạn
    //    string appPassword = "lhrr sheb polh lgni";           // ← Mật khẩu ứng dụng 16 ký tự

    //    MailMessage mail = new MailMessage();
    //    mail.From = new MailAddress(fromEmail);
    //    mail.To.Add(toEmail);
    //    mail.Subject = subject;
    //    mail.Body = body;

    //    SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);
    //    smtp.Credentials = new NetworkCredential(fromEmail, appPassword);
    //    smtp.EnableSsl = true;

    //    smtp.Send(mail);
    //}