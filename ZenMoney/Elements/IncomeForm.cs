using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenMoney.Handlers;

namespace ZenMoney.Elements
{

    public partial class IncomeForm : Form
    {
        formMain form;
        CollectedIncomeData Data = new CollectedIncomeData();
        public IncomeForm()
        {
            InitializeComponent();
        }

        private void DateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            var dateTime = dateTimePicker1.Value;
            Data.Time = dateTime;
        }


        public class CollectedIncomeData
        {
            public DateTime Time { get; set; }

            public string Source { get; set; }
            public int Amount { get; set; }
            public string Type { get; set; }
        }

        private void TextBox5_TextChanged(object sender, EventArgs e)
        {
            var amount = textBox5.Text;
            Data.Amount = Convert.ToInt32(amount);
        }

        private void TextBox6_TextChanged(object sender, EventArgs e)
        {
            Data.Source = textBox6.Text;
        }

        private void TextBox7_TextChanged(object sender, EventArgs e)
        {
            Data.Type = textBox7.Text;
        }

        private void AddIncome_Click(object sender, EventArgs e)
        {
            var collectExpencesData = new CollectInternaIncomelData(Data);
            Program.incomeList.Add(collectExpencesData);
            form = new formMain();
            //form.FillIncomeForm();
            form.Show();

        }

    }
}
