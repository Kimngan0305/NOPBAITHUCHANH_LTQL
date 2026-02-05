using QuanLybanHang.Forms;
using QuanLyBanHang.Forms;



namespace QuanLybanHang
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new frmSanPham());
          


        }
    }
}