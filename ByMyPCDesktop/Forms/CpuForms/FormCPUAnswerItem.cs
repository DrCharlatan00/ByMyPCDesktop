using ByMyPcDesktop.ConnectToApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ByMyPCDesktop.Forms.CpuForms
{
    public partial class FormCPUAnswerItem : Form
    {
        private readonly ConnectorToApi connector;

        public FormCPUAnswerItem(ConnectorToApi connector)
        {
            InitializeComponent();
            this.connector = connector;
        }

        private async void FormCPUAnswerItem_Load(object sender, EventArgs e)
        {
            var data = await connector.GetCpuSmallsAsync();
            foreach (var item in data) {
                CpuView.Nodes[0].Nodes.Add(item.Name);
            }
        }
    }
}
