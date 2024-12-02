namespace Pedidos
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
            panel1 = new Panel();
            BtnRegistrar = new Button();
            txtDirecccion = new TextBox();
            label2 = new Label();
            txtNombrePedidos = new TextBox();
            label1 = new Label();
            dgvPedidos = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            NombrePedidos = new DataGridViewTextBoxColumn();
            Direccion = new DataGridViewTextBoxColumn();
            Fecha = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            panel3 = new Panel();
            BtnProcesar = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).BeginInit();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(BtnRegistrar);
            panel1.Controls.Add(txtDirecccion);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txtNombrePedidos);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(546, 277);
            panel1.TabIndex = 1;
            // 
            // BtnRegistrar
            // 
            BtnRegistrar.BackColor = Color.Transparent;
            BtnRegistrar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnRegistrar.Location = new Point(394, 205);
            BtnRegistrar.Margin = new Padding(3, 4, 3, 4);
            BtnRegistrar.Name = "BtnRegistrar";
            BtnRegistrar.Size = new Size(121, 45);
            BtnRegistrar.TabIndex = 4;
            BtnRegistrar.Text = "REGISTRAR";
            BtnRegistrar.UseVisualStyleBackColor = false;
            BtnRegistrar.Click += BtnRegistrar_Click;
            // 
            // txtDirecccion
            // 
            txtDirecccion.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtDirecccion.Location = new Point(34, 136);
            txtDirecccion.Margin = new Padding(3, 4, 3, 4);
            txtDirecccion.Name = "txtDirecccion";
            txtDirecccion.Size = new Size(481, 29);
            txtDirecccion.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(34, 109);
            label2.Name = "label2";
            label2.Size = new Size(85, 23);
            label2.TabIndex = 2;
            label2.Text = "Direccion:";
            // 
            // txtNombrePedidos
            // 
            txtNombrePedidos.Font = new Font("Segoe UI", 9.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            txtNombrePedidos.Location = new Point(31, 48);
            txtNombrePedidos.Margin = new Padding(3, 4, 3, 4);
            txtNombrePedidos.Name = "txtNombrePedidos";
            txtNombrePedidos.Size = new Size(484, 29);
            txtNombrePedidos.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(31, 24);
            label1.Name = "label1";
            label1.Size = new Size(183, 23);
            label1.TabIndex = 0;
            label1.Text = "Nombres de pedidos  :";
            // 
            // dgvPedidos
            // 
            dgvPedidos.AllowUserToAddRows = false;
            dgvPedidos.AllowUserToDeleteRows = false;
            dgvPedidos.BackgroundColor = Color.Gray;
            dgvPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPedidos.Columns.AddRange(new DataGridViewColumn[] { Id, NombrePedidos, Direccion, Fecha });
            dgvPedidos.GridColor = SystemColors.InactiveCaption;
            dgvPedidos.Location = new Point(3, 4);
            dgvPedidos.Margin = new Padding(3, 4, 3, 4);
            dgvPedidos.Name = "dgvPedidos";
            dgvPedidos.ReadOnly = true;
            dgvPedidos.RowHeadersWidth = 51;
            dgvPedidos.Size = new Size(550, 263);
            dgvPedidos.TabIndex = 2;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 125;
            // 
            // NombrePedidos
            // 
            NombrePedidos.HeaderText = "NombrePedidos";
            NombrePedidos.MinimumWidth = 6;
            NombrePedidos.Name = "NombrePedidos";
            NombrePedidos.ReadOnly = true;
            NombrePedidos.Width = 125;
            // 
            // Direccion
            // 
            Direccion.HeaderText = "Direccion";
            Direccion.MinimumWidth = 6;
            Direccion.Name = "Direccion";
            Direccion.ReadOnly = true;
            Direccion.Width = 125;
            // 
            // Fecha
            // 
            Fecha.HeaderText = "Fecha";
            Fecha.MinimumWidth = 6;
            Fecha.Name = "Fecha";
            Fecha.ReadOnly = true;
            Fecha.Width = 125;
            // 
            // panel2
            // 
            panel2.Controls.Add(panel1);
            panel2.Location = new Point(14, 16);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(563, 293);
            panel2.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Controls.Add(BtnProcesar);
            panel3.Controls.Add(dgvPedidos);
            panel3.Location = new Point(24, 317);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(690, 267);
            panel3.TabIndex = 4;
            // 
            // BtnProcesar
            // 
            BtnProcesar.BackColor = Color.Transparent;
            BtnProcesar.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnProcesar.Location = new Point(575, 4);
            BtnProcesar.Margin = new Padding(3, 4, 3, 4);
            BtnProcesar.Name = "BtnProcesar";
            BtnProcesar.Size = new Size(112, 43);
            BtnProcesar.TabIndex = 3;
            BtnProcesar.Text = "PROCESAR";
            BtnProcesar.UseVisualStyleBackColor = false;
            BtnProcesar.Click += BtnProcesar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPedidos).EndInit();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button BtnRegistrar;
        private TextBox txtDirecccion;
        private Label label2;
        private TextBox txtNombrePedidos;
        private Label label1;
        private DataGridView dgvPedidos;
        private Panel panel2;
        private Panel panel3;
        private Button BtnProcesar;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn NombrePedidos;
        private DataGridViewTextBoxColumn Direccion;
        private DataGridViewTextBoxColumn Fecha;
    }
}
