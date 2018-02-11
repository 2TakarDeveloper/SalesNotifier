using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SalesNotification.Core;

namespace SalesNotifier.App
{
    public partial class NotificationPage : MetroFramework.Forms.MetroForm
    {
        public NotificationPage()
        {
            InitializeComponent();
            metroGrid1.DataSource = NotificationManager.GetThreshHoldData();
        }
    }
}
