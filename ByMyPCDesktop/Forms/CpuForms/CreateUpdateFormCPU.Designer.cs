namespace ByMyPCDesktop.Forms.CpuForms
{
    partial class CreateUpdateFormCPU
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            UILabelName = new Label();
            UILabelSocket = new Label();
            nameBox = new TextBox();
            boxSocket = new ComboBox();
            checkBoxSocket = new CheckBox();
            UIRequiredBox = new GroupBox();
            UICpuOtherBox = new GroupBox();
            boxIsLive = new CheckBox();
            coresBox = new TextBox();
            frequencyBox = new TextBox();
            UICountCoresLabel = new Label();
            UIFrequencyLabel = new Label();
            wrongItemVarsProvider = new ErrorProvider(components);
            UIRequiredBox.SuspendLayout();
            UICpuOtherBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)wrongItemVarsProvider).BeginInit();
            SuspendLayout();
            // 
            // UILabelName
            // 
            UILabelName.AutoSize = true;
            UILabelName.Location = new Point(6, 36);
            UILabelName.Name = "UILabelName";
            UILabelName.Size = new Size(65, 15);
            UILabelName.TabIndex = 0;
            UILabelName.Text = "Name CPU";
            // 
            // UILabelSocket
            // 
            UILabelSocket.AutoSize = true;
            UILabelSocket.Location = new Point(20, 98);
            UILabelSocket.Name = "UILabelSocket";
            UILabelSocket.Size = new Size(36, 15);
            UILabelSocket.TabIndex = 0;
            UILabelSocket.Text = "Soket";
            // 
            // nameBox
            // 
            nameBox.BorderStyle = BorderStyle.FixedSingle;
            nameBox.Cursor = Cursors.IBeam;
            nameBox.Location = new Point(77, 33);
            nameBox.Name = "nameBox";
            nameBox.Size = new Size(152, 23);
            nameBox.TabIndex = 1;
            // 
            // boxSocket
            // 
            boxSocket.BackColor = Color.White;
            boxSocket.FlatStyle = FlatStyle.System;
            boxSocket.FormattingEnabled = true;
            boxSocket.Items.AddRange(new object[] { "AM4", "AM3+", "AM3", "AM2", "LGA775", "LGA1551", "LGA1155", "LGA2011" });
            boxSocket.Location = new Point(77, 95);
            boxSocket.Name = "boxSocket";
            boxSocket.Size = new Size(152, 23);
            boxSocket.TabIndex = 2;
            // 
            // checkBoxSocket
            // 
            checkBoxSocket.AutoSize = true;
            checkBoxSocket.Location = new Point(243, 97);
            checkBoxSocket.Name = "checkBoxSocket";
            checkBoxSocket.Size = new Size(56, 19);
            checkBoxSocket.TabIndex = 3;
            checkBoxSocket.Text = "Other";
            checkBoxSocket.UseVisualStyleBackColor = true;
            checkBoxSocket.CheckedChanged += checkBoxSocket_CheckedChanged;
            // 
            // UIRequiredBox
            // 
            UIRequiredBox.BackColor = Color.NavajoWhite;
            UIRequiredBox.Controls.Add(UILabelSocket);
            UIRequiredBox.Controls.Add(nameBox);
            UIRequiredBox.Controls.Add(checkBoxSocket);
            UIRequiredBox.Controls.Add(UILabelName);
            UIRequiredBox.Controls.Add(boxSocket);
            UIRequiredBox.Location = new Point(12, 12);
            UIRequiredBox.Name = "UIRequiredBox";
            UIRequiredBox.Size = new Size(321, 140);
            UIRequiredBox.TabIndex = 4;
            UIRequiredBox.TabStop = false;
            UIRequiredBox.Text = "Required";
            // 
            // UICpuOtherBox
            // 
            UICpuOtherBox.BackColor = SystemColors.InactiveCaption;
            UICpuOtherBox.Controls.Add(boxIsLive);
            UICpuOtherBox.Controls.Add(coresBox);
            UICpuOtherBox.Controls.Add(frequencyBox);
            UICpuOtherBox.Controls.Add(UICountCoresLabel);
            UICpuOtherBox.Controls.Add(UIFrequencyLabel);
            UICpuOtherBox.Location = new Point(347, 12);
            UICpuOtherBox.Name = "UICpuOtherBox";
            UICpuOtherBox.Size = new Size(441, 140);
            UICpuOtherBox.TabIndex = 5;
            UICpuOtherBox.TabStop = false;
            UICpuOtherBox.Text = "Not Necessarily";
            // 
            // boxIsLive
            // 
            boxIsLive.AutoSize = true;
            boxIsLive.Location = new Point(273, 68);
            boxIsLive.Name = "boxIsLive";
            boxIsLive.Size = new Size(84, 19);
            boxIsLive.TabIndex = 3;
            boxIsLive.Text = "CPU Is Live";
            boxIsLive.UseVisualStyleBackColor = true;
            // 
            // coresBox
            // 
            coresBox.Location = new Point(105, 90);
            coresBox.Name = "coresBox";
            coresBox.Size = new Size(30, 23);
            coresBox.TabIndex = 2;
            coresBox.Leave += coresBox_Leave;
            // 
            // frequencyBox
            // 
            frequencyBox.Location = new Point(105, 33);
            frequencyBox.Name = "frequencyBox";
            frequencyBox.Size = new Size(119, 23);
            frequencyBox.TabIndex = 1;
            frequencyBox.Leave += frequencyBox_Leave;
            // 
            // UICountCoresLabel
            // 
            UICountCoresLabel.AutoSize = true;
            UICountCoresLabel.Location = new Point(26, 93);
            UICountCoresLabel.Name = "UICountCoresLabel";
            UICountCoresLabel.Size = new Size(73, 15);
            UICountCoresLabel.TabIndex = 0;
            UICountCoresLabel.Text = "Count Cores";
            // 
            // UIFrequencyLabel
            // 
            UIFrequencyLabel.AutoSize = true;
            UIFrequencyLabel.Location = new Point(26, 36);
            UIFrequencyLabel.Name = "UIFrequencyLabel";
            UIFrequencyLabel.Size = new Size(62, 15);
            UIFrequencyLabel.TabIndex = 0;
            UIFrequencyLabel.Text = "Frequency";
            // 
            // wrongItemVarsProvider
            // 
            wrongItemVarsProvider.ContainerControl = this;
            // 
            // CreateUpdateFormCPU
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(UICpuOtherBox);
            Controls.Add(UIRequiredBox);
            Name = "CreateUpdateFormCPU";
            Text = "CUFormCPU";
            UIRequiredBox.ResumeLayout(false);
            UIRequiredBox.PerformLayout();
            UICpuOtherBox.ResumeLayout(false);
            UICpuOtherBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)wrongItemVarsProvider).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label UILabelName;
        private Label UILabelSocket;
        private TextBox nameBox;
        private ComboBox boxSocket;
        private CheckBox checkBoxSocket;
        private GroupBox UIRequiredBox;
        private GroupBox UICpuOtherBox;
        private Label UIFrequencyLabel;
        private CheckBox boxIsLive;
        private TextBox coresBox;
        private TextBox frequencyBox;
        private Label UICountCoresLabel;
        private ErrorProvider wrongItemVarsProvider;
    }
}