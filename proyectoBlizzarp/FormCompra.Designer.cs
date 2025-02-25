namespace proyectoBlizzarp
{
    partial class FormCompra
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonPagar = new System.Windows.Forms.Button();
            this.buttonCancelar = new System.Windows.Forms.Button();
            this.labelNumTarjeta = new System.Windows.Forms.Label();
            this.textBoxNumTarjeta = new System.Windows.Forms.TextBox();
            this.labelCodigoSeguridad = new System.Windows.Forms.Label();
            this.textBoxCVV = new System.Windows.Forms.TextBox();
            this.textBoxFechaCaducidad = new System.Windows.Forms.TextBox();
            this.flowLayoutPanelJuego = new System.Windows.Forms.FlowLayoutPanel();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.labelCompra = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::proyectoBlizzarp.Properties.Resources.MetodosDePago;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(23, 426);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(303, 138);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::proyectoBlizzarp.Properties.Resources.imgTarVisa;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(23, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(556, 318);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // buttonPagar
            // 
            this.buttonPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPagar.Location = new System.Drawing.Point(12, 625);
            this.buttonPagar.Name = "buttonPagar";
            this.buttonPagar.Size = new System.Drawing.Size(156, 40);
            this.buttonPagar.TabIndex = 12;
            this.buttonPagar.Text = "Pagar";
            this.buttonPagar.UseVisualStyleBackColor = true;
            this.buttonPagar.Click += new System.EventHandler(this.buttonPagar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(272, 625);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(125, 39);
            this.buttonCancelar.TabIndex = 13;
            this.buttonCancelar.Text = "Cancelar";
            this.buttonCancelar.UseVisualStyleBackColor = true;
            // 
            // labelNumTarjeta
            // 
            this.labelNumTarjeta.AutoSize = true;
            this.labelNumTarjeta.BackColor = System.Drawing.Color.Black;
            this.labelNumTarjeta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNumTarjeta.ForeColor = System.Drawing.Color.White;
            this.labelNumTarjeta.Location = new System.Drawing.Point(211, 173);
            this.labelNumTarjeta.Name = "labelNumTarjeta";
            this.labelNumTarjeta.Size = new System.Drawing.Size(186, 20);
            this.labelNumTarjeta.TabIndex = 14;
            this.labelNumTarjeta.Text = "Numero de la Tarjeta";
            // 
            // textBoxNumTarjeta
            // 
            this.textBoxNumTarjeta.Location = new System.Drawing.Point(72, 208);
            this.textBoxNumTarjeta.Name = "textBoxNumTarjeta";
            this.textBoxNumTarjeta.Size = new System.Drawing.Size(428, 22);
            this.textBoxNumTarjeta.TabIndex = 15;
            // 
            // labelCodigoSeguridad
            // 
            this.labelCodigoSeguridad.AutoSize = true;
            this.labelCodigoSeguridad.BackColor = System.Drawing.Color.Black;
            this.labelCodigoSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoSeguridad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCodigoSeguridad.Location = new System.Drawing.Point(387, 243);
            this.labelCodigoSeguridad.Name = "labelCodigoSeguridad";
            this.labelCodigoSeguridad.Size = new System.Drawing.Size(46, 20);
            this.labelCodigoSeguridad.TabIndex = 16;
            this.labelCodigoSeguridad.Text = "CVV";
            // 
            // textBoxCVV
            // 
            this.textBoxCVV.Location = new System.Drawing.Point(356, 266);
            this.textBoxCVV.Name = "textBoxCVV";
            this.textBoxCVV.Size = new System.Drawing.Size(100, 22);
            this.textBoxCVV.TabIndex = 17;
            // 
            // textBoxFechaCaducidad
            // 
            this.textBoxFechaCaducidad.Location = new System.Drawing.Point(196, 266);
            this.textBoxFechaCaducidad.Name = "textBoxFechaCaducidad";
            this.textBoxFechaCaducidad.Size = new System.Drawing.Size(100, 22);
            this.textBoxFechaCaducidad.TabIndex = 18;
            // 
            // flowLayoutPanelJuego
            // 
            this.flowLayoutPanelJuego.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelJuego.Location = new System.Drawing.Point(631, 12);
            this.flowLayoutPanelJuego.Name = "flowLayoutPanelJuego";
            this.flowLayoutPanelJuego.Size = new System.Drawing.Size(195, 450);
            this.flowLayoutPanelJuego.TabIndex = 19;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(541, 634);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(334, 20);
            this.progressBar.TabIndex = 20;
            // 
            // labelCompra
            // 
            this.labelCompra.AutoSize = true;
            this.labelCompra.BackColor = System.Drawing.Color.Transparent;
            this.labelCompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCompra.Location = new System.Drawing.Point(541, 599);
            this.labelCompra.Name = "labelCompra";
            this.labelCompra.Size = new System.Drawing.Size(44, 16);
            this.labelCompra.TabIndex = 21;
            this.labelCompra.Text = "label1";
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyectoBlizzarp.Properties.Resources.FondoAzul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(918, 677);
            this.Controls.Add(this.labelCompra);
            this.Controls.Add(this.progressBar);
            this.Controls.Add(this.flowLayoutPanelJuego);
            this.Controls.Add(this.textBoxFechaCaducidad);
            this.Controls.Add(this.textBoxCVV);
            this.Controls.Add(this.labelCodigoSeguridad);
            this.Controls.Add(this.textBoxNumTarjeta);
            this.Controls.Add(this.labelNumTarjeta);
            this.Controls.Add(this.buttonCancelar);
            this.Controls.Add(this.buttonPagar);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FormCompra";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonPagar;
        private System.Windows.Forms.Button buttonCancelar;
        private System.Windows.Forms.Label labelNumTarjeta;
        private System.Windows.Forms.TextBox textBoxNumTarjeta;
        private System.Windows.Forms.Label labelCodigoSeguridad;
        private System.Windows.Forms.TextBox textBoxCVV;
        private System.Windows.Forms.TextBox textBoxFechaCaducidad;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelJuego;
        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Label labelCompra;
    }
}