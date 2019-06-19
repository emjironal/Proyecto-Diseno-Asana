namespace Proyecto_Diseno_Asana.vista
{
    partial class GUIAvance
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
            this.lb_subtask_name = new System.Windows.Forms.Label();
            this.lb_horas_dedicadas = new System.Windows.Forms.Label();
            this.spn_horas_dedicadas = new System.Windows.Forms.NumericUpDown();
            this.lb_descripcion = new System.Windows.Forms.Label();
            this.txt_descripcion = new System.Windows.Forms.RichTextBox();
            this.lb_adjuntar_documento = new System.Windows.Forms.Label();
            this.btn_seleccionar_archivo = new System.Windows.Forms.Button();
            this.btn_registrar_avance = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.table_archivos_seleccionados = new System.Windows.Forms.DataGridView();
            this.nombre_archivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipo_archivo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel6 = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.spn_horas_dedicadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_archivos_seleccionados)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.tableLayoutPanel4.SuspendLayout();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_subtask_name
            // 
            this.lb_subtask_name.AutoSize = true;
            this.lb_subtask_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_subtask_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subtask_name.Location = new System.Drawing.Point(9, 7);
            this.lb_subtask_name.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_subtask_name.Name = "lb_subtask_name";
            this.lb_subtask_name.Size = new System.Drawing.Size(191, 31);
            this.lb_subtask_name.TabIndex = 0;
            this.lb_subtask_name.Text = "Nuevo Avance";
            // 
            // lb_horas_dedicadas
            // 
            this.lb_horas_dedicadas.AutoSize = true;
            this.lb_horas_dedicadas.BackColor = System.Drawing.Color.Transparent;
            this.lb_horas_dedicadas.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_horas_dedicadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_horas_dedicadas.Location = new System.Drawing.Point(2, 0);
            this.lb_horas_dedicadas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_horas_dedicadas.Name = "lb_horas_dedicadas";
            this.lb_horas_dedicadas.Size = new System.Drawing.Size(354, 20);
            this.lb_horas_dedicadas.TabIndex = 1;
            this.lb_horas_dedicadas.Text = "Horas dedicadas";
            // 
            // spn_horas_dedicadas
            // 
            this.spn_horas_dedicadas.Dock = System.Windows.Forms.DockStyle.Top;
            this.spn_horas_dedicadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spn_horas_dedicadas.Location = new System.Drawing.Point(360, 2);
            this.spn_horas_dedicadas.Margin = new System.Windows.Forms.Padding(2);
            this.spn_horas_dedicadas.Name = "spn_horas_dedicadas";
            this.spn_horas_dedicadas.Size = new System.Drawing.Size(150, 28);
            this.spn_horas_dedicadas.TabIndex = 2;
            // 
            // lb_descripcion
            // 
            this.lb_descripcion.AutoSize = true;
            this.lb_descripcion.BackColor = System.Drawing.Color.Transparent;
            this.lb_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_descripcion.Location = new System.Drawing.Point(2, 89);
            this.lb_descripcion.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_descripcion.Name = "lb_descripcion";
            this.lb_descripcion.Size = new System.Drawing.Size(92, 20);
            this.lb_descripcion.TabIndex = 3;
            this.lb_descripcion.Text = "Descripción";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(2, 150);
            this.txt_descripcion.Margin = new System.Windows.Forms.Padding(2);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(512, 443);
            this.txt_descripcion.TabIndex = 4;
            this.txt_descripcion.Text = "";
            // 
            // lb_adjuntar_documento
            // 
            this.lb_adjuntar_documento.AutoSize = true;
            this.lb_adjuntar_documento.BackColor = System.Drawing.Color.Transparent;
            this.lb_adjuntar_documento.Dock = System.Windows.Forms.DockStyle.Top;
            this.lb_adjuntar_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_adjuntar_documento.Location = new System.Drawing.Point(2, 0);
            this.lb_adjuntar_documento.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_adjuntar_documento.Name = "lb_adjuntar_documento";
            this.lb_adjuntar_documento.Size = new System.Drawing.Size(252, 20);
            this.lb_adjuntar_documento.TabIndex = 5;
            this.lb_adjuntar_documento.Text = "Adjuntar documento";
            // 
            // btn_seleccionar_archivo
            // 
            this.btn_seleccionar_archivo.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_seleccionar_archivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_seleccionar_archivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar_archivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_seleccionar_archivo.Location = new System.Drawing.Point(258, 2);
            this.btn_seleccionar_archivo.Margin = new System.Windows.Forms.Padding(2);
            this.btn_seleccionar_archivo.Name = "btn_seleccionar_archivo";
            this.btn_seleccionar_archivo.Size = new System.Drawing.Size(252, 46);
            this.btn_seleccionar_archivo.TabIndex = 6;
            this.btn_seleccionar_archivo.Text = "Seleccionar archivo";
            this.btn_seleccionar_archivo.UseVisualStyleBackColor = false;
            this.btn_seleccionar_archivo.Click += new System.EventHandler(this.Btn_seleccionar_archivo_Click);
            // 
            // btn_registrar_avance
            // 
            this.btn_registrar_avance.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_registrar_avance.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_registrar_avance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_avance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_registrar_avance.Location = new System.Drawing.Point(258, 5);
            this.btn_registrar_avance.Margin = new System.Windows.Forms.Padding(2);
            this.btn_registrar_avance.Name = "btn_registrar_avance";
            this.btn_registrar_avance.Size = new System.Drawing.Size(252, 49);
            this.btn_registrar_avance.TabIndex = 7;
            this.btn_registrar_avance.Text = "Registrar avance";
            this.btn_registrar_avance.UseVisualStyleBackColor = false;
            this.btn_registrar_avance.Click += new System.EventHandler(this.Btn_registrar_avance_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancelar.Location = new System.Drawing.Point(2, 5);
            this.btn_cancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(252, 49);
            this.btn_cancelar.TabIndex = 8;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = false;
            this.btn_cancelar.Click += new System.EventHandler(this.Btn_cancelar_Click);
            // 
            // table_archivos_seleccionados
            // 
            this.table_archivos_seleccionados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_archivos_seleccionados.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre_archivo,
            this.tipo_archivo});
            this.table_archivos_seleccionados.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table_archivos_seleccionados.Location = new System.Drawing.Point(2, 91);
            this.table_archivos_seleccionados.Margin = new System.Windows.Forms.Padding(2);
            this.table_archivos_seleccionados.Name = "table_archivos_seleccionados";
            this.table_archivos_seleccionados.RowHeadersWidth = 51;
            this.table_archivos_seleccionados.RowTemplate.Height = 24;
            this.table_archivos_seleccionados.Size = new System.Drawing.Size(512, 442);
            this.table_archivos_seleccionados.TabIndex = 9;
            // 
            // nombre_archivo
            // 
            this.nombre_archivo.HeaderText = "Nombre del archivo";
            this.nombre_archivo.MinimumWidth = 6;
            this.nombre_archivo.Name = "nombre_archivo";
            this.nombre_archivo.Width = 400;
            // 
            // tipo_archivo
            // 
            this.tipo_archivo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tipo_archivo.HeaderText = "Tipo";
            this.tipo_archivo.MinimumWidth = 6;
            this.tipo_archivo.Name = "tipo_archivo";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(14, 63);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1040, 599);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.lb_descripcion, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.txt_descripcion, 0, 2);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 3;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(516, 595);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 2;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel3.Controls.Add(this.lb_horas_dedicadas, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.spn_horas_dedicadas, 1, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(512, 85);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 1;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.table_archivos_seleccionados, 0, 1);
            this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel6, 0, 2);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(522, 2);
            this.tableLayoutPanel4.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 3;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75F));
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(516, 595);
            this.tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel5.ColumnCount = 2;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Controls.Add(this.lb_adjuntar_documento, 0, 0);
            this.tableLayoutPanel5.Controls.Add(this.btn_seleccionar_archivo, 1, 0);
            this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel5.Location = new System.Drawing.Point(2, 2);
            this.tableLayoutPanel5.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 1;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(512, 85);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            this.tableLayoutPanel6.ColumnCount = 2;
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Controls.Add(this.btn_cancelar, 0, 0);
            this.tableLayoutPanel6.Controls.Add(this.btn_registrar_avance, 1, 0);
            this.tableLayoutPanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel6.Location = new System.Drawing.Point(2, 537);
            this.tableLayoutPanel6.Margin = new System.Windows.Forms.Padding(2);
            this.tableLayoutPanel6.Name = "tableLayoutPanel6";
            this.tableLayoutPanel6.RowCount = 1;
            this.tableLayoutPanel6.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel6.Size = new System.Drawing.Size(512, 56);
            this.tableLayoutPanel6.TabIndex = 1;
            // 
            // GUIAvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto_Diseno_Asana.Properties.Resources.Bwhite_bg;
            this.ClientSize = new System.Drawing.Size(1063, 668);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.lb_subtask_name);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GUIAvance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ASANA upgrade";
            ((System.ComponentModel.ISupportInitialize)(this.spn_horas_dedicadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_archivos_seleccionados)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.tableLayoutPanel4.ResumeLayout(false);
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel5.PerformLayout();
            this.tableLayoutPanel6.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_subtask_name;
        private System.Windows.Forms.Label lb_horas_dedicadas;
        private System.Windows.Forms.NumericUpDown spn_horas_dedicadas;
        private System.Windows.Forms.Label lb_descripcion;
        private System.Windows.Forms.RichTextBox txt_descripcion;
        private System.Windows.Forms.Label lb_adjuntar_documento;
        private System.Windows.Forms.Button btn_seleccionar_archivo;
        private System.Windows.Forms.Button btn_registrar_avance;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.DataGridView table_archivos_seleccionados;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre_archivo;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipo_archivo;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel6;
    }
}