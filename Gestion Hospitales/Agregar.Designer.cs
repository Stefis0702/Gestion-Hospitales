namespace Gestion_Hospitales
{
    partial class Agregar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Agregar));
            this.lbPersona = new System.Windows.Forms.Label();
            this.cmbPersona = new System.Windows.Forms.ComboBox();
            this.lbMotivoConsulta = new System.Windows.Forms.Label();
            this.lbEspecialidad = new System.Windows.Forms.Label();
            this.lbEdad = new System.Windows.Forms.Label();
            this.lbNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtEdad = new System.Windows.Forms.TextBox();
            this.txtMotivoConsulta = new System.Windows.Forms.TextBox();
            this.txtEspecialidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lbSelMedico = new System.Windows.Forms.Label();
            this.cmbSelMedico = new System.Windows.Forms.ComboBox();
            this.btnCrear = new System.Windows.Forms.Button();
            this.pbFoto = new System.Windows.Forms.PictureBox();
            this.btnVolver = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // lbPersona
            // 
            this.lbPersona.AutoSize = true;
            this.lbPersona.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPersona.Location = new System.Drawing.Point(128, 157);
            this.lbPersona.Name = "lbPersona";
            this.lbPersona.Size = new System.Drawing.Size(86, 13);
            this.lbPersona.TabIndex = 0;
            this.lbPersona.Text = "Tipo Persona:";
            // 
            // cmbPersona
            // 
            this.cmbPersona.FormattingEnabled = true;
            this.cmbPersona.Location = new System.Drawing.Point(220, 154);
            this.cmbPersona.Name = "cmbPersona";
            this.cmbPersona.Size = new System.Drawing.Size(190, 21);
            this.cmbPersona.TabIndex = 1;
            this.cmbPersona.SelectedIndexChanged += new System.EventHandler(this.cmbPersona_SelectedIndexChanged);
            // 
            // lbMotivoConsulta
            // 
            this.lbMotivoConsulta.AutoSize = true;
            this.lbMotivoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMotivoConsulta.Location = new System.Drawing.Point(445, 400);
            this.lbMotivoConsulta.Name = "lbMotivoConsulta";
            this.lbMotivoConsulta.Size = new System.Drawing.Size(102, 13);
            this.lbMotivoConsulta.TabIndex = 2;
            this.lbMotivoConsulta.Text = "Motivo Consulta:";
            // 
            // lbEspecialidad
            // 
            this.lbEspecialidad.AutoSize = true;
            this.lbEspecialidad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEspecialidad.Location = new System.Drawing.Point(461, 157);
            this.lbEspecialidad.Name = "lbEspecialidad";
            this.lbEspecialidad.Size = new System.Drawing.Size(83, 13);
            this.lbEspecialidad.TabIndex = 4;
            this.lbEspecialidad.Text = "Especialidad:";
            // 
            // lbEdad
            // 
            this.lbEdad.AutoSize = true;
            this.lbEdad.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEdad.Location = new System.Drawing.Point(496, 347);
            this.lbEdad.Name = "lbEdad";
            this.lbEdad.Size = new System.Drawing.Size(40, 13);
            this.lbEdad.TabIndex = 6;
            this.lbEdad.Text = "Edad:";
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNombre.Location = new System.Drawing.Point(484, 227);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(54, 13);
            this.lbNombre.TabIndex = 8;
            this.lbNombre.Text = "Nombre:";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(550, 220);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(121, 20);
            this.txtNombre.TabIndex = 9;
            // 
            // txtEdad
            // 
            this.txtEdad.Location = new System.Drawing.Point(550, 340);
            this.txtEdad.Name = "txtEdad";
            this.txtEdad.Size = new System.Drawing.Size(121, 20);
            this.txtEdad.TabIndex = 10;
            // 
            // txtMotivoConsulta
            // 
            this.txtMotivoConsulta.Location = new System.Drawing.Point(550, 393);
            this.txtMotivoConsulta.Name = "txtMotivoConsulta";
            this.txtMotivoConsulta.Size = new System.Drawing.Size(121, 20);
            this.txtMotivoConsulta.TabIndex = 11;
            // 
            // txtEspecialidad
            // 
            this.txtEspecialidad.Location = new System.Drawing.Point(550, 150);
            this.txtEspecialidad.Name = "txtEspecialidad";
            this.txtEspecialidad.Size = new System.Drawing.Size(121, 20);
            this.txtEspecialidad.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 25);
            this.label2.TabIndex = 13;
            this.label2.Text = "AGREGAR";
            // 
            // lbApellido
            // 
            this.lbApellido.AutoSize = true;
            this.lbApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbApellido.Location = new System.Drawing.Point(484, 284);
            this.lbApellido.Name = "lbApellido";
            this.lbApellido.Size = new System.Drawing.Size(56, 13);
            this.lbApellido.TabIndex = 16;
            this.lbApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(550, 277);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(121, 20);
            this.txtApellido.TabIndex = 17;
            // 
            // lbSelMedico
            // 
            this.lbSelMedico.AutoSize = true;
            this.lbSelMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSelMedico.Location = new System.Drawing.Point(118, 219);
            this.lbSelMedico.Name = "lbSelMedico";
            this.lbSelMedico.Size = new System.Drawing.Size(98, 13);
            this.lbSelMedico.TabIndex = 18;
            this.lbSelMedico.Text = "Asignar Medico:";
            // 
            // cmbSelMedico
            // 
            this.cmbSelMedico.FormattingEnabled = true;
            this.cmbSelMedico.Location = new System.Drawing.Point(220, 216);
            this.cmbSelMedico.Name = "cmbSelMedico";
            this.cmbSelMedico.Size = new System.Drawing.Size(190, 21);
            this.cmbSelMedico.TabIndex = 19;
            // 
            // btnCrear
            // 
            this.btnCrear.BackColor = System.Drawing.Color.White;
            this.btnCrear.Location = new System.Drawing.Point(464, 480);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 20;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = false;
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // pbFoto
            // 
            this.pbFoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pbFoto.Image = ((System.Drawing.Image)(resources.GetObject("pbFoto.Image")));
            this.pbFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbFoto.InitialImage")));
            this.pbFoto.Location = new System.Drawing.Point(157, 284);
            this.pbFoto.Name = "pbFoto";
            this.pbFoto.Size = new System.Drawing.Size(194, 180);
            this.pbFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbFoto.TabIndex = 24;
            this.pbFoto.TabStop = false;
            // 
            // btnVolver
            // 
            this.btnVolver.BackColor = System.Drawing.Color.White;
            this.btnVolver.Location = new System.Drawing.Point(643, 480);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 25;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = false;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(101, 136);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(654, 381);
            this.listBox1.TabIndex = 26;
            // 
            // Agregar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(863, 597);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.pbFoto);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.cmbSelMedico);
            this.Controls.Add(this.lbSelMedico);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lbApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtEspecialidad);
            this.Controls.Add(this.txtMotivoConsulta);
            this.Controls.Add(this.txtEdad);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.lbEdad);
            this.Controls.Add(this.lbEspecialidad);
            this.Controls.Add(this.lbMotivoConsulta);
            this.Controls.Add(this.cmbPersona);
            this.Controls.Add(this.lbPersona);
            this.Name = "Agregar";
            this.Text = "Agregar";
            ((System.ComponentModel.ISupportInitialize)(this.pbFoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbPersona;
        private System.Windows.Forms.ComboBox cmbPersona;
        private System.Windows.Forms.Label lbMotivoConsulta;
        private System.Windows.Forms.Label lbEspecialidad;
        private System.Windows.Forms.Label lbEdad;
        private System.Windows.Forms.Label lbNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtEdad;
        private System.Windows.Forms.TextBox txtMotivoConsulta;
        private System.Windows.Forms.TextBox txtEspecialidad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lbSelMedico;
        private System.Windows.Forms.ComboBox cmbSelMedico;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.PictureBox pbFoto;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.ListBox listBox1;
    }
}