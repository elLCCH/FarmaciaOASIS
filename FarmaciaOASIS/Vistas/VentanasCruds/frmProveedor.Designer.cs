namespace FarmaciaOASIS.Vistas.VentanasCruds
{
    partial class frmProveedor
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
            System.Windows.Forms.Label apellidoLabel;
            System.Windows.Forms.Label ciudadLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label telfLabel;
            this.proveedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.ciudadTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.telfTextBox = new System.Windows.Forms.TextBox();
            this.bdcfrmProveedor = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            apellidoLabel = new System.Windows.Forms.Label();
            ciudadLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            telfLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnAceptar.TabIndex = 13;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(-1, 21);
            this.label1.Size = new System.Drawing.Size(374, 31);
            this.label1.Text = "REGISTRAR PROVEEDOR";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            apellidoLabel.Location = new System.Drawing.Point(25, 125);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(84, 24);
            apellidoLabel.TabIndex = 19;
            apellidoLabel.Text = "Apellido:";
            // 
            // ciudadLabel
            // 
            ciudadLabel.AutoSize = true;
            ciudadLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ciudadLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            ciudadLabel.Location = new System.Drawing.Point(25, 170);
            ciudadLabel.Name = "ciudadLabel";
            ciudadLabel.Size = new System.Drawing.Size(75, 24);
            ciudadLabel.TabIndex = 21;
            ciudadLabel.Text = "Ciudad:";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            direccionLabel.Location = new System.Drawing.Point(25, 217);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(95, 24);
            direccionLabel.TabIndex = 25;
            direccionLabel.Text = "Direccion:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            nombreLabel.Location = new System.Drawing.Point(25, 80);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(84, 24);
            nombreLabel.TabIndex = 27;
            nombreLabel.Text = "Nombre:";
            // 
            // telfLabel
            // 
            telfLabel.AutoSize = true;
            telfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telfLabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            telfLabel.Location = new System.Drawing.Point(25, 262);
            telfLabel.Name = "telfLabel";
            telfLabel.Size = new System.Drawing.Size(90, 24);
            telfLabel.TabIndex = 29;
            telfLabel.Text = "Telefono:";
            // 
            // proveedorBindingSource
            // 
            this.proveedorBindingSource.DataSource = typeof(FarmaciaOASIS.Data.Proveedor);
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Apellido", true));
            this.apellidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoTextBox.Location = new System.Drawing.Point(125, 122);
            this.apellidoTextBox.MaxLength = 30;
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(218, 29);
            this.apellidoTextBox.TabIndex = 9;
            // 
            // ciudadTextBox
            // 
            this.ciudadTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ciudadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Ciudad", true));
            this.ciudadTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciudadTextBox.Location = new System.Drawing.Point(125, 167);
            this.ciudadTextBox.MaxLength = 20;
            this.ciudadTextBox.Name = "ciudadTextBox";
            this.ciudadTextBox.Size = new System.Drawing.Size(218, 29);
            this.ciudadTextBox.TabIndex = 10;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.direccionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Direccion", true));
            this.direccionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(125, 214);
            this.direccionTextBox.MaxLength = 50;
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(218, 29);
            this.direccionTextBox.TabIndex = 11;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(125, 77);
            this.nombreTextBox.MaxLength = 30;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(218, 29);
            this.nombreTextBox.TabIndex = 8;
            // 
            // telfTextBox
            // 
            this.telfTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.proveedorBindingSource, "Telf", true));
            this.telfTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telfTextBox.Location = new System.Drawing.Point(125, 259);
            this.telfTextBox.MaxLength = 10;
            this.telfTextBox.Name = "telfTextBox";
            this.telfTextBox.Size = new System.Drawing.Size(218, 29);
            this.telfTextBox.TabIndex = 12;
            this.telfTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TelfTextBox_KeyPress);
            // 
            // bdcfrmProveedor
            // 
            this.bdcfrmProveedor.Fixed = true;
            this.bdcfrmProveedor.Horizontal = true;
            this.bdcfrmProveedor.TargetControl = this;
            this.bdcfrmProveedor.Vertical = true;
            // 
            // frmProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 407);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(ciudadLabel);
            this.Controls.Add(this.ciudadTextBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(telfLabel);
            this.Controls.Add(this.telfTextBox);
            this.Name = "frmProveedor";
            this.Text = "frmProveedor";
            this.Load += new System.EventHandler(this.frmProveedor_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.telfTextBox, 0);
            this.Controls.SetChildIndex(telfLabel, 0);
            this.Controls.SetChildIndex(this.nombreTextBox, 0);
            this.Controls.SetChildIndex(nombreLabel, 0);
            this.Controls.SetChildIndex(this.direccionTextBox, 0);
            this.Controls.SetChildIndex(direccionLabel, 0);
            this.Controls.SetChildIndex(this.ciudadTextBox, 0);
            this.Controls.SetChildIndex(ciudadLabel, 0);
            this.Controls.SetChildIndex(this.apellidoTextBox, 0);
            this.Controls.SetChildIndex(apellidoLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.proveedorBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource proveedorBindingSource;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox ciudadTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.TextBox telfTextBox;
        private Bunifu.Framework.UI.BunifuDragControl bdcfrmProveedor;
    }
}