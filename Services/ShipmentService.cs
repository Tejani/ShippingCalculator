using ShippingCalculator.Contract;
using ShippingCalculator.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShippingCalculator.Services;

public class ShipmentService : IShipmentService
{
    public InvoiceResponse Calculate(ShipmentDto dto)
    {
        double baseCharge = (dto.WeightKg * 5) + (dto.DistanceKm * 2);
        double surcharge = 0;

        // Express adds 10% to base
        if (dto.IsExpress)
            surcharge += baseCharge * 0.10;

        // Fragile adds flat 150
        if (dto.IsFragile)
            surcharge += 150;

        double subtotal = baseCharge + surcharge;

        // Discounts
        var discountRates = new Dictionary<string, double>(StringComparer.OrdinalIgnoreCase)
        {
            { "Gold", 0.15 },
            { "Silver", 0.10 },
            { "Bronze", 0.05 }
        };

        double discountPercentage = discountRates.TryGetValue(dto.ClientCategory, out var rate) ? rate : 0.0;

        double discount = subtotal * discountPercentage;

        return new InvoiceResponse
        {
            ShipmentId = dto.ShipmentId,
            BaseCharge = Math.Round(baseCharge),
            Surcharge = Math.Round(surcharge),
            Discount = Math.Round(discount),
            FinalCharge = Math.Round(baseCharge + surcharge - discount)
        };
    }
}
