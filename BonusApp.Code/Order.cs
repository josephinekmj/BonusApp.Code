using BonusApp.Code;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp.Code
{
    public class Order
{
    private List<Product> _products = new List<Product>();

    public Func<double, double> Bonus { get; set; } // Ændring fra BonusProvider til Func<double, double>

    public void AddProduct(Product p)
    {
        _products.Add(p);
    }

    public double GetValueOfProducts()
    {
        return _products.Sum(p => p.Value);
    }

    // Original GetBonus metode
    public double GetBonus()
    {
        return Bonus(GetValueOfProducts());
    }

    // Overloaded GetBonus metode
    public double GetBonus(Func<double, double> bonusCalculation)
    {
        return bonusCalculation(GetValueOfProducts());
    }

    // Original GetTotalPrice metode
    public double GetTotalPrice()
    {
        return GetValueOfProducts() - GetBonus();
    }

    // Overloaded GetTotalPrice metode
    public double GetTotalPrice(Func<double, double> bonusCalculation)
    {
        return GetValueOfProducts() - GetBonus(bonusCalculation);
    }
}
}
