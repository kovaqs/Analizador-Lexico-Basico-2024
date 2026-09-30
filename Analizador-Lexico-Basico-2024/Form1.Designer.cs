
namespace Analizador_Lexico_Basico_2024
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pnBarra = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dICCIONARIOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diccionarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarCódigoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarSalidaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.diccionarioToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pnSalida = new System.Windows.Forms.Panel();
            this.dgTablaSalida = new System.Windows.Forms.DataGridView();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.toolStripSalida = new System.Windows.Forms.ToolStripMenuItem();
            this.pnCodigo = new System.Windows.Forms.Panel();
            this.richCodigo = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAnalizar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.pnBarra.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnSalida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaSalida)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.pnCodigo.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnBarra
            // 
            this.pnBarra.Controls.Add(this.btnSalir);
            this.pnBarra.Controls.Add(this.pictureBox1);
            this.pnBarra.Controls.Add(this.panel4);
            this.pnBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBarra.Location = new System.Drawing.Point(0, 0);
            this.pnBarra.Name = "pnBarra";
            this.pnBarra.Size = new System.Drawing.Size(1301, 36);
            this.pnBarra.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dICCIONARIOToolStripMenuItem,
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(15, 36);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1286, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dICCIONARIOToolStripMenuItem
            // 
            this.dICCIONARIOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diccionarioToolStripMenuItem1,
            this.guardarCódigoToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.exportarSalidaToolStripMenuItem});
            this.dICCIONARIOToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.dICCIONARIOToolStripMenuItem.Name = "dICCIONARIOToolStripMenuItem";
            this.dICCIONARIOToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.dICCIONARIOToolStripMenuItem.Text = "&Archivo";
            this.dICCIONARIOToolStripMenuItem.Click += new System.EventHandler(this.dICCIONARIOToolStripMenuItem_Click);
            // 
            // diccionarioToolStripMenuItem1
            // 
            this.diccionarioToolStripMenuItem1.Name = "diccionarioToolStripMenuItem1";
            this.diccionarioToolStripMenuItem1.Size = new System.Drawing.Size(233, 26);
            this.diccionarioToolStripMenuItem1.Text = "Abrir";
            this.diccionarioToolStripMenuItem1.Click += new System.EventHandler(this.diccionarioToolStripMenuItem1_Click);
            // 
            // guardarCódigoToolStripMenuItem
            // 
            this.guardarCódigoToolStripMenuItem.Name = "guardarCódigoToolStripMenuItem";
            this.guardarCódigoToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.guardarCódigoToolStripMenuItem.Text = "Guardar";
            this.guardarCódigoToolStripMenuItem.Click += new System.EventHandler(this.guardarCódigoToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.guardarComoToolStripMenuItem.Text = "Guardar como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // exportarSalidaToolStripMenuItem
            // 
            this.exportarSalidaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pDFToolStripMenuItem,
            this.cSVToolStripMenuItem});
            this.exportarSalidaToolStripMenuItem.Name = "exportarSalidaToolStripMenuItem";
            this.exportarSalidaToolStripMenuItem.Size = new System.Drawing.Size(233, 26);
            this.exportarSalidaToolStripMenuItem.Text = "Exportar Salida (CSV)";
            this.exportarSalidaToolStripMenuItem.Click += new System.EventHandler(this.exportarSalidaToolStripMenuItem_Click);
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.diccionarioToolStripMenuItem2});
            this.configuraciónToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(156)))), ((int)(((byte)(156)))));
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(116, 24);
            this.configuraciónToolStripMenuItem.Text = "&Configuración";
            // 
            // diccionarioToolStripMenuItem2
            // 
            this.diccionarioToolStripMenuItem2.Name = "diccionarioToolStripMenuItem2";
            this.diccionarioToolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.diccionarioToolStripMenuItem2.Text = "Diccionario";
            this.diccionarioToolStripMenuItem2.Click += new System.EventHandler(this.diccionarioToolStripMenuItem2_Click);
            // 
            // panel3
            // 
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 815);
            this.panel3.TabIndex = 3;
            // 
            // panel4
            // 
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(3, 36);
            this.panel4.TabIndex = 4;
            // 
            // pnSalida
            // 
            this.pnSalida.Controls.Add(this.dgTablaSalida);
            this.pnSalida.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnSalida.Location = new System.Drawing.Point(15, 573);
            this.pnSalida.Name = "pnSalida";
            this.pnSalida.Size = new System.Drawing.Size(1286, 278);
            this.pnSalida.TabIndex = 6;
            this.pnSalida.Visible = false;
            // 
            // dgTablaSalida
            // 
            this.dgTablaSalida.AllowUserToAddRows = false;
            this.dgTablaSalida.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgTablaSalida.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgTablaSalida.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.dgTablaSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgTablaSalida.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgTablaSalida.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(44)))));
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgTablaSalida.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.dgTablaSalida.ColumnHeadersHeight = 40;
            this.dgTablaSalida.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgTablaSalida.EnableHeadersVisualStyles = false;
            this.dgTablaSalida.Location = new System.Drawing.Point(0, 0);
            this.dgTablaSalida.Name = "dgTablaSalida";
            this.dgTablaSalida.ReadOnly = true;
            this.dgTablaSalida.RowHeadersVisible = false;
            this.dgTablaSalida.RowHeadersWidth = 51;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(202)))), ((int)(((byte)(230)))));
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(48)))), ((int)(((byte)(71)))));
            this.dgTablaSalida.RowsDefaultCellStyle = dataGridViewCellStyle14;
            this.dgTablaSalida.RowTemplate.Height = 24;
            this.dgTablaSalida.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgTablaSalida.Size = new System.Drawing.Size(1286, 278);
            this.dgTablaSalida.TabIndex = 76;
            // 
            // menuStrip2
            // 
            this.menuStrip2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.menuStrip2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSalida});
            this.menuStrip2.Location = new System.Drawing.Point(15, 545);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1286, 28);
            this.menuStrip2.TabIndex = 7;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // toolStripSalida
            // 
            this.toolStripSalida.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.toolStripSalida.Checked = true;
            this.toolStripSalida.CheckOnClick = true;
            this.toolStripSalida.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripSalida.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSalida.ForeColor = System.Drawing.Color.Silver;
            this.toolStripSalida.Name = "toolStripSalida";
            this.toolStripSalida.Size = new System.Drawing.Size(64, 24);
            this.toolStripSalida.Text = "Salida";
            this.toolStripSalida.Click += new System.EventHandler(this.toolStripMenuItem1_Click_1);
            // 
            // pnCodigo
            // 
            this.pnCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.pnCodigo.Controls.Add(this.richCodigo);
            this.pnCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnCodigo.Location = new System.Drawing.Point(15, 100);
            this.pnCodigo.Name = "pnCodigo";
            this.pnCodigo.Size = new System.Drawing.Size(1286, 445);
            this.pnCodigo.TabIndex = 8;
            // 
            // richCodigo
            // 
            this.richCodigo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(27)))), ((int)(((byte)(39)))), ((int)(((byte)(48)))));
            this.richCodigo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richCodigo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richCodigo.Font = new System.Drawing.Font("Consolas", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richCodigo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(195)))), ((int)(((byte)(229)))));
            this.richCodigo.Location = new System.Drawing.Point(0, 0);
            this.richCodigo.Name = "richCodigo";
            this.richCodigo.Size = new System.Drawing.Size(1286, 445);
            this.richCodigo.TabIndex = 0;
            this.richCodigo.Text = "Abra un archivo de java, c++ o C# \n;)";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAnalizar);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(15, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1286, 36);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(3, 36);
            this.panel2.TabIndex = 4;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "icons8-play-24.png");
            // 
            // pDFToolStripMenuItem
            // 
            this.pDFToolStripMenuItem.Name = "pDFToolStripMenuItem";
            this.pDFToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.pDFToolStripMenuItem.Text = "PDF";
            this.pDFToolStripMenuItem.Click += new System.EventHandler(this.pDFToolStripMenuItem_Click);
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.cSVToolStripMenuItem.Text = "CSV";
            this.cSVToolStripMenuItem.Click += new System.EventHandler(this.cSVToolStripMenuItem_Click);
            // 
            // btnAnalizar
            // 
            this.btnAnalizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAnalizar.FlatAppearance.BorderSize = 0;
            this.btnAnalizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnalizar.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnalizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(205)))), ((int)(((byte)(97)))));
            this.btnAnalizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAnalizar.ImageIndex = 0;
            this.btnAnalizar.ImageList = this.imageList1;
            this.btnAnalizar.Location = new System.Drawing.Point(3, 0);
            this.btnAnalizar.Name = "btnAnalizar";
            this.btnAnalizar.Size = new System.Drawing.Size(102, 36);
            this.btnAnalizar.TabIndex = 5;
            this.btnAnalizar.Text = "Iniciar";
            this.btnAnalizar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAnalizar.UseVisualStyleBackColor = true;
            this.btnAnalizar.Click += new System.EventHandler(this.btnAnalizar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::Analizador_Lexico_Basico_2024.Properties.Resources.icons8_estudio_visual_60;
            this.pictureBox1.Location = new System.Drawing.Point(3, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(46, 36);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Transparent;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSalir.FlatAppearance.BorderSize = 0;
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(77)))), ((int)(((byte)(47)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(229)))), ((int)(((byte)(210)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(1254, 0);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(47, 36);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "X";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(23)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(1301, 851);
            this.Controls.Add(this.pnCodigo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip2);
            this.Controls.Add(this.pnSalida);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pnBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.pnBarra.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnSalida.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgTablaSalida)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.pnCodigo.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnBarra;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem dICCIONARIOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diccionarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem guardarCódigoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarSalidaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem diccionarioToolStripMenuItem2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel pnSalida;
        private System.Windows.Forms.DataGridView dgTablaSalida;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem toolStripSalida;
        private System.Windows.Forms.Panel pnCodigo;
        private System.Windows.Forms.RichTextBox richCodigo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAnalizar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem pDFToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cSVToolStripMenuItem;
        private System.Windows.Forms.Button btnSalir;
    }
}

