using ByMyPcDesktop.ConnectToApi;
using ByMyPCDesktop.Forms.CpuForms;

namespace ByMyPCDesktop
{
    public partial class MainForm : Form
    {
        private ConnectorToApi connector;

        public MainForm()
        {
            InitializeComponent();
             connector = new ConnectorToApi(new Uri("https://localhost:7055"));
        }

        private void CpuBtn_Click(object sender, EventArgs e)
        {
            var form = new CpuFormMain(connector);
            form.Show(this);
            this.Hide();
        }
    }
}
