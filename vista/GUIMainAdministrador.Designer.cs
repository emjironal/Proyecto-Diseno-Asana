namespace Proyecto_Diseno_Asana.vista
{
    partial class GUIMainAdministrador
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
            this.btnImportar = new System.Windows.Forms.Button();
            this.btnCompletar = new System.Windows.Forms.Button();
            this.lblProyectos = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Actualizar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Administrar = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menú Administrador";
            // 
            // btnImportar
            // 
            this.btnImportar.Location = new System.Drawing.Point(50, 100);
            this.btnImportar.Name = "btnImportar";
            this.btnImportar.Size = new System.Drawing.Size(228, 54);
            this.btnImportar.TabIndex = 1;
            this.btnImportar.Text = "Importar Proyecto";
            this.btnImportar.UseVisualStyleBackColor = true;
            this.btnImportar.Click += new System.EventHandler(this.BtnImportar_Click);
            // 
            // btnCompletar
            // 
            this.btnCompletar.Location = new System.Drawing.Point(767, 100);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(228, 54);
            this.btnCompletar.TabIndex = 2;
            this.btnCompletar.Text = "Completar Usuario";
            this.btnCompletar.UseVisualStyleBackColor = true;
            this.btnCompletar.Click += new System.EventHandler(this.BtnCompletar_Click);
            // 
            // lblProyectos
            // 
            this.lblProyectos.AutoEllipsis = true;
            this.lblProyectos.AutoSize = true;
            this.lblProyectos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProyectos.Location = new System.Drawing.Point(61, 188);
            this.lblProyectos.Name = "lblProyectos";
            this.lblProyectos.Size = new System.Drawing.Size(136, 31);
            this.lblProyectos.TabIndex = 3;
            this.lblProyectos.Text = "Proyectos";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Nombre,
            this.Actualizar,
            this.Administrar});
            this.dataGridView1.Location = new System.Drawing.Point(50, 286);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(956, 274);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridView1_CellClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 10;
            this.ID.Name = "ID";
            this.ID.Visible = false;
            this.ID.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.MinimumWidth = 10;
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 200;
            // 
            // Actualizar
            // 
            this.Actualizar.HeaderText = "Actualizar";
            this.Actualizar.MinimumWidth = 10;
            this.Actualizar.Name = "Actualizar";
            this.Actualizar.Width = 200;
            // 
            // Administrar
            // 
            this.Administrar.HeaderText = "Administrar";
            this.Administrar.MinimumWidth = 10;
            this.Administrar.Name = "Administrar";
            this.Administrar.Width = 200;
            // 
            // GUIMainAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 636);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.lblProyectos);
            this.Controls.Add(this.btnCompletar);
            this.Controls.Add(this.btnImportar);
            this.Controls.Add(this.label1);
            this.Name = "GUIMainAdministrador";
            this.Text = "ASANA upgrade";
            this.Load += new System.EventHandler(this.GUIMainAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnImportar;
        private System.Windows.Forms.Button btnCompletar;
        private System.Windows.Forms.Label lblProyectos;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn Actualizar;
        private System.Windows.Forms.DataGridViewButtonColumn Administrar;
    }
}