using ByMyPcDesktop.ConnectToApi;
using ByMyPcDesktop.ConnectToApi.Exceptions;
using ByMyPcDesktop.ConnectToApi.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging.Effects;
using System.Text;
using System.Windows.Forms;


namespace ByMyPCDesktop.Forms.CpuForms
{
    public partial class CreateUpdateFormCPU : Form
    {
        private TextBox textBox = new();
        private bool IsUpdate = false;
        private Guid UpdatedModelID;
        private readonly ConnectorToApi connector;

        public CreateUpdateFormCPU(ConnectorToApi connector)
        {
            InitializeComponent();
            textBox.Size = boxSocket.Size;
            textBox.Location = boxSocket.Location;
            textBox.Visible = false;
            Controls.Add(textBox);
            textBox.BringToFront();
            btnAccept.Text = "Create";
            UpdatedModelID = Guid.Empty;
            this.connector = connector;
        }

        public CreateUpdateFormCPU(ConnectorToApi connector, CpuModelGet model) : this(connector)
        {
            nameBox.Text = model.Name;
            boxSocket.Text = model.Socket;
            frequencyBox.Text = model.Frequency.ToString();
            coresBox.Text = model.Count_Cores.ToString();
            boxIsLive.Checked = model.IsLive;
            IsUpdate = true;
            btnAccept.Text = "Update";
            UpdatedModelID = model.id;
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

        private async void btnAccept_Click(object sender, EventArgs e)
        {



            if (IsUpdate)
            {
                DTOCpuUpdateModel dto;

                try
                {
                    DTOCpuUpdateModel dtoCheck = new(
                        UpdatedModelID,
                        nameBox.Text,
                        checkBoxSocket.Checked == true ? textBox.Text : boxSocket.Text,
                        Convert.ToInt32(frequencyBox.Text),
                        Convert.ToInt32(coresBox.Text),
                        boxIsLive.Checked
                        );
                    dto = dtoCheck;
                }
                catch
                {
                    DialogResult dialogResult = MessageBox.Show(this, "One of the parameters you entered is incorrect; please double-check the data.", "Mistake with parameters", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    if (dialogResult == DialogResult.Cancel)
                    {
                        Owner?.Show();
                        Close();
                        return;
                    }
                    return;
                }
                try
                {
                    CpuModelGet result = await connector.UpdateAsync(dto);
#if DEBUG
                    MessageBox.Show(this, $"Item: {result.id}  \n Name:{result.Name}");
                    return;
#endif
#pragma warning disable CS0162 // IDE Joke
                    MessageBox.Show(this, $"Cpu Update successfully : {result.id}", "Operation result", MessageBoxButtons.OK, MessageBoxIcon.Information);
#pragma warning restore CS0162 // IDE Joke
                }
                catch (ApiOperationFailed<object> ex)
                {
#if DEBUG
                    MessageBox.Show(ex.Message + ex.ItemThrow.GetType().FullName);
                    return;
#endif
#pragma warning disable CS0162 // IDE Joke
                    MessageBox.Show(this, "Operation update failed", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
#pragma warning restore CS0162 // IDE Joke

                }
                catch (ArgumentException ex)
                {
#if DEBUG
                    MessageBox.Show(ex.Message);
                    return;
#endif
#pragma warning disable CS0162 // IDE Joke
                    MessageBox.Show(this, "Operation update failed, data is wrong", "Mistake with data", MessageBoxButtons.OK, MessageBoxIcon.Error);
#pragma warning restore CS0162 // IDE Joke
                }


            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Owner?.Show();
            Close();
        }
    }
}
