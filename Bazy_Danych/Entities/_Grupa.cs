using CodeFirst.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Confurnce.Models
{
    public class _Grupa
    {
        [Key]
        public int Id_Grupy { get; set; }
        public int Rok { get; set; }

        public _Prowadzoncy Prowadzoncy { get; set; }
        public int Id_Prowadzoncego { get; set; }
        public IEnumerable<_Uczen> Uczen { get; set; }
    }
}
