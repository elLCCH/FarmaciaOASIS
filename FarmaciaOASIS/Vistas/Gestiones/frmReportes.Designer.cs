namespace FarmaciaOASIS.Vistas.Gestiones
{
    partial class frmReportes
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
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label ciLabel;
            System.Windows.Forms.Label noFacturaLabel;
            System.Windows.Forms.Label noAutorizacionLabel;
            System.Windows.Forms.Label fechaLabel;
            this.detalleFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.detalleFacturaDataGridView = new System.Windows.Forms.DataGridView();
            this.ColNumFact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodMed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColCant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColPre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreLabel1 = new System.Windows.Forms.Label();
            this.apellidoLabel1 = new System.Windows.Forms.Label();
            this.ciLabel1 = new System.Windows.Forms.Label();
            this.noFacturaLabel1 = new System.Windows.Forms.Label();
            this.noAutorizacionLabel1 = new System.Windows.Forms.Label();
            this.fechaLabel1 = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            ciLabel = new System.Windows.Forms.Label();
            noFacturaLabel = new System.Windows.Forms.Label();
            noAutorizacionLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.detalleFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleFacturaDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            // 
            // btnEliminar
            // 
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusqueda.Location = new System.Drawing.Point(31, 60);
            this.txtBusqueda.Text = "";
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBusqueda_KeyPress);
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBusqueda_KeyUp);
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.ForeColor = System.Drawing.SystemColors.Control;
            nombreLabel.Location = new System.Drawing.Point(27, 169);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(91, 24);
            nombreLabel.TabIndex = 13;
            nombreLabel.Text = "Nombre:";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoLabel.ForeColor = System.Drawing.SystemColors.Control;
            apellidoLabel.Location = new System.Drawing.Point(27, 193);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(93, 24);
            apellidoLabel.TabIndex = 14;
            apellidoLabel.Text = "Apellido:";
            // 
            // ciLabel
            // 
            ciLabel.AutoSize = true;
            ciLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ciLabel.ForeColor = System.Drawing.SystemColors.Control;
            ciLabel.Location = new System.Drawing.Point(27, 220);
            ciLabel.Name = "ciLabel";
            ciLabel.Size = new System.Drawing.Size(35, 24);
            ciLabel.TabIndex = 15;
            ciLabel.Text = "Ci:";
            // 
            // noFacturaLabel
            // 
            noFacturaLabel.AutoSize = true;
            noFacturaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noFacturaLabel.ForeColor = System.Drawing.SystemColors.Control;
            noFacturaLabel.Location = new System.Drawing.Point(27, 145);
            noFacturaLabel.Name = "noFacturaLabel";
            noFacturaLabel.Size = new System.Drawing.Size(119, 24);
            noFacturaLabel.TabIndex = 16;
            noFacturaLabel.Text = "No Factura:";
            // 
            // noAutorizacionLabel
            // 
            noAutorizacionLabel.AutoSize = true;
            noAutorizacionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            noAutorizacionLabel.ForeColor = System.Drawing.SystemColors.Control;
            noAutorizacionLabel.Location = new System.Drawing.Point(27, 121);
            noAutorizacionLabel.Name = "noAutorizacionLabel";
            noAutorizacionLabel.Size = new System.Drawing.Size(165, 24);
            noAutorizacionLabel.TabIndex = 17;
            noAutorizacionLabel.Text = "No Autorizacion:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.ForeColor = System.Drawing.SystemColors.Control;
            fechaLabel.Location = new System.Drawing.Point(27, 249);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(75, 24);
            fechaLabel.TabIndex = 18;
            fechaLabel.Text = "Fecha:";
            // 
            // detalleFacturaBindingSource
            // 
            this.detalleFacturaBindingSource.DataSource = typeof(FarmaciaOASIS.Data.DetalleFactura);
            // 
            // detalleFacturaDataGridView
            // 
            this.detalleFacturaDataGridView.AllowUserToAddRows = false;
            this.detalleFacturaDataGridView.AllowUserToDeleteRows = false;
            this.detalleFacturaDataGridView.AutoGenerateColumns = false;
            this.detalleFacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleFacturaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNumFact,
            this.CodMed,
            this.ColCant,
            this.ColPre});
            this.detalleFacturaDataGridView.DataSource = this.detalleFacturaBindingSource;
            this.detalleFacturaDataGridView.Location = new System.Drawing.Point(303, 85);
            this.detalleFacturaDataGridView.Name = "detalleFacturaDataGridView";
            this.detalleFacturaDataGridView.ReadOnly = true;
            this.detalleFacturaDataGridView.Size = new System.Drawing.Size(451, 265);
            this.detalleFacturaDataGridView.TabIndex = 12;
            // 
            // ColNumFact
            // 
            this.ColNumFact.DataPropertyName = "NoFactura";
            this.ColNumFact.HeaderText = "NoFactura";
            this.ColNumFact.Name = "ColNumFact";
            this.ColNumFact.ReadOnly = true;
            // 
            // CodMed
            // 
            this.CodMed.DataPropertyName = "CodMed";
            this.CodMed.HeaderText = "CodMed";
            this.CodMed.Name = "CodMed";
            this.CodMed.ReadOnly = true;
            // 
            // ColCant
            // 
            this.ColCant.DataPropertyName = "CantMed";
            this.ColCant.HeaderText = "CantMed";
            this.ColCant.Name = "ColCant";
            this.ColCant.ReadOnly = true;
            // 
            // ColPre
            // 
            this.ColPre.DataPropertyName = "Precio";
            this.ColPre.HeaderText = "Precio";
            this.ColPre.Name = "ColPre";
            this.ColPre.ReadOnly = true;
            // 
            // nombreLabel1
            // 
            this.nombreLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleFacturaBindingSource, "Factura.Cliente.Nombre", true));
            this.nombreLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.nombreLabel1.Location = new System.Drawing.Point(196, 170);
            this.nombreLabel1.Name = "nombreLabel1";
            this.nombreLabel1.Size = new System.Drawing.Size(100, 23);
            this.nombreLabel1.TabIndex = 14;
            this.nombreLabel1.Text = "label1";
            // 
            // apellidoLabel1
            // 
            this.apellidoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleFacturaBindingSource, "Factura.Cliente.Apellido", true));
            this.apellidoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.apellidoLabel1.Location = new System.Drawing.Point(196, 192);
            this.apellidoLabel1.Name = "apellidoLabel1";
            this.apellidoLabel1.Size = new System.Drawing.Size(100, 23);
            this.apellidoLabel1.TabIndex = 15;
            this.apellidoLabel1.Text = "label1";
            // 
            // ciLabel1
            // 
            this.ciLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleFacturaBindingSource, "Factura.Cliente.Ci", true));
            this.ciLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.ciLabel1.Location = new System.Drawing.Point(196, 215);
            this.ciLabel1.Name = "ciLabel1";
            this.ciLabel1.Size = new System.Drawing.Size(100, 23);
            this.ciLabel1.TabIndex = 16;
            this.ciLabel1.Text = "label1";
            // 
            // noFacturaLabel1
            // 
            this.noFacturaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleFacturaBindingSource, "NoFactura", true));
            this.noFacturaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noFacturaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.noFacturaLabel1.Location = new System.Drawing.Point(196, 147);
            this.noFacturaLabel1.Name = "noFacturaLabel1";
            this.noFacturaLabel1.Size = new System.Drawing.Size(100, 23);
            this.noFacturaLabel1.TabIndex = 17;
            this.noFacturaLabel1.Text = "label1";
            // 
            // noAutorizacionLabel1
            // 
            this.noAutorizacionLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleFacturaBindingSource, "NoAutorizacion", true));
            this.noAutorizacionLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noAutorizacionLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.noAutorizacionLabel1.Location = new System.Drawing.Point(196, 121);
            this.noAutorizacionLabel1.Name = "noAutorizacionLabel1";
            this.noAutorizacionLabel1.Size = new System.Drawing.Size(100, 23);
            this.noAutorizacionLabel1.TabIndex = 18;
            this.noAutorizacionLabel1.Text = "label1";
            // 
            // fechaLabel1
            // 
            this.fechaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleFacturaBindingSource, "Factura.Fecha", true));
            this.fechaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.fechaLabel1.Location = new System.Drawing.Point(196, 250);
            this.fechaLabel1.Name = "fechaLabel1";
            this.fechaLabel1.Size = new System.Drawing.Size(100, 23);
            this.fechaLabel1.TabIndex = 19;
            this.fechaLabel1.Text = "label1";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.SystemColors.Control;
            this.lblTotal.Location = new System.Drawing.Point(196, 306);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(66, 24);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "label1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(290, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(346, 31);
            this.label1.TabIndex = 21;
            this.label1.Text = "REPORTE DE FACTURA";
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(53)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaLabel1);
            this.Controls.Add(noAutorizacionLabel);
            this.Controls.Add(this.noAutorizacionLabel1);
            this.Controls.Add(noFacturaLabel);
            this.Controls.Add(this.noFacturaLabel1);
            this.Controls.Add(ciLabel);
            this.Controls.Add(this.ciLabel1);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoLabel1);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreLabel1);
            this.Controls.Add(this.detalleFacturaDataGridView);
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
            this.Controls.SetChildIndex(this.txtBusqueda, 0);
            this.Controls.SetChildIndex(this.btnRegistrar, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.detalleFacturaDataGridView, 0);
            this.Controls.SetChildIndex(this.nombreLabel1, 0);
            this.Controls.SetChildIndex(nombreLabel, 0);
            this.Controls.SetChildIndex(this.apellidoLabel1, 0);
            this.Controls.SetChildIndex(apellidoLabel, 0);
            this.Controls.SetChildIndex(this.ciLabel1, 0);
            this.Controls.SetChildIndex(ciLabel, 0);
            this.Controls.SetChildIndex(this.noFacturaLabel1, 0);
            this.Controls.SetChildIndex(noFacturaLabel, 0);
            this.Controls.SetChildIndex(this.noAutorizacionLabel1, 0);
            this.Controls.SetChildIndex(noAutorizacionLabel, 0);
            this.Controls.SetChildIndex(this.fechaLabel1, 0);
            this.Controls.SetChildIndex(fechaLabel, 0);
            this.Controls.SetChildIndex(this.lblTotal, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.detalleFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleFacturaDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource detalleFacturaBindingSource;
        private System.Windows.Forms.DataGridView detalleFacturaDataGridView;
        private System.Windows.Forms.Label nombreLabel1;
        private System.Windows.Forms.Label apellidoLabel1;
        private System.Windows.Forms.Label ciLabel1;
        private System.Windows.Forms.Label noFacturaLabel1;
        private System.Windows.Forms.Label noAutorizacionLabel1;
        private System.Windows.Forms.Label fechaLabel1;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPre;
    }
}