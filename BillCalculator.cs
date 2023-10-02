using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tina.Practice.CountMoney
{
    public class BillCalculator
    {
        public IEnumerable<int> CalculateSplitAmount(int totalAmount, decimal tipRate, int numberOfPeople)
        {
            if (totalAmount <= 0)
            {
                throw new ArgumentException("輸入的總金額需大於零", nameof(totalAmount));
            }
            if (tipRate < 0)
            {
                throw new ArgumentException("輸入的小費需大於等於零%", nameof(tipRate));
            }
            if (numberOfPeople <= 0)
            {
                throw new ArgumentException("輸入的人數需大於零", nameof(numberOfPeople));
            }

            decimal tipAmount = 0;          //小費金額
            decimal totalAmountAndTip = 0;  //總消費金額(總金額+小費)
            decimal amountPerPerson = 0;    //每個人要付的錢
            int amountIntPerPerson = 0;     //每個人付的錢(無條件捨去)
            int remainingAmount = 0;        //剩餘要分配的錢


            tipAmount = totalAmount * tipRate * 0.01M;
            totalAmountAndTip = totalAmount + tipAmount;
            amountPerPerson = totalAmountAndTip / numberOfPeople;
            amountIntPerPerson = Convert.ToInt32(Math.Floor(amountPerPerson));
            remainingAmount = (int)totalAmountAndTip - (amountIntPerPerson * numberOfPeople);

            List<int> amounts = new List<int>();
            int amountIntPerPersonAdd = amountIntPerPerson+1;
            for (int i = 0; i < numberOfPeople; i++)
            {
                if (remainingAmount > 0)
                {
                    remainingAmount--;
                    amounts.Add(amountIntPerPersonAdd);
                }
                else {
                    amounts.Add(amountIntPerPerson);
                }
            }
            return amounts;
        }
    }
}
