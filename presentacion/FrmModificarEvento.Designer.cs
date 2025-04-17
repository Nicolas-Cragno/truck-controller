namespace presentacion
{
    partial class FrmModificarEvento
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
            this.lblModificarEventoTitulo = new System.Windows.Forms.Label();
            this.tbxModificarEventoTractor = new System.Windows.Forms.TextBox();
            this.lblModificarEventoTractor = new System.Windows.Forms.Label();
            this.btnModificarEventoCancel = new System.Windows.Forms.Button();
            this.btnModificarEventoOK = new System.Windows.Forms.Button();
            this.tbxModificarEventoTipo = new System.Windows.Forms.TextBox();
            this.lblModificarEventoTipo = new System.Windows.Forms.Label();
            this.gbxModificarEventoDescripcion = new System.Windows.Forms.GroupBox();
            this.tbxModificarEventoDetalle = new System.Windows.Forms.TextBox();
            this.tbxModificarEventoPersona = new System.Windows.Forms.TextBox();
            this.lblModificarEventoPersona = new System.Windows.Forms.Label();
            this.lblModificarEventoIdEvento = new System.Windows.Forms.Label();
            this.gbxModificarEventoDescripcion.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblModificarEventoTitulo
            // 
            this.lblModificarEventoTitulo.AutoSize = true;
            this.lblModificarEventoTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarEventoTitulo.Location = new System.Drawing.Point(12, 9);
            this.lblModificarEventoTitulo.Name = "lblModificarEventoTitulo";
            this.lblModificarEventoTitulo.Size = new System.Drawing.Size(105, 25);
            this.lblModificarEventoTitulo.TabIndex = 0;
            this.lblModificarEventoTitulo.Text = "Evento n°";
            // 
            // tbxModificarEventoTractor
            // 
            this.tbxModificarEventoTractor.Location = new System.Drawing.Point(17, 103);
            this.tbxModificarEventoTractor.Name = "tbxModificarEventoTractor";
            this.tbxModificarEventoTractor.Size = new System.Drawing.Size(52, 20);
            this.tbxModificarEventoTractor.TabIndex = 12;
            // 
            // lblModificarEventoTractor
            // 
            this.lblModificarEventoTractor.AutoSize = true;
            this.lblModificarEventoTractor.Location = new System.Drawing.Point(14, 87);
            this.lblModificarEventoTractor.Name = "lblModificarEventoTractor";
            this.lblModificarEventoTractor.Size = new System.Drawing.Size(41, 13);
            this.lblModificarEventoTractor.TabIndex = 0;
            this.lblModificarEventoTractor.Text = "Tractor";
            // 
            // btnModificarEventoCancel
            // 
            this.btnModificarEventoCancel.Location = new System.Drawing.Point(165, 370);
            this.btnModificarEventoCancel.Name = "btnModificarEventoCancel";
            this.btnModificarEventoCancel.Size = new System.Drawing.Size(75, 23);
            this.btnModificarEventoCancel.TabIndex = 16;
            this.btnModificarEventoCancel.Text = "Cancelar";
            this.btnModificarEventoCancel.UseVisualStyleBackColor = true;
            this.btnModificarEventoCancel.Click += new System.EventHandler(this.btnModificarEventoCancel_Click);
            // 
            // btnModificarEventoOK
            // 
            this.btnModificarEventoOK.Location = new System.Drawing.Point(17, 370);
            this.btnModificarEventoOK.Name = "btnModificarEventoOK";
            this.btnModificarEventoOK.Size = new System.Drawing.Size(75, 23);
            this.btnModificarEventoOK.TabIndex = 15;
            this.btnModificarEventoOK.Text = "Guardar";
            this.btnModificarEventoOK.UseVisualStyleBackColor = true;
            this.btnModificarEventoOK.Click += new System.EventHandler(this.btnModificarEventoOK_Click);
            // 
            // tbxModificarEventoTipo
            // 
            this.tbxModificarEventoTipo.Location = new System.Drawing.Point(90, 103);
            this.tbxModificarEventoTipo.Name = "tbxModificarEventoTipo";
            this.tbxModificarEventoTipo.Size = new System.Drawing.Size(150, 20);
            this.tbxModificarEventoTipo.TabIndex = 13;
            // 
            // lblModificarEventoTipo
            // 
            this.lblModificarEventoTipo.AutoSize = true;
            this.lblModificarEventoTipo.Location = new System.Drawing.Point(87, 87);
            this.lblModificarEventoTipo.Name = "lblModificarEventoTipo";
            this.lblModificarEventoTipo.Size = new System.Drawing.Size(79, 13);
            this.lblModificarEventoTipo.TabIndex = 0;
            this.lblModificarEventoTipo.Text = "Tipo de evento";
            // 
            // gbxModificarEventoDescripcion
            // 
            this.gbxModificarEventoDescripcion.Controls.Add(this.tbxModificarEventoDetalle);
            this.gbxModificarEventoDescripcion.Location = new System.Drawing.Point(17, 142);
            this.gbxModificarEventoDescripcion.Name = "gbxModificarEventoDescripcion";
            this.gbxModificarEventoDescripcion.Size = new System.Drawing.Size(223, 222);
            this.gbxModificarEventoDescripcion.TabIndex = 0;
            this.gbxModificarEventoDescripcion.TabStop = false;
            this.gbxModificarEventoDescripcion.Text = "Descripción";
            // 
            // tbxModificarEventoDetalle
            // 
            this.tbxModificarEventoDetalle.AllowDrop = true;
            this.tbxModificarEventoDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.tbxModificarEventoDetalle.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.tbxModificarEventoDetalle.Location = new System.Drawing.Point(6, 19);
            this.tbxModificarEventoDetalle.Multiline = true;
            this.tbxModificarEventoDetalle.Name = "tbxModificarEventoDetalle";
            this.tbxModificarEventoDetalle.Size = new System.Drawing.Size(211, 197);
            this.tbxModificarEventoDetalle.TabIndex = 14;
            // 
            // tbxModificarEventoPersona
            // 
            this.tbxModificarEventoPersona.Location = new System.Drawing.Point(17, 58);
            this.tbxModificarEventoPersona.Name = "tbxModificarEventoPersona";
            this.tbxModificarEventoPersona.Size = new System.Drawing.Size(223, 20);
            this.tbxModificarEventoPersona.TabIndex = 11;
            // 
            // lblModificarEventoPersona
            // 
            this.lblModificarEventoPersona.AutoSize = true;
            this.lblModificarEventoPersona.Location = new System.Drawing.Point(14, 42);
            this.lblModificarEventoPersona.Name = "lblModificarEventoPersona";
            this.lblModificarEventoPersona.Size = new System.Drawing.Size(38, 13);
            this.lblModificarEventoPersona.TabIndex = 0;
            this.lblModificarEventoPersona.Text = "Chofer";
            // 
            // lblModificarEventoIdEvento
            // 
            this.lblModificarEventoIdEvento.AutoSize = true;
            this.lblModificarEventoIdEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblModificarEventoIdEvento.Location = new System.Drawing.Point(123, 9);
            this.lblModificarEventoIdEvento.Name = "lblModificarEventoIdEvento";
            this.lblModificarEventoIdEvento.Size = new System.Drawing.Size(24, 25);
            this.lblModificarEventoIdEvento.TabIndex = 44;
            this.lblModificarEventoIdEvento.Text = "0";
            // 
            // FrmModificarEvento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(258, 408);
            this.Controls.Add(this.lblModificarEventoIdEvento);
            this.Controls.Add(this.tbxModificarEventoTractor);
            this.Controls.Add(this.lblModificarEventoTractor);
            this.Controls.Add(this.btnModificarEventoCancel);
            this.Controls.Add(this.btnModificarEventoOK);
            this.Controls.Add(this.tbxModificarEventoTipo);
            this.Controls.Add(this.lblModificarEventoTipo);
            this.Controls.Add(this.gbxModificarEventoDescripcion);
            this.Controls.Add(this.tbxModificarEventoPersona);
            this.Controls.Add(this.lblModificarEventoPersona);
            this.Controls.Add(this.lblModificarEventoTitulo);
            this.Name = "FrmModificarEvento";
            this.Text = "Edición de eventos";
            this.Load += new System.EventHandler(this.FrmModificarEvento_Load);
            this.gbxModificarEventoDescripcion.ResumeLayout(false);
            this.gbxModificarEventoDescripcion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblModificarEventoTitulo;
        private System.Windows.Forms.TextBox tbxModificarEventoTractor;
        private System.Windows.Forms.Label lblModificarEventoTractor;
        private System.Windows.Forms.Button btnModificarEventoCancel;
        private System.Windows.Forms.Button btnModificarEventoOK;
        private System.Windows.Forms.TextBox tbxModificarEventoTipo;
        private System.Windows.Forms.Label lblModificarEventoTipo;
        private System.Windows.Forms.GroupBox gbxModificarEventoDescripcion;
        private System.Windows.Forms.TextBox tbxModificarEventoDetalle;
        private System.Windows.Forms.TextBox tbxModificarEventoPersona;
        private System.Windows.Forms.Label lblModificarEventoPersona;
        private System.Windows.Forms.Label lblModificarEventoIdEvento;
    }
}