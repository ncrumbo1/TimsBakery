using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TimsBakery.modules
{
    class RegisterCalculations
   {
      public decimal Subtotal { get; private set; } = 0m;
      public decimal TaxRate { get; set; } = 0.08m;  // 8% tax
      public decimal Discount { get; set; } = 0.00m; // Future-proofing

      public Dictionary<string, decimal> ProductPrices { get; } = new Dictionary<string, decimal>()
        {
            { "Donut", 1.25m },
            { "Coffee", 2.50m },
            { "Bagel", 2.00m },
            { "Muffin", 2.75m },
            { "Latte", 3.25m },
            { "Iced Coffee", 2.75m },
            { "Croissant", 3.00m },
            { "Cookie", 1.50m }
        };

      public string AddItem(string product, int quantity)
      {
         if (!ProductPrices.ContainsKey(product) || quantity <= 0)
            return null;

         decimal unitPrice = ProductPrices[product];
         decimal lineTotal = quantity * unitPrice;
         Subtotal += lineTotal;

         return $"{quantity}x {product.PadRight(12)} ${lineTotal:F2}";
      }

      public decimal GetTax()
      {
         return Subtotal * TaxRate;
      }

      public decimal GetTotal()
      {
         return Subtotal + GetTax() - Discount;
      }

      public void Reset()
      {
         Subtotal = 0m;
         Discount = 0m;
      }
   }
}
