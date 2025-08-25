using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Quic;
using System.Text;
using System.Threading.Tasks;

namespace retailSalesCompany
{
    public class prodVarPri : products
    {
        public decimal price { get; set; }
        public decimal quantity { get; set; }

        public prodVarPri(int idPr, string Name, decimal Price, decimal Quantity) : base(idPr, Name)
        {
            this.price = Price;
            this.quantity = Quantity;
        }
        public override decimal getPrice()
        {
            decimal pricecuantity = this.price * quantity;
            return prTax(pricecuantity);
        }

        public override string getDetail()
        {
            return $"{idPr} {Name}\n" +
                   $"    measurment:..: Kilogram\n" +
                   $"    Quantity.....: {quantity}" +
                   $"    Price/Kilo..: {price:C}\n" +
                   $"    Tax.........: 19%\n" +
                   $"    Value.......: {getPrice():C}\n";
        }
    }
    
    
}
