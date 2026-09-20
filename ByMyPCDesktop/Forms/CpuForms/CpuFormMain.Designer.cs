namespace ByMyPCDesktop.Forms.CpuForms
{
    partial class CpuFormMain
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
            CpuTable = new DataGridView();
            BtnGet = new Button();
            BoxDataView = new GroupBox();
            CounterPage = new Label();
            BtnPageUp = new Button();
            BtnPageDown = new Button();
            BtnGetFullDataPag = new Button();
            textSearchBox = new TextBox();
            UILabelByName = new Label();
            searchBox = new GroupBox();
            UISearchByID = new Label();
            UISearchImage = new PictureBox();
            pictureBox1 = new PictureBox();
            GuidSearchBox = new TextBox();
            ActionBox = new GroupBox();
            bntDelete = new Button();
            btnUpdate = new Button();
            btnCreate = new Button();
            ((System.ComponentModel.ISupportInitialize)CpuTable).BeginInit();
            BoxDataView.SuspendLayout();
            searchBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UISearchImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ActionBox.SuspendLayout();
            SuspendLayout();
            // 
            // CpuTable
            // 
            CpuTable.BackgroundColor = Color.Gainsboro;
            CpuTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CpuTable.Location = new Point(12, 12);
            CpuTable.Name = "CpuTable";
            CpuTable.Size = new Size(590, 351);
            CpuTable.TabIndex = 0;
            CpuTable.CellClick += CpuTable_CellClick;
            // 
            // BtnGet
            // 
            BtnGet.BackColor = Color.WhiteSmoke;
            BtnGet.FlatStyle = FlatStyle.Popup;
            BtnGet.Location = new Point(6, 22);
            BtnGet.Name = "BtnGet";
            BtnGet.Size = new Size(188, 30);
            BtnGet.TabIndex = 1;
            BtnGet.Text = "Get data";
            BtnGet.UseVisualStyleBackColor = false;
            BtnGet.Click += BtnGet_Click;
            // 
            // BoxDataView
            // 
            BoxDataView.BackColor = SystemColors.ControlLight;
            BoxDataView.Controls.Add(CounterPage);
            BoxDataView.Controls.Add(BtnPageUp);
            BoxDataView.Controls.Add(BtnPageDown);
            BoxDataView.Controls.Add(BtnGetFullDataPag);
            BoxDataView.Controls.Add(BtnGet);
            BoxDataView.FlatStyle = FlatStyle.System;
            BoxDataView.Location = new Point(608, 12);
            BoxDataView.Name = "BoxDataView";
            BoxDataView.Size = new Size(200, 144);
            BoxDataView.TabIndex = 2;
            BoxDataView.TabStop = false;
            BoxDataView.Text = "View data setting ";
            // 
            // CounterPage
            // 
            CounterPage.AutoSize = true;
            CounterPage.Location = new Point(91, 114);
            CounterPage.Name = "CounterPage";
            CounterPage.Size = new Size(13, 15);
            CounterPage.TabIndex = 4;
            CounterPage.Text = "1";
            // 
            // BtnPageUp
            // 
            BtnPageUp.Location = new Point(110, 105);
            BtnPageUp.Name = "BtnPageUp";
            BtnPageUp.Size = new Size(32, 33);
            BtnPageUp.TabIndex = 3;
            BtnPageUp.Text = "->";
            BtnPageUp.UseVisualStyleBackColor = true;
            BtnPageUp.Click += BtnPageUp_Click;
            // 
            // BtnPageDown
            // 
            BtnPageDown.Location = new Point(53, 105);
            BtnPageDown.Name = "BtnPageDown";
            BtnPageDown.Size = new Size(32, 33);
            BtnPageDown.TabIndex = 3;
            BtnPageDown.Text = "<-";
            BtnPageDown.UseVisualStyleBackColor = true;
            BtnPageDown.Click += BtnPageDown_Click;
            // 
            // BtnGetFullDataPag
            // 
            BtnGetFullDataPag.BackColor = Color.CadetBlue;
            BtnGetFullDataPag.FlatStyle = FlatStyle.Popup;
            BtnGetFullDataPag.Location = new Point(6, 66);
            BtnGetFullDataPag.Name = "BtnGetFullDataPag";
            BtnGetFullDataPag.Size = new Size(188, 23);
            BtnGetFullDataPag.TabIndex = 2;
            BtnGetFullDataPag.Text = "Get full data";
            BtnGetFullDataPag.UseVisualStyleBackColor = false;
            BtnGetFullDataPag.Click += BtnGetFullDataPag_Click;
            // 
            // textSearchBox
            // 
            textSearchBox.BorderStyle = BorderStyle.FixedSingle;
            textSearchBox.Location = new Point(6, 53);
            textSearchBox.Name = "textSearchBox";
            textSearchBox.Size = new Size(138, 23);
            textSearchBox.TabIndex = 3;
            textSearchBox.KeyDown += textSearchBox_KeyDown;
            // 
            // UILabelByName
            // 
            UILabelByName.AutoSize = true;
            UILabelByName.FlatStyle = FlatStyle.Flat;
            UILabelByName.Location = new Point(6, 35);
            UILabelByName.Name = "UILabelByName";
            UILabelByName.Size = new Size(91, 15);
            UILabelByName.TabIndex = 4;
            UILabelByName.Text = "Search by name";
            UILabelByName.Click += label1_Click;
            // 
            // searchBox
            // 
            searchBox.BackColor = SystemColors.ControlLight;
            searchBox.Controls.Add(UISearchByID);
            searchBox.Controls.Add(UISearchImage);
            searchBox.Controls.Add(pictureBox1);
            searchBox.Controls.Add(GuidSearchBox);
            searchBox.Controls.Add(textSearchBox);
            searchBox.Controls.Add(UILabelByName);
            searchBox.Location = new Point(608, 162);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(200, 149);
            searchBox.TabIndex = 5;
            searchBox.TabStop = false;
            searchBox.Text = "Search";
            // 
            // UISearchByID
            // 
            UISearchByID.AutoSize = true;
            UISearchByID.FlatStyle = FlatStyle.Popup;
            UISearchByID.Location = new Point(6, 82);
            UISearchByID.Name = "UISearchByID";
            UISearchByID.Size = new Size(72, 15);
            UISearchByID.TabIndex = 6;
            UISearchByID.Text = "Search By ID";
            // 
            // UISearchImage
            // 
            UISearchImage.Image = Properties.Resources.icons8_поиск_50;
            UISearchImage.Location = new Point(150, 100);
            UISearchImage.Name = "UISearchImage";
            UISearchImage.Size = new Size(28, 23);
            UISearchImage.SizeMode = PictureBoxSizeMode.StretchImage;
            UISearchImage.TabIndex = 5;
            UISearchImage.TabStop = false;
            UISearchImage.Click += UISearchID_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.icons8_поиск_50;
            pictureBox1.Location = new Point(150, 53);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(28, 23);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            pictureBox1.Click += UIPicSearchName_Click;
            // 
            // GuidSearchBox
            // 
            GuidSearchBox.BorderStyle = BorderStyle.FixedSingle;
            GuidSearchBox.Location = new Point(6, 100);
            GuidSearchBox.Name = "GuidSearchBox";
            GuidSearchBox.Size = new Size(138, 23);
            GuidSearchBox.TabIndex = 3;
            GuidSearchBox.KeyDown += GuidSearchBox_KeyDown;
            // 
            // ActionBox
            // 
            ActionBox.BackColor = Color.Wheat;
            ActionBox.Controls.Add(bntDelete);
            ActionBox.Controls.Add(btnUpdate);
            ActionBox.Controls.Add(btnCreate);
            ActionBox.FlatStyle = FlatStyle.Flat;
            ActionBox.Location = new Point(12, 369);
            ActionBox.Name = "ActionBox";
            ActionBox.Size = new Size(199, 143);
            ActionBox.TabIndex = 6;
            ActionBox.TabStop = false;
            ActionBox.Text = "Action CPU";
            // 
            // bntDelete
            // 
            bntDelete.BackColor = Color.LightCoral;
            bntDelete.FlatStyle = FlatStyle.Popup;
            bntDelete.Location = new Point(28, 114);
            bntDelete.Name = "bntDelete";
            bntDelete.Size = new Size(125, 23);
            bntDelete.TabIndex = 8;
            bntDelete.Text = "Delete";
            bntDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.Orange;
            btnUpdate.FlatStyle = FlatStyle.Popup;
            btnUpdate.Location = new Point(28, 67);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(125, 23);
            btnUpdate.TabIndex = 8;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DarkSeaGreen;
            btnCreate.FlatStyle = FlatStyle.Popup;
            btnCreate.Location = new Point(28, 22);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(125, 23);
            btnCreate.TabIndex = 7;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click;
            // 
            // CpuFormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(995, 531);
            Controls.Add(ActionBox);
            Controls.Add(searchBox);
            Controls.Add(BoxDataView);
            Controls.Add(CpuTable);
            MaximumSize = new Size(1011, 570);
            MinimumSize = new Size(1011, 570);
            Name = "CpuFormMain";
            Text = "Cpu Window";
            FormClosing += CpuFormMain_FormClosing;
            ((System.ComponentModel.ISupportInitialize)CpuTable).EndInit();
            BoxDataView.ResumeLayout(false);
            BoxDataView.PerformLayout();
            searchBox.ResumeLayout(false);
            searchBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)UISearchImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ActionBox.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private DataGridView CpuTable;
        private Button BtnGet;
        private GroupBox BoxDataView;
        private Button BtnGetFullDataPag;
        private Label CounterPage;
        private Button BtnPageUp;
        private Button BtnPageDown;
        private TextBox textSearchBox;
        private Label UILabelByName;
        private GroupBox searchBox;
        private PictureBox pictureBox1;
        private PictureBox UISearchImage;
        private TextBox GuidSearchBox;
        private Label UISearchByID;
        private GroupBox ActionBox;
        private Button bntDelete;
        private Button btnUpdate;
        private Button btnCreate;
    }
}