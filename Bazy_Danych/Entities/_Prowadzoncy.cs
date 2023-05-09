using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confurnce.Models
{
    public class _Prowadzoncy
    {
        [Key]
        public int Id_Prowadzoncego { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Imie { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Nazwisko { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Email { get; set; }

        public IEnumerable<_Grupa> Grupa { get; set; }
    }
}
