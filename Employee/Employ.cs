using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Time;
namespace Employee
{
    public abstract class Employ : IPay
    {
        public required int id { get; set; }
        public required string fullName { get; set; }
        public required int Document { get; set; }
        public required string role { get; set; }
        public required Getime Birthday { get; set; }
        public abstract decimal getPayment();

        public override string ToString()
        {
            return $"ID.................: {id} +" +
                $"{Environment.NewLine}Nombre.................: {fullName} +" +
                $"{Environment.NewLine} Documento.................: {Document} +" +
                $"{Environment.NewLine} Rol.................: {role} +" +
                $"{Environment.NewLine} Fecha de Nacimiento: {Birthday}";
        }
    }
}
