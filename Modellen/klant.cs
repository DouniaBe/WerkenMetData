using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WerkenMetData.Moddelen
{
    public class Klant
    {
        public int Id { get; set; }
        [StringLength(maximumLength:50)]
        public string Naam { get; set; }
        public string Voornaam { get; set; }

        [DataType(DataType.Date)]
        public DateTime Geboortedatum { get; set; }
    }
}
