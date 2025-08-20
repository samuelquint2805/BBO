using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    public class halftimeEmployee : Employ
    {
        public required int workedHours { get; set; }
        public required int hourValue { get; set; }
        public override decimal getPayment()
        {
            return workedHours * hourValue;
        }
        public override string ToString()
        {
            return base.ToString() + $"{Environment.NewLine} Horas Trabajadas.................: {workedHours} +" +
                $"{Environment.NewLine} Valor por Hora.................: {hourValue} +" +
                $"{Environment.NewLine} Pago Total.................: {getPayment()}";
        }
    }
}
