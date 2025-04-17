namespace presentacion
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lblFiltrarEventos = new System.Windows.Forms.Label();
            this.tbxFiltrarEventos = new System.Windows.Forms.TextBox();
            this.dgvListarEventos = new System.Windows.Forms.DataGridView();
            this.btnFiltrarEventos = new System.Windows.Forms.Button();
            this.btnAgregarEvento = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pbxLogoPrincipal = new System.Windows.Forms.PictureBox();
            this.lblTituloPrincipal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEventos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFiltrarEventos
            // 
            this.lblFiltrarEventos.AutoSize = true;
            this.lblFiltrarEventos.Location = new System.Drawing.Point(273, 114);
            this.lblFiltrarEventos.Name = "lblFiltrarEventos";
            this.lblFiltrarEventos.Size = new System.Drawing.Size(29, 13);
            this.lblFiltrarEventos.TabIndex = 0;
            this.lblFiltrarEventos.Text = "Filtro";
            // 
            // tbxFiltrarEventos
            // 
            this.tbxFiltrarEventos.Location = new System.Drawing.Point(308, 111);
            this.tbxFiltrarEventos.Name = "tbxFiltrarEventos";
            this.tbxFiltrarEventos.Size = new System.Drawing.Size(221, 20);
            this.tbxFiltrarEventos.TabIndex = 1;
            this.tbxFiltrarEventos.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbxFiltrarEventos_DragEnter);
            // 
            // dgvListarEventos
            // 
            this.dgvListarEventos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListarEventos.Location = new System.Drawing.Point(12, 137);
            this.dgvListarEventos.Name = "dgvListarEventos";
            this.dgvListarEventos.Size = new System.Drawing.Size(597, 279);
            this.dgvListarEventos.TabIndex = 3;
            this.dgvListarEventos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvListarEventos_CellContentClick);
            this.dgvListarEventos.SelectionChanged += new System.EventHandler(this.dgvListarEventos_SelectionChanged);
            // 
            // btnFiltrarEventos
            // 
            this.btnFiltrarEventos.Location = new System.Drawing.Point(535, 109);
            this.btnFiltrarEventos.Name = "btnFiltrarEventos";
            this.btnFiltrarEventos.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrarEventos.TabIndex = 2;
            this.btnFiltrarEventos.Text = "Buscar";
            this.btnFiltrarEventos.UseVisualStyleBackColor = true;
            this.btnFiltrarEventos.Click += new System.EventHandler(this.btnFiltrarEventos_Click);
            // 
            // btnAgregarEvento
            // 
            this.btnAgregarEvento.Location = new System.Drawing.Point(510, 422);
            this.btnAgregarEvento.Name = "btnAgregarEvento";
            this.btnAgregarEvento.Size = new System.Drawing.Size(99, 23);
            this.btnAgregarEvento.TabIndex = 4;
            this.btnAgregarEvento.Text = "Nuevo Evento";
            this.btnAgregarEvento.UseVisualStyleBackColor = true;
            this.btnAgregarEvento.Click += new System.EventHandler(this.btnAgregarEvento_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // pbxLogoPrincipal
            // 
            this.pbxLogoPrincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pbxLogoPrincipal.Image = ((System.Drawing.Image)(resources.GetObject("pbxLogoPrincipal.Image")));
            this.pbxLogoPrincipal.InitialImage = ((System.Drawing.Image)(resources.GetObject("pbxLogoPrincipal.InitialImage")));
            this.pbxLogoPrincipal.Location = new System.Drawing.Point(12, 9);
            this.pbxLogoPrincipal.Name = "pbxLogoPrincipal";
            this.pbxLogoPrincipal.Size = new System.Drawing.Size(110, 100);
            this.pbxLogoPrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogoPrincipal.TabIndex = 5;
            this.pbxLogoPrincipal.TabStop = false;
            // 
            // lblTituloPrincipal
            // 
            this.lblTituloPrincipal.AutoSize = true;
            this.lblTituloPrincipal.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloPrincipal.Location = new System.Drawing.Point(158, 9);
            this.lblTituloPrincipal.Name = "lblTituloPrincipal";
            this.lblTituloPrincipal.Size = new System.Drawing.Size(298, 37);
            this.lblTituloPrincipal.TabIndex = 0;
            this.lblTituloPrincipal.Text = "Registro de eventos";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 449);
            this.Controls.Add(this.lblTituloPrincipal);
            this.Controls.Add(this.pbxLogoPrincipal);
            this.Controls.Add(this.btnAgregarEvento);
            this.Controls.Add(this.btnFiltrarEventos);
            this.Controls.Add(this.dgvListarEventos);
            this.Controls.Add(this.tbxFiltrarEventos);
            this.Controls.Add(this.lblFiltrarEventos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmPrincipal";
            this.Text = "Truck Controller";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListarEventos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogoPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFiltrarEventos;
        private System.Windows.Forms.TextBox tbxFiltrarEventos;
        private System.Windows.Forms.DataGridView dgvListarEventos;
        private System.Windows.Forms.Button btnFiltrarEventos;
        private System.Windows.Forms.Button btnAgregarEvento;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.PictureBox pbxLogoPrincipal;
        private System.Windows.Forms.Label lblTituloPrincipal;
    }
}