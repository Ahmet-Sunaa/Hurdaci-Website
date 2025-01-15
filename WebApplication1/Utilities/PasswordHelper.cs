using System.Security.Cryptography;
using System.Text;
using WebApplication1.DAL.Context;
using WebApplication1.DAL.Entities;

namespace WebApplication1.Utilities
{
  

    public static class PasswordHelper
    {

        // Şifreyi hashlemek için PBKDF2 kullanımı
        public static (string passwordHash, string salt) HashPassword(string password)
        {
            // Rastgele bir salt üret
            byte[] saltBytes = RandomNumberGenerator.GetBytes(16);
            string salt = Convert.ToBase64String(saltBytes);

            // Salt ile şifreyi hashle
            var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 100000, HashAlgorithmName.SHA256);
            byte[] hash = pbkdf2.GetBytes(32); // Hash uzunluğu

            return (Convert.ToBase64String(hash), salt);
        }

        // Hashlenmiş şifreyi doğrulama
        public static bool VerifyPassword(string password, string storedHash, string storedSalt)
        {
            byte[] saltBytes = Convert.FromBase64String(storedSalt);

            var pbkdf2 = new Rfc2898DeriveBytes(password, saltBytes, 100000, HashAlgorithmName.SHA256);
            byte[] hash = pbkdf2.GetBytes(32);

            return Convert.ToBase64String(hash) == storedHash;
        }

        public static bool VerifyAdmin(string username, string password)
        {
            using (var context = new HurdaciContext())
            {
                var admin = context.Admins.FirstOrDefault(a => a.UserName == username);

                if (admin == null)
                    return false;

                return PasswordHelper.VerifyPassword(password, admin.PasswordHash, admin.Salt);
            }
        }
        public static void SeedAdmin(HurdaciContext context)
        {
            if (!context.Admins.Any())
            {
#
                var (passwordHash, salt) = PasswordHelper.HashPassword("admin");

                var admin = new Admin
                {
                    UserName = "admin",
                    PasswordHash = passwordHash,
                    Salt = salt
                };

                context.Admins.Add(admin);
                context.SaveChanges();
            }
        }
    }

}
