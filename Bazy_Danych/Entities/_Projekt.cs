using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confurnce.Models
{
    public class _Projekt
    {
        [Key]
        public int Id_projektu { get; set; }
        public int Licza_etapow { get; set; }
        public int Liczba_ukonczonych_etapow { get; set; }

        public IEnumerable<_Praca> Praca { get; set; }

        public _Uczen Uczen { get; set; }
        public int Id_ucznia { get; set; }

    }
}
