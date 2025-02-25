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
            this.labelMisJuegos.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMisJuegos.ForeColor = System.Drawing.Color.White;
            this.labelMisJuegos.Location = new System.Drawing.Point(31, 32);
            this.labelMisJuegos.Name = "labelMisJuegos";
            this.labelMisJuegos.Size = new System.Drawing.Size(199, 39);
            this.labelMisJuegos.TabIndex = 0;
            this.labelMisJuegos.Text = "Mis Juegos";
            // 
            // flowLayoutPanelMisJuegos
            // 
            this.flowLayoutPanelMisJuegos.Location = new System.Drawing.Point(5, 91);
            this.flowLayoutPanelMisJuegos.Name = "flowLayoutPanelMisJuegos";
            this.flowLayoutPanelMisJuegos.Size = new System.Drawing.Size(933, 424);
            this.flowLayoutPanelMisJuegos.TabIndex = 1;
            // 
            // FormMisJuegos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyectoBlizzarp.Properties.Resources.COPIN__1_;
            this.ClientSize = new System.Drawing.Size(950, 527);
            this.Controls.Add(this.flowLayoutPanelMisJuegos);
            this.Controls.Add(this.labelMisJuegos);
            this.Name = "FormMisJuegos";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelMisJuegos;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMisJuegos;
    }
}