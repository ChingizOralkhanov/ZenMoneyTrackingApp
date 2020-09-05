using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using ZenMoney.Handlers;

namespace ZenMoney.Elements
{
    
    public partial class ExpencesForm : Form
    {
        formMain form;
        CollectedExpencesData Data = new CollectedExpencesData();
        public ExpencesForm()
        {
            InitializeComponent();
        }

        private void DateTimeBox_ValueChanged(object sender, EventArgs e)
        {
            var dateTime = dateTimeBox.Value;
            Data.TransactionTime = dateTime;
        }

 

        private void FromBox_TextChanged(object sender, EventArgs e)
        {
            var transaction = fromBox.Text;
            Data.TransactionReceived = transaction;
        }

        private void AmountBox_TextChanged(object sender, EventArgs e)
        {
            var amount = amountBox.Text;
            var convertedAmount = Convert.ToInt32(amount);
            Data.TransactionAmount = convertedAmount;
        }



        private void TypeBox_TextChanged(object sender, EventArgs e)
        {
            var cashOrCard = typeBox.Text;
            Data.TransactionType = cashOrCard;

        }

        public void AddButton_Click(object sender, EventArgs e)
        {   
            var collectExpencesData = new CollectInternalData(Data);
            Program.expencesList.Add(collectExpencesData);
            form = new formMain();
            form.Show();




        }
    }

    public class CollectedExpencesData
    {
        public DateTime TransactionTime { get; set; }
        public string TransactionName { get; set; }
        public string TransactionReceived { get; set; }
        public int TransactionAmount { get; set; }
        public string AccountName { get; set; }
        public string TransactionType { get; set; }

        public void CollectData(DateTime transactionTime, string transactionName, string transactionReceived, int transactionAmount, string accountName, string transactionType)
        {
            transactionTime = TransactionTime;
            transactionName = TransactionName;
            transactionReceived = TransactionReceived;
            transactionAmount = TransactionAmount;
            accountName = AccountName;
            transactionType = TransactionType;
        }
    }
}
