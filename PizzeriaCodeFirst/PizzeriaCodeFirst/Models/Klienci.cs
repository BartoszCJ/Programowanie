using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCodeFirst.Models
{
    public class Klienci
    {

        [Key]
        [Column("ID_Klienta")]
        public int Id { get; set; }
        [Required]
        public string Imie { get; set; }
        public string Nazwisko { get; set; }

        public virtual ICollection<Zamowienie> Zamowienies { get; set; } = new List<Zamowienie>();
    }
}
