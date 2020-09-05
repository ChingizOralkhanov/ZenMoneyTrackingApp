using OfficeOpenXml;
using SautinSoft.Document;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TemplateEngine.Docx;
using ZenMoney.Elements;
using ZenMoney.Handlers;
using Telegram.Bot;
using Telegram.Bot.Args;
using Telegram.Bot.Types.ReplyMarkups;
namespace ZenMoney
{

    public partial class formMain : Form
    {
        string telegramTokenId = "1311273286:AAE7a5pNdkg4yMulothxUoq-qIU9yGSSA-Y";
        static ITelegramBotClient botClient;
        public formMain()
        {
            botClient = new TelegramBotClient(telegramTokenId);
            var responce = botClient.GetMeAsync().Result;
        
            botClient.OnMessage += Bot_OnMessage;
            botClient.OnCallbackQuery+=BotOnCallbackQueryReceived;

            botClient.StartReceiving();
            InitializeComponent();
            FillForm();
            FillIncomeForm();

        }
        static async void Bot_OnMessage(object sender, MessageEventArgs e)
        {
            var message = e.Message;
            if (e.Message.Text != null)
            {
                await botClient.SendTextMessageAsync(
                  chatId: e.Message.Chat,
                  text: "You said:\n" + e.Message.Text
                );
            }
            switch (message.Text)
            {
                case "/start":
                    string text = @"Список комманд:
                                    /start - запуск бота
                                    /menu - вывод меню
                                    /keyboard - вывод клавиатуры";
                   await botClient.SendTextMessageAsync(message.From.Id, text);
                    break;
                case "/menu":
                    var menuKeyboard = new InlineKeyboardMarkup( new[] {
                        new[]
                        {
                            InlineKeyboardButton.WithCallbackData("Добавить расход"),
                            InlineKeyboardButton.WithCallbackData("Добавить доход"),

                        },
                        new[]
                        {
                            InlineKeyboardButton.WithCallbackData("Oтчет Word"),
                            InlineKeyboardButton.WithCallbackData("Oтчет Excel"),
                            InlineKeyboardButton.WithCallbackData("Oтчет PDF"),
                        }

                    });
                    await botClient.SendTextMessageAsync(message.From.Id, "Выберите пункт меню",replyMarkup: menuKeyboard);
                    break;
                case "/keyboard":
                    break;
                default:
                    break;
            }
        }
        private static async void BotOnCallbackQueryReceived(object sender, Telegram.Bot.Args.CallbackQueryEventArgs e)
        {
            string buttonText = e.CallbackQuery.Data;
            string name = $"{e.CallbackQuery.From.FirstName} {e.CallbackQuery.From.LastName}";
            if (buttonText == "Добавить доход")
            {
                var telegramExpencesData = new CollectedExpencesData();
                telegramExpencesData.TransactionTime = e.CallbackQuery.Message.Date;
                string text = "Please enter the amount, spend on, and type (cash or credit)" + Environment.NewLine+
                    "For example: 1000, food, credit";

                await botClient.SendTextMessageAsync(e.CallbackQuery.From.Id, text);

            }
        }
        private static void addExpenceTelegramBot()
        {

        }
        private void formMain_Load(System.Object sender, System.EventArgs e)
        {
            
        }

        
        void MoveIndicator(Control btn)
        {
            indicator.Left = btn.Left;
            indicator.Width = btn.Width;
        }

        private void ButtonDashboard_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            this.layoutTabs.SelectTab("dashboardTab");
        }

