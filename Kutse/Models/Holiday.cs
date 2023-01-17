using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Kutse.Models
{
    public class Holiday
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Sissesta pidustus")]
        public string Pidustus { get; set; }

        [Required(ErrorMessage = "Sissesta kuupäev")]
        public DateTime kuupaev { get; set; }
    }
}