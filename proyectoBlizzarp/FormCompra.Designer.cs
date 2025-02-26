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
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::proyectoBlizzarp.Properties.Resources.MetodosDePago;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(17, 346);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(227, 112);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::proyectoBlizzarp.Properties.Resources.imgTarVisa;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(17, 10);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(417, 262);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // buttonPagar
            // 
            this.buttonPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonPagar.Location = new System.Drawing.Point(17, 507);
            this.buttonPagar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonPagar.Name = "buttonPagar";
            this.buttonPagar.Size = new System.Drawing.Size(117, 32);
            this.buttonPagar.TabIndex = 12;
            this.buttonPagar.Text = "Pagar";
            this.buttonPagar.UseVisualStyleBackColor = true;
            this.buttonPagar.Click += new System.EventHandler(this.buttonPagar_Click);
            // 
            // buttonCancelar
            // 
            this.buttonCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCancelar.Location = new System.Drawing.Point(204, 508);
            this.buttonCancelar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCancelar.Name = "buttonCancelar";
            this.buttonCancelar.Size = new System.Drawing.Size(94, 32);
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
            this.labelNumTarjeta.Location = new System.Drawing.Point(155, 131);
            this.labelNumTarjeta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelNumTarjeta.Name = "labelNumTarjeta";
            this.labelNumTarjeta.Size = new System.Drawing.Size(162, 17);
            this.labelNumTarjeta.TabIndex = 14;
            this.labelNumTarjeta.Text = "Numero de la Tarjeta";
            // 
            // textBoxNumTarjeta
            // 
            this.textBoxNumTarjeta.Location = new System.Drawing.Point(56, 160);
            this.textBoxNumTarjeta.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxNumTarjeta.Name = "textBoxNumTarjeta";
            this.textBoxNumTarjeta.Size = new System.Drawing.Size(322, 20);
            this.textBoxNumTarjeta.TabIndex = 15;
            // 
            // labelCodigoSeguridad
            // 
            this.labelCodigoSeguridad.AutoSize = true;
            this.labelCodigoSeguridad.BackColor = System.Drawing.Color.Black;
            this.labelCodigoSeguridad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCodigoSeguridad.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCodigoSeguridad.Location = new System.Drawing.Point(279, 188);
            this.labelCodigoSeguridad.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCodigoSeguridad.Name = "labelCodigoSeguridad";
            this.labelCodigoSeguridad.Size = new System.Drawing.Size(38, 17);
            this.labelCodigoSeguridad.TabIndex = 16;
            this.labelCodigoSeguridad.Text = "CVV";
            // 
            // textBoxCVV
            // 
            this.textBoxCVV.Location = new System.Drawing.Point(266, 207);
            this.textBoxCVV.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxCVV.Name = "textBoxCVV";
            this.textBoxCVV.Size = new System.Drawing.Size(76, 20);
            this.textBoxCVV.TabIndex = 17;
            // 
            // textBoxFechaCaducidad
            // 
            this.textBoxFechaCaducidad.Location = new System.Drawing.Point(144, 207);
            this.textBoxFechaCaducidad.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBoxFechaCaducidad.Name = "textBoxFechaCaducidad";
            this.textBoxFechaCaducidad.Size = new System.Drawing.Size(76, 20);
            this.textBoxFechaCaducidad.TabIndex = 18;
            // 
            // flowLayoutPanelJuego
            // 
            this.flowLayoutPanelJuego.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanelJuego.Location = new System.Drawing.Point(463, 10);
            this.flowLayoutPanelJuego.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanelJuego.Name = "flowLayoutPanelJuego";
            this.flowLayoutPanelJuego.Size = new System.Drawing.Size(146, 366);
            this.flowLayoutPanelJuego.TabIndex = 19;
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(406, 515);
            this.progressBar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(250, 16);
            this.progressBar.TabIndex = 20;
            this.progressBar.Click += new System.EventHandler(this.progressBar_Click);
            // 
            // labelCompra
            // 
            this.labelCompra.AutoSize = true;
            this.labelCompra.BackColor = System.Drawing.Color.Transparent;
            this.labelCompra.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelCompra.Location = new System.Drawing.Point(406, 487);
            this.labelCompra.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelCompra.Name = "labelCompra";
            this.labelCompra.Size = new System.Drawing.Size(0, 13);
            this.labelCompra.TabIndex = 21;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(56, 243);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(202, 20);
            this.textBoxNombre.TabIndex = 22;
            // 
            // FormCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyectoBlizzarp.Properties.Resources.FondoAzul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(688, 550);
            this.Controls.Add(this.textBoxNombre);
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
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.TextBox textBoxNombre;
    }
}