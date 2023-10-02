using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Tina.Practice.CountMoney
{
    public partial class FormCalculate : Form
    {
        public FormCalculate()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            int totalAmount;
            decimal tipRate;
            int numberOfPeople;

            int.TryParse(textBoxTotal.Text, out totalAmount);
            decimal.TryParse(textBoxTip.Text, out tipRate);
            int.TryParse(textBoxPeople.Text, out numberOfPeople);

            var billCalculator = new BillCalculator();
            try 
            {
                IEnumerable<int> result = billCalculator.CalculateSplitAmount(totalAmount, tipRate, numberOfPeople);

                textBoxResult.Clear();

                var personAmounts = result.Select((amount, index) => $"第{index + 1}人, 應付 {amount} 元");
                textBoxResult.AppendText(string.Join(Environment.NewLine, personAmounts));
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show($"輸入錯誤:{ex.Message}");
            }
        }
        
    }
}
