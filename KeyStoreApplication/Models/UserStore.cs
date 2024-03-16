using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KeyStoreApplication.Models


{
    public class UserStore
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name can not be empty")]
        public string Name { get; set; }

    }
}
