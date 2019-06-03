using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Eventos.Mvc.ViewModels
{
    public class UsuarioViewModel
    {
        [Required]
        [DataType(DataType.Text)]
        public string Usuario { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        public string ReturnUrl { get; set; }
    }
}