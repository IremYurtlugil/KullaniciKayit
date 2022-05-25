﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ViewModels.KullaniciVM
{
   public class LoginVM
    {
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} boş geçilemez")]
        [Display(Name = " Mail Adresi", Prompt = "isimsoyisim@firmaadi.com")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "{0} boş geçilemez")]
        [Display(Name = "Şifre")]
        [DataType(DataType.Password)]
        [StringLength(8, ErrorMessage = "Şifre 8 karakterli olmalıdır.")]
        public string Password { get; set; }
    }
}
