namespace matriculaUniversitaria.GraphicUserInterface
{
    partial class AgregarCarrera
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
            this.timerStart = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTotalCreditos = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEstado = new System.Windows.Forms.ComboBox();
            this.dateEnd = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // timerStart
            // 
            this.timerStart.Location = new System.Drawing.Point(143, 169);
            this.timerStart.Name = "timerStart";
            this.timerStart.Size = new System.Drawing.Size(200, 20);
            this.timerStart.TabIndex = 16;
            this.timerStart.ValueChanged += new System.EventHandler(this.timerStart_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Fecha de inicio";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 87);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Total creditos";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtTotalCreditos
            // 
            this.txtTotalCreditos.AccessibleName = "txtApellido";
            this.txtTotalCreditos.Location = new System.Drawing.Point(143, 84);
            this.txtTotalCreditos.Name = "txtTotalCreditos";
            this.txtTotalCreditos.Size = new System.Drawing.Size(200, 20);
            this.txtTotalCreditos.TabIndex = 13;
            this.txtTotalCreditos.TextChanged += new System.EventHandler(this.txtTotalCreditos_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "Nombre";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.AccessibleName = "txtNombre";
            this.txtNombre.Location = new System.Drawing.Point(143, 42);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(200, 20);
            this.txtNombre.TabIndex = 11;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 18;
            this.label1.Text = "Estado";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cmbEstado
            // 
            this.cmbEstado.FormattingEnabled = true;
            this.cmbEstado.Location = new System.Drawing.Point(143, 126);
            this.cmbEstado.Name = "cmbEstado";
            this.cmbEstado.Size = new System.Drawing.Size(200, 21);
            this.cmbEstado.TabIndex = 19;
            this.cmbEstado.Text = "- Seleccione una opción -";
            this.cmbEstado.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // dateEnd
            // 
            this.dateEnd.Location = new System.Drawing.Point(143, 211);
            this.dateEnd.Name = "dateEnd";
            this.dateEnd.Size = new System.Drawing.Size(200, 20);
            this.dateEnd.TabIndex = 21;
            this.dateEnd.ValueChanged += new System.EventHandler(this.dateEnd_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "Fecha de finalización";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // btnAceptar
            // 
            this.btnAceptar.Location = new System.Drawing.Point(404, 239);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(75, 23);
            this.btnAceptar.TabIndex = 22;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(504, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 23;
            this.button2.Text = "Cancelar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Codigo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.AccessibleName = "txtNombre";
            this.txtCodigo.Location = new System.Drawing.Point(143, 9);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(200, 20);
            this.txtCodigo.TabIndex = 24;
            // 
            // AgregarCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(625, 290);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.dateEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbEstado);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timerStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtTotalCreditos);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNombre);
            this.Name = "AgregarCarrera";
            this.Text = "AgregarCarrera";
            this.Load += new System.EventHandler(this.AgregarCarrera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker timerStart;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTotalCreditos;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbEstado;
        private System.Windows.Forms.DateTimePicker dateEnd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigo;
    }
}