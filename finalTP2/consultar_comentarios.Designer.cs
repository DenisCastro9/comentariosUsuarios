
namespace finalTP2
{
    partial class consultar_comentarios
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idcomentarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechahoraDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idredSocialDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.comentariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalTP2DataSet2 = new finalTP2.finalTP2DataSet2();
            this.comentariosTableAdapter = new finalTP2.finalTP2DataSet2TableAdapters.comentariosTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.redSocialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.finalTP2DataSet3 = new finalTP2.finalTP2DataSet3();
            this.redSocialTableAdapter = new finalTP2.finalTP2DataSet3TableAdapters.redSocialTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comentariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalTP2DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.redSocialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalTP2DataSet3)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idcomentarioDataGridViewTextBoxColumn,
            this.fechahoraDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.idusuarioDataGridViewTextBoxColumn,
            this.idredSocialDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.comentariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 166);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(787, 260);
            this.dataGridView1.TabIndex = 0;
            // 
            // idcomentarioDataGridViewTextBoxColumn
            // 
            this.idcomentarioDataGridViewTextBoxColumn.DataPropertyName = "id_comentario";
            this.idcomentarioDataGridViewTextBoxColumn.HeaderText = "id_comentario";
            this.idcomentarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idcomentarioDataGridViewTextBoxColumn.Name = "idcomentarioDataGridViewTextBoxColumn";
            this.idcomentarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcomentarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // fechahoraDataGridViewTextBoxColumn
            // 
            this.fechahoraDataGridViewTextBoxColumn.DataPropertyName = "fecha_hora";
            this.fechahoraDataGridViewTextBoxColumn.HeaderText = "fecha_hora";
            this.fechahoraDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.fechahoraDataGridViewTextBoxColumn.Name = "fechahoraDataGridViewTextBoxColumn";
            this.fechahoraDataGridViewTextBoxColumn.Width = 125;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "descripcion";
            this.descripcionDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.Width = 125;
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            this.idusuarioDataGridViewTextBoxColumn.DataPropertyName = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "id_usuario";
            this.idusuarioDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            this.idusuarioDataGridViewTextBoxColumn.Width = 125;
            // 
            // idredSocialDataGridViewTextBoxColumn
            // 
            this.idredSocialDataGridViewTextBoxColumn.DataPropertyName = "id_redSocial";
            this.idredSocialDataGridViewTextBoxColumn.HeaderText = "id_redSocial";
            this.idredSocialDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idredSocialDataGridViewTextBoxColumn.Name = "idredSocialDataGridViewTextBoxColumn";
            this.idredSocialDataGridViewTextBoxColumn.Width = 125;
            // 
            // comentariosBindingSource
            // 
            this.comentariosBindingSource.DataMember = "comentarios";
            this.comentariosBindingSource.DataSource = this.finalTP2DataSet2;
            // 
            // finalTP2DataSet2
            // 
            this.finalTP2DataSet2.DataSetName = "finalTP2DataSet2";
            this.finalTP2DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // comentariosTableAdapter
            // 
            this.comentariosTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Filtrar por Nombre: ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(160, 81);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(155, 22);
            this.textBox1.TabIndex = 2;
            this.textBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox1_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(377, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Filtrar Red Social: ";
            // 
            // comboBox1
            // 
            this.comboBox1.DataSource = this.redSocialBindingSource;
            this.comboBox1.DisplayMember = "nombre";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(507, 81);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 4;
            this.comboBox1.ValueMember = "id_redSocial";
            this.comboBox1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.comboBox1_KeyUp);
            // 
            // redSocialBindingSource
            // 
            this.redSocialBindingSource.DataMember = "redSocial";
            this.redSocialBindingSource.DataSource = this.finalTP2DataSet3;
            // 
            // finalTP2DataSet3
            // 
            this.finalTP2DataSet3.DataSetName = "finalTP2DataSet3";
            this.finalTP2DataSet3.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // redSocialTableAdapter
            // 
            this.redSocialTableAdapter.ClearBeforeFill = true;
            // 
            // consultar_comentarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(811, 450);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "consultar_comentarios";
            this.Text = "consultar_comentarios";
            this.Load += new System.EventHandler(this.consultar_comentarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comentariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalTP2DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.redSocialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.finalTP2DataSet3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private finalTP2DataSet2 finalTP2DataSet2;
        private System.Windows.Forms.BindingSource comentariosBindingSource;
        private finalTP2DataSet2TableAdapters.comentariosTableAdapter comentariosTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcomentarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechahoraDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idredSocialDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private finalTP2DataSet3 finalTP2DataSet3;
        private System.Windows.Forms.BindingSource redSocialBindingSource;
        private finalTP2DataSet3TableAdapters.redSocialTableAdapter redSocialTableAdapter;
    }
}