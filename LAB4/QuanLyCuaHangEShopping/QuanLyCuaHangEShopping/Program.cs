using System;
using System.Windows.Forms;
using QuanLyCuaHangEShopping.Forms;

namespace QuanLyCuaHangEShopping
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain()); // Chạy Form Main đầu tiên
        }
    }
}