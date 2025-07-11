using ShippingCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCalculator.Contract;

public interface IShipmentService
{
    InvoiceResponse Calculate(ShipmentDto dto);
}