        private void ButtonExpences_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            this.layoutTabs.SelectTab("expencesTab");
        }

        private void ButtonIncome_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            this.layoutTabs.SelectTab("incomeTab");
        }

        private void ButtonAccount_Click(object sender, EventArgs e)
        {
            MoveIndicator((Control)sender);
            this.layoutTabs.SelectTab("accountTab");
        }


        private void DateTimeBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SearchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddExpences_Click(object sender, EventArgs e)
        {
            var popupForm = new ExpencesForm();
            popupForm.Show();

        }
        private List<CollectedExpencesData> getExpences()
        {
            var list = new List<CollectedExpencesData>();

            foreach(var data in Program.expencesList)
            {   
                foreach(var expence in Program.expencesList)
                {
                    list.Add(expence.Data);
                }
                
            }
            return list;
        }

        public void FillForm()
        {
            int n = 1;
            int sum = 0;
       
            foreach (var item in Program.expencesList)
            {

                string[] row = new string[] { n.ToString(), item.Data.TransactionTime.ToString(),  item.Data.TransactionAmount.ToString(), item.Data.TransactionReceived, item.Data.TransactionType };

                dataGridView1.Rows.Add(row);
                sum += item.Data.TransactionAmount;
                n++;
            }

            expendituresNumber.Text = sum.ToString();
            int balance = Int32.Parse(label2.Text) - sum;
            label2.Text = balance.ToString();
        }
        public void FillIncomeForm()
        {
            int n = 1;
            int sum = 0;
            int balance = 0;
            foreach (var item in Program.incomeList)
            {

                string[] row = new string[] { n.ToString(), item.Data.Time.ToString(), item.Data.Amount.ToString(), item.Data.Source, item.Data.Type };

                dataGridView3.Rows.Add(row);
                sum += item.Data.Amount;
                n++;
            }

            IncomeNumber.Text = sum.ToString();
            balance = Int32.Parse(label2.Text) + sum;
            label2.Text = balance.ToString();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var incomePopup = new IncomeForm();
            incomePopup.Show();
        }

        private void GenerateButtton_Click(object sender, EventArgs e)
        {
            CreateXlsReport(Program.expencesList, Program.incomeList);

            MessageBox.Show("Отчет был создан");
        }

        public void CreateXlsReport(List<CollectInternalData> expencesData, List<CollectInternaIncomelData> incomeData)
        {
            string spreadsheetPath = "expences.xlsx";
            File.Delete(spreadsheetPath);

            var spreadsheetInfo = new FileInfo(spreadsheetPath);
      
            ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;

            var package = new ExcelPackage(spreadsheetInfo);
         
            var expencesWorkSheet = package.Workbook.Worksheets.Add("Expences");

            expencesWorkSheet.Cells["A1"].Value = "Number";
            expencesWorkSheet.Cells["B1"].Value = "Time";
            expencesWorkSheet.Cells["C1"].Value = "Amount";
            expencesWorkSheet.Cells["D1"].Value = "Spent on";
            expencesWorkSheet.Cells["E1"].Value = "Type";
            expencesWorkSheet.Cells["A1:L1"].Style.Font.Bold = true;
            expencesWorkSheet.Cells["B1:B25"].Style.Numberformat.Format = DateTimeFormatInfo.CurrentInfo.ShortDatePattern;
            expencesWorkSheet.Column(2).Width = 15;

            expencesWorkSheet.Cells["G1"].Value = "IncomeData";
            expencesWorkSheet.Cells["H1"].Value = "Number";
            expencesWorkSheet.Cells["I1"].Value = "Time";
            expencesWorkSheet.Cells["J1"].Value = "Amount";
            expencesWorkSheet.Cells["K1"].Value = "Source";
            expencesWorkSheet.Cells["L1"].Value = "Type";
            expencesWorkSheet.Cells["I1:I25"].Style.Numberformat.Format = DateTimeFormatInfo.CurrentInfo.ShortDatePattern;
            expencesWorkSheet.Column(9).Width = 15;
            expencesWorkSheet.Column(7).Width = 15;
            int currentRow = 2;
            int number = 1;
            foreach(var expence in expencesData)
            {
                expencesWorkSheet.Cells["A" + currentRow.ToString()].Value = number;
                expencesWorkSheet.Cells["B" + currentRow.ToString()].Value = expence.Data.TransactionTime;
                expencesWorkSheet.Cells["C" + currentRow.ToString()].Value = expence.Data.TransactionAmount;
                expencesWorkSheet.Cells["D" + currentRow.ToString()].Value = expence.Data.TransactionReceived;
                expencesWorkSheet.Cells["E" + currentRow.ToString()].Value = expence.Data.TransactionType;

               
                currentRow++;
                number++;
            }

            int incomeRow = 2;
            int incomeNumber = 1;
            foreach(var income in incomeData)
            {
                expencesWorkSheet.Cells["H" + incomeRow.ToString()].Value = incomeNumber;
                expencesWorkSheet.Cells["I" + incomeRow.ToString()].Value = income.Data.Time;
                expencesWorkSheet.Cells["J" + incomeRow.ToString()].Value = income.Data.Amount;
                expencesWorkSheet.Cells["K" + incomeRow.ToString()].Value = income.Data.Source;
                expencesWorkSheet.Cells["L" + incomeRow.ToString()].Value = income.Data.Type;

                incomeRow++;
                incomeNumber++;
            }


            expencesWorkSheet.View.FreezePanes(2, 1);
            expencesWorkSheet.Cells["C" + (currentRow).ToString()].Formula = "SUM(C2:C" + (currentRow - 1).ToString() + ")";
            expencesWorkSheet.Cells["A" + (currentRow).ToString()].Formula = "SUM(A2:A" + (currentRow - 1).ToString() + ")";
            expencesWorkSheet.Cells["A" + (currentRow).ToString()].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
            expencesWorkSheet.Cells["B" + (currentRow).ToString()].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
            expencesWorkSheet.Cells["C" + (currentRow).ToString()].Style.Border.Top.Style = OfficeOpenXml.Style.ExcelBorderStyle.Thin;
            package.Save();
        }

        private void ReportWord_Click(object sender, EventArgs e)
        {
            CreateWordFileReport(Program.expencesList, Program.incomeList);
            MessageBox.Show("Отчет был создан");

        }

        public void CreateWordFileReport(List<CollectInternalData> expencesData, List<CollectInternaIncomelData> incomeData)
        {
            File.Delete("OutputDocument.docx");
            File.Copy("InputTemplate.docx", "OutputDocument.docx");

            var tableContent = new TableContent("Expences Table");
            var incomeTableContent = new TableContent("Income Table");
            int number = 1;
            foreach(var expence in expencesData)
            {
                tableContent.AddRow(
                    new FieldContent("Number", number.ToString()),
                    new FieldContent("Time", expence.Data.TransactionTime.ToString()),
                    new FieldContent("Amount", expence.Data.TransactionAmount.ToString()),
                    new FieldContent("Spend on", expence.Data.TransactionReceived),
                    new FieldContent("Type", expence.Data.TransactionType));

            }

            foreach(var income in incomeData)
            {
                incomeTableContent.AddRow(
                   new FieldContent("Number", number.ToString()),
                   new FieldContent("Time", income.Data.Time.ToString()),
                   new FieldContent("Amount", income.Data.Amount.ToString()),
                   new FieldContent("Source", income.Data.Source),
                   new FieldContent("Type", income.Data.Type));
            }
            var valuesToFill = new Content(tableContent, incomeTableContent);
            using (var outputDocument = new TemplateProcessor("OutputDocument.docx")
                .SetRemoveContentControls(true))
            {
                outputDocument.FillContent(valuesToFill);
                outputDocument.SaveChanges();
            }
        }

        private void ReportPDF_Click(object sender, EventArgs e)
        {
            CreatePDFFIleReport();
            MessageBox.Show("Отчет был создан");
        }
        public void CreatePDFFIleReport()
        {
            CreateWordFileReport(Program.expencesList, Program.incomeList);
            var document = DocumentCore.Load(@"C:\Users\user\source\repos\ZenMoney\ZenMoney\bin\Debug\OutputDocument.docx");
            document.Save(@"C:\Users\user\source\repos\ZenMoney\ZenMoney\bin\Debug/report.pdf");

        }
    }
}

