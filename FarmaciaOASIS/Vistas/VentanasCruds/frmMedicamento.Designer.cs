namespace FarmaciaOASIS.Vistas.VentanasCruds
{
    partial class frmMedicamento
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
            System.Windows.Forms.Label cantidadLabel;
            System.Windows.Forms.Label nomMedLabel;
            System.Windows.Forms.Label pUnitLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label codProvLabel;
            this.medicamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.nomMedTextBox = new System.Windows.Forms.TextBox();
            this.pUnitTextBox = new System.Windows.Forms.TextBox();
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bdcfrmMedicamentos = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.nombreComboBox = new System.Windows.Forms.ComboBox();
            this.codProvLabel1 = new System.Windows.Forms.Label();
            cantidadLabel = new System.Windows.Forms.Label();
            nomMedLabel = new System.Windows.Forms.Label();
            pUnitLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            codProvLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnAceptar.TabIndex = 12;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnCancelar.TabIndex = 13;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(65, 32);
            this.label1.Size = new System.Drawing.Size(248, 31);
            this.label1.Text = "MEDICAMENTOS";
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cantidadLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            cantidadLabel.Location = new System.Drawing.Point(33, 174);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(89, 24);
            cantidadLabel.TabIndex = 18;
            cantidadLabel.Text = "Cantidad:";
            // 
            // nomMedLabel
            // 
            nomMedLabel.AutoSize = true;
            nomMedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomMedLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            nomMedLabel.Location = new System.Drawing.Point(33, 130);
            nomMedLabel.Name = "nomMedLabel";
            nomMedLabel.Size = new System.Drawing.Size(165, 24);
            nomMedLabel.TabIndex = 24;
            nomMedLabel.Text = "Nombre Producto:";
            // 
            // pUnitLabel
            // 
            pUnitLabel.AutoSize = true;
            pUnitLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            pUnitLabel.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            pUnitLabel.Location = new System.Drawing.Point(33, 219);
            pUnitLabel.Name = "pUnitLabel";
            pUnitLabel.Size = new System.Drawing.Size(137, 24);
            pUnitLabel.TabIndex = 26;
            pUnitLabel.Text = "Precio Unitario:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            nombreLabel.Location = new System.Drawing.Point(34, 269);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(177, 24);
            nombreLabel.TabIndex = 26;
            nombreLabel.Text = "Nombre Proveedor:";
            // 
            // codProvLabel
            // 
            codProvLabel.AutoSize = true;
            codProvLabel.Location = new System.Drawing.Point(319, 220);
            codProvLabel.Name = "codProvLabel";
            codProvLabel.Size = new System.Drawing.Size(54, 13);
            codProvLabel.TabIndex = 27;
            codProvLabel.Text = "Cod Prov:";
            // 
            // medicamentoBindingSource
            // 
            this.medicamentoBindingSource.DataSource = typeof(FarmaciaOASIS.Data.Medicamento);
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentoBindingSource, "Cantidad", true));
            this.cantidadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cantidadTextBox.Location = new System.Drawing.Point(222, 171);
            this.cantidadTextBox.MaxLength = 5;
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(206, 29);
            this.cantidadTextBox.TabIndex = 9;
            this.cantidadTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CantidadTextBox_KeyPress);
            // 
            // nomMedTextBox
            // 
            this.nomMedTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nomMedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentoBindingSource, "NomMed", true));
            this.nomMedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomMedTextBox.Location = new System.Drawing.Point(222, 127);
            this.nomMedTextBox.MaxLength = 30;
            this.nomMedTextBox.Name = "nomMedTextBox";
            this.nomMedTextBox.Size = new System.Drawing.Size(206, 29);
            this.nomMedTextBox.TabIndex = 8;
            // 
            // pUnitTextBox
            // 
            this.pUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentoBindingSource, "PUnit", true));
            this.pUnitTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pUnitTextBox.Location = new System.Drawing.Point(222, 216);
            this.pUnitTextBox.MaxLength = 5;
            this.pUnitTextBox.Name = "pUnitTextBox";
            this.pUnitTextBox.Size = new System.Drawing.Size(206, 29);
            this.pUnitTextBox.TabIndex = 10;
            this.pUnitTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.PUnitTextBox_KeyPress);
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataSource = typeof(FarmaciaOASIS.Data.Proveedor);
            // 
            // bdcfrmMedicamentos
            // 
            this.bdcfrmMedicamentos.Fixed = true;
            this.bdcfrmMedicamentos.Horizontal = true;
            this.bdcfrmMedicamentos.TargetControl = this;
            this.bdcfrmMedicamentos.Vertical = true;
            // 
            // nombreComboBox
            // 
            this.nombreComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentoBindingSource, "Proveedor.Nombre", true));
            this.nombreComboBox.DataSource = this.proveedorBindingSource;
            this.nombreComboBox.DisplayMember = "Nombre";
            this.nombreComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreComboBox.FormattingEnabled = true;
            this.nombreComboBox.Location = new System.Drawing.Point(222, 266);
            this.nombreComboBox.Name = "nombreComboBox";
            this.nombreComboBox.Size = new System.Drawing.Size(206, 32);
            this.nombreComboBox.TabIndex = 27;
            this.nombreComboBox.SelectedIndexChanged += new System.EventHandler(this.NombreComboBox_SelectedIndexChanged);
            // 
            // codProvLabel1
            // 
            this.codProvLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "CodProv", true));
            this.codProvLabel1.Location = new System.Drawing.Point(301, 220);
            this.codProvLabel1.Name = "codProvLabel1";
            this.codProvLabel1.Size = new System.Drawing.Size(100, 23);
            this.codProvLabel1.TabIndex = 28;
            this.codProvLabel1.Text = "label2";
            // 
            // frmMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 407);
            this.Controls.Add(this.pUnitTextBox);
            this.Controls.Add(codProvLabel);
            this.Controls.Add(this.codProvLabel1);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreComboBox);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(nomMedLabel);
            this.Controls.Add(this.nomMedTextBox);
            this.Controls.Add(pUnitLabel);
            this.Name = "frmMedicamento";
            this.Text = "frmMedicamento";
            this.Load += new System.EventHandler(this.frmMedicamento_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(pUnitLabel, 0);
            this.Controls.SetChildIndex(this.nomMedTextBox, 0);
            this.Controls.SetChildIndex(nomMedLabel, 0);
            this.Controls.SetChildIndex(this.cantidadTextBox, 0);
            this.Controls.SetChildIndex(cantidadLabel, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.nombreComboBox, 0);
            this.Controls.SetChildIndex(nombreLabel, 0);
            this.Controls.SetChildIndex(this.codProvLabel1, 0);
            this.Controls.SetChildIndex(codProvLabel, 0);
            this.Controls.SetChildIndex(this.pUnitTextBox, 0);
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource medicamentoBindingSource;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox nomMedTextBox;
        private System.Windows.Forms.TextBox pUnitTextBox;
        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private Bunifu.Framework.UI.BunifuDragControl bdcfrmMedicamentos;
        private System.Windows.Forms.ComboBox nombreComboBox;
        private System.Windows.Forms.Label codProvLabel1;
    }
}