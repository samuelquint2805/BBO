using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace retailSalesCompany
{
    // prodPrEst es una clase derivada de products que representa productos con precio estimado (no variable)
    public class prodPrEst : products
    {
      
        public decimal PriceEst { get; set; }
        public prodPrEst(int idPr, string Name, decimal PriceEst) : base(idPr, Name)
        {
            this.PriceEst = PriceEst;
        }
        // implementacion del metodo getPrice para productos con precio estimado, se llama al metodo prTax para calcular
        // el precio con impuestos
        public override decimal getPrice()
        {
            return prTax(PriceEst);
        }
        public override string getDetail()
        {
            return $"{idPr} {Name}\n" +
                   $"    Price.......: {PriceEst:C}\n" +
                   $"    Tax.........: 19%\n" +
                   $"    Value.......: {getPrice():C}\n";
        }
    }
    
    
}
