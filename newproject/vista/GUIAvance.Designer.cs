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
            ((System.ComponentModel.ISupportInitialize)(this.spn_horas_dedicadas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_archivos_seleccionados)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_subtask_name
            // 
            this.lb_subtask_name.AutoSize = true;
            this.lb_subtask_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_subtask_name.Location = new System.Drawing.Point(12, 9);
            this.lb_subtask_name.Name = "lb_subtask_name";
            this.lb_subtask_name.Size = new System.Drawing.Size(147, 38);
            this.lb_subtask_name.TabIndex = 0;
            this.lb_subtask_name.Text = "SubTask";
            // 
            // lb_horas_dedicadas
            // 
            this.lb_horas_dedicadas.AutoSize = true;
            this.lb_horas_dedicadas.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_horas_dedicadas.Location = new System.Drawing.Point(13, 70);
            this.lb_horas_dedicadas.Name = "lb_horas_dedicadas";
            this.lb_horas_dedicadas.Size = new System.Drawing.Size(159, 25);
            this.lb_horas_dedicadas.TabIndex = 1;
            this.lb_horas_dedicadas.Text = "Horas dedicadas";
            // 
            // spn_horas_dedicadas
            // 
            this.spn_horas_dedicadas.Location = new System.Drawing.Point(205, 73);
            this.spn_horas_dedicadas.Name = "spn_horas_dedicadas";
            this.spn_horas_dedicadas.Size = new System.Drawing.Size(50, 22);
            this.spn_horas_dedicadas.TabIndex = 2;
            // 
            // lb_descripcion
            // 
            this.lb_descripcion.AutoSize = true;
            this.lb_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_descripcion.Location = new System.Drawing.Point(13, 115);
            this.lb_descripcion.Name = "lb_descripcion";
            this.lb_descripcion.Size = new System.Drawing.Size(114, 25);
            this.lb_descripcion.TabIndex = 3;
            this.lb_descripcion.Text = "Descripción";
            // 
            // txt_descripcion
            // 
            this.txt_descripcion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_descripcion.Location = new System.Drawing.Point(18, 153);
            this.txt_descripcion.Name = "txt_descripcion";
            this.txt_descripcion.Size = new System.Drawing.Size(381, 261);
            this.txt_descripcion.TabIndex = 4;
            this.txt_descripcion.Text = "";
            // 
            // lb_adjuntar_documento
            // 
            this.lb_adjuntar_documento.AutoSize = true;
            this.lb_adjuntar_documento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_adjuntar_documento.Location = new System.Drawing.Point(417, 70);
            this.lb_adjuntar_documento.Name = "lb_adjuntar_documento";
            this.lb_adjuntar_documento.Size = new System.Drawing.Size(187, 25);
            this.lb_adjuntar_documento.TabIndex = 5;
            this.lb_adjuntar_documento.Text = "Adjuntar documento";
            // 
            // btn_seleccionar_archivo
            // 
            this.btn_seleccionar_archivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_seleccionar_archivo.Location = new System.Drawing.Point(621, 64);
            this.btn_seleccionar_archivo.Name = "btn_seleccionar_archivo";
            this.btn_seleccionar_archivo.Size = new System.Drawing.Size(202, 36);
            this.btn_seleccionar_archivo.TabIndex = 6;
            this.btn_seleccionar_archivo.Text = "Seleccionar archivo";
            this.btn_seleccionar_archivo.UseVisualStyleBackColor = true;
            this.btn_seleccionar_archivo.Click += new System.EventHandler(this.Btn_seleccionar_archivo_Click);
            // 
            // btn_registrar_avance
            // 
            this.btn_registrar_avance.BackColor = System.Drawing.Color.LimeGreen;
            this.btn_registrar_avance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registrar_avance.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_registrar_avance.Location = new System.Drawing.Point(645, 374);
            this.btn_registrar_avance.Name = "btn_registrar_avance";
            this.btn_registrar_avance.Size = new System.Drawing.Size(178, 40);
            this.btn_registrar_avance.TabIndex = 7;
            this.btn_registrar_avance.Text = "Registrar avance";
            this.btn_registrar_avance.UseVisualStyleBackColor = false;
            this.btn_registrar_avance.Click += new System.EventHandler(this.Btn_registrar_avance_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.BackColor = System.Drawing.Color.Red;
            this.btn_cancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cancelar.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_cancelar.Location = new System.Drawing.Point(422, 374);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(178, 40);
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
            this.table_archivos_seleccionados.Location = new System.Drawing.Point(422, 115);
            this.table_archivos_seleccionados.Name = "table_archivos_seleccionados";
            this.table_archivos_seleccionados.RowHeadersWidth = 51;
            this.table_archivos_seleccionados.RowTemplate.Height = 24;
            this.table_archivos_seleccionados.Size = new System.Drawing.Size(401, 253);
            this.table_archivos_seleccionados.TabIndex = 9;
            // 
            // nombre_archivo
            // 
            this.nombre_archivo.HeaderText = "Nombre del archivo";
            this.nombre_archivo.MinimumWidth = 6;
            this.nombre_archivo.Name = "nombre_archivo";
            this.nombre_archivo.Width = 125;
            // 
            // tipo_archivo
            // 
            this.tipo_archivo.HeaderText = "Tipo de archivo";
            this.tipo_archivo.MinimumWidth = 6;
            this.tipo_archivo.Name = "tipo_archivo";
            this.tipo_archivo.Width = 125;
            // 
            // GUIAvance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 444);
            this.Controls.Add(this.table_archivos_seleccionados);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_registrar_avance);
            this.Controls.Add(this.btn_seleccionar_archivo);
            this.Controls.Add(this.lb_adjuntar_documento);
            this.Controls.Add(this.txt_descripcion);
            this.Controls.Add(this.lb_descripcion);
            this.Controls.Add(this.spn_horas_dedicadas);
            this.Controls.Add(this.lb_horas_dedicadas);
            this.Controls.Add(this.lb_subtask_name);
            this.Name = "GUIAvance";
            this.Text = "GUIAvance";
            ((System.ComponentModel.ISupportInitialize)(this.spn_horas_dedicadas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.table_archivos_seleccionados)).EndInit();
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
    }
}