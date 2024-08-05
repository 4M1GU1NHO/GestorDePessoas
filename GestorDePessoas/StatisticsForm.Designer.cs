namespace GestorDePessoas
{
    partial class StatisticsForm
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
            this.panelMen = new System.Windows.Forms.Panel();
            this.labelMen = new System.Windows.Forms.Label();
            this.panelWomen = new System.Windows.Forms.Panel();
            this.labelWomen = new System.Windows.Forms.Label();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.labelTotal = new System.Windows.Forms.Label();
            this.panelMen.SuspendLayout();
            this.panelWomen.SuspendLayout();
            this.panelTotal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMen
            // 
            this.panelMen.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panelMen.Controls.Add(this.labelMen);
            this.panelMen.Location = new System.Drawing.Point(0, 252);
            this.panelMen.Name = "panelMen";
            this.panelMen.Size = new System.Drawing.Size(347, 188);
            this.panelMen.TabIndex = 0;
            this.panelMen.MouseEnter += new System.EventHandler(this.panelMen_MouseEnter);
            this.panelMen.MouseLeave += new System.EventHandler(this.panelMen_MouseLeave);
            // 
            // labelMen
            // 
            this.labelMen.AutoSize = true;
            this.labelMen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMen.Location = new System.Drawing.Point(3, 12);
            this.labelMen.Name = "labelMen";
            this.labelMen.Size = new System.Drawing.Size(109, 20);
            this.labelMen.TabIndex = 1;
            this.labelMen.Text = "Meninos: 00%";
            // 
            // panelWomen
            // 
            this.panelWomen.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelWomen.Controls.Add(this.labelWomen);
            this.panelWomen.Location = new System.Drawing.Point(345, 252);
            this.panelWomen.Name = "panelWomen";
            this.panelWomen.Size = new System.Drawing.Size(346, 188);
            this.panelWomen.TabIndex = 1;
            this.panelWomen.MouseEnter += new System.EventHandler(this.panelWomen_MouseEnter);
            this.panelWomen.MouseLeave += new System.EventHandler(this.panelWomen_MouseLeave);
            // 
            // labelWomen
            // 
            this.labelWomen.AutoSize = true;
            this.labelWomen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelWomen.Location = new System.Drawing.Point(8, 12);
            this.labelWomen.Name = "labelWomen";
            this.labelWomen.Size = new System.Drawing.Size(109, 20);
            this.labelWomen.TabIndex = 2;
            this.labelWomen.Text = "Meninas: 00%";
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelTotal.Controls.Add(this.labelTotal);
            this.panelTotal.Location = new System.Drawing.Point(0, 0);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(691, 252);
            this.panelTotal.TabIndex = 1;
            this.panelTotal.MouseEnter += new System.EventHandler(this.panelTotal_MouseEnter);
            this.panelTotal.MouseLeave += new System.EventHandler(this.panelTotal_MouseLeave);
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(3, 9);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(187, 20);
            this.labelTotal.TabIndex = 0;
            this.labelTotal.Text = "Total de Estudantes: 000";
            // 
            // StatisticsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(689, 441);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.panelWomen);
            this.Controls.Add(this.panelMen);
            this.Name = "StatisticsForm";
            this.Text = "StatisticsForm";
            this.Load += new System.EventHandler(this.StatisticsForm_Load);
            this.panelMen.ResumeLayout(false);
            this.panelMen.PerformLayout();
            this.panelWomen.ResumeLayout(false);
            this.panelWomen.PerformLayout();
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMen;
        private System.Windows.Forms.Panel panelWomen;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelMen;
        private System.Windows.Forms.Label labelWomen;
    }
}