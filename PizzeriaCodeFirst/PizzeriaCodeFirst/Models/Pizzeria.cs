using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCodeFirst.Models
{
    public class Pizzeria
    {

        [Key]
        [Column("ID_Pizzeri")]
        public int Id { get; set; }
        [Required]
        public string Adres { get; set; }
        public string Telefon { get; set; }

        public int ID_Produktu { get; set; }

        public virtual ICollection<Zamowienie> Zamowienies { get; set; } = new List<Zamowienie>();

        public virtual ICollection<Pracownik> Pracowniks { get; set; } = new List<Pracownik>();
       
        public virtual Produkty? Produkt { get; set; }
    }
}
