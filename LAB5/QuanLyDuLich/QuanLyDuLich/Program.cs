using System;
using System.Windows.Forms;
using QuanLyDuLich.Forms;

namespace QuanLyDuLich
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmMain()); // Chạy Form Main điều hướng của Hệ thống Du lịch
        }
    }
}