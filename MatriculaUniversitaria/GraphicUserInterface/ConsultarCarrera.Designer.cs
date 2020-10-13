namespace matriculaUniversitaria.GraphicUserInterface
{
    partial class ConsultarCarrera
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
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Lista = new System.Windows.Forms.ListBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(654, 130);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(111, 23);
            this.btnEliminar.TabIndex = 13;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(654, 101);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(111, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(654, 72);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(111, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nombre de carrera";
            // 
            // Lista
            // 
            this.Lista.AccessibleName = "listPerson";
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(38, 72);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(595, 355);
            this.Lista.TabIndex = 9;
            this.Lista.SelectedIndexChanged += new System.EventHandler(this.Lista_SelectedIndexChanged);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(136, 27);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(416, 20);
            this.txtBuscar.TabIndex = 8;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(558, 24);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // ConsultarCarrera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.btnBuscar);
            this.Name = "ConsultarCarrera";
            this.Text = "ConsultarCarrera";
            this.Load += new System.EventHandler(this.ConsultarCarrera_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Lista;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
    }
}