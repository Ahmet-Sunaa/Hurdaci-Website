using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace WebApplication1.DAL.Entities
{
    public class Admin
    {
        public int AdminID { get; set; }
        public string UserName { get; set; }
        // Hashlenmiş şifre
        public string PasswordHash { get; set; }

        // Salt (şifreleme için rastgele oluşturulan veri)
        public string Salt { get; set; }

        // Bu özellik veritabanında saklanmaz, sadece API istemcisinden alınan şifreyi temsil eder.
        [NotMapped]
        public string Password { get; set; }  // Sadece geçici bir alan, veritabanına kaydedilmez


        public string Email {  get; set; }
        public string? ResetToken { get; set; }  // Şifre sıfırlama token'ı
        public DateTime? TokenExpiry { get; set; }
    }
}
