using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class fulltimeemployee : Employ
    {
        public required decimal salary {  get; set; }

        public override decimal getPayment()
        {
            return salary;
        }
        
        public override string ToString()
        {
            return base.ToString() + $"{Environment.NewLine} Salario.................: {salary}";
        }
    }
}
