using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SL.Models
{
    internal class Product
    {
        private int Id { get; set; }
        private string product { get; set; }
        private int aantal { get; set; }
        private Gebruiker gebruiker { get; set; }

        public Product(int id , String product, int aantal)
        { 
            Id = id;
            this.product = product;
            this.aantal = aantal;

        }


    }
}
