namespace ColorProject
{
    partial class Form1
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
            this.leftPanel = new System.Windows.Forms.Panel();
            this.leftColorPanel = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();
            this.rightLabel = new System.Windows.Forms.Label();
            this.topPanel = new System.Windows.Forms.Panel();
            this.topLabel = new System.Windows.Forms.Label();
            this.leftPanel.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // leftPanel
            // 
            this.leftPanel.Controls.Add(this.leftColorPanel);
            this.leftPanel.Location = new System.Drawing.Point(1, 100);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(399, 399);
            this.leftPanel.TabIndex = 0;
            // 
            // leftColorPanel
            // 
            this.leftColorPanel.Location = new System.Drawing.Point(9, 49);
            this.leftColorPanel.Name = "leftColorPanel";
            this.leftColorPanel.Size = new System.Drawing.Size(380, 300);
            this.leftColorPanel.TabIndex = 0;
            this.leftColorPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.leftColorPanel_Paint);
            // 
            // rightPanel
            // 
            this.rightPanel.Controls.Add(this.rightLabel);
            this.rightPanel.Location = new System.Drawing.Point(400, 100);
            this.rightPanel.Name = "rightPanel";
            this.rightPanel.Size = new System.Drawing.Size(399, 399);
            this.rightPanel.TabIndex = 1;
            // 
            // rightLabel
            // 
            this.rightLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightLabel.Location = new System.Drawing.Point(9, 164);
            this.rightLabel.Name = "rightLabel";
            this.rightLabel.Size = new System.Drawing.Size(380, 70);
            this.rightLabel.TabIndex = 0;
            this.rightLabel.Text = "WordTextBox";
            this.rightLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rightLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.rightLabel_Paint);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.topLabel);
            this.topPanel.Location = new System.Drawing.Point(1, 1);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(798, 99);
            this.topPanel.TabIndex = 1;
            this.topPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.topPanel_Paint);
            // 
            // topLabel
            // 
            this.topLabel.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.topLabel.Location = new System.Drawing.Point(9, 14);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(780, 70);
            this.topLabel.TabIndex = 1;
            this.topLabel.Text = "WordTextBox";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.topLabel.Paint += new System.Windows.Forms.PaintEventHandler(this.topLabel_Paint);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.leftPanel);
            this.Controls.Add(this.rightPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.leftPanel.ResumeLayout(false);
            this.rightPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel leftPanel;
        private System.Windows.Forms.Panel rightPanel;
        private System.Windows.Forms.Panel leftColorPanel;
        private System.Windows.Forms.Label rightLabel;
        private System.Windows.Forms.Panel topPanel;
        private System.Windows.Forms.Label topLabel;
    }
}

