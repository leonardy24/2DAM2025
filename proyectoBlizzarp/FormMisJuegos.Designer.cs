namespace proyectoBlizzarp
{
    partial class FormMisJuegos
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
            this.labelMisJuegos = new System.Windows.Forms.Label();
            this.flowLayoutPanelMisJuegos = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // labelMisJuegos
            // 
            this.labelMisJuegos.AutoSize = true;
            this.labelMisJuegos.BackColor = System.Drawing.Color.Transparent;
            this.labelMisJuegos.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMisJuegos.ForeColor = System.Drawing.Color.White;
            this.labelMisJuegos.Location = new System.Drawing.Point(31, 32);
            this.labelMisJuegos.Name = "labelMisJuegos";
            this.labelMisJuegos.Size = new System.Drawing.Size(270, 54);
            this.labelMisJuegos.TabIndex = 0;
            this.labelMisJuegos.Text = "Mis Juegos";
            // 
            // flowLayoutPanelMisJuegos
            // 
            this.flowLayoutPanelMisJuegos.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelMisJuegos.Location = new System.Drawing.Point(30, 113);
            this.flowLayoutPanelMisJuegos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanelMisJuegos.Name = "flowLayoutPanelMisJuegos";
            this.flowLayoutPanelMisJuegos.Size = new System.Drawing.Size(1345, 609);
            this.flowLayoutPanelMisJuegos.TabIndex = 1;
            this.flowLayoutPanelMisJuegos.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelMisJuegos_Paint);
            // 
            // FormMisJuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyectoBlizzarp.Properties.Resources.COPIN__1_;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1387, 748);
            this.Controls.Add(this.flowLayoutPanelMisJuegos);
            this.Controls.Add(this.labelMisJuegos);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "FormMisJuegos";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FormMisJuegos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMisJuegos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMisJuegos;
    }
}