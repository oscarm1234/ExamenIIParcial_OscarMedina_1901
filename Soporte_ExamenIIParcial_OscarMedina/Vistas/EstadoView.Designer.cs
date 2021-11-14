
namespace Soporte_ExamenIIParcial_OscarMedina.Vistas
{
    partial class EstadoView
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
            this.chbdisponible = new System.Windows.Forms.CheckBox();
            this.usuariosdatagriedviwe = new System.Windows.Forms.DataGridView();
            this.bttcancelar = new System.Windows.Forms.Button();
            this.btteliminar = new System.Windows.Forms.Button();
            this.bttguardar = new System.Windows.Forms.Button();
            this.bttmodificar = new System.Windows.Forms.Button();
            this.bttnuevo = new System.Windows.Forms.Button();
            this.cbestado = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Cbx_Prioridad = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosdatagriedviwe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // chbdisponible
            // 
            this.chbdisponible.AutoSize = true;
            this.chbdisponible.Location = new System.Drawing.Point(442, 119);
            this.chbdisponible.Name = "chbdisponible";
            this.chbdisponible.Size = new System.Drawing.Size(75, 17);
            this.chbdisponible.TabIndex = 64;
            this.chbdisponible.Text = "Disponible";
            this.chbdisponible.UseVisualStyleBackColor = true;
            // 
            // usuariosdatagriedviwe
            // 
            this.usuariosdatagriedviwe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usuariosdatagriedviwe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosdatagriedviwe.Location = new System.Drawing.Point(3, 256);
            this.usuariosdatagriedviwe.Margin = new System.Windows.Forms.Padding(4);
            this.usuariosdatagriedviwe.Name = "usuariosdatagriedviwe";
            this.usuariosdatagriedviwe.Size = new System.Drawing.Size(537, 209);
            this.usuariosdatagriedviwe.TabIndex = 63;
            // 
            // bttcancelar
            // 
            this.bttcancelar.Enabled = false;
            this.bttcancelar.Location = new System.Drawing.Point(442, 188);
            this.bttcancelar.Margin = new System.Windows.Forms.Padding(4);
            this.bttcancelar.Name = "bttcancelar";
            this.bttcancelar.Size = new System.Drawing.Size(98, 38);
            this.bttcancelar.TabIndex = 62;
            this.bttcancelar.Text = "Cancelar";
            this.bttcancelar.UseVisualStyleBackColor = true;
            // 
            // btteliminar
            // 
            this.btteliminar.Location = new System.Drawing.Point(336, 188);
            this.btteliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btteliminar.Name = "btteliminar";
            this.btteliminar.Size = new System.Drawing.Size(98, 38);
            this.btteliminar.TabIndex = 61;
            this.btteliminar.Text = "Eliminar";
            this.btteliminar.UseVisualStyleBackColor = true;
            // 
            // bttguardar
            // 
            this.bttguardar.Location = new System.Drawing.Point(230, 188);
            this.bttguardar.Margin = new System.Windows.Forms.Padding(4);
            this.bttguardar.Name = "bttguardar";
            this.bttguardar.Size = new System.Drawing.Size(98, 38);
            this.bttguardar.TabIndex = 60;
            this.bttguardar.Text = "Guardar";
            this.bttguardar.UseVisualStyleBackColor = true;
            // 
            // bttmodificar
            // 
            this.bttmodificar.Location = new System.Drawing.Point(124, 188);
            this.bttmodificar.Margin = new System.Windows.Forms.Padding(4);
            this.bttmodificar.Name = "bttmodificar";
            this.bttmodificar.Size = new System.Drawing.Size(98, 38);
            this.bttmodificar.TabIndex = 59;
            this.bttmodificar.Text = "Modificar";
            this.bttmodificar.UseVisualStyleBackColor = true;
            // 
            // bttnuevo
            // 
            this.bttnuevo.Location = new System.Drawing.Point(18, 188);
            this.bttnuevo.Margin = new System.Windows.Forms.Padding(4);
            this.bttnuevo.Name = "bttnuevo";
            this.bttnuevo.Size = new System.Drawing.Size(98, 38);
            this.bttnuevo.TabIndex = 58;
            this.bttnuevo.Text = "Nuevo";
            this.bttnuevo.UseVisualStyleBackColor = true;
            // 
            // cbestado
            // 
            this.cbestado.FormattingEnabled = true;
            this.cbestado.Items.AddRange(new object[] {
            "Sin resolver",
            "Abierto",
            "En espera ",
            "Cerrado"});
            this.cbestado.Location = new System.Drawing.Point(188, 77);
            this.cbestado.Margin = new System.Windows.Forms.Padding(4);
            this.cbestado.Name = "cbestado";
            this.cbestado.Size = new System.Drawing.Size(245, 21);
            this.cbestado.TabIndex = 57;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 84);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 56;
            this.label3.Text = "Estado del Ticket:";
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(188, 37);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(245, 20);
            this.txtid.TabIndex = 55;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 54;
            this.label1.Text = "ID:";
            // 
            // Cbx_Prioridad
            // 
            this.Cbx_Prioridad.FormattingEnabled = true;
            this.Cbx_Prioridad.Items.AddRange(new object[] {
            "Alta",
            "Baja",
            "Leve"});
            this.Cbx_Prioridad.Location = new System.Drawing.Point(188, 113);
            this.Cbx_Prioridad.Margin = new System.Windows.Forms.Padding(4);
            this.Cbx_Prioridad.Name = "Cbx_Prioridad";
            this.Cbx_Prioridad.Size = new System.Drawing.Size(245, 21);
            this.Cbx_Prioridad.TabIndex = 66;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 120);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Prioridad del Ticket:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // EstadoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 465);
            this.Controls.Add(this.Cbx_Prioridad);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chbdisponible);
            this.Controls.Add(this.usuariosdatagriedviwe);
            this.Controls.Add(this.bttcancelar);
            this.Controls.Add(this.btteliminar);
            this.Controls.Add(this.bttguardar);
            this.Controls.Add(this.bttmodificar);
            this.Controls.Add(this.bttnuevo);
            this.Controls.Add(this.cbestado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label1);
            this.Name = "EstadoView";
            this.Text = "EstadoView";
            this.Load += new System.EventHandler(this.EstadoView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosdatagriedviwe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.CheckBox chbdisponible;
        public System.Windows.Forms.DataGridView usuariosdatagriedviwe;
        public System.Windows.Forms.Button bttcancelar;
        public System.Windows.Forms.Button btteliminar;
        public System.Windows.Forms.Button bttguardar;
        public System.Windows.Forms.Button bttmodificar;
        public System.Windows.Forms.Button bttnuevo;
        public System.Windows.Forms.ComboBox cbestado;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ComboBox Cbx_Prioridad;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}