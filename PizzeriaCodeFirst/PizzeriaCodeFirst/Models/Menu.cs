using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaCodeFirst.Models
{
    public class Menu
    {

        [Key]
        [Column("ID_Menu")]
        public int Id { get; set; }
        [Required]
        public string Nazwa_Dania { get; set; }
        public int Cena { get; set; }
        public int Rabat { get; set; }
        public virtual ICollection<Zamowienie> Zamowienies { get; set; } = new List<Zamowienie>();
    }
}
