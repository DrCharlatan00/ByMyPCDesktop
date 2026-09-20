using ByMyPcDesktop.ConnectToApi;
using ByMyPcDesktop.ConnectToApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace ByMyPCDesktop.Forms.CpuForms
{
    public partial class CpuFormMain : Form
    {
        BindingSource bindingSource = new();
        private readonly ConnectorToApi connector;

        public CpuFormMain(ConnectorToApi connector)
        {
            InitializeComponent();
            this.connector = connector;

            CpuTable.ReadOnly = true;
            CpuTable.DataSource = bindingSource;
        }

        private async void BtnGet_Click(object sender, EventArgs e)
        {
            try
            {
                var data = await connector.GetCpuSmallsAsync();

                var bindList = new BindingList<CpuSmallModel>(data.ToList());

                bindingSource.DataSource = bindList;
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(this, $"Data not get {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif

#if !DEBUG
                MessageBox.Show(this,$"Cpu not get, posible service close","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

#endif
            }
        }

        private void CpuFormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Owner?.Show();
        }

        private void BtnPageDown_Click(object sender, EventArgs e)
        {
            CounterPage.Text = (Convert.ToInt32(CounterPage.Text) - 1).ToString();

        }

        private void BtnPageUp_Click(object sender, EventArgs e)
        {
            CounterPage.Text = (Convert.ToInt32(CounterPage.Text) + 1).ToString();
        }

        private async void BtnGetFullDataPag_Click(object sender, EventArgs e)
        {
            try
            {
                IEnumerable<CpuModelGet> data = await connector.GetWithPagFull(Convert.ToInt32(CounterPage.Text), 5);

                bindingSource.DataSource = new BindingList<CpuModelGet>(data.ToList());
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(this, $"Data not get {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif

#if !DEBUG
                MessageBox.Show(this,$"Cpu not get, posible service close","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

#endif
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void UIPicSearchName_Click(object sender, EventArgs e)
        {
            await SearchByName();
        }

        private async Task SearchByName()
        {
            try
            {
                var data = await connector.SearchByNameCpu(textSearchBox.Text ?? "");

                bindingSource.DataSource = new BindingList<CpuModelGet>(data.ToList());
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(this, $"Data not get {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif

#if !DEBUG
                MessageBox.Show(this,$"Cpu not get, posible service close","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

#endif
            }
        }

        private async void textSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await SearchByName();
            }
        }

        private async void UISearchID_Click(object sender, EventArgs e)
        {
            bool flowControl = await GetByID();
            if (!flowControl)
            {
                return;
            }

        }

        private async Task<bool> GetByID()
        {
            try
            {
                var data = await connector.GetByID(GuidSearchBox.Text ?? "");
                if (data is null)
                {
                    MessageBox.Show(this, "CPU Not found", "Item Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return false;
                }
                IList<CpuModelGet> cpu = [data!];
                bindingSource.DataSource = new BindingList<CpuModelGet>(cpu);
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(this, $"Data not get or wrong GUID \n message: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif

#if !DEBUG
                MessageBox.Show(this,$"GUID Is not valid, please enter valid GUID","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

#endif
            }

            return true;
        }

        private async void GuidSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            await GetByID();
        }
    }
}
