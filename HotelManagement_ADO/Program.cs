using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using HotelManagement_ADO.AdminForms;
using HotelManagement_ADO.BS_Layer;
using HotelManagement_ADO.EmployeeForms;
using HotelManagement_ADO.Interface;
using HotelManagement_ADO.ReportForm;

namespace HotelManagement_ADO
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new FormLogin());
            Application.Run(new ReportRevenue());
        }
    }
}
