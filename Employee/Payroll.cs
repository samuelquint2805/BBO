using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using Time;

namespace Employee
{
    public class Payroll : IPay
    {
        public required int  id { get; set; }
        public required string description { get; set; }
        public required List<Employ> employees { get; set; }
        public required Getime date { get; set; }
        public decimal getPayment()
        {
            decimal total = 0;
            foreach (Employ employ in employees)
            {
                total += employ.getPayment();
            }
            return total;
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("===========NÓMINA===========");
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            sb.Append($"Nómina N°: {id}");
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            sb.Append($"Fecha: {date}");
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            sb.Append($"Descripción: {description}");
            foreach (Employ employ in employees)
            {
                sb.Append(employ.ToString());
                sb.Append(Environment.NewLine);
                sb.Append(Environment.NewLine);
            }
            sb.Append(Environment.NewLine);
            sb.Append(Environment.NewLine);
            sb.Append($"Total a pagar: {getPayment():C2}");
            return sb.ToString();
        }
    }
}
