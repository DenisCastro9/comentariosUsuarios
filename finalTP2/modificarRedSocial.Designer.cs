
namespace finalTP2
{
    partial class modificarRedSocial
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.idR_txt = new System.Windows.Forms.TextBox();
            this.nombreR_txt = new System.Windows.Forms.TextBox();
            this.descripcionR_txt = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID de Red Social a modificar: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre de Red Social: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 214);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(174, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Descripcion de Red Social";
            // 
            // idR_txt
            // 
            this.idR_txt.Location = new System.Drawing.Point(226, 67);
            this.idR_txt.Name = "idR_txt";
            this.idR_txt.Size = new System.Drawing.Size(100, 22);
            this.idR_txt.TabIndex = 3;
            // 
            // nombreR_txt
            // 
            this.nombreR_txt.Location = new System.Drawing.Point(226, 151);
            this.nombreR_txt.Name = "nombreR_txt";
            this.nombreR_txt.Size = new System.Drawing.Size(100, 22);
            this.nombreR_txt.TabIndex = 4;
            // 
            // descripcionR_txt
            // 
            this.descripcionR_txt.Location = new System.Drawing.Point(226, 211);
            this.descripcionR_txt.Multiline = true;
            this.descripcionR_txt.Name = "descripcionR_txt";
            this.descripcionR_txt.Size = new System.Drawing.Size(181, 91);
            this.descripcionR_txt.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(332, 64);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 6;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(165, 331);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 29);
            this.button2.TabIndex = 7;
            this.button2.Text = "Modificar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // modificarRedSocial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 396);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.descripcionR_txt);
            this.Controls.Add(this.nombreR_txt);
            this.Controls.Add(this.idR_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "modificarRedSocial";
            this.Text = "modificarRedSocial";
            this.Load += new System.EventHandler(this.modificarRedSocial_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox idR_txt;
        private System.Windows.Forms.TextBox nombreR_txt;
        private System.Windows.Forms.TextBox descripcionR_txt;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}