namespace matriculaUniversitaria.GraphicUserInterface
{
    partial class LobbyEstudiante
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.matriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarNotasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.realizarMatriculaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.matriculaToolStripMenuItem,
            this.consultarNotasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Matricula";
            // 
            // matriculaToolStripMenuItem
            // 
            this.matriculaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.realizarMatriculaToolStripMenuItem});
            this.matriculaToolStripMenuItem.Name = "matriculaToolStripMenuItem";
            this.matriculaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.matriculaToolStripMenuItem.Text = "Matricula";
            this.matriculaToolStripMenuItem.Click += new System.EventHandler(this.matriculaToolStripMenuItem_Click);
            // 
            // consultarNotasToolStripMenuItem
            // 
            this.consultarNotasToolStripMenuItem.Name = "consultarNotasToolStripMenuItem";
            this.consultarNotasToolStripMenuItem.Size = new System.Drawing.Size(102, 20);
            this.consultarNotasToolStripMenuItem.Text = "Consultar notas";
            this.consultarNotasToolStripMenuItem.Click += new System.EventHandler(this.consultarNotasToolStripMenuItem_Click);
            // 
            // realizarMatriculaToolStripMenuItem
            // 
            this.realizarMatriculaToolStripMenuItem.Name = "realizarMatriculaToolStripMenuItem";
            this.realizarMatriculaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.realizarMatriculaToolStripMenuItem.Text = "Realizar matricula";
            this.realizarMatriculaToolStripMenuItem.Click += new System.EventHandler(this.realizarMatriculaToolStripMenuItem_Click);
            // 
            // LobbyEstudiante
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "LobbyEstudiante";
            this.Text = "LobbyEstudiante";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem matriculaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarNotasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem realizarMatriculaToolStripMenuItem;
    }
}