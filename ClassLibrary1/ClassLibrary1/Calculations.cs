using System.Collections;

namespace ClassLibrary1
{
    public class Calculations
    {
        int discount;
        int category;
        String purpose;

        public Calculations(int discount, int category, String purpose)
        {
            this.category = category;
            this.purpose = purpose;
            this.discount = discount;

        }

        public double CostPriem()
        {
            double result = 0;
            double startcost = 0;
            if (purpose.Equals("Консультация")) {
                startcost = 1000 * category;
                
            }
            else if (purpose.Equals("Обследование"))
            {
                startcost = 2 * 1000 * category;
                

            }
            else if (purpose.Equals("Лечение"))
            {
                startcost = 3 * 1000 * category;
                
            }
            else
            {
                return 0;
            }
            double itogdisc = 0.01 * discount * startcost;
            result = startcost - itogdisc;
            return result;
        }
    }
}