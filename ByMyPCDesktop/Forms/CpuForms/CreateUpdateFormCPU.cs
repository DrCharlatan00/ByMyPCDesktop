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
    public partial class CreateUpdateFormCPU : Form
    {
        private TextBox textBox = new();
        public CreateUpdateFormCPU()
        {
            InitializeComponent();
            textBox.Size = boxSocket.Size;
            textBox.Location = boxSocket.Location;
            textBox.Visible = false;
            Controls.Add(textBox);
            textBox.BringToFront();

        }

        public CreateUpdateFormCPU(CpuModelGet model) : this()
        {
            nameBox.Text = model.Name;
            boxSocket.Text = model.Socket;
            frequencyBox.Text = model.Frequency.ToString();
            coresBox.Text = model.Count_Cores.ToString();
            boxIsLive.Checked = model.IsLive;
        }

        private void checkBoxSocket_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxSocket.Checked)
            {
                boxSocket.Visible = false;
                textBox.Visible = true;
                return;
            }
            boxSocket.Visible = true;
            textBox.Visible = false;
        }

        private void frequencyBox_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(frequencyBox.Text);
            }
            catch
            {
                wrongItemVarsProvider.SetError(frequencyBox, "The frequency must consist only of a number.");
                return;
            }
            wrongItemVarsProvider.Clear();
        }

        private void coresBox_Leave(object sender, EventArgs e)
        {
            try
            {
                Convert.ToInt32(coresBox.Text);
            }
            catch
            {
                wrongItemVarsProvider.SetError(coresBox, "The Cores CPU must consist only of a number.");
                return;
            }
            wrongItemVarsProvider.Clear();
        }
    }
}
