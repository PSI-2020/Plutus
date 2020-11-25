using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class WebPayment
    {
        public int Date { get; set; }
        [Key]
        public string Name { get; set; }
        public double Amount { get; set; }
        public string Category { get; set; }
    }
}
