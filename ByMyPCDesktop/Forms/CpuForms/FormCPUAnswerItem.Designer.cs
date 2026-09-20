namespace ByMyPCDesktop.Forms.CpuForms
{
    partial class FormCPUAnswerItem
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
            TreeNode treeNode1 = new TreeNode("CPU");
            CpuView = new TreeView();
            SuspendLayout();
            // 
            // CpuView
            // 
            CpuView.Location = new Point(12, 12);
            CpuView.Name = "CpuView";
            treeNode1.Name = "CpuNode";
            treeNode1.Text = "CPU";
            CpuView.Nodes.AddRange(new TreeNode[] { treeNode1 });
            CpuView.Size = new Size(418, 482);
            CpuView.TabIndex = 1;
            // 
            // FormCPUAnswerItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 506);
            Controls.Add(CpuView);
            MaximumSize = new Size(458, 545);
            MinimumSize = new Size(458, 545);
            Name = "FormCPUAnswerItem";
            Text = "FormCPUAnswerItem";
            Load += FormCPUAnswerItem_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView CpuView;
    }
}