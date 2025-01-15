using System.Net.Mail;
using System.Net;

namespace WebApplication1.Utilities
{
    public interface IEmailSender
    {
        Task SendEmailAsync(string email, string subject, string message);
    }

    public class EmailSender : IEmailSender
    {
        // SMTP sunucu bilgileri
        private readonly string _smtpServer = "smtp.gmail.com"; // Google SMTP sunucusu
        private readonly int _smtpPort = 587; // TLS için port
        private readonly string _smtpUser = "YOUR GMAİL ADRESS"; // Gmail adresi
        private readonly string _smtpPass = "YOUR GMAİL ACCOUNT APP PASSWORD"; // Gmail uygulama şifresi

        public async Task SendEmailAsync(string email, string subject, string message)
        {
            try
            {
                using var smtpClient = new SmtpClient(_smtpServer)
                {
                    Port = _smtpPort,
                    Credentials = new NetworkCredential(_smtpUser, _smtpPass),
                    EnableSsl = true, // TLS kullanımı için true
                };

                using var mailMessage = new MailMessage
                {
                    From = new MailAddress(_smtpUser, "Şifremi Unuttum Destek"),
                    Subject = subject,
                    Body = message,
                    IsBodyHtml = true, // HTML desteği için true
                };
                mailMessage.To.Add(email);

                await smtpClient.SendMailAsync(mailMessage);
            }
            catch (SmtpException ex)
            {
                // SMTP hatalarını loglamak için
                Console.WriteLine($"SMTP Hatası: {ex.Message}");
                throw;
            }
            catch (Exception ex)
            {
                // Genel hataları loglamak için
                Console.WriteLine($"Hata: {ex.Message}");
                throw;
            }
        }
    }
}
