namespace proyectoBlizzarp
{
    partial class FormDescripcionCompra
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
            this.buttonComprar = new System.Windows.Forms.Button();
            this.buttonAggLista = new System.Windows.Forms.Button();
            this.pictureBoxJuego = new System.Windows.Forms.PictureBox();
            this.tituloDescrip = new System.Windows.Forms.Label();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.labelPrecio = new System.Windows.Forms.Label();
            this.labelDecrip = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJuego)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonComprar
            // 
            this.buttonComprar.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonComprar.Location = new System.Drawing.Point(759, 293);
            this.buttonComprar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonComprar.Name = "buttonComprar";
            this.buttonComprar.Size = new System.Drawing.Size(277, 42);
            this.buttonComprar.TabIndex = 0;
            this.buttonComprar.Text = "Comprar";
            this.buttonComprar.UseVisualStyleBackColor = true;
            this.buttonComprar.Click += new System.EventHandler(this.buttonComprar_Click);
            // 
            // buttonAggLista
            // 
            this.buttonAggLista.Font = new System.Drawing.Font("Microsoft YaHei UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAggLista.Location = new System.Drawing.Point(759, 379);
            this.buttonAggLista.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAggLista.Name = "buttonAggLista";
            this.buttonAggLista.Size = new System.Drawing.Size(277, 43);
            this.buttonAggLista.TabIndex = 1;
            this.buttonAggLista.Text = "Añadir a la lista";
            this.buttonAggLista.UseVisualStyleBackColor = true;
            // 
            // pictureBoxJuego
            // 
            this.pictureBoxJuego.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxJuego.Location = new System.Drawing.Point(48, 36);
            this.pictureBoxJuego.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBoxJuego.Name = "pictureBoxJuego";
            this.pictureBoxJuego.Size = new System.Drawing.Size(609, 409);
            this.pictureBoxJuego.TabIndex = 2;
            this.pictureBoxJuego.TabStop = false;
            // 
            // tituloDescrip
            // 
            this.tituloDescrip.AutoSize = true;
            this.tituloDescrip.BackColor = System.Drawing.Color.Transparent;
            this.tituloDescrip.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tituloDescrip.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.tituloDescrip.Location = new System.Drawing.Point(33, 474);
            this.tituloDescrip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.tituloDescrip.Name = "tituloDescrip";
            this.tituloDescrip.Size = new System.Drawing.Size(240, 50);
            this.tituloDescrip.TabIndex = 3;
            this.tituloDescrip.Text = "Descripción";
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.BackColor = System.Drawing.Color.Transparent;
            this.labelTitulo.Font = new System.Drawing.Font("Microsoft YaHei UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelTitulo.Location = new System.Drawing.Point(749, 94);
            this.labelTitulo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(220, 50);
            this.labelTitulo.TabIndex = 4;
            this.labelTitulo.Text = "labelTitulo";
            this.labelTitulo.Click += new System.EventHandler(this.labelTitulo_Click);
            // 
            // labelPrecio
            // 
            this.labelPrecio.AutoSize = true;
            this.labelPrecio.BackColor = System.Drawing.Color.Transparent;
            this.labelPrecio.Font = new System.Drawing.Font("Microsoft YaHei UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrecio.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPrecio.Location = new System.Drawing.Point(752, 169);
            this.labelPrecio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPrecio.Name = "labelPrecio";
            this.labelPrecio.Size = new System.Drawing.Size(166, 36);
            this.labelPrecio.TabIndex = 5;
            this.labelPrecio.Text = "labelPrecio";
            this.labelPrecio.Click += new System.EventHandler(this.labelPrecio_Click);
            // 
            // labelDecrip
            // 
            this.labelDecrip.AutoSize = true;
            this.labelDecrip.BackColor = System.Drawing.Color.Transparent;
            this.labelDecrip.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDecrip.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelDecrip.Location = new System.Drawing.Point(43, 556);
            this.labelDecrip.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelDecrip.Name = "labelDecrip";
            this.labelDecrip.Size = new System.Drawing.Size(61, 24);
            this.labelDecrip.TabIndex = 6;
            this.labelDecrip.Text = "label1";
            // 
            // FormDescripcionCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyectoBlizzarp.Properties.Resources.FondoAzul;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1107, 730);
            this.Controls.Add(this.labelDecrip);
            this.Controls.Add(this.labelPrecio);
            this.Controls.Add(this.labelTitulo);
            this.Controls.Add(this.tituloDescrip);
            this.Controls.Add(this.pictureBoxJuego);
            this.Controls.Add(this.buttonAggLista);
            this.Controls.Add(this.buttonComprar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormDescripcionCompra";
            this.Text = "FormCompra";
            this.Load += new System.EventHandler(this.FormCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJuego)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonComprar;
        private System.Windows.Forms.Button buttonAggLista;
        private System.Windows.Forms.PictureBox pictureBoxJuego;
        private System.Windows.Forms.Label tituloDescrip;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Label labelPrecio;
        private System.Windows.Forms.Label labelDecrip;
    }
}