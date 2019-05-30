namespace Proyecto_Diseno_Asana.vista
{
    partial class GUIRegistro
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
            this.btnCompletar = new System.Windows.Forms.Button();
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.cBisAdmin = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tBCorreo = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCompletar
            // 
            this.btnCompletar.Location = new System.Drawing.Point(161, 329);
            this.btnCompletar.Name = "btnCompletar";
            this.btnCompletar.Size = new System.Drawing.Size(200, 48);
            this.btnCompletar.TabIndex = 11;
            this.btnCompletar.Text = "Completar";
            this.btnCompletar.UseVisualStyleBackColor = true;
            this.btnCompletar.Click += new System.EventHandler(this.BtnCompletar_Click);
            // 
            // tBNombre
            // 
            this.tBNombre.Location = new System.Drawing.Point(161, 184);
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(410, 31);
            this.tBNombre.TabIndex = 10;
            // 
            // cBisAdmin
            // 
            this.cBisAdmin.AutoSize = true;
            this.cBisAdmin.Location = new System.Drawing.Point(161, 266);
            this.cBisAdmin.Name = "cBisAdmin";
            this.cBisAdmin.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cBisAdmin.Size = new System.Drawing.Size(207, 29);
            this.cBisAdmin.TabIndex = 9;
            this.cBisAdmin.Text = "Es Administrador";
            this.cBisAdmin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.cBisAdmin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Correo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(29, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Completar Usuario";
            // 
            // tBCorreo
            // 
            this.tBCorreo.Location = new System.Drawing.Point(161, 116);
            this.tBCorreo.Name = "tBCorreo";
            this.tBCorreo.Size = new System.Drawing.Size(410, 31);
            this.tBCorreo.TabIndex = 12;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(434, 329);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(200, 48);
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.Button1_Click);
            // 
            // GUIRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.tBCorreo);
            this.Controls.Add(this.btnCompletar);
            this.Controls.Add(this.tBNombre);
            this.Controls.Add(this.cBisAdmin);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "GUIRegistro";
            this.Text = "ASANA upgrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCompletar;
        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.CheckBox cBisAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tBCorreo;
        private System.Windows.Forms.Button btnCancelar;
    }
}