using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesNotifier.Static;

namespace SalesNotifier.App
{
    public partial class MainPage : MetroFramework.Forms.MetroForm
    {
        public MainPage()
        {
            InitializeComponent();
            Globals.FilePath = Path.Combine(Environment.GetFolderPath(
                Environment.SpecialFolder.ApplicationData), "data.json");
        }

        private void Data_Click(object sender, EventArgs e)
        {
            DataPage dataPage= new DataPage();
            dataPage.ShowDialog();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Notifications_Click(object sender, EventArgs e)
        {
            NotificationPage notificationPage= new NotificationPage();
            notificationPage.ShowDialog();
        }
    }
}
