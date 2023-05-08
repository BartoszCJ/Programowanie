using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCodeFirst.Models
{
    public class Pracownik
    {

        [Key]
        [Column("ID_Pracownika")]
        public int Id { get; set; }
        [Required]
        public string Imie { get; set; }
        public string Nazwisko { get; set; }
        public int Stawka { get; set; }
        public string Stanowisko { get; set; }

        public virtual ICollection<Zamowienie> Zamowienies { get; set; } = new List<Zamowienie>();
        
        public virtual ICollection<Pizzeria> Pizzerias { get; set; } = new List<Pizzeria>();
        public virtual Pizzeria? Pizzeria { get; set; }

    }
}
