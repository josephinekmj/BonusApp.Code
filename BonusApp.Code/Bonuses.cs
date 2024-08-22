using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusApp.Code
{
    public class Bonuses
    {
        public static double TenPercent(double amount)
        {
            return amount / 10.0; // Beregner 10% af beløbet
        }

        public static double FlatTwoIfAmountMoreThanFive(double amount)
        {
            return amount > 5.0 ? 2.0 : 0.0; // Returnerer 2.0 hvis beløbet er større end 5.0
        }
    }
}

