using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pizzaconformulario
{
    public class Pizza
    {
        public Pizza()
        {
            this.Queso = new Queso();
        }
            
        public string Tamaño { get; set; }
        public string Tipo { get; set; }
        public string Porciones { get; set; }
        public Queso Queso { get; set; }
        public Refresco Refresco { get; set; }

    }
}
