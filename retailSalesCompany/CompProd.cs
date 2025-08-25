using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retailSalesCompany
{
    public class CompProd : products 
    {
        List<products> Vprods;
        decimal Discount;
        decimal totalPrice;

        public CompProd(int idPr, string Name, List<products> Vprods, decimal Discount) : base(idPr, Name)
        {
            this.Vprods = Vprods;
            this.Discount = Discount;
            totalPrice = 0;
            foreach (var p in Vprods)
            {
                totalPrice += p.getPrice();
            }
        }
        public override decimal getPrice()
        {
            return totalPrice * (1 - (Discount / 100));
        }
        public override string getDetail()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{idPr} {Name}\n" +
                          $" Includes the following products:\n");
            foreach (var p in Vprods)
            {
                sb.AppendLine($"      - {p.Name}: {p.getPrice():C}");
            }
            sb.AppendLine($" Discount.....: {Discount}%\n" +
                          $" Total Value..: {getPrice():C}\n");
            return sb.ToString();
        }
    }
}
