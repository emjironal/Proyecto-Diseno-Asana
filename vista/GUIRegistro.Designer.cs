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
            this.tBNombre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cBisAdmin = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tBCorreo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tBNombre
            // 
            this.tBNombre.Location = new System.Drawing.Point(176, 190);
            this.tBNombre.Name = "tBNombre";
            this.tBNombre.Size = new System.Drawing.Size(388, 31);
            this.tBNombre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Correo:";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nombre:";
            // 
            // cBisAdmin
            // 
            this.cBisAdmin.AutoSize = true;
            this.cBisAdmin.Location = new System.Drawing.Point(176, 277);
            this.cBisAdmin.Name = "cBisAdmin";
            this.cBisAdmin.Size = new System.Drawing.Size(207, 29);
            this.cBisAdmin.TabIndex = 4;
            this.cBisAdmin.Text = "Es Administrador";
            this.cBisAdmin.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(545, 37);
            this.label3.TabIndex = 5;
            this.label3.Text = "Completar información del Usuario";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(437, 340);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(149, 48);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Registrar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // tBCorreo
            // 
            this.tBCorreo.Location = new System.Drawing.Point(176, 107);
            this.tBCorreo.Name = "tBCorreo";
            this.tBCorreo.Size = new System.Drawing.Size(388, 31);
            this.tBCorreo.TabIndex = 7;
            // 
            // GUIRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tBCorreo);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cBisAdmin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tBNombre);
            this.Name = "GUIRegistro";
            this.Text = "ASANA Upgrade";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tBNombre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cBisAdmin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tBCorreo;
    }
}