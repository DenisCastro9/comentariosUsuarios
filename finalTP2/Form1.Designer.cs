
namespace finalTP2
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDeUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarUsuarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargarUnComentarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.comentariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarComentariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redesSocialesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administrarToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.altaDeRedSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bajaDeRedSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarRedSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.comentariosToolStripMenuItem,
            this.redesSocialesToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem,
            this.consultarToolStripMenuItem,
            this.cargarUnComentarioToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(79, 24);
            this.toolStripMenuItem1.Text = "Usuarios";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeUsuarioToolStripMenuItem,
            this.bajaDeUsuarioToolStripMenuItem,
            this.modificarUsuarioToolStripMenuItem});
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.administrarToolStripMenuItem.Text = "Administrar";
            // 
            // altaDeUsuarioToolStripMenuItem
            // 
            this.altaDeUsuarioToolStripMenuItem.Name = "altaDeUsuarioToolStripMenuItem";
            this.altaDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.altaDeUsuarioToolStripMenuItem.Text = "Alta de Usuario";
            this.altaDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.altaDeUsuarioToolStripMenuItem_Click);
            // 
            // bajaDeUsuarioToolStripMenuItem
            // 
            this.bajaDeUsuarioToolStripMenuItem.Name = "bajaDeUsuarioToolStripMenuItem";
            this.bajaDeUsuarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.bajaDeUsuarioToolStripMenuItem.Text = "Baja de Usuario";
            this.bajaDeUsuarioToolStripMenuItem.Click += new System.EventHandler(this.bajaDeUsuarioToolStripMenuItem_Click);
            // 
            // modificarUsuarioToolStripMenuItem
            // 
            this.modificarUsuarioToolStripMenuItem.Name = "modificarUsuarioToolStripMenuItem";
            this.modificarUsuarioToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.modificarUsuarioToolStripMenuItem.Text = "Modificar Usuario";
            this.modificarUsuarioToolStripMenuItem.Click += new System.EventHandler(this.modificarUsuarioToolStripMenuItem_Click);
            // 
            // consultarToolStripMenuItem
            // 
            this.consultarToolStripMenuItem.Name = "consultarToolStripMenuItem";
            this.consultarToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.consultarToolStripMenuItem.Text = "Consultar";
            this.consultarToolStripMenuItem.Click += new System.EventHandler(this.consultarToolStripMenuItem_Click);
            // 
            // cargarUnComentarioToolStripMenuItem
            // 
            this.cargarUnComentarioToolStripMenuItem.Name = "cargarUnComentarioToolStripMenuItem";
            this.cargarUnComentarioToolStripMenuItem.Size = new System.Drawing.Size(238, 26);
            this.cargarUnComentarioToolStripMenuItem.Text = "Cargar un Comentario";
            this.cargarUnComentarioToolStripMenuItem.Click += new System.EventHandler(this.cargarUnComentarioToolStripMenuItem_Click);
            // 
            // comentariosToolStripMenuItem
            // 
            this.comentariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultarComentariosToolStripMenuItem});
            this.comentariosToolStripMenuItem.Name = "comentariosToolStripMenuItem";
            this.comentariosToolStripMenuItem.Size = new System.Drawing.Size(107, 24);
            this.comentariosToolStripMenuItem.Text = "Comentarios";
            // 
            // consultarComentariosToolStripMenuItem
            // 
            this.consultarComentariosToolStripMenuItem.Name = "consultarComentariosToolStripMenuItem";
            this.consultarComentariosToolStripMenuItem.Size = new System.Drawing.Size(242, 26);
            this.consultarComentariosToolStripMenuItem.Text = "Consultar Comentarios";
            this.consultarComentariosToolStripMenuItem.Click += new System.EventHandler(this.consultarComentariosToolStripMenuItem_Click);
            // 
            // redesSocialesToolStripMenuItem
            // 
            this.redesSocialesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem1});
            this.redesSocialesToolStripMenuItem.Name = "redesSocialesToolStripMenuItem";
            this.redesSocialesToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.redesSocialesToolStripMenuItem.Text = "Redes Sociales";
            // 
            // administrarToolStripMenuItem1
            // 
            this.administrarToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.altaDeRedSocialToolStripMenuItem,
            this.bajaDeRedSocialToolStripMenuItem,
            this.modificarRedSocialToolStripMenuItem});
            this.administrarToolStripMenuItem1.Name = "administrarToolStripMenuItem1";
            this.administrarToolStripMenuItem1.Size = new System.Drawing.Size(224, 26);
            this.administrarToolStripMenuItem1.Text = "Administrar";
            // 
            // altaDeRedSocialToolStripMenuItem
            // 
            this.altaDeRedSocialToolStripMenuItem.Name = "altaDeRedSocialToolStripMenuItem";
            this.altaDeRedSocialToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.altaDeRedSocialToolStripMenuItem.Text = "Alta de Red Social";
            this.altaDeRedSocialToolStripMenuItem.Click += new System.EventHandler(this.altaDeRedSocialToolStripMenuItem_Click);
            // 
            // bajaDeRedSocialToolStripMenuItem
            // 
            this.bajaDeRedSocialToolStripMenuItem.Name = "bajaDeRedSocialToolStripMenuItem";
            this.bajaDeRedSocialToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.bajaDeRedSocialToolStripMenuItem.Text = "Baja de Red Social";
            this.bajaDeRedSocialToolStripMenuItem.Click += new System.EventHandler(this.bajaDeRedSocialToolStripMenuItem_Click);
            // 
            // modificarRedSocialToolStripMenuItem
            // 
            this.modificarRedSocialToolStripMenuItem.Name = "modificarRedSocialToolStripMenuItem";
            this.modificarRedSocialToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.modificarRedSocialToolStripMenuItem.Text = "Modificar Red Social";
            this.modificarRedSocialToolStripMenuItem.Click += new System.EventHandler(this.modificarRedSocialToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altaDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDeUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarUsuarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargarUnComentarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem comentariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarComentariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redesSocialesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem altaDeRedSocialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bajaDeRedSocialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarRedSocialToolStripMenuItem;
    }
}

