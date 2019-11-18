﻿namespace FarmaciaOASIS.Vistas.VentanasCruds
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
            System.Windows.Forms.Label codProvLabel;
            System.Windows.Forms.Label nomMedLabel;
            System.Windows.Forms.Label pUnitLabel;
            this.medicamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cantidadTextBox = new System.Windows.Forms.TextBox();
            this.codProvTextBox = new System.Windows.Forms.TextBox();
            this.nomMedTextBox = new System.Windows.Forms.TextBox();
            this.pUnitTextBox = new System.Windows.Forms.TextBox();
            cantidadLabel = new System.Windows.Forms.Label();
            codProvLabel = new System.Windows.Forms.Label();
            nomMedLabel = new System.Windows.Forms.Label();
            pUnitLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAceptar
            // 
            this.btnAceptar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnAceptar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnAceptar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnAceptar.Click += new System.EventHandler(this.BtnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(159)))), ((int)(((byte)(127)))));
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(118)))), ((int)(((byte)(126)))));
            this.btnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // cantidadLabel
            // 
            cantidadLabel.AutoSize = true;
            cantidadLabel.Location = new System.Drawing.Point(91, 103);
            cantidadLabel.Name = "cantidadLabel";
            cantidadLabel.Size = new System.Drawing.Size(52, 13);
            cantidadLabel.TabIndex = 18;
            cantidadLabel.Text = "Cantidad:";
            // 
            // codProvLabel
            // 
            codProvLabel.AutoSize = true;
            codProvLabel.Location = new System.Drawing.Point(91, 155);
            codProvLabel.Name = "codProvLabel";
            codProvLabel.Size = new System.Drawing.Size(54, 13);
            codProvLabel.TabIndex = 22;
            codProvLabel.Text = "Cod Prov:";
            // 
            // nomMedLabel
            // 
            nomMedLabel.AutoSize = true;
            nomMedLabel.Location = new System.Drawing.Point(91, 181);
            nomMedLabel.Name = "nomMedLabel";
            nomMedLabel.Size = new System.Drawing.Size(56, 13);
            nomMedLabel.TabIndex = 24;
            nomMedLabel.Text = "Nom Med:";
            // 
            // pUnitLabel
            // 
            pUnitLabel.AutoSize = true;
            pUnitLabel.Location = new System.Drawing.Point(91, 207);
            pUnitLabel.Name = "pUnitLabel";
            pUnitLabel.Size = new System.Drawing.Size(36, 13);
            pUnitLabel.TabIndex = 26;
            pUnitLabel.Text = "PUnit:";
            // 
            // medicamentoBindingSource
            // 
            this.medicamentoBindingSource.DataSource = typeof(FarmaciaOASIS.Data.Medicamento);
            // 
            // cantidadTextBox
            // 
            this.cantidadTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentoBindingSource, "Cantidad", true));
            this.cantidadTextBox.Location = new System.Drawing.Point(153, 100);
            this.cantidadTextBox.Name = "cantidadTextBox";
            this.cantidadTextBox.Size = new System.Drawing.Size(100, 20);
            this.cantidadTextBox.TabIndex = 19;
            // 
            // codProvTextBox
            // 
            this.codProvTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentoBindingSource, "CodProv", true));
            this.codProvTextBox.Location = new System.Drawing.Point(153, 152);
            this.codProvTextBox.Name = "codProvTextBox";
            this.codProvTextBox.Size = new System.Drawing.Size(100, 20);
            this.codProvTextBox.TabIndex = 23;
            // 
            // nomMedTextBox
            // 
            this.nomMedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentoBindingSource, "NomMed", true));
            this.nomMedTextBox.Location = new System.Drawing.Point(153, 178);
            this.nomMedTextBox.Name = "nomMedTextBox";
            this.nomMedTextBox.Size = new System.Drawing.Size(100, 20);
            this.nomMedTextBox.TabIndex = 25;
            // 
            // pUnitTextBox
            // 
            this.pUnitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentoBindingSource, "PUnit", true));
            this.pUnitTextBox.Location = new System.Drawing.Point(153, 204);
            this.pUnitTextBox.Name = "pUnitTextBox";
            this.pUnitTextBox.Size = new System.Drawing.Size(100, 20);
            this.pUnitTextBox.TabIndex = 27;
            // 
            // frmMedicamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 407);
            this.Controls.Add(cantidadLabel);
            this.Controls.Add(this.cantidadTextBox);
            this.Controls.Add(codProvLabel);
            this.Controls.Add(this.codProvTextBox);
            this.Controls.Add(nomMedLabel);
            this.Controls.Add(this.nomMedTextBox);
            this.Controls.Add(pUnitLabel);
            this.Controls.Add(this.pUnitTextBox);
            this.Name = "frmMedicamento";
            this.Text = "frmMedicamento";
            this.Load += new System.EventHandler(this.frmMedicamento_Load);
            this.Controls.SetChildIndex(this.pUnitTextBox, 0);
            this.Controls.SetChildIndex(pUnitLabel, 0);
            this.Controls.SetChildIndex(this.nomMedTextBox, 0);
            this.Controls.SetChildIndex(nomMedLabel, 0);
            this.Controls.SetChildIndex(this.codProvTextBox, 0);
            this.Controls.SetChildIndex(codProvLabel, 0);
            this.Controls.SetChildIndex(this.cantidadTextBox, 0);
            this.Controls.SetChildIndex(cantidadLabel, 0);
            this.Controls.SetChildIndex(this.btnCancelar, 0);
            this.Controls.SetChildIndex(this.btnAceptar, 0);
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource medicamentoBindingSource;
        private System.Windows.Forms.TextBox cantidadTextBox;
        private System.Windows.Forms.TextBox codProvTextBox;
        private System.Windows.Forms.TextBox nomMedTextBox;
        private System.Windows.Forms.TextBox pUnitTextBox;
    }
}