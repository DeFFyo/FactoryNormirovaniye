using System;
using System.Windows.Forms;

namespace Normirovanie
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                using (var db = new WorkDBContext())
                {
                    db.Database.CreateIfNotExists();
                }
                Application.Run(new Form1());
            }
            catch (System.ArgumentException)
            {
                return;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Подробнее:\n\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
