using System.ComponentModel.DataAnnotations;

namespace WebApplication1.DAL.ViewModel
{
    public class ResetPasswordViewModel
    {
        public string Token { get; set; } // Gizli input için


        public string NewPassword { get; set; }

        public string ConfirmPassword { get; set; }
    }
}
