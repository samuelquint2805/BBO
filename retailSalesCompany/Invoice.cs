using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace retailSalesCompany
{
    public class Invoice
    {
        private static int invoiceCounter = 0;
        private List<iProduct> _products;
        public int InvoiceNumber = 0;


        public Invoice()
        {
            invoiceCounter++;
            _products = new List<iProduct>();
            InvoiceNumber = invoiceCounter;
        }

        // Agregar producto a la factura
        public void AddProduct(iProduct producto)
        {
            _products.Add(producto);
        }

        // Calcular total de la factura
        public decimal GetTotal()
        {
            decimal total = 0;
            foreach (var p in _products)
            {
                total += p.getPrice();
            }
            return total;
        }

        // Imprimir factura
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"INVOICE # {InvoiceNumber}");
            sb.AppendLine();

            foreach (var p in _products)
            {
                sb.AppendLine(p.getDetail());
            }

            sb.AppendLine("===========================");
            sb.AppendLine($"TOTAL: {GetTotal():C}");
            return sb.ToString();
        }

    }
}
