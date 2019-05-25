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
            this.btnImportNew = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCompletar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnImportNew
            // 
            this.btnImportNew.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImportNew.Location = new System.Drawing.Point(41, 107);
            this.btnImportNew.Name = "btnImportNew";
            this.btnImportNew.Size = new System.Drawing.Size(344, 45);
            this.btnImportNew.TabIndex = 0;
            this.btnImportNew.Text = "Importar Proyecto Nuevo";
            this.btnImportNew.UseVisualStyleBackColor = true;
            this.btnImportNew.Click += new System.EventHandler(this.BtnImportNew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Proyectos:";
            // 
            // btnCompletar
            // 
            this.btnCompletar.Location = new System.Drawing.Point(817, 107);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(233, 45);
            this.btnCompletar.TabIndex = 2;
            this.btnCompletar.Text = "Completar Usuario";
            this.btnCompletar.UseVisualStyleBackColor = true;
            this.btnCompletar.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(323, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Menú Administrador";
            // 
            // GUIMainAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1137, 752);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCompletar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnImportNew);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "GUIMainAdministrador";
            this.Text = "ASANA Upgrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnImportNew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCompletar;
        private System.Windows.Forms.Label label2;
    }
}