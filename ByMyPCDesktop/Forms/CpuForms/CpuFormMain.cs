using ByMyPcDesktop.ConnectToApi;
using ByMyPcDesktop.ConnectToApi.Exceptions;
using ByMyPcDesktop.ConnectToApi.Models;
using System.ComponentModel;

namespace ByMyPCDesktop.Forms.CpuForms
{
    public partial class CpuFormMain : Form
    {
        BindingSource bindingSource = new();
        private readonly ConnectorToApi connector;
        string ClickedID = string.Empty;

        public CpuFormMain(ConnectorToApi connector)
        {
            InitializeComponent();
            this.connector = connector;

            CpuTable.ReadOnly = true;
            CpuTable.DataSource = bindingSource;
        }

        private async void BtnGet_Click(object sender, EventArgs e)
        {
            await GetSmallData();
        }

        private async Task GetSmallData()
        {
            try
            {
                await FrozeUI();

                var data = await connector.GetCpuSmallsAsync();

                var bindList = new BindingList<CpuSmallModel>(data.ToList());

                bindingSource.DataSource = bindList;
                await UnFrozeUI();
            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(this, $"Data not get {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif

#if !DEBUG
                MessageBox.Show(this,$"Cpu not get, posible service close","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

#endif
                await UnFrozeUI();

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
                await FrozeUI();
                IEnumerable<CpuModelGet> data = await connector.GetWithPagFull(Convert.ToInt32(CounterPage.Text), 15);

                bindingSource.DataSource = new BindingList<CpuModelGet>(data.ToList());
                await UnFrozeUI();

            }
            catch (Exception ex)
            {
#if DEBUG
                MessageBox.Show(this, $"Data not get {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
#endif

#if !DEBUG
                MessageBox.Show(this,$"Cpu not get, posible service close","Error",MessageBoxButtons.OK,MessageBoxIcon.Error);

#endif
                await UnFrozeUI();

            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private async void UIPicSearchName_Click(object sender, EventArgs e)
        {
            await FrozeUI();
            await SearchByName();
            await UnFrozeUI();
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
            await FrozeUI();
            bool flowControl = await GetByID();
            if (!flowControl)
            {
                await UnFrozeUI();
                return;
            }
            await UnFrozeUI();

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
        #region Froze and Unfroze

        private async Task FrozeUI()
        {
            ActionBox.Enabled = false;
            searchBox.Enabled = false;
            BoxDataView.Enabled = false;
        }

        private async Task UnFrozeUI()
        {
            ActionBox.Enabled = true;
            searchBox.Enabled = true;
            BoxDataView.Enabled = true;
        }
        #endregion
        private async void GuidSearchBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await FrozeUI();
                await GetByID();
                await UnFrozeUI();
            }
        }

        private void CpuTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                ClickedID = CpuTable.Rows[e.RowIndex].Cells["ID"].Value.ToString() ?? "";

            }
        }

        #region Create Update Delete
        private void btnCreate_Click(object sender, EventArgs e)
        {
            CreateUpdateFormCPU formUpdate = new(connector);
            Hide();
            formUpdate.Show(this);
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(ClickedID))
            {
                FormCPUAnswerItem form = new FormCPUAnswerItem(connector);
                Hide();
                form.ShowDialog(this);
                return;
            }
            CpuModelGet? cpu = await connector.GetByID(ClickedID);
            if (cpu is null)
            {
                MessageBox.Show(this, "This CPU is not avaible now", "CPU not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            CreateUpdateFormCPU formUpdate = new(connector, cpu);
            Hide();
            formUpdate.Show(this);

        }
        

        private async void bntDelete_Click(object sender, EventArgs e)
        {
            await FrozeUI();
            DialogResult dialogResult = MessageBox.Show(this,"You a sure delete CPU","Delete Cpu",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (dialogResult == DialogResult.No) return;
            if (ClickedID != string.Empty)
            {
                try
                {
                    await connector.DeleteCpuAsync(Guid.Parse(ClickedID));
                }
                catch (ApiOperationFailed<object>)
                {
                    MessageBox.Show(this, "This CPU not removed, please check cpu is database", "CPU not removed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (ApiGetException)
                {
                    MessageBox.Show(this, "This CPU is not avaible now, please update table", "CPU not found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception) {
                    MessageBox.Show(this, "unexpect CPU not removed, please call administrator", "CPU remove Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                await GetSmallData();
            }
            
        }
        #endregion
    }
}
