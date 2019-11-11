using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TestDevJunior.Models
{
    public class Client
    {
        public int id { get; set; }
        public string razao_social { get; set; }
        public string cnpj { get; set; }
        public DateTime data_fundacao { get; set; }
        public decimal capital { get; set; }
        public bool quarentena { get; set; }
        public bool status_cliente { get; set; }
        public char classificacao { get; set; }


    }
}
