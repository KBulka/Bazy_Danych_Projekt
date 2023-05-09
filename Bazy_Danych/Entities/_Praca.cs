using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confurnce.Models
{
 
    public class _Praca
    {
        [Key]
        public int Id_pracy { get; set; }
        public int nr_etapu { get; set; }
        public int Ocena { get; set; }
        public int Zawartosc_pracy { get; set; }
        public int Czy_ukonczony { get; set; }

        public _Projekt Projekt { get; set; }
        public int Id_projektu { get; set; }

    }
}
