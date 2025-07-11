using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCalculator.Models;

public class InvoiceResponse
{
    public string ShipmentId { get; set; }
    public double BaseCharge { get; set; }
    public double Surcharge { get; set; }
    public double Discount { get; set; }
    public double FinalCharge { get; set; }
}
