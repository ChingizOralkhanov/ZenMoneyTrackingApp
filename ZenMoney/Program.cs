using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZenMoney.Handlers;

namespace ZenMoney
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        public static List<CollectInternalData> expencesList = new List<CollectInternalData>();
        public static List<CollectInternaIncomelData> incomeList = new List<CollectInternaIncomelData>();

        [STAThread]
        static void Main()
        {
            
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new formMain());
 
        }
    }
}
