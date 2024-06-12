namespace Testing_Chart
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.pieChartShip = new System.Windows.Forms.ToolStripMenuItem();
            this.barChartShip = new System.Windows.Forms.ToolStripMenuItem();
            this.lineChartShip = new System.Windows.Forms.ToolStripMenuItem();
            this.testingShip = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(3, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1195, 645);
            this.panel1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pieChartShip,
            this.barChartShip,
            this.lineChartShip,
            this.testingShip});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1200, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // pieChartShip
            // 
            this.pieChartShip.Name = "pieChartShip";
            this.pieChartShip.Size = new System.Drawing.Size(55, 20);
            this.pieChartShip.Text = "圓餅圖";
            // 
            // barChartShip
            // 
            this.barChartShip.Name = "barChartShip";
            this.barChartShip.Size = new System.Drawing.Size(55, 20);
            this.barChartShip.Text = "長條圖";
            // 
            // lineChartShip
            // 
            this.lineChartShip.Name = "lineChartShip";
            this.lineChartShip.Size = new System.Drawing.Size(55, 20);
            this.lineChartShip.Text = "折線圖";
            // 
            // testingShip
            // 
            this.testingShip.Name = "testingShip";
            this.testingShip.Size = new System.Drawing.Size(43, 20);
            this.testingShip.Text = "元件";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1200, 675);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "圖表";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem pieChartShip;
        private System.Windows.Forms.ToolStripMenuItem barChartShip;
        private System.Windows.Forms.ToolStripMenuItem lineChartShip;
        private System.Windows.Forms.ToolStripMenuItem testingShip;
    }
}

