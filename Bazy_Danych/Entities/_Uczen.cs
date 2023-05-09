using Confurnce.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirst.Models
{
    public class _Uczen
    {
        [Key]
        public int Id_ucznia { get; set; }
   
        [Column(TypeName = "nvarchar(50)")]
        public string Imie { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Nazwisko { get; set; }

        public _Grupa Grupa { get; set; }
        public int Id_grupy { get; set; }

        public IEnumerable<_Projekt> Projekt { get; set; }

    }
}
