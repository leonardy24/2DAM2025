namespace proyectoBlizzarp
{
    partial class GestionCatalogo
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
            this.dataGridViewCatalogo = new System.Windows.Forms.DataGridView();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.PanelAgregar = new System.Windows.Forms.Panel();
            this.buttonGuardar = new System.Windows.Forms.Button();
            this.buttonSelecImagen = new System.Windows.Forms.Button();
            this.textBoxPrecio = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDescripcion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonEliminar = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalogo)).BeginInit();
            this.PanelAgregar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewCatalogo
            // 
            this.dataGridViewCatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCatalogo.Location = new System.Drawing.Point(219, 24);
            this.dataGridViewCatalogo.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridViewCatalogo.Name = "dataGridViewCatalogo";
            this.dataGridViewCatalogo.RowTemplate.Height = 24;
            this.dataGridViewCatalogo.Size = new System.Drawing.Size(438, 243);
            this.dataGridViewCatalogo.TabIndex = 0;
            this.dataGridViewCatalogo.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Location = new System.Drawing.Point(41, 24);
            this.buttonConsultar.Margin = new System.Windows.Forms.Padding(2);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(76, 25);
            this.buttonConsultar.TabIndex = 1;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.buttonConsultar_Click);
            // 
            // PanelAgregar
            // 
            this.PanelAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PanelAgregar.Controls.Add(this.buttonGuardar);
            this.PanelAgregar.Controls.Add(this.buttonSelecImagen);
            this.PanelAgregar.Controls.Add(this.textBoxPrecio);
            this.PanelAgregar.Controls.Add(this.label4);
            this.PanelAgregar.Controls.Add(this.textBoxDescripcion);
            this.PanelAgregar.Controls.Add(this.label3);
            this.PanelAgregar.Controls.Add(this.textBoxTitulo);
            this.PanelAgregar.Controls.Add(this.label2);
            this.PanelAgregar.Controls.Add(this.label1);
            this.PanelAgregar.Location = new System.Drawing.Point(12, 281);
            this.PanelAgregar.Name = "PanelAgregar";
            this.PanelAgregar.Size = new System.Drawing.Size(645, 248);
            this.PanelAgregar.TabIndex = 2;
            // 
            // buttonGuardar
            // 
            this.buttonGuardar.Location = new System.Drawing.Point(142, 193);
            this.buttonGuardar.Name = "buttonGuardar";
            this.buttonGuardar.Size = new System.Drawing.Size(134, 23);
            this.buttonGuardar.TabIndex = 8;
            this.buttonGuardar.Text = "Guardar";
            this.buttonGuardar.UseVisualStyleBackColor = true;
            this.buttonGuardar.Click += new System.EventHandler(this.buttonGuardar_Click);
            // 
            // buttonSelecImagen
            // 
            this.buttonSelecImagen.Location = new System.Drawing.Point(292, 125);
            this.buttonSelecImagen.Name = "buttonSelecImagen";
            this.buttonSelecImagen.Size = new System.Drawing.Size(138, 23);
            this.buttonSelecImagen.TabIndex = 7;
            this.buttonSelecImagen.Text = "seleccionar Imagen";
            this.buttonSelecImagen.UseVisualStyleBackColor = true;
            this.buttonSelecImagen.Click += new System.EventHandler(this.buttonSelecImagen_Click);
            // 
            // textBoxPrecio
            // 
            this.textBoxPrecio.Location = new System.Drawing.Point(81, 125);
            this.textBoxPrecio.Name = "textBoxPrecio";
            this.textBoxPrecio.Size = new System.Drawing.Size(100, 20);
            this.textBoxPrecio.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Precio";
            // 
            // textBoxDescripcion
            // 
            this.textBoxDescripcion.Location = new System.Drawing.Point(292, 56);
            this.textBoxDescripcion.Name = "textBoxDescripcion";
            this.textBoxDescripcion.Size = new System.Drawing.Size(202, 20);
            this.textBoxDescripcion.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(213, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Descripcion";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // textBoxTitulo
            // 
            this.textBoxTitulo.Location = new System.Drawing.Point(64, 56);
            this.textBoxTitulo.Name = "textBoxTitulo";
            this.textBoxTitulo.Size = new System.Drawing.Size(100, 20);
            this.textBoxTitulo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulo";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(212, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingresar Juego";
            // 
            // buttonEliminar
            // 
            this.buttonEliminar.Location = new System.Drawing.Point(41, 99);
            this.buttonEliminar.Name = "buttonEliminar";
            this.buttonEliminar.Size = new System.Drawing.Size(75, 23);
            this.buttonEliminar.TabIndex = 3;
            this.buttonEliminar.Text = "Eliminar";
            this.buttonEliminar.UseVisualStyleBackColor = true;
            this.buttonEliminar.Click += new System.EventHandler(this.buttonEliminar_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(41, 187);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(75, 23);
            this.buttonUpdate.TabIndex = 4;
            this.buttonUpdate.Text = "Actualizar";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // GestionCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(669, 541);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonEliminar);
            this.Controls.Add(this.PanelAgregar);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.dataGridViewCatalogo);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestionCatalogo";
            this.Text = "GestionCatalogo";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCatalogo)).EndInit();
            this.PanelAgregar.ResumeLayout(false);
            this.PanelAgregar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewCatalogo;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Panel PanelAgregar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxPrecio;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxDescripcion;
        private System.Windows.Forms.Button buttonSelecImagen;
        private System.Windows.Forms.Button buttonGuardar;
        private System.Windows.Forms.Button buttonEliminar;
        private System.Windows.Forms.Button buttonUpdate;
    }
}