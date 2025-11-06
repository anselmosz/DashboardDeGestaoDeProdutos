namespace GPSFA_WinForms
{
    partial class frmVoluntarios
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
            this.lblVoluntarios = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblVoluntarios
            // 
            this.lblVoluntarios.AutoSize = true;
            this.lblVoluntarios.Location = new System.Drawing.Point(12, 9);
            this.lblVoluntarios.Name = "lblVoluntarios";
            this.lblVoluntarios.Size = new System.Drawing.Size(168, 20);
            this.lblVoluntarios.TabIndex = 1;
            this.lblVoluntarios.Text = "Gestao de Voluntarios";
            // 
            // frmVoluntarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 681);
            this.Controls.Add(this.lblVoluntarios);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmVoluntarios";
            this.Text = "frmVoluntarios";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVoluntarios;
    }
}