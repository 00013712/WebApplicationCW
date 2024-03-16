using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KeyStoreApplication.Models
{
    public class KeyStore
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Login can not be empty")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Password can not be empty")]
        public string Password { get; set; }

        [Required(ErrorMessage = "WebPlatform can not be empty")]
        public string WebPlatform { get; set;}

        public int? UserId { get; set; }
        [ForeignKey("UserId")]
        public UserStore? UserStore { get; set; }

    }
}
