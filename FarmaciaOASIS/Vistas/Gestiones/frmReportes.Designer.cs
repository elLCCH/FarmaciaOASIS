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
            System.Windows.Forms.Label nomMedLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
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
            this.medicamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nomMedLabel1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.facturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaDataGridView = new System.Windows.Forms.DataGridView();
            this.NoFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelGanancias = new System.Windows.Forms.Panel();
            this.btnAceptarGanacias = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bdvGanacias = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            nombreLabel = new System.Windows.Forms.Label();
            apellidoLabel = new System.Windows.Forms.Label();
            ciLabel = new System.Windows.Forms.Label();
            noFacturaLabel = new System.Windows.Forms.Label();
            noAutorizacionLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            nomMedLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleFacturaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panelGanancias.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)));
            this.btnRegistrar.BackColor = System.Drawing.Color.SlateGray;
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnRegistrar.Location = new System.Drawing.Point(73, 344);
            this.btnRegistrar.Size = new System.Drawing.Size(179, 46);
            this.btnRegistrar.Text = "Generar PDF";
            this.btnRegistrar.Click += new System.EventHandler(this.BtnRegistrar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnEliminar.FlatAppearance.BorderSize = 0;
            this.btnEliminar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnEliminar.Location = new System.Drawing.Point(6, 442);
            this.btnEliminar.Size = new System.Drawing.Size(135, 40);
            this.btnEliminar.Visible = false;
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(69)))), ((int)(((byte)(76)))));
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(45)))), ((int)(((byte)(53)))));
            this.btnModificar.Location = new System.Drawing.Point(15, 396);
            this.btnModificar.Size = new System.Drawing.Size(298, 40);
            this.btnModificar.Text = "Ver Reporte de Ganancias";
            this.btnModificar.Click += new System.EventHandler(this.BtnModificar_Click);
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBusqueda.Location = new System.Drawing.Point(296, 56);
            this.txtBusqueda.Size = new System.Drawing.Size(583, 24);
            this.txtBusqueda.Text = "";
            this.txtBusqueda.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtBusqueda_KeyPress);
            this.txtBusqueda.KeyUp += new System.Windows.Forms.KeyEventHandler(this.TxtBusqueda_KeyUp);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(8, 6);
            this.pictureBox2.Size = new System.Drawing.Size(94, 88);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(927, 6);
            this.pictureBox1.Size = new System.Drawing.Size(87, 88);
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
            // nomMedLabel
            // 
            nomMedLabel.AutoSize = true;
            nomMedLabel.Location = new System.Drawing.Point(509, 257);
            nomMedLabel.Name = "nomMedLabel";
            nomMedLabel.Size = new System.Drawing.Size(56, 13);
            nomMedLabel.TabIndex = 21;
            nomMedLabel.Text = "Nom Med:";
            // 
            // detalleFacturaBindingSource
            // 
            this.detalleFacturaBindingSource.DataSource = typeof(FarmaciaOASIS.Data.DetalleFactura);
            // 
            // detalleFacturaDataGridView
            // 
            this.detalleFacturaDataGridView.AllowUserToAddRows = false;
            this.detalleFacturaDataGridView.AllowUserToDeleteRows = false;
            this.detalleFacturaDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.detalleFacturaDataGridView.AutoGenerateColumns = false;
            this.detalleFacturaDataGridView.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Monotype Corsiva", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detalleFacturaDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.detalleFacturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detalleFacturaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColNumFact,
            this.CodMed,
            this.ColCant,
            this.ColPre});
            this.detalleFacturaDataGridView.DataSource = this.detalleFacturaBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(245)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.detalleFacturaDataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.detalleFacturaDataGridView.EnableHeadersVisualStyles = false;
            this.detalleFacturaDataGridView.Location = new System.Drawing.Point(333, 101);
            this.detalleFacturaDataGridView.Name = "detalleFacturaDataGridView";
            this.detalleFacturaDataGridView.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(245)))), ((int)(((byte)(214)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.detalleFacturaDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.detalleFacturaDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.detalleFacturaDataGridView.Size = new System.Drawing.Size(546, 298);
            this.detalleFacturaDataGridView.TabIndex = 12;
            // 
            // ColNumFact
            // 
            this.ColNumFact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColNumFact.DataPropertyName = "NoFactura";
            this.ColNumFact.HeaderText = "NoFactura";
            this.ColNumFact.Name = "ColNumFact";
            this.ColNumFact.ReadOnly = true;
            // 
            // CodMed
            // 
            this.CodMed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.CodMed.DataPropertyName = "CodMed";
            this.CodMed.HeaderText = "CodMed";
            this.CodMed.Name = "CodMed";
            this.CodMed.ReadOnly = true;
            // 
            // ColCant
            // 
            this.ColCant.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.ColCant.DataPropertyName = "CantMed";
            this.ColCant.HeaderText = "CantMed";
            this.ColCant.Name = "ColCant";
            this.ColCant.ReadOnly = true;
            // 
            // ColPre
            // 
            this.ColPre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
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
            this.nombreLabel1.Location = new System.Drawing.Point(174, 170);
            this.nombreLabel1.Name = "nombreLabel1";
            this.nombreLabel1.Size = new System.Drawing.Size(139, 23);
            this.nombreLabel1.TabIndex = 14;
            this.nombreLabel1.Text = "label1";
            // 
            // apellidoLabel1
            // 
            this.apellidoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleFacturaBindingSource, "Factura.Cliente.Apellido", true));
            this.apellidoLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.apellidoLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.apellidoLabel1.Location = new System.Drawing.Point(174, 192);
            this.apellidoLabel1.Name = "apellidoLabel1";
            this.apellidoLabel1.Size = new System.Drawing.Size(139, 23);
            this.apellidoLabel1.TabIndex = 15;
            this.apellidoLabel1.Text = "label1";
            // 
            // ciLabel1
            // 
            this.ciLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleFacturaBindingSource, "Factura.Cliente.Ci", true));
            this.ciLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ciLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.ciLabel1.Location = new System.Drawing.Point(174, 220);
            this.ciLabel1.Name = "ciLabel1";
            this.ciLabel1.Size = new System.Drawing.Size(139, 23);
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
            this.noFacturaLabel1.Size = new System.Drawing.Size(117, 23);
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
            this.noAutorizacionLabel1.Size = new System.Drawing.Size(117, 23);
            this.noAutorizacionLabel1.TabIndex = 18;
            this.noAutorizacionLabel1.Text = "label1";
            // 
            // fechaLabel1
            // 
            this.fechaLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.detalleFacturaBindingSource, "Factura.Fecha", true));
            this.fechaLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaLabel1.ForeColor = System.Drawing.SystemColors.Control;
            this.fechaLabel1.Location = new System.Drawing.Point(174, 249);
            this.fechaLabel1.Name = "fechaLabel1";
            this.fechaLabel1.Size = new System.Drawing.Size(139, 23);
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
            this.lblTotal.Size = new System.Drawing.Size(56, 24);
            this.lblTotal.TabIndex = 20;
            this.lblTotal.Text = "Total";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(376, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(306, 33);
            this.label1.TabIndex = 21;
            this.label1.Text = "REPORTE DE FACTURA";
            // 
            // medicamentoBindingSource
            // 
            this.medicamentoBindingSource.DataSource = typeof(FarmaciaOASIS.Data.Medicamento);
            // 
            // nomMedLabel1
            // 
            this.nomMedLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.medicamentoBindingSource, "NomMed", true));
            this.nomMedLabel1.Location = new System.Drawing.Point(571, 257);
            this.nomMedLabel1.Name = "nomMedLabel1";
            this.nomMedLabel1.Size = new System.Drawing.Size(100, 23);
            this.nomMedLabel1.TabIndex = 22;
            this.nomMedLabel1.Text = "label2";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(174, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 25;
            this.label3.Text = "Busqueda:";
            // 
            // facturaBindingSource
            // 
            this.facturaBindingSource.DataSource = typeof(FarmaciaOASIS.Data.Factura);
            // 
            // facturaDataGridView
            // 
            this.facturaDataGridView.AutoGenerateColumns = false;
            this.facturaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.facturaDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NoFactura,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.facturaDataGridView.DataSource = this.facturaBindingSource;
            this.facturaDataGridView.Location = new System.Drawing.Point(28, 3);
            this.facturaDataGridView.Name = "facturaDataGridView";
            this.facturaDataGridView.Size = new System.Drawing.Size(342, 220);
            this.facturaDataGridView.TabIndex = 26;
            // 
            // NoFactura
            // 
            this.NoFactura.DataPropertyName = "NoFactura";
            this.NoFactura.HeaderText = "NoFactura";
            this.NoFactura.Name = "NoFactura";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Fecha";
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CodCliente";
            this.dataGridViewTextBoxColumn3.HeaderText = "CodCliente";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Cliente";
            this.dataGridViewTextBoxColumn4.HeaderText = "Cliente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "DetalleFactura";
            this.dataGridViewTextBoxColumn5.HeaderText = "DetalleFactura";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(41, 77);
            this.chart1.Name = "chart1";
            this.chart1.Size = new System.Drawing.Size(725, 325);
            this.chart1.TabIndex = 29;
            this.chart1.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.facturaDataGridView);
            this.panel1.Location = new System.Drawing.Point(932, 86);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(162, 107);
            this.panel1.TabIndex = 30;
            this.panel1.Visible = false;
            // 
            // panelGanancias
            // 
            this.panelGanancias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(176)))), ((int)(((byte)(230)))));
            this.panelGanancias.Controls.Add(this.btnAceptarGanacias);
            this.panelGanancias.Controls.Add(this.label4);
            this.panelGanancias.Controls.Add(this.chart1);
            this.panelGanancias.Location = new System.Drawing.Point(108, 42);
            this.panelGanancias.Name = "panelGanancias";
            this.panelGanancias.Size = new System.Drawing.Size(786, 470);
            this.panelGanancias.TabIndex = 31;
            this.panelGanancias.Visible = false;
            // 
            // btnAceptarGanacias
            // 
            this.btnAceptarGanacias.Location = new System.Drawing.Point(351, 408);
            this.btnAceptarGanacias.Name = "btnAceptarGanacias";
            this.btnAceptarGanacias.Size = new System.Drawing.Size(125, 31);
            this.btnAceptarGanacias.TabIndex = 31;
            this.btnAceptarGanacias.Text = "ACEPTAR";
            this.btnAceptarGanacias.UseVisualStyleBackColor = true;
            this.btnAceptarGanacias.Click += new System.EventHandler(this.BtnAceptarGanacias_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(239, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(336, 33);
            this.label4.TabIndex = 30;
            this.label4.Text = "REPORTE DE GANANCIAS";
            // 
            // bdvGanacias
            // 
            this.bdvGanacias.Fixed = false;
            this.bdvGanacias.Horizontal = true;
            this.bdvGanacias.TargetControl = this.panelGanancias;
            this.bdvGanacias.Vertical = true;
            // 
            // frmReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(176)))), ((int)(((byte)(140)))));
            this.ClientSize = new System.Drawing.Size(1016, 494);
            this.Controls.Add(this.panelGanancias);
            this.Controls.Add(this.detalleFacturaDataGridView);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label3);
            this.Controls.Add(nomMedLabel);
            this.Controls.Add(this.nomMedLabel1);
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
            this.Name = "frmReportes";
            this.Text = "frmReportes";
            this.Load += new System.EventHandler(this.frmReportes_Load);
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
            this.Controls.SetChildIndex(this.nomMedLabel1, 0);
            this.Controls.SetChildIndex(nomMedLabel, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.detalleFacturaDataGridView, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.txtBusqueda, 0);
            this.Controls.SetChildIndex(this.btnModificar, 0);
            this.Controls.SetChildIndex(this.btnEliminar, 0);
            this.Controls.SetChildIndex(this.btnRegistrar, 0);
            this.Controls.SetChildIndex(this.panelGanancias, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalleFacturaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.medicamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturaDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panelGanancias.ResumeLayout(false);
            this.panelGanancias.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColNumFact;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodMed;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColCant;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColPre;
        private System.Windows.Forms.BindingSource medicamentoBindingSource;
        private System.Windows.Forms.Label nomMedLabel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.BindingSource facturaBindingSource;
        private System.Windows.Forms.DataGridView facturaDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NoFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panelGanancias;
        private System.Windows.Forms.Button btnAceptarGanacias;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuDragControl bdvGanacias;
    }
}