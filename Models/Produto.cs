using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace concilig.Models
{
    public class Produto
    {
        [Key]
        public int id { get; set; }
        public string nome {get; set;}
        public ICollection<Contrato> Contratos {get; set;}
    }
}