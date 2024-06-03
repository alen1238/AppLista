namespace AppLista
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cmbGenero = new ComboBox();
            label4 = new Label();
            cmbDisponible = new ComboBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            txtISBN = new TextBox();
            menuStrip1 = new MenuStrip();
            registrarToolStripMenuItem = new ToolStripMenuItem();
            consultarToolStripMenuItem = new ToolStripMenuItem();
            eliminarToolStripMenuItem = new ToolStripMenuItem();
            label6 = new Label();
            txtAutor = new TextBox();
            txtTitulo = new TextBox();
            dgvLista = new DataGridView();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLista).BeginInit();
            SuspendLayout();
            // 
            // cmbGenero
            // 
            cmbGenero.FormattingEnabled = true;
            cmbGenero.Items.AddRange(new object[] { "Novela", "Ensayo", "Poesia", "Cuento", "Otro" });
            cmbGenero.Location = new Point(781, 90);
            cmbGenero.Name = "cmbGenero";
            cmbGenero.Size = new Size(132, 33);
            cmbGenero.TabIndex = 42;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(657, 165);
            label4.Name = "label4";
            label4.Size = new Size(97, 25);
            label4.TabIndex = 39;
            label4.Text = "Disponible";
            // 
            // cmbDisponible
            // 
            cmbDisponible.FormattingEnabled = true;
            cmbDisponible.Items.AddRange(new object[] { "true", "false" });
            cmbDisponible.Location = new Point(781, 157);
            cmbDisponible.Name = "cmbDisponible";
            cmbDisponible.Size = new Size(132, 33);
            cmbDisponible.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(675, 93);
            label3.Name = "label3";
            label3.Size = new Size(69, 25);
            label3.TabIndex = 37;
            label3.Text = "Género";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(144, 144);
            label2.Name = "label2";
            label2.Size = new Size(56, 25);
            label2.TabIndex = 36;
            label2.Text = "Titulo";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 95);
            label1.Name = "label1";
            label1.Size = new Size(50, 25);
            label1.TabIndex = 34;
            label1.Text = "ISBN";
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(259, 87);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(288, 31);
            txtISBN.TabIndex = 33;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(24, 24);
            menuStrip1.Items.AddRange(new ToolStripItem[] { registrarToolStripMenuItem, consultarToolStripMenuItem, eliminarToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1106, 33);
            menuStrip1.TabIndex = 32;
            menuStrip1.Text = "menuStrip1";
            // 
            // registrarToolStripMenuItem
            // 
            registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            registrarToolStripMenuItem.Size = new Size(97, 29);
            registrarToolStripMenuItem.Text = "Registrar";
            registrarToolStripMenuItem.Click += registrarToolStripMenuItem_Click;
            // 
            // consultarToolStripMenuItem
            // 
            consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            consultarToolStripMenuItem.Size = new Size(103, 29);
            consultarToolStripMenuItem.Text = "Consultar";
            consultarToolStripMenuItem.Click += consultarToolStripMenuItem_Click;
            // 
            // eliminarToolStripMenuItem
            // 
            eliminarToolStripMenuItem.Name = "eliminarToolStripMenuItem";
            eliminarToolStripMenuItem.Size = new Size(90, 29);
            eliminarToolStripMenuItem.Text = "Eliminar";
            eliminarToolStripMenuItem.Click += eliminarToolStripMenuItem_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(150, 201);
            label6.Name = "label6";
            label6.Size = new Size(57, 25);
            label6.TabIndex = 44;
            label6.Text = "Autor";
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(259, 198);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(288, 31);
            txtAutor.TabIndex = 43;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(259, 144);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(288, 31);
            txtTitulo.TabIndex = 45;
            // 
            // dgvLista
            // 
            dgvLista.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLista.Location = new Point(162, 268);
            dgvLista.Name = "dgvLista";
            dgvLista.RowHeadersWidth = 62;
            dgvLista.RowTemplate.Height = 33;
            dgvLista.Size = new Size(783, 225);
            dgvLista.TabIndex = 46;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1106, 622);
            Controls.Add(dgvLista);
            Controls.Add(txtTitulo);
            Controls.Add(label6);
            Controls.Add(txtAutor);
            Controls.Add(cmbGenero);
            Controls.Add(label4);
            Controls.Add(cmbDisponible);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtISBN);
            Controls.Add(menuStrip1);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLista).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbGenero;
        private DateTimePicker dtFecha;
        private Label label5;
        private Label label4;
        private ComboBox cmbDisponible;
        private Label label3;
        private Label label2;
        private TextBox txtDestino;
        private Label label1;
        private TextBox txtISBN;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem registrarToolStripMenuItem;
        private Label label6;
        private TextBox txtAutor;
        private TextBox txtTitulo;
        private ToolStripMenuItem consultarToolStripMenuItem;
        private ToolStripMenuItem eliminarToolStripMenuItem;
        private DataGridView dgvLista;
    }
}