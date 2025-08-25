using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retailSalesCompany
{
    // clase IProduct se usa como un contrato para los productos, tambien se puede usar para otros servicios extras
    public interface iProduct
    {
        int idPr { get; }
        string Name { get; }
        //metodo para obtener el precio del producto mas adelante
        decimal getPrice();
        string getDetail();
        
    }
}
