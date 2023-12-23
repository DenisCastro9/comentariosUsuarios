
namespace finalTP2
{
    partial class alta_comentario
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.fechaC_dtp = new System.Windows.Forms.DateTimePicker();
            this.comentario_txt = new System.Windows.Forms.TextBox();
            this.nombre_cmb = new System.Windows.Forms.ComboBox();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalTP2DataSet = new finalTP2.finalTP2DataSet();
            this.redSocial_cmb = new System.Windows.Forms.ComboBox();
            this.redSocialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalTP2DataSet1 = new finalTP2.finalTP2DataSet1();
            this.usuariosTableAdapter = new finalTP2.finalTP2DataSetTableAdapters.usuariosTableAdapter();
            this.redSocialTableAdapter = new finalTP2.finalTP2DataSet1TableAdapters.redSocialTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalTP2DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redSocialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalTP2DataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fecha y Hora del comentario: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(122, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Comentario: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(68, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nombre del Usuario: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 290);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Red Social: ";
            // 
            // fechaC_dtp
            // 
            this.fechaC_dtp.Location = new System.Drawing.Point(230, 50);
            this.fechaC_dtp.Name = "fechaC_dtp";
            this.fechaC_dtp.Size = new System.Drawing.Size(200, 22);
            this.fechaC_dtp.TabIndex = 4;
            // 
            // comentario_txt
            // 
            this.comentario_txt.Location = new System.Drawing.Point(230, 111);
            this.comentario_txt.Multiline = true;
            this.comentario_txt.Name = "comentario_txt";
            this.comentario_txt.Size = new System.Drawing.Size(237, 96);
            this.comentario_txt.TabIndex = 5;
            // 
            // nombre_cmb
            // 
            this.nombre_cmb.DataSource = this.usuariosBindingSource;
            this.nombre_cmb.DisplayMember = "nombre";
            this.nombre_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.nombre_cmb.FormattingEnabled = true;
            this.nombre_cmb.Location = new System.Drawing.Point(230, 234);
            this.nombre_cmb.Name = "nombre_cmb";
            this.nombre_cmb.Size = new System.Drawing.Size(200, 24);
            this.nombre_cmb.TabIndex = 6;
            this.nombre_cmb.ValueMember = "id_usuario";
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "usuarios";
            this.usuariosBindingSource.DataSource = this.finalTP2DataSet;
            // 
            // finalTP2DataSet
            // 
            this.finalTP2DataSet.DataSetName = "finalTP2DataSet";
            this.finalTP2DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // redSocial_cmb
            // 
            this.redSocial_cmb.DataSource = this.redSocialBindingSource;
            this.redSocial_cmb.DisplayMember = "nombre";
            this.redSocial_cmb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.redSocial_cmb.FormattingEnabled = true;
            this.redSocial_cmb.Location = new System.Drawing.Point(230, 287);
            this.redSocial_cmb.Name = "redSocial_cmb";
            this.redSocial_cmb.Size = new System.Drawing.Size(135, 24);
            this.redSocial_cmb.TabIndex = 7;
            this.redSocial_cmb.ValueMember = "id_redSocial";
            // 
            // redSocialBindingSource
            // 
            this.redSocialBindingSource.DataMember = "redSocial";
            this.redSocialBindingSource.DataSource = this.finalTP2DataSet1;
            // 
            // finalTP2DataSet1
            // 
            this.finalTP2DataSet1.DataSetName = "finalTP2DataSet1";
            this.finalTP2DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // redSocialTableAdapter
            // 
            this.redSocialTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(189, 355);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 42);
            this.button1.TabIndex = 8;
            this.button1.Text = "Comentar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // alta_comentario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.redSocial_cmb);
            this.Controls.Add(this.nombre_cmb);
            this.Controls.Add(this.comentario_txt);
            this.Controls.Add(this.fechaC_dtp);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "alta_comentario";
            this.Text = "alta_comentario";
            this.Load += new System.EventHandler(this.alta_comentario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalTP2DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redSocialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalTP2DataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker fechaC_dtp;
        private System.Windows.Forms.TextBox comentario_txt;
        private System.Windows.Forms.ComboBox nombre_cmb;
        private System.Windows.Forms.ComboBox redSocial_cmb;
        private finalTP2DataSet finalTP2DataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private finalTP2DataSetTableAdapters.usuariosTableAdapter usuariosTableAdapter;
        private finalTP2DataSet1 finalTP2DataSet1;
        private System.Windows.Forms.BindingSource redSocialBindingSource;
        private finalTP2DataSet1TableAdapters.redSocialTableAdapter redSocialTableAdapter;
        private System.Windows.Forms.Button button1;
    }
}