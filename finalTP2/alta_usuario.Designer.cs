
namespace finalTP2
{
    partial class alta_usuario
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
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.nombre_txt = new System.Windows.Forms.TextBox();
            this.apellido_txt = new System.Windows.Forms.TextBox();
            this.celular_txt = new System.Windows.Forms.TextBox();
            this.mail_txt = new System.Windows.Forms.TextBox();
            this.fecha_dtp = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Apellido: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 183);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Fecha de Nacimiento: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "numero Celular: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(106, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "E-mail: ";
            // 
            // nombre_txt
            // 
            this.nombre_txt.Location = new System.Drawing.Point(167, 65);
            this.nombre_txt.Name = "nombre_txt";
            this.nombre_txt.Size = new System.Drawing.Size(116, 22);
            this.nombre_txt.TabIndex = 5;
            // 
            // apellido_txt
            // 
            this.apellido_txt.Location = new System.Drawing.Point(167, 124);
            this.apellido_txt.Name = "apellido_txt";
            this.apellido_txt.Size = new System.Drawing.Size(116, 22);
            this.apellido_txt.TabIndex = 6;
            // 
            // celular_txt
            // 
            this.celular_txt.Location = new System.Drawing.Point(167, 239);
            this.celular_txt.Name = "celular_txt";
            this.celular_txt.Size = new System.Drawing.Size(100, 22);
            this.celular_txt.TabIndex = 7;
            // 
            // mail_txt
            // 
            this.mail_txt.Location = new System.Drawing.Point(167, 296);
            this.mail_txt.Name = "mail_txt";
            this.mail_txt.Size = new System.Drawing.Size(186, 22);
            this.mail_txt.TabIndex = 8;
            // 
            // fecha_dtp
            // 
            this.fecha_dtp.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha_dtp.Location = new System.Drawing.Point(167, 178);
            this.fecha_dtp.Name = "fecha_dtp";
            this.fecha_dtp.Size = new System.Drawing.Size(116, 22);
            this.fecha_dtp.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(167, 353);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 34);
            this.button1.TabIndex = 10;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alta_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.fecha_dtp);
            this.Controls.Add(this.mail_txt);
            this.Controls.Add(this.celular_txt);
            this.Controls.Add(this.apellido_txt);
            this.Controls.Add(this.nombre_txt);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "alta_usuario";
            this.Text = "alta_usuario";
            this.Load += new System.EventHandler(this.alta_usuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox nombre_txt;
        private System.Windows.Forms.TextBox apellido_txt;
        private System.Windows.Forms.TextBox celular_txt;
        private System.Windows.Forms.TextBox mail_txt;
        private System.Windows.Forms.DateTimePicker fecha_dtp;
        private System.Windows.Forms.Button button1;
    }
}