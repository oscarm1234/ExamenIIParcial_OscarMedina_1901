
namespace Soporte_ExamenIIParcial_OscarMedina.Vistas
{
    partial class TipoSoporteView
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
            this.bttcancelar = new System.Windows.Forms.Button();
            this.btteliminar = new System.Windows.Forms.Button();
            this.bttguardar = new System.Windows.Forms.Button();
            this.bttmodificar = new System.Windows.Forms.Button();
            this.bttnuevo = new System.Windows.Forms.Button();
            this.autoLabel1 = new Syncfusion.Windows.Forms.Tools.AutoLabel();
            this.cbsoporte = new System.Windows.Forms.ComboBox();
            this.usuariosdatagriedviwe = new System.Windows.Forms.DataGridView();
            this.txtobservacion = new System.Windows.Forms.TextBox();
            this.txtdepto = new System.Windows.Forms.TextBox();
            this.txtid = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.usuariosdatagriedviwe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // bttcancelar
            // 
            this.bttcancelar.Enabled = false;
            this.bttcancelar.Location = new System.Drawing.Point(362, 260);
            this.bttcancelar.Margin = new System.Windows.Forms.Padding(4);
            this.bttcancelar.Name = "bttcancelar";
            this.bttcancelar.Size = new System.Drawing.Size(77, 27);
            this.bttcancelar.TabIndex = 43;
            this.bttcancelar.Text = "Cancelar";
            this.bttcancelar.UseVisualStyleBackColor = true;
            // 
            // btteliminar
            // 
            this.btteliminar.Location = new System.Drawing.Point(277, 260);
            this.btteliminar.Margin = new System.Windows.Forms.Padding(4);
            this.btteliminar.Name = "btteliminar";
            this.btteliminar.Size = new System.Drawing.Size(77, 27);
            this.btteliminar.TabIndex = 42;
            this.btteliminar.Text = "Eliminar";
            this.btteliminar.UseVisualStyleBackColor = true;
            // 
            // bttguardar
            // 
            this.bttguardar.Enabled = false;
            this.bttguardar.Location = new System.Drawing.Point(192, 260);
            this.bttguardar.Margin = new System.Windows.Forms.Padding(4);
            this.bttguardar.Name = "bttguardar";
            this.bttguardar.Size = new System.Drawing.Size(77, 27);
            this.bttguardar.TabIndex = 41;
            this.bttguardar.Text = "Guardar";
            this.bttguardar.UseVisualStyleBackColor = true;
            // 
            // bttmodificar
            // 
            this.bttmodificar.Location = new System.Drawing.Point(98, 260);
            this.bttmodificar.Margin = new System.Windows.Forms.Padding(4);
            this.bttmodificar.Name = "bttmodificar";
            this.bttmodificar.Size = new System.Drawing.Size(77, 27);
            this.bttmodificar.TabIndex = 40;
            this.bttmodificar.Text = "Modificar";
            this.bttmodificar.UseVisualStyleBackColor = true;
            // 
            // bttnuevo
            // 
            this.bttnuevo.Location = new System.Drawing.Point(13, 260);
            this.bttnuevo.Margin = new System.Windows.Forms.Padding(4);
            this.bttnuevo.Name = "bttnuevo";
            this.bttnuevo.Size = new System.Drawing.Size(77, 27);
            this.bttnuevo.TabIndex = 39;
            this.bttnuevo.Text = "Nuevo";
            this.bttnuevo.UseVisualStyleBackColor = true;
            // 
            // autoLabel1
            // 
            this.autoLabel1.BackColor = System.Drawing.Color.Transparent;
            this.autoLabel1.Font = new System.Drawing.Font("Book Antiqua", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.autoLabel1.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.autoLabel1.Location = new System.Drawing.Point(168, 9);
            this.autoLabel1.Name = "autoLabel1";
            this.autoLabel1.Size = new System.Drawing.Size(230, 33);
            this.autoLabel1.TabIndex = 58;
            this.autoLabel1.Text = "Soporte Tecnico";
            // 
            // cbsoporte
            // 
            this.cbsoporte.FormattingEnabled = true;
            this.cbsoporte.Items.AddRange(new object[] {
            "Incidencias Basicas",
            "Problemas Tecnicos Mas utitilizados",
            "Sofware",
            "Hardware"});
            this.cbsoporte.Location = new System.Drawing.Point(260, 159);
            this.cbsoporte.Margin = new System.Windows.Forms.Padding(4);
            this.cbsoporte.Name = "cbsoporte";
            this.cbsoporte.Size = new System.Drawing.Size(299, 21);
            this.cbsoporte.TabIndex = 57;
            // 
            // usuariosdatagriedviwe
            // 
            this.usuariosdatagriedviwe.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usuariosdatagriedviwe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.usuariosdatagriedviwe.Location = new System.Drawing.Point(17, 295);
            this.usuariosdatagriedviwe.Margin = new System.Windows.Forms.Padding(4);
            this.usuariosdatagriedviwe.Name = "usuariosdatagriedviwe";
            this.usuariosdatagriedviwe.Size = new System.Drawing.Size(558, 232);
            this.usuariosdatagriedviwe.TabIndex = 56;
            // 
            // txtobservacion
            // 
            this.txtobservacion.Enabled = false;
            this.txtobservacion.Location = new System.Drawing.Point(260, 207);
            this.txtobservacion.Margin = new System.Windows.Forms.Padding(4);
            this.txtobservacion.Name = "txtobservacion";
            this.txtobservacion.Size = new System.Drawing.Size(299, 20);
            this.txtobservacion.TabIndex = 55;
            // 
            // txtdepto
            // 
            this.txtdepto.Enabled = false;
            this.txtdepto.Location = new System.Drawing.Point(260, 111);
            this.txtdepto.Margin = new System.Windows.Forms.Padding(4);
            this.txtdepto.Name = "txtdepto";
            this.txtdepto.Size = new System.Drawing.Size(299, 20);
            this.txtdepto.TabIndex = 54;
            // 
            // txtid
            // 
            this.txtid.Location = new System.Drawing.Point(260, 65);
            this.txtid.Margin = new System.Windows.Forms.Padding(4);
            this.txtid.Name = "txtid";
            this.txtid.ReadOnly = true;
            this.txtid.Size = new System.Drawing.Size(125, 20);
            this.txtid.TabIndex = 53;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 210);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 52;
            this.label4.Text = "Descripcion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 164);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 13);
            this.label3.TabIndex = 51;
            this.label3.Text = "Tipo de Soporte:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 50;
            this.label2.Text = "Categoria Tecnica:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 72);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 49;
            this.label1.Text = "ID";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // TipoSoporteView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 537);
            this.Controls.Add(this.bttcancelar);
            this.Controls.Add(this.btteliminar);
            this.Controls.Add(this.autoLabel1);
            this.Controls.Add(this.bttguardar);
            this.Controls.Add(this.cbsoporte);
            this.Controls.Add(this.bttmodificar);
            this.Controls.Add(this.usuariosdatagriedviwe);
            this.Controls.Add(this.bttnuevo);
            this.Controls.Add(this.txtobservacion);
            this.Controls.Add(this.txtdepto);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "TipoSoporteView";
            this.Text = "TipoSoporteView";
            ((System.ComponentModel.ISupportInitialize)(this.usuariosdatagriedviwe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button bttcancelar;
        public System.Windows.Forms.Button btteliminar;
        public System.Windows.Forms.Button bttguardar;
        public System.Windows.Forms.Button bttmodificar;
        public System.Windows.Forms.Button bttnuevo;
        private Syncfusion.Windows.Forms.Tools.AutoLabel autoLabel1;
        public System.Windows.Forms.ComboBox cbsoporte;
        public System.Windows.Forms.DataGridView usuariosdatagriedviwe;
        public System.Windows.Forms.TextBox txtobservacion;
        public System.Windows.Forms.TextBox txtdepto;
        public System.Windows.Forms.TextBox txtid;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.ErrorProvider errorProvider1;
    }
}