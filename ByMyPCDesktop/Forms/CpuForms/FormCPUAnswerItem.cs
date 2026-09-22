using ByMyPcDesktop.ConnectToApi;
using ByMyPcDesktop.ConnectToApi.Models;
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
        public record CpuList(Guid Key, string Name);
        bool IsOne = true;
        private readonly ConnectorToApi connector;
        private List<CpuList> Cpus = new();
        public FormCPUAnswerItem(ConnectorToApi connector)
        {
            InitializeComponent();
            this.connector = connector;

        }

        private async void FormCPUAnswerItem_Load(object sender, EventArgs e)
        {
            var data = await connector.GetCpuSmallsAsync();
            foreach (var item in data)
            {
                CpuView.Nodes[0].Nodes.Add(item.Name);
                Cpus.Add(new CpuList(item.id,item.Name));
            }
        }

        private async void CpuView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (IsOne) {
                IsOne = false;
                return;
            }
            if (e.Node.Text is null) return;
            Guid? idCpu = Cpus.FirstOrDefault(x => x.Name == e?.Node?.Text).Key;
            if (idCpu is null) 
                return;
            
            CpuModelGet? item = await connector.GetByID((Guid)idCpu);
            if (item is null) 
                return;
            
            CreateUpdateFormCPU form = new CreateUpdateFormCPU(item);
            form.Show(Owner);
            this.Close();
        }
    }

   
}
