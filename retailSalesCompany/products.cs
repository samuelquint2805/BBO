using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retailSalesCompany
{
    //products tiene la implementacion de iProduct y se usa como clase base para los productos fisicos de la tienda
    //junto con el calculo de impuestos
    public abstract class products : iProduct
    {
        public int idPr { get; set; }
        public string Name { get; set; }
        public decimal TaxValue { get; init; } = 19;
        public abstract decimal getPrice();
        public abstract string getDetail();


        public products(int idPr, string Name)
        {
            this.idPr = idPr;
            this.Name = Name;
        }

        //metodo para calcular el precio con impuestos
        public decimal prTax(decimal pri)
        {
            return pri * (1+ (TaxValue / 100));
        }

    }

    
    
}
