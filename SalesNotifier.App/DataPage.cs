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
using SalesNotifier.Entity;
using SalesNotifier.Static;

namespace SalesNotifier.App
{
    public partial class DataPage : MetroFramework.Forms.MetroForm
    {
        private SalesData SelectedData { get; set; }
        public DataPage()
        {
            InitializeComponent();
            DataGrid.DataSource = Globals.StorageData;
        }

        private void UpdateData_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                Parser.ExcelParser.ExcelReader(openFileDialog1.FileName);
                DataProvider.UpdateData();
                DataGrid.DataSource = Globals.StorageData;
            }
        }

        private void DataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            SelectedData = (SalesData)DataGrid.SelectedRows[0].DataBoundItem;
            Support1Upper.Value = (decimal)SelectedData.SupportRange1.SupportRange.UpperLimit;
            Support1Lower.Value = (decimal)SelectedData.SupportRange1.SupportRange.LowerLimit;
            Support2Upper.Value = (decimal)SelectedData.SupportRange2.SupportRange.UpperLimit;
            Support2Lower.Value = (decimal)SelectedData.SupportRange2.SupportRange.LowerLimit;
        }

        private void Support1Upper_ValueChanged(object sender, EventArgs e)
        {
            SelectedData.SupportRange1.SupportRange.UpperLimit = (double)Support1Upper.Value;
            SaveData();
        }

        private void Support1Lower_ValueChanged(object sender, EventArgs e)
        {
            SelectedData.SupportRange1.SupportRange.LowerLimit = (double)Support1Lower.Value;
            SaveData();
        }

        private void Support2Upper_ValueChanged(object sender, EventArgs e)
        {
            SelectedData.SupportRange2.SupportRange.UpperLimit = (double)Support2Upper.Value;
            SaveData();
        }

        private void Support2Lower_ValueChanged(object sender, EventArgs e)
        {
            SelectedData.SupportRange2.SupportRange.LowerLimit = (double)Support2Lower.Value;
            SaveData();
        }

        private void SaveData()
        {
            Globals.StorageData = (List<SalesData>)DataGrid.DataSource;
        }

    }
}
