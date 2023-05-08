using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCodeFirst.Models
{
    public class Produkty
    {

        [Key]
        [Column("ID_Produktu")]
        public int Id { get; set; }
        [Required]
        public string Nazwa_Produktu { get; set; }
        public int Ilosc_Produktu { get; set; }
        public int Max_Ilosc_Produktu { get; set; }

        public virtual Pizzeria? Pizzeria { get; set; }
    }
}
