namespace proyectoBlizzarp
{
    partial class TodosLosJuego
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
            this.panelPrincipal = new System.Windows.Forms.Panel();
            this.flowLayoutPanelTodosLosJuegos = new System.Windows.Forms.FlowLayoutPanel();
            this.labelYadisponibles = new System.Windows.Forms.Label();
            this.panelPresentacion = new System.Windows.Forms.Panel();
            this.panelPrincipal.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelPrincipal
            // 
            this.panelPrincipal.BackgroundImage = global::proyectoBlizzarp.Properties.Resources.FondoAzul;
            this.panelPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPrincipal.Controls.Add(this.flowLayoutPanelTodosLosJuegos);
            this.panelPrincipal.Controls.Add(this.labelYadisponibles);
            this.panelPrincipal.Location = new System.Drawing.Point(0, 338);
            this.panelPrincipal.Margin = new System.Windows.Forms.Padding(4);
            this.panelPrincipal.Name = "panelPrincipal";
            this.panelPrincipal.Size = new System.Drawing.Size(2050, 800);
            this.panelPrincipal.TabIndex = 1;
            this.panelPrincipal.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPrincipal_Paint);
            // 
            // flowLayoutPanelTodosLosJuegos
            // 
            this.flowLayoutPanelTodosLosJuegos.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelTodosLosJuegos.Location = new System.Drawing.Point(69, 112);
            this.flowLayoutPanelTodosLosJuegos.Margin = new System.Windows.Forms.Padding(4);
            this.flowLayoutPanelTodosLosJuegos.Name = "flowLayoutPanelTodosLosJuegos";
            this.flowLayoutPanelTodosLosJuegos.Size = new System.Drawing.Size(1816, 454);
            this.flowLayoutPanelTodosLosJuegos.TabIndex = 1;
            this.flowLayoutPanelTodosLosJuegos.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanelTodosLosJuegos_Paint);
            // 
            // labelYadisponibles
            // 
            this.labelYadisponibles.AutoSize = true;
            this.labelYadisponibles.BackColor = System.Drawing.Color.Transparent;
            this.labelYadisponibles.Font = new System.Drawing.Font("Microsoft YaHei UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelYadisponibles.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelYadisponibles.Location = new System.Drawing.Point(120, 39);
            this.labelYadisponibles.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelYadisponibles.Name = "labelYadisponibles";
            this.labelYadisponibles.Size = new System.Drawing.Size(320, 52);
            this.labelYadisponibles.TabIndex = 0;
            this.labelYadisponibles.Text = "Ya Disponibles";
            // 
            // panelPresentacion
            // 
            this.panelPresentacion.BackgroundImage = global::proyectoBlizzarp.Properties.Resources.imagenPresentacion;
            this.panelPresentacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelPresentacion.Location = new System.Drawing.Point(0, 1);
            this.panelPresentacion.Margin = new System.Windows.Forms.Padding(4);
            this.panelPresentacion.Name = "panelPresentacion";
            this.panelPresentacion.Size = new System.Drawing.Size(2050, 341);
            this.panelPresentacion.TabIndex = 0;
            this.panelPresentacion.Paint += new System.Windows.Forms.PaintEventHandler(this.panelPresentacion_Paint);
            // 
            // TodosLosJuego
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 933);
            this.Controls.Add(this.panelPrincipal);
            this.Controls.Add(this.panelPresentacion);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TodosLosJuego";
            this.Text = "TodosLosJuego";
            this.panelPrincipal.ResumeLayout(false);
            this.panelPrincipal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelPresentacion;
        private System.Windows.Forms.Panel panelPrincipal;
        private System.Windows.Forms.Label labelYadisponibles;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelTodosLosJuegos;
    }
}