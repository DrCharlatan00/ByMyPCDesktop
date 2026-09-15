namespace ByMyPCDesktop
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            CpuBtn = new Button();
            SuspendLayout();
            // 
            // CpuBtn
            // 
            CpuBtn.Location = new Point(38, 43);
            CpuBtn.Name = "CpuBtn";
            CpuBtn.Size = new Size(133, 106);
            CpuBtn.TabIndex = 0;
            CpuBtn.Text = "Go to Cpu Window";
            CpuBtn.UseVisualStyleBackColor = true;
            CpuBtn.Click += CpuBtn_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(CpuBtn);
            Name = "MainForm";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button CpuBtn;
    }
}
