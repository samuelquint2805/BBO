using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time
{
    public class Getime
    {
        #region Variables
        //definimos las variables de fecha juntos con el constructor


        public DateTime year { get; set; }
        public DateTime month { get; set; }
        public DateTime day { get; set; }
        public DateTime valorEmp { get; set; }

        public Getime(int year, int month, int day)
        {
            valorEmp = new DateTime(year, month, day);
            year = valorEmp.Year;
            month = valorEmp.Month;
            day = valorEmp.Day;
        }
        public override string ToString()
        {
            return valorEmp.ToShortDateString();
        }
        #endregion
    }
}
