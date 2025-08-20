using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
   public class ComissionEmployee : fulltimeemployee
    {
        public decimal comissionRate { get; set; }
        
        public override decimal getPayment()
        {
            
            return base.getPayment() + comissionRate;
        }
        public override string ToString()
        {
            return base.ToString() + $"{Environment.NewLine} Tasa de Comisión.................: {comissionRate} +" +
                $"{Environment.NewLine} Pago Total con Comisión.................: {getPayment()}";
        }
    }
}
