namespace WINMYSQL.LISTAS
{
    partial class FrmMaterias
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
            splitContainer1 = new SplitContainer();
            dtbMaterias = new DataGridView();
            label1 = new Label();
            txtMaterias = new TextBox();
            btnAgregarMaterias = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dtbMaterias).BeginInit();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnAgregarMaterias);
            splitContainer1.Panel1.Controls.Add(txtMaterias);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(dtbMaterias);
            splitContainer1.Size = new Size(810, 486);
            splitContainer1.SplitterDistance = 102;
            splitContainer1.TabIndex = 0;
            // 
            // dtbMaterias
            // 
            dtbMaterias.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtbMaterias.Dock = DockStyle.Fill;
            dtbMaterias.Location = new Point(0, 0);
            dtbMaterias.Name = "dtbMaterias";
            dtbMaterias.RowHeadersWidth = 51;
            dtbMaterias.Size = new Size(810, 380);
            dtbMaterias.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 9);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 0;
            label1.Text = "Buscar";
            // 
            // txtMaterias
            // 
            txtMaterias.Location = new Point(32, 32);
            txtMaterias.Name = "txtMaterias";
            txtMaterias.Size = new Size(611, 27);
            txtMaterias.TabIndex = 1;
            // 
            // btnAgregarMaterias
            // 
            btnAgregarMaterias.Location = new Point(672, 32);
            btnAgregarMaterias.Name = "btnAgregarMaterias";
            btnAgregarMaterias.Size = new Size(94, 29);
            btnAgregarMaterias.TabIndex = 2;
            btnAgregarMaterias.Text = "AGREGAR";
            btnAgregarMaterias.UseVisualStyleBackColor = true;
            // 
            // FrmMaterias
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 486);
            Controls.Add(splitContainer1);
            Name = "FrmMaterias";
            Text = "Materias";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dtbMaterias).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Button btnAgregarMaterias;
        private TextBox txtMaterias;
        private Label label1;
        private DataGridView dtbMaterias;
    }
}