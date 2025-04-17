namespace presentacion
{
    partial class frmAgregarEvento
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
            this.btnAgregarEventoCancel = new System.Windows.Forms.Button();
            this.btnAgregarEventoOK = new System.Windows.Forms.Button();
            this.tbxAgregarEventoTipo = new System.Windows.Forms.TextBox();
            this.lblAgregarEventoTipo = new System.Windows.Forms.Label();
            this.gbxAgregarEventoDescripcion = new System.Windows.Forms.GroupBox();
            this.tbxAgregarEventoDetalle = new System.Windows.Forms.TextBox();
            this.tbxAgregarEventoPersona = new System.Windows.Forms.TextBox();
            this.lblAgregarEventoPersona = new System.Windows.Forms.Label();
            this.lblAgregarEventoTitulo = new System.Windows.Forms.Label();
            this.tbxAgregarEventoTractor = new System.Windows.Forms.TextBox();
            this.lblAgregarEventoTractor = new System.Windows.Forms.Label();
            this.gbxAgregarEventoDescripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregarEventoCancel
            // 
            this.btnAgregarEventoCancel.Location = new System.Drawing.Point(165, 369);
            this.btnAgregarEventoCancel.Name = "btnAgregarEventoCancel";
            this.btnAgregarEventoCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEventoCancel.TabIndex = 10;
            this.btnAgregarEventoCancel.Text = "Cancelar";
            this.btnAgregarEventoCancel.UseVisualStyleBackColor = true;
            this.btnAgregarEventoCancel.Click += new System.EventHandler(this.btnAgregarEventoCancel_Click);
            // 
            // btnAgregarEventoOK
            // 
            this.btnAgregarEventoOK.Location = new System.Drawing.Point(17, 369);
            this.btnAgregarEventoOK.Name = "btnAgregarEventoOK";
            this.btnAgregarEventoOK.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarEventoOK.TabIndex = 9;
            this.btnAgregarEventoOK.Text = "Agregar";
            this.btnAgregarEventoOK.UseVisualStyleBackColor = true;
            this.btnAgregarEventoOK.Click += new System.EventHandler(this.btnAgregarEventoOK_Click);
            // 
            // tbxAgregarEventoTipo
            // 
            this.tbxAgregarEventoTipo.Location = new System.Drawing.Point(90, 102);
            this.tbxAgregarEventoTipo.Name = "tbxAgregarEventoTipo";
            this.tbxAgregarEventoTipo.Size = new System.Drawing.Size(150, 20);
            this.tbxAgregarEventoTipo.TabIndex = 7;
            // 
            // lblAgregarEventoTipo
            // 
            this.lblAgregarEventoTipo.AutoSize = true;
            this.lblAgregarEventoTipo.Location = new System.Drawing.Point(87, 86);
            this.lblAgregarEventoTipo.Name = "lblAgregarEventoTipo";
            this.lblAgregarEventoTipo.Size = new System.Drawing.Size(79, 13);
            this.lblAgregarEventoTipo.TabIndex = 0;
            this.lblAgregarEventoTipo.Text = "Tipo de evento";
            // 
            // gbxAgregarEventoDescripcion
            // 
            this.gbxAgregarEventoDescripcion.Controls.Add(this.tbxAgregarEventoDetalle);
            this.gbxAgregarEventoDescripcion.Location = new System.Drawing.Point(17, 141);
            this.gbxAgregarEventoDescripcion.Name = "gbxAgregarEventoDescripcion";
            this.gbxAgregarEventoDescripcion.Size = new System.Drawing.Size(223, 222);
            this.gbxAgregarEventoDescripcion.TabIndex = 0;
            this.gbxAgregarEventoDescripcion.TabStop = false;
            this.gbxAgregarEventoDescripcion.Text = "Descripción";
            // 
            // tbxAgregarEventoDetalle
            // 
            this.tbxAgregarEventoDetalle.AllowDrop = true;
            this.tbxAgregarEventoDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbxAgregarEventoDetalle.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxAgregarEventoDetalle.Location = new System.Drawing.Point(6, 19);
            this.tbxAgregarEventoDetalle.Multiline = true;
            this.tbxAgregarEventoDetalle.Name = "tbxAgregarEventoDetalle";
            this.tbxAgregarEventoDetalle.Size = new System.Drawing.Size(211, 197);
            this.tbxAgregarEventoDetalle.TabIndex = 8;
            // 
            // tbxAgregarEventoPersona
            // 
            this.tbxAgregarEventoPersona.Location = new System.Drawing.Point(17, 57);
            this.tbxAgregarEventoPersona.Name = "tbxAgregarEventoPersona";
            this.tbxAgregarEventoPersona.Size = new System.Drawing.Size(223, 20);
            this.tbxAgregarEventoPersona.TabIndex = 5;
            // 
            // lblAgregarEventoPersona
            // 
            this.lblAgregarEventoPersona.AutoSize = true;
            this.lblAgregarEventoPersona.Location = new System.Drawing.Point(14, 41);
            this.lblAgregarEventoPersona.Name = "lblAgregarEventoPersona";
            this.lblAgregarEventoPersona.Size = new System.Drawing.Size(38, 13);
            this.lblAgregarEventoPersona.TabIndex = 0;
            this.lblAgregarEventoPersona.Text = "Chofer";
            // 
            // lblAgregarEventoTitulo
            // 
            this.lblAgregarEventoTitulo.AutoSize = true;
            this.lblAgregarEventoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgregarEventoTitulo.Location = new System.Drawing.Point(56, 9);
            this.lblAgregarEventoTitulo.Name = "lblAgregarEventoTitulo";
            this.lblAgregarEventoTitulo.Size = new System.Drawing.Size(147, 25);
            this.lblAgregarEventoTitulo.TabIndex = 0;
            this.lblAgregarEventoTitulo.Text = "Nuevo Evento";
            // 
            // tbxAgregarEventoTractor
            // 
            this.tbxAgregarEventoTractor.Location = new System.Drawing.Point(17, 102);
            this.tbxAgregarEventoTractor.Name = "tbxAgregarEventoTractor";
            this.tbxAgregarEventoTractor.Size = new System.Drawing.Size(52, 20);
            this.tbxAgregarEventoTractor.TabIndex = 6;
            // 
            // lblAgregarEventoTractor
            // 
            this.lblAgregarEventoTractor.AutoSize = true;
            this.lblAgregarEventoTractor.Location = new System.Drawing.Point(14, 86);
            this.lblAgregarEventoTractor.Name = "lblAgregarEventoTractor";
            this.lblAgregarEventoTractor.Size = new System.Drawing.Size(41, 13);
            this.lblAgregarEventoTractor.TabIndex = 0;
            this.lblAgregarEventoTractor.Text = "Tractor";
            // 
            // frmAgregarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(259, 405);
            this.Controls.Add(this.tbxAgregarEventoTractor);
            this.Controls.Add(this.lblAgregarEventoTractor);
            this.Controls.Add(this.btnAgregarEventoCancel);
            this.Controls.Add(this.btnAgregarEventoOK);
            this.Controls.Add(this.tbxAgregarEventoTipo);
            this.Controls.Add(this.lblAgregarEventoTipo);
            this.Controls.Add(this.gbxAgregarEventoDescripcion);
            this.Controls.Add(this.tbxAgregarEventoPersona);
            this.Controls.Add(this.lblAgregarEventoPersona);
            this.Controls.Add(this.lblAgregarEventoTitulo);
            this.Name = "frmAgregarEvento";
            this.Text = "AgregarEvento";
            this.Load += new System.EventHandler(this.AgregarEvento_Load);
            this.gbxAgregarEventoDescripcion.ResumeLayout(false);
            this.gbxAgregarEventoDescripcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAgregarEventoCancel;
        private System.Windows.Forms.Button btnAgregarEventoOK;
        private System.Windows.Forms.TextBox tbxAgregarEventoTipo;
        private System.Windows.Forms.Label lblAgregarEventoTipo;
        private System.Windows.Forms.GroupBox gbxAgregarEventoDescripcion;
        private System.Windows.Forms.TextBox tbxAgregarEventoDetalle;
        private System.Windows.Forms.TextBox tbxAgregarEventoPersona;
        private System.Windows.Forms.Label lblAgregarEventoPersona;
        private System.Windows.Forms.Label lblAgregarEventoTitulo;
        private System.Windows.Forms.TextBox tbxAgregarEventoTractor;
        private System.Windows.Forms.Label lblAgregarEventoTractor;
    }
}