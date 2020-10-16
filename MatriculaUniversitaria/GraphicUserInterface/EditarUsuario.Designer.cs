namespace matriculaUniversitaria.GraphicUserInterface
{
    partial class EditarUsuario
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.txtState = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCountry = new System.Windows.Forms.TextBox();
            this.cmbAcademylvl = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timerBornDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.cbxTipo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(612, 320);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 29);
            this.btnCancelar.TabIndex = 41;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(409, 320);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(91, 29);
            this.btnAceptar.TabIndex = 40;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(26, 328);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 39;
            this.label8.Text = "Estado/Provincia";
            // 
            // txtState
            // 
            this.txtState.AccessibleName = "txtDni";
            this.txtState.Location = new System.Drawing.Point(152, 325);
            this.txtState.Name = "txtState";
            this.txtState.Size = new System.Drawing.Size(200, 20);
            this.txtState.TabIndex = 38;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(69, 13);
            this.label7.TabIndex = 37;
            this.label7.Text = "Nacionalidad";
            // 
            // txtCountry
            // 
            this.txtCountry.AccessibleName = "txtDni";
            this.txtCountry.Location = new System.Drawing.Point(152, 282);
            this.txtCountry.Name = "txtCountry";
            this.txtCountry.Size = new System.Drawing.Size(200, 20);
            this.txtCountry.TabIndex = 36;
            // 
            // cmbAcademylvl
            // 
            this.cmbAcademylvl.AccessibleName = "cmbSex";
            this.cmbAcademylvl.FormattingEnabled = true;
            this.cmbAcademylvl.Location = new System.Drawing.Point(152, 237);
            this.cmbAcademylvl.Name = "cmbAcademylvl";
            this.cmbAcademylvl.Size = new System.Drawing.Size(200, 21);
            this.cmbAcademylvl.TabIndex = 35;
            this.cmbAcademylvl.Text = "- Elija una opción -";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 240);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 34;
            this.label6.Text = "Nivel Académico";
            // 
            // timerBornDate
            // 
            this.timerBornDate.Location = new System.Drawing.Point(152, 190);
            this.timerBornDate.Name = "timerBornDate";
            this.timerBornDate.Size = new System.Drawing.Size(200, 20);
            this.timerBornDate.TabIndex = 33;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 32;
            this.label5.Text = "Fecha de nacimiento";
            // 
            // cmbSexo
            // 
            this.cmbSexo.AccessibleName = "cmbSex";
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(152, 148);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(200, 21);
            this.cmbSexo.TabIndex = 31;
            this.cmbSexo.Text = "- Elija una opción -";
            this.cmbSexo.SelectedIndexChanged += new System.EventHandler(this.cmbSexo_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 30;
            this.label4.Text = "Sexo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Apellido";
            // 
            // txtApellido
            // 
            this.txtApellido.AccessibleName = "txtApellido";
            this.txtApellido.Location = new System.Drawing.Point(152, 105);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(200, 20);
            this.txtApellido.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Nombre";
            // 
            // txtNombre
            // 
            this.txtNombre.AccessibleName = "txtNombre";
            this.txtNombre.Location = new System.Drawing.Point(152, 63);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 26;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 25;
            this.label1.Text = "Num. cedula";
            // 
            // txtDni
            // 
            this.txtDni.AccessibleName = "txtDni";
            this.txtDni.Location = new System.Drawing.Point(152, 23);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(200, 20);
            this.txtDni.TabIndex = 24;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // cbxTipo
            // 
            this.cbxTipo.FormattingEnabled = true;
            this.cbxTipo.Items.AddRange(new object[] {
            "Administrador",
            "Profesor",
            "Estudiante"});
            this.cbxTipo.Location = new System.Drawing.Point(472, 23);
            this.cbxTipo.Name = "cbxTipo";
            this.cbxTipo.Size = new System.Drawing.Size(200, 21);
            this.cbxTipo.TabIndex = 43;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(386, 26);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 13);
            this.label9.TabIndex = 42;
            this.label9.Text = "Tipo de usuario";
            // 
            // EditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 374);
            this.Controls.Add(this.cbxTipo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtState);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCountry);
            this.Controls.Add(this.cmbAcademylvl);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.timerBornDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDni);
            this.Name = "EditarUsuario";
            this.Text = "EditarUsuario";
            this.Load += new System.EventHandler(this.EditarUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtState;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCountry;
        private System.Windows.Forms.ComboBox cmbAcademylvl;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker timerBornDate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.ComboBox cbxTipo;
        private System.Windows.Forms.Label label9;
    }
}