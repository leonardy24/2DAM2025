namespace proyectoBlizzarp
{
    partial class FormAdmi
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
            this.label1 = new System.Windows.Forms.Label();
            this.Usuario = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Contrasena = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.radioButtonEsAdmin = new System.Windows.Forms.RadioButton();
            this.buttonConsultar = new System.Windows.Forms.Button();
            this.ButtonEliminar = new System.Windows.Forms.Button();
            this.buttonGuardarCambios = new System.Windows.Forms.Button();
            this.buttonCatalogoJuegos = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(301, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(279, 40);
            this.label1.TabIndex = 0;
            this.label1.Text = "Administrador";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Usuario
            // 
            this.Usuario.Location = new System.Drawing.Point(619, 114);
            this.Usuario.Name = "Usuario";
            this.Usuario.Size = new System.Drawing.Size(144, 20);
            this.Usuario.TabIndex = 1;
            this.Usuario.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(640, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 30);
            this.label2.TabIndex = 2;
            this.label2.Text = "Usuario";
            // 
            // Contrasena
            // 
            this.Contrasena.Location = new System.Drawing.Point(619, 195);
            this.Contrasena.Name = "Contrasena";
            this.Contrasena.Size = new System.Drawing.Size(144, 20);
            this.Contrasena.TabIndex = 3;
            this.Contrasena.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Showcard Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(608, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(161, 30);
            this.label3.TabIndex = 4;
            this.label3.Text = "Contraseña";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(244, 114);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(284, 116);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(645, 271);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 27);
            this.button1.TabIndex = 6;
            this.button1.Text = "Aceptar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // radioButtonEsAdmin
            // 
            this.radioButtonEsAdmin.AutoSize = true;
            this.radioButtonEsAdmin.BackColor = System.Drawing.Color.Transparent;
            this.radioButtonEsAdmin.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEsAdmin.ForeColor = System.Drawing.Color.White;
            this.radioButtonEsAdmin.Location = new System.Drawing.Point(595, 229);
            this.radioButtonEsAdmin.Name = "radioButtonEsAdmin";
            this.radioButtonEsAdmin.Size = new System.Drawing.Size(209, 27);
            this.radioButtonEsAdmin.TabIndex = 7;
            this.radioButtonEsAdmin.TabStop = true;
            this.radioButtonEsAdmin.Text = "Es Administrador";
            this.radioButtonEsAdmin.UseVisualStyleBackColor = false;
            // 
            // buttonConsultar
            // 
            this.buttonConsultar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConsultar.Location = new System.Drawing.Point(94, 114);
            this.buttonConsultar.Name = "buttonConsultar";
            this.buttonConsultar.Size = new System.Drawing.Size(97, 23);
            this.buttonConsultar.TabIndex = 8;
            this.buttonConsultar.Text = "Consultar";
            this.buttonConsultar.UseVisualStyleBackColor = true;
            this.buttonConsultar.Click += new System.EventHandler(this.button2_Click);
            // 
            // ButtonEliminar
            // 
            this.ButtonEliminar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonEliminar.Location = new System.Drawing.Point(94, 171);
            this.ButtonEliminar.Name = "ButtonEliminar";
            this.ButtonEliminar.Size = new System.Drawing.Size(97, 23);
            this.ButtonEliminar.TabIndex = 9;
            this.ButtonEliminar.Text = "Eliminar";
            this.ButtonEliminar.UseVisualStyleBackColor = true;
            this.ButtonEliminar.Click += new System.EventHandler(this.ButtonEliminar_Click);
            // 
            // buttonGuardarCambios
            // 
            this.buttonGuardarCambios.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonGuardarCambios.Location = new System.Drawing.Point(94, 229);
            this.buttonGuardarCambios.Name = "buttonGuardarCambios";
            this.buttonGuardarCambios.Size = new System.Drawing.Size(97, 23);
            this.buttonGuardarCambios.TabIndex = 10;
            this.buttonGuardarCambios.Text = "Guardar";
            this.buttonGuardarCambios.UseVisualStyleBackColor = true;
            this.buttonGuardarCambios.Click += new System.EventHandler(this.buttonGuardarCambios_Click);
            // 
            // buttonCatalogoJuegos
            // 
            this.buttonCatalogoJuegos.Location = new System.Drawing.Point(94, 292);
            this.buttonCatalogoJuegos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonCatalogoJuegos.Name = "buttonCatalogoJuegos";
            this.buttonCatalogoJuegos.Size = new System.Drawing.Size(97, 25);
            this.buttonCatalogoJuegos.TabIndex = 11;
            this.buttonCatalogoJuegos.Text = "Gestión Catálogo";
            this.buttonCatalogoJuegos.UseVisualStyleBackColor = true;
            this.buttonCatalogoJuegos.Click += new System.EventHandler(this.buttonCatalogoJuegos_Click);
            // 
            // FormAdmi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::proyectoBlizzarp.Properties.Resources.imagenFondoAdmin;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonCatalogoJuegos);
            this.Controls.Add(this.buttonGuardarCambios);
            this.Controls.Add(this.ButtonEliminar);
            this.Controls.Add(this.buttonConsultar);
            this.Controls.Add(this.radioButtonEsAdmin);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.Contrasena);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Usuario);
            this.Controls.Add(this.label1);
            this.Name = "FormAdmi";
            this.Text = "Form4";
            this.Load += new System.EventHandler(this.FormAdmi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Usuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Contrasena;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.RadioButton radioButtonEsAdmin;
        private System.Windows.Forms.Button buttonConsultar;
        private System.Windows.Forms.Button ButtonEliminar;
        private System.Windows.Forms.Button buttonGuardarCambios;
        private System.Windows.Forms.Button buttonCatalogoJuegos;
    }
}