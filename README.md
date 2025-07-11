# Invoice Calculation Engine - Logistics

### 🧾 Business Rules Applied:
1. BaseCharge = Weight * 5 + Distance * 2
2. Express adds 10% to base charge
3. Fragile adds ₹150 flat
4. Client Discount (on base + surcharge):
   - Gold: 15%
   - Silver: 10%
   - Bronze: 5%
5. FinalCharge = base + surcharge - discount (rounded)

### 📥 Input
See `Shipment.json`

### 📤 Sample Output
See console output

### ⚙ Assumptions
- Weight and Distance are always positive.
- ClientCategory is one of: Gold, Silver, Bronze. Others get 0% discount.
- Rounding is done to nearest rupee (Math.Round).

### Extensibility Strategy
- Future surcharges (e.g., fuel cost, tolls) can be added by implementing interfaces or a rules engine.
- Consider `IChargeRule` interface for pluggable rules.
