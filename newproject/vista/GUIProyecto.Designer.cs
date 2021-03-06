﻿namespace Proyecto_Diseno_Asana.vista
{
    partial class GUIProyecto
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lNombreProyecto = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnAgregarAvance = new System.Windows.Forms.Button();
            this.lNombreTarea = new System.Windows.Forms.Label();
            this.lNotas = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lFchEntrega = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.lEncargado = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gBEvidencias = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Creador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.gBEvidencias.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.treeView1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.treeView1.Location = new System.Drawing.Point(27, 86);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(394, 581);
            this.treeView1.TabIndex = 0;
            this.treeView1.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.TreeView1_NodeMouseClick);
            this.treeView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.TreeView1_KeyDown);
            // 
            // lNombreProyecto
            // 
            this.lNombreProyecto.AutoSize = true;
            this.lNombreProyecto.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreProyecto.Location = new System.Drawing.Point(28, 26);
            this.lNombreProyecto.Name = "lNombreProyecto";
            this.lNombreProyecto.Size = new System.Drawing.Size(130, 33);
            this.lNombreProyecto.TabIndex = 1;
            this.lNombreProyecto.Text = "Proyecto";
            this.lNombreProyecto.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.btnAgregarAvance, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.lNombreTarea, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lNotas, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.gBEvidencias, 0, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(427, 86);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12.61891F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.736168F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.736168F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 27.15977F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.97398F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 8.774995F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(638, 581);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // btnAgregarAvance
            // 
            this.btnAgregarAvance.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnAgregarAvance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnAgregarAvance.Enabled = false;
            this.btnAgregarAvance.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnAgregarAvance.Location = new System.Drawing.Point(3, 530);
            this.btnAgregarAvance.Name = "btnAgregarAvance";
            this.btnAgregarAvance.Size = new System.Drawing.Size(632, 48);
            this.btnAgregarAvance.TabIndex = 6;
            this.btnAgregarAvance.Text = "Agregar Avance";
            this.btnAgregarAvance.UseVisualStyleBackColor = false;
            this.btnAgregarAvance.Click += new System.EventHandler(this.BtnAgregarAvance_Click);
            // 
            // lNombreTarea
            // 
            this.lNombreTarea.AutoSize = true;
            this.lNombreTarea.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lNombreTarea.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNombreTarea.Location = new System.Drawing.Point(3, 0);
            this.lNombreTarea.Name = "lNombreTarea";
            this.lNombreTarea.Size = new System.Drawing.Size(632, 73);
            this.lNombreTarea.TabIndex = 0;
            this.lNombreTarea.Text = "Tarea";
            // 
            // lNotas
            // 
            this.lNotas.AutoSize = true;
            this.lNotas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lNotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNotas.Location = new System.Drawing.Point(3, 173);
            this.lNotas.Name = "lNotas";
            this.lNotas.Size = new System.Drawing.Size(632, 157);
            this.lNotas.TabIndex = 2;
            this.lNotas.Text = "Notas";
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.13513F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.86487F));
            this.tableLayoutPanel2.Controls.Add(this.pictureBox1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lFchEntrega, 1, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 126);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 44F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(632, 44);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox1.Image = global::Proyecto_Diseno_Asana.Properties.Resources.ultramini2;
            this.pictureBox1.Location = new System.Drawing.Point(40, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(21, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lFchEntrega
            // 
            this.lFchEntrega.AutoSize = true;
            this.lFchEntrega.Dock = System.Windows.Forms.DockStyle.Top;
            this.lFchEntrega.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lFchEntrega.Location = new System.Drawing.Point(67, 0);
            this.lFchEntrega.Name = "lFchEntrega";
            this.lFchEntrega.Size = new System.Drawing.Size(562, 16);
            this.lFchEntrega.TabIndex = 2;
            this.lFchEntrega.Text = "Fecha";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10.13513F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 89.86487F));
            this.tableLayoutPanel3.Controls.Add(this.lEncargado, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.pictureBox2, 0, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 76);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(632, 44);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // lEncargado
            // 
            this.lEncargado.AutoSize = true;
            this.lEncargado.Dock = System.Windows.Forms.DockStyle.Top;
            this.lEncargado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lEncargado.Location = new System.Drawing.Point(67, 0);
            this.lEncargado.Name = "lEncargado";
            this.lEncargado.Size = new System.Drawing.Size(562, 16);
            this.lEncargado.TabIndex = 0;
            this.lEncargado.Text = "Encargado";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = global::Proyecto_Diseno_Asana.Properties.Resources.iconEncargado;
            this.pictureBox2.Location = new System.Drawing.Point(40, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 38);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // gBEvidencias
            // 
            this.gBEvidencias.Controls.Add(this.dataGridView1);
            this.gBEvidencias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gBEvidencias.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gBEvidencias.Location = new System.Drawing.Point(3, 333);
            this.gBEvidencias.Name = "gBEvidencias";
            this.gBEvidencias.Size = new System.Drawing.Size(632, 191);
            this.gBEvidencias.TabIndex = 5;
            this.gBEvidencias.TabStop = false;
            this.gBEvidencias.Text = "Evidencias";
            this.gBEvidencias.Visible = false;
            this.gBEvidencias.Enter += new System.EventHandler(this.GBAvances_Enter);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Creador,
            this.Fecha});
            this.dataGridView1.Location = new System.Drawing.Point(-3, 38);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.Size = new System.Drawing.Size(626, 147);
            this.dataGridView1.TabIndex = 0;
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
            // Creador
            // 
            this.Creador.HeaderText = "Creador";
            this.Creador.MinimumWidth = 10;
            this.Creador.Name = "Creador";
            this.Creador.Width = 350;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.MinimumWidth = 10;
            this.Fecha.Name = "Fecha";
            // 
            // GUIProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Diseno_Asana.Properties.Resources.Bwhite_bg;
            this.ClientSize = new System.Drawing.Size(1073, 674);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lNombreProyecto);
            this.Controls.Add(this.treeView1);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUIProyecto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ASANA upgrade";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GUIProyecto_KeyDown);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.gBEvidencias.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lNombreProyecto;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lNombreTarea;
        private System.Windows.Forms.Label lEncargado;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lFchEntrega;
        private System.Windows.Forms.Label lNotas;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox gBEvidencias;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnAgregarAvance;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Creador;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}