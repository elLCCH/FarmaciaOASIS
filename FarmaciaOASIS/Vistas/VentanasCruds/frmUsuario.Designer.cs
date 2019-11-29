namespace FarmaciaOASIS.Vistas.VentanasCruds
{
    partial class frmUsuario
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
            System.Windows.Forms.Label celLabel;
            System.Windows.Forms.Label ciLabel;
            System.Windows.Forms.Label contraseniaLabel;
            System.Windows.Forms.Label cuentaLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label rolLabel;
            this.usuarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.apellidoTextBox = new System.Windows.Forms.TextBox();
            this.celTextBox = new System.Windows.Forms.TextBox();
            this.ciTextBox = new System.Windows.Forms.TextBox();
            this.contraseniaTextBox = new System.Windows.Forms.TextBox();
            this.cuentaTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.rolComboBox = new System.Windows.Forms.ComboBox();
            apellidoLabel = new System.Windows.Forms.Label();
            celLabel = new System.Windows.Forms.Label();
            ciLabel = new System.Windows.Forms.Label();
            contraseniaLabel = new System.Windows.Forms.Label();
            cuentaLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            rolLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnAceptar.TabIndex = 15;
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(22, 18);
            this.label1.Size = new System.Drawing.Size(323, 31);
            this.label1.Text = "REGISTRAR USUARIO";
            // 
            // apellidoLabel
            // 
            apellidoLabel.AutoSize = true;
            apellidoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            apellidoLabel.Location = new System.Drawing.Point(30, 137);
            apellidoLabel.Name = "apellidoLabel";
            apellidoLabel.Size = new System.Drawing.Size(84, 24);
            apellidoLabel.TabIndex = 19;
            apellidoLabel.Text = "Apellido:";
            // 
            // celLabel
            // 
            celLabel.AutoSize = true;
            celLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            celLabel.Location = new System.Drawing.Point(28, 242);
            celLabel.Name = "celLabel";
            celLabel.Size = new System.Drawing.Size(43, 24);
            celLabel.TabIndex = 21;
            celLabel.Text = "Cel:";
            // 
            // ciLabel
            // 
            ciLabel.AutoSize = true;
            ciLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ciLabel.Location = new System.Drawing.Point(27, 62);
            ciLabel.Name = "ciLabel";
            ciLabel.Size = new System.Drawing.Size(32, 24);
            ciLabel.TabIndex = 23;
            ciLabel.Text = "Ci:";
            // 
            // contraseniaLabel
            // 
            contraseniaLabel.AutoSize = true;
            contraseniaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contraseniaLabel.Location = new System.Drawing.Point(28, 207);
            contraseniaLabel.Name = "contraseniaLabel";
            contraseniaLabel.Size = new System.Drawing.Size(115, 24);
            contraseniaLabel.TabIndex = 27;
            contraseniaLabel.Text = "Contrasenia:";
            // 
            // cuentaLabel
            // 
            cuentaLabel.AutoSize = true;
            cuentaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cuentaLabel.Location = new System.Drawing.Point(28, 171);
            cuentaLabel.Name = "cuentaLabel";
            cuentaLabel.Size = new System.Drawing.Size(75, 24);
            cuentaLabel.TabIndex = 29;
            cuentaLabel.Text = "Cuenta:";
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombreLabel.Location = new System.Drawing.Point(27, 100);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(84, 24);
            nombreLabel.TabIndex = 31;
            nombreLabel.Text = "Nombre:";
            // 
            // rolLabel
            // 
            rolLabel.AutoSize = true;
            rolLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rolLabel.Location = new System.Drawing.Point(30, 279);
            rolLabel.Name = "rolLabel";
            rolLabel.Size = new System.Drawing.Size(43, 24);
            rolLabel.TabIndex = 32;
            rolLabel.Text = "Rol:";
            // 
            // usuarioBindingSource
            // 
            this.usuarioBindingSource.DataSource = typeof(FarmaciaOASIS.Data.Usuario);
            // 
            // apellidoTextBox
            // 
            this.apellidoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.apellidoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Apellido", true));
            this.apellidoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoTextBox.Location = new System.Drawing.Point(142, 134);
            this.apellidoTextBox.MaxLength = 30;
            this.apellidoTextBox.Name = "apellidoTextBox";
            this.apellidoTextBox.Size = new System.Drawing.Size(190, 29);
            this.apellidoTextBox.TabIndex = 10;
            // 
            // celTextBox
            // 
            this.celTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Cel", true));
            this.celTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celTextBox.Location = new System.Drawing.Point(143, 240);
            this.celTextBox.Name = "celTextBox";
            this.celTextBox.Size = new System.Drawing.Size(190, 29);
            this.celTextBox.TabIndex = 13;
            this.celTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.CelTextBox_KeyPress);
            // 
            // ciTextBox
            // 
            this.ciTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ciTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Ci", true));
            this.ciTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciTextBox.Location = new System.Drawing.Point(142, 59);
            this.ciTextBox.MaxLength = 15;
            this.ciTextBox.Name = "ciTextBox";
            this.ciTextBox.Size = new System.Drawing.Size(190, 29);
            this.ciTextBox.TabIndex = 8;
            // 
            // contraseniaTextBox
            // 
            this.contraseniaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Contrasenia", true));
            this.contraseniaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contraseniaTextBox.Location = new System.Drawing.Point(143, 204);
            this.contraseniaTextBox.MaxLength = 40;
            this.contraseniaTextBox.Name = "contraseniaTextBox";
            this.contraseniaTextBox.PasswordChar = '*';
            this.contraseniaTextBox.Size = new System.Drawing.Size(190, 29);
            this.contraseniaTextBox.TabIndex = 12;
            // 
            // cuentaTextBox
            // 
            this.cuentaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Cuenta", true));
            this.cuentaTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cuentaTextBox.Location = new System.Drawing.Point(143, 169);
            this.cuentaTextBox.MaxLength = 30;
            this.cuentaTextBox.Name = "cuentaTextBox";
            this.cuentaTextBox.Size = new System.Drawing.Size(190, 29);
            this.cuentaTextBox.TabIndex = 11;
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombreTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Nombre", true));
            this.nombreTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreTextBox.Location = new System.Drawing.Point(142, 97);
            this.nombreTextBox.MaxLength = 30;
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(190, 29);
            this.nombreTextBox.TabIndex = 9;
            // 
            // rolComboBox
            // 
            this.rolComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuarioBindingSource, "Rol", true));
            this.rolComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rolComboBox.FormattingEnabled = true;
            this.rolComboBox.Items.AddRange(new object[] {
            "AUXILIAR",
            "ADMINISTRADOR"});
            this.rolComboBox.Location = new System.Drawing.Point(143, 276);
            this.rolComboBox.Name = "rolComboBox";
            this.rolComboBox.Size = new System.Drawing.Size(189, 32);
            this.rolComboBox.TabIndex = 14;
            // 
            // frmUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 407);
            this.Controls.Add(rolLabel);
            this.Controls.Add(this.rolComboBox);
            this.Controls.Add(apellidoLabel);
            this.Controls.Add(this.apellidoTextBox);
            this.Controls.Add(celLabel);
            this.Controls.Add(this.celTextBox);
            this.Controls.Add(ciLabel);
            this.Controls.Add(this.ciTextBox);
            this.Controls.Add(contraseniaLabel);
            this.Controls.Add(this.contraseniaTextBox);
            this.Controls.Add(cuentaLabel);
            this.Controls.Add(this.cuentaTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Name = "frmUsuario";
            this.Text = "frmUsuario";
            this.Load += new System.EventHandler(this.frmUsuario_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            this.Controls.SetChildIndex(this.nombreTextBox, 0);
            this.Controls.SetChildIndex(nombreLabel, 0);
            this.Controls.SetChildIndex(this.cuentaTextBox, 0);
            this.Controls.SetChildIndex(cuentaLabel, 0);
            this.Controls.SetChildIndex(this.contraseniaTextBox, 0);
            this.Controls.SetChildIndex(contraseniaLabel, 0);
            this.Controls.SetChildIndex(this.ciTextBox, 0);
            this.Controls.SetChildIndex(ciLabel, 0);
            this.Controls.SetChildIndex(this.celTextBox, 0);
            this.Controls.SetChildIndex(celLabel, 0);
            this.Controls.SetChildIndex(this.apellidoTextBox, 0);
            this.Controls.SetChildIndex(apellidoLabel, 0);
            this.Controls.SetChildIndex(this.rolComboBox, 0);
            this.Controls.SetChildIndex(rolLabel, 0);
            ((System.ComponentModel.ISupportInitialize)(this.usuarioBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource usuarioBindingSource;
        private System.Windows.Forms.TextBox apellidoTextBox;
        private System.Windows.Forms.TextBox celTextBox;
        private System.Windows.Forms.TextBox ciTextBox;
        private System.Windows.Forms.TextBox contraseniaTextBox;
        private System.Windows.Forms.TextBox cuentaTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.ComboBox rolComboBox;
    }
}