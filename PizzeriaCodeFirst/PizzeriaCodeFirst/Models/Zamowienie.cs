using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCodeFirst.Models
{
    public class Zamowienie
    {

        [Key]
        [Column("ID_Zamowienia")]
        public int Id { get; set; }
        [Required]
        public string Adres { get; set; }
        public string Cena { get; set; }
        public DateTime Data_Godz { get; set; }

        public virtual ICollection<Klienci> Kliencis { get; set; } = new List<Klienci>();
        public virtual ICollection<Menu> Menus { get; set; } = new List<Menu>();
        public virtual ICollection<Pracownik> Pracowniks { get; set; } = new List<Pracownik>();
        public virtual ICollection<Pizzeria> Pizzerias { get; set; } = new List<Pizzeria>();
        public virtual Klienci? Klient { get; set; }
        public virtual Menu? MenuI { get; set; }
        public virtual Pracownik? Pracownik { get; set; }
        public virtual Pizzeria? Pizzeria { get; set; }

    }
}
