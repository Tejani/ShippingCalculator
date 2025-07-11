using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCalculator.Models;

public class ShipmentDto
{
    public string ShipmentId { get; set; }
    public double WeightKg { get; set; }
    public double DistanceKm { get; set; }
    public bool IsExpress { get; set; }
    public bool IsFragile { get; set; }
    public string ClientCategory { get; set; }
}
