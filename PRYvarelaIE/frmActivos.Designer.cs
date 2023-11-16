namespace PRYvarelaIE
{
    partial class frmActivos
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
            this.rtbContenido = new System.Windows.Forms.RichTextBox();
            this.tvCarpetas = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(443, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(341, 29);
            this.label1.TabIndex = 7;
            this.label1.Text = "SELECCIONE UN ARCHIVO";
            // 
            // rtbContenido
            // 
            this.rtbContenido.Location = new System.Drawing.Point(-116, 174);
            this.rtbContenido.Margin = new System.Windows.Forms.Padding(4);
            this.rtbContenido.Name = "rtbContenido";
            this.rtbContenido.ReadOnly = true;
            this.rtbContenido.Size = new System.Drawing.Size(1033, 312);
            this.rtbContenido.TabIndex = 6;
            this.rtbContenido.Text = "";
            // 
            // tvCarpetas
            // 
            this.tvCarpetas.Location = new System.Drawing.Point(-116, -35);
            this.tvCarpetas.Margin = new System.Windows.Forms.Padding(4);
            this.tvCarpetas.Name = "tvCarpetas";
            this.tvCarpetas.Size = new System.Drawing.Size(368, 175);
            this.tvCarpetas.TabIndex = 5;
            // 
            // frmActivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.rtbContenido);
            this.Controls.Add(this.tvCarpetas);
            this.Name = "frmActivos";
            this.Text = "frmActivos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbContenido;
        private System.Windows.Forms.TreeView tvCarpetas;
    }
}