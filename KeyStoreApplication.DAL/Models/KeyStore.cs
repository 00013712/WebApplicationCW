﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace KeyStoreApplication.Models
{
    public class KeyStore
    {
        //Made by Wiut student 00013712

        //[Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]   
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

    //Made by Wiut student 00013712
}
