namespace CentroDiurnoApplication
{
    partial class MainInterface
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainInterface));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuItem_fondosExternos = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItem_fondosPropios = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_months = new System.Windows.Forms.ComboBox();
            this.button_generatePDF = new System.Windows.Forms.Button();
            this.textBox_jps = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_fodesaf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_clean = new System.Windows.Forms.Button();
            this.button_update = new System.Windows.Forms.Button();
            this.button_delete = new System.Windows.Forms.Button();
            this.button_add = new System.Windows.Forms.Button();
            this.textBox_conapan = new System.Windows.Forms.TextBox();
            this.textBox_description = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.comboBox_months2 = new System.Windows.Forms.ComboBox();
            this.button_generate_pdf_fp = new System.Windows.Forms.Button();
            this.button_clean_fp = new System.Windows.Forms.Button();
            this.button_update_fp = new System.Windows.Forms.Button();
            this.button_delete_fp = new System.Windows.Forms.Button();
            this.button_add_fp = new System.Windows.Forms.Button();
            this.dataGridView_fp = new System.Windows.Forms.DataGridView();
            this.textBox_montoFP = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_descripcionFP = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fp)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItem_fondosExternos,
            this.menuItem_fondosPropios});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(846, 24);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuItem_fondosExternos
            // 
            this.menuItem_fondosExternos.Name = "menuItem_fondosExternos";
            this.menuItem_fondosExternos.Size = new System.Drawing.Size(106, 20);
            this.menuItem_fondosExternos.Text = "Fondos Publicos";
            this.menuItem_fondosExternos.Click += new System.EventHandler(this.gastosToolStripMenuItem_Click);
            // 
            // menuItem_fondosPropios
            // 
            this.menuItem_fondosPropios.Name = "menuItem_fondosPropios";
            this.menuItem_fondosPropios.Size = new System.Drawing.Size(101, 20);
            this.menuItem_fondosPropios.Text = "Fondos Propios";
            this.menuItem_fondosPropios.Click += new System.EventHandler(this.fondosPropiosToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.comboBox_months);
            this.panel1.Controls.Add(this.button_generatePDF);
            this.panel1.Controls.Add(this.textBox_jps);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_fodesaf);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.button_clean);
            this.panel1.Controls.Add(this.button_update);
            this.panel1.Controls.Add(this.button_delete);
            this.panel1.Controls.Add(this.button_add);
            this.panel1.Controls.Add(this.textBox_conapan);
            this.panel1.Controls.Add(this.textBox_description);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.dataGridView);
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(846, 522);
            this.panel1.TabIndex = 15;
            // 
            // comboBox_months
            // 
            this.comboBox_months.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_months.FormattingEnabled = true;
            this.comboBox_months.Location = new System.Drawing.Point(86, 177);
            this.comboBox_months.Name = "comboBox_months";
            this.comboBox_months.Size = new System.Drawing.Size(121, 21);
            this.comboBox_months.TabIndex = 28;
            this.comboBox_months.SelectedValueChanged += new System.EventHandler(this.comboBox_months_SelectedValueChanged);
            // 
            // button_generatePDF
            // 
            this.button_generatePDF.BackColor = System.Drawing.Color.Silver;
            this.button_generatePDF.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_generatePDF.Location = new System.Drawing.Point(380, 472);
            this.button_generatePDF.Name = "button_generatePDF";
            this.button_generatePDF.Size = new System.Drawing.Size(102, 32);
            this.button_generatePDF.TabIndex = 27;
            this.button_generatePDF.Text = "Generar PDF";
            this.button_generatePDF.UseVisualStyleBackColor = false;
            this.button_generatePDF.Click += new System.EventHandler(this.button_generatePDF_Click);
            // 
            // textBox_jps
            // 
            this.textBox_jps.Location = new System.Drawing.Point(392, 114);
            this.textBox_jps.Name = "textBox_jps";
            this.textBox_jps.Size = new System.Drawing.Size(158, 20);
            this.textBox_jps.TabIndex = 17;
            this.textBox_jps.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_only_numbers);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(346, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 25;
            this.label4.Text = "JPS:";
            // 
            // textBox_fodesaf
            // 
            this.textBox_fodesaf.Location = new System.Drawing.Point(392, 84);
            this.textBox_fodesaf.Name = "textBox_fodesaf";
            this.textBox_fodesaf.Size = new System.Drawing.Size(158, 20);
            this.textBox_fodesaf.TabIndex = 16;
            this.textBox_fodesaf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_only_numbers);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(317, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 16);
            this.label2.TabIndex = 24;
            this.label2.Text = "Fodesaf:";
            // 
            // button_clean
            // 
            this.button_clean.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_clean.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clean.Location = new System.Drawing.Point(448, 165);
            this.button_clean.Name = "button_clean";
            this.button_clean.Size = new System.Drawing.Size(75, 23);
            this.button_clean.TabIndex = 20;
            this.button_clean.Text = "Limpiar";
            this.button_clean.UseVisualStyleBackColor = false;
            this.button_clean.Click += new System.EventHandler(this.clear_text_box);
            // 
            // button_update
            // 
            this.button_update.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_update.Location = new System.Drawing.Point(349, 165);
            this.button_update.Name = "button_update";
            this.button_update.Size = new System.Drawing.Size(75, 23);
            this.button_update.TabIndex = 19;
            this.button_update.Text = "Actualizar";
            this.button_update.UseVisualStyleBackColor = false;
            this.button_update.Click += new System.EventHandler(this.button_update_Click);
            // 
            // button_delete
            // 
            this.button_delete.BackColor = System.Drawing.Color.Red;
            this.button_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_delete.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_delete.Location = new System.Drawing.Point(529, 165);
            this.button_delete.Name = "button_delete";
            this.button_delete.Size = new System.Drawing.Size(75, 23);
            this.button_delete.TabIndex = 21;
            this.button_delete.Text = "Eliminar";
            this.button_delete.UseVisualStyleBackColor = false;
            this.button_delete.Click += new System.EventHandler(this.button_delete_Click);
            // 
            // button_add
            // 
            this.button_add.BackColor = System.Drawing.Color.Lime;
            this.button_add.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add.Location = new System.Drawing.Point(268, 165);
            this.button_add.Name = "button_add";
            this.button_add.Size = new System.Drawing.Size(75, 23);
            this.button_add.TabIndex = 18;
            this.button_add.Text = "Agregar";
            this.button_add.UseVisualStyleBackColor = false;
            this.button_add.Click += new System.EventHandler(this.button_add_Click);
            // 
            // textBox_conapan
            // 
            this.textBox_conapan.Location = new System.Drawing.Point(392, 54);
            this.textBox_conapan.Name = "textBox_conapan";
            this.textBox_conapan.Size = new System.Drawing.Size(158, 20);
            this.textBox_conapan.TabIndex = 15;
            this.textBox_conapan.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_only_numbers);
            // 
            // textBox_description
            // 
            this.textBox_description.Location = new System.Drawing.Point(392, 23);
            this.textBox_description.Name = "textBox_description";
            this.textBox_description.Size = new System.Drawing.Size(158, 20);
            this.textBox_description.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(312, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 16);
            this.label3.TabIndex = 23;
            this.label3.Text = "Conapan:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(291, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 22;
            this.label1.Text = "Descripción:";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AllowUserToResizeColumns = false;
            this.dataGridView.AllowUserToResizeRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.BackgroundColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 30;
            this.dataGridView.Location = new System.Drawing.Point(30, 215);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Blue;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView.RowTemplate.Height = 30;
            this.dataGridView.Size = new System.Drawing.Size(786, 242);
            this.dataGridView.TabIndex = 26;
            this.dataGridView.Click += new System.EventHandler(this.dataGridView_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.comboBox_months2);
            this.panel2.Controls.Add(this.button_generate_pdf_fp);
            this.panel2.Controls.Add(this.button_clean_fp);
            this.panel2.Controls.Add(this.button_update_fp);
            this.panel2.Controls.Add(this.button_delete_fp);
            this.panel2.Controls.Add(this.button_add_fp);
            this.panel2.Controls.Add(this.dataGridView_fp);
            this.panel2.Controls.Add(this.textBox_montoFP);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.textBox_descripcionFP);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Location = new System.Drawing.Point(0, 27);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(846, 522);
            this.panel2.TabIndex = 28;
            // 
            // comboBox_months2
            // 
            this.comboBox_months2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_months2.FormattingEnabled = true;
            this.comboBox_months2.Location = new System.Drawing.Point(72, 167);
            this.comboBox_months2.Name = "comboBox_months2";
            this.comboBox_months2.Size = new System.Drawing.Size(121, 21);
            this.comboBox_months2.TabIndex = 34;
            this.comboBox_months2.SelectedIndexChanged += new System.EventHandler(this.comboBox_months_SelectedValueChanged);
            // 
            // button_generate_pdf_fp
            // 
            this.button_generate_pdf_fp.BackColor = System.Drawing.Color.Silver;
            this.button_generate_pdf_fp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_generate_pdf_fp.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button_generate_pdf_fp.Location = new System.Drawing.Point(380, 472);
            this.button_generate_pdf_fp.Name = "button_generate_pdf_fp";
            this.button_generate_pdf_fp.Size = new System.Drawing.Size(102, 32);
            this.button_generate_pdf_fp.TabIndex = 33;
            this.button_generate_pdf_fp.Text = "Generar PDF";
            this.button_generate_pdf_fp.UseVisualStyleBackColor = false;
            this.button_generate_pdf_fp.Click += new System.EventHandler(this.button_generate_pdf_fp_Click);
            // 
            // button_clean_fp
            // 
            this.button_clean_fp.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_clean_fp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_clean_fp.Location = new System.Drawing.Point(448, 165);
            this.button_clean_fp.Name = "button_clean_fp";
            this.button_clean_fp.Size = new System.Drawing.Size(75, 23);
            this.button_clean_fp.TabIndex = 30;
            this.button_clean_fp.Text = "Limpiar";
            this.button_clean_fp.UseVisualStyleBackColor = false;
            this.button_clean_fp.Click += new System.EventHandler(this.clear_text_box);
            // 
            // button_update_fp
            // 
            this.button_update_fp.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button_update_fp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_update_fp.Location = new System.Drawing.Point(349, 165);
            this.button_update_fp.Name = "button_update_fp";
            this.button_update_fp.Size = new System.Drawing.Size(75, 23);
            this.button_update_fp.TabIndex = 29;
            this.button_update_fp.Text = "Actualizar";
            this.button_update_fp.UseVisualStyleBackColor = false;
            this.button_update_fp.Click += new System.EventHandler(this.button_update_fp_Click);
            // 
            // button_delete_fp
            // 
            this.button_delete_fp.BackColor = System.Drawing.Color.Red;
            this.button_delete_fp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_delete_fp.ForeColor = System.Drawing.SystemColors.WindowText;
            this.button_delete_fp.Location = new System.Drawing.Point(529, 165);
            this.button_delete_fp.Name = "button_delete_fp";
            this.button_delete_fp.Size = new System.Drawing.Size(75, 23);
            this.button_delete_fp.TabIndex = 31;
            this.button_delete_fp.Text = "Eliminar";
            this.button_delete_fp.UseVisualStyleBackColor = false;
            this.button_delete_fp.Click += new System.EventHandler(this.button_delete_fp_Click);
            // 
            // button_add_fp
            // 
            this.button_add_fp.BackColor = System.Drawing.Color.Lime;
            this.button_add_fp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button_add_fp.Location = new System.Drawing.Point(268, 165);
            this.button_add_fp.Name = "button_add_fp";
            this.button_add_fp.Size = new System.Drawing.Size(75, 23);
            this.button_add_fp.TabIndex = 28;
            this.button_add_fp.Text = "Agregar";
            this.button_add_fp.UseVisualStyleBackColor = false;
            this.button_add_fp.Click += new System.EventHandler(this.button_add_fp_Click);
            // 
            // dataGridView_fp
            // 
            this.dataGridView_fp.AllowUserToAddRows = false;
            this.dataGridView_fp.AllowUserToDeleteRows = false;
            this.dataGridView_fp.AllowUserToResizeColumns = false;
            this.dataGridView_fp.AllowUserToResizeRows = false;
            this.dataGridView_fp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_fp.BackgroundColor = System.Drawing.Color.MidnightBlue;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_fp.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView_fp.ColumnHeadersHeight = 30;
            this.dataGridView_fp.Location = new System.Drawing.Point(30, 215);
            this.dataGridView_fp.Name = "dataGridView_fp";
            this.dataGridView_fp.ReadOnly = true;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.Blue;
            this.dataGridView_fp.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView_fp.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.LightSteelBlue;
            this.dataGridView_fp.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridView_fp.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightSeaGreen;
            this.dataGridView_fp.RowTemplate.Height = 30;
            this.dataGridView_fp.Size = new System.Drawing.Size(786, 242);
            this.dataGridView_fp.TabIndex = 32;
            this.dataGridView_fp.Click += new System.EventHandler(this.dataGridView_fp_Click);
            // 
            // textBox_montoFP
            // 
            this.textBox_montoFP.Location = new System.Drawing.Point(392, 84);
            this.textBox_montoFP.Name = "textBox_montoFP";
            this.textBox_montoFP.Size = new System.Drawing.Size(158, 20);
            this.textBox_montoFP.TabIndex = 3;
            this.textBox_montoFP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_only_numbers);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(330, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Monto:";
            // 
            // textBox_descripcionFP
            // 
            this.textBox_descripcionFP.Location = new System.Drawing.Point(392, 54);
            this.textBox_descripcionFP.Name = "textBox_descripcionFP";
            this.textBox_descripcionFP.Size = new System.Drawing.Size(158, 20);
            this.textBox_descripcionFP.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(289, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "Descripción:";
            // 
            // MainInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(846, 548);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainInterface";
            this.Text = "Control de pagos";
            this.Load += new System.EventHandler(this.MainInterface_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_fp)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuItem_fondosExternos;
        private System.Windows.Forms.ToolStripMenuItem menuItem_fondosPropios;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button_generatePDF;
        private System.Windows.Forms.TextBox textBox_jps;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_fodesaf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_clean;
        private System.Windows.Forms.Button button_update;
        private System.Windows.Forms.Button button_delete;
        private System.Windows.Forms.Button button_add;
        private System.Windows.Forms.TextBox textBox_conapan;
        private System.Windows.Forms.TextBox textBox_description;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button_generate_pdf_fp;
        private System.Windows.Forms.Button button_clean_fp;
        private System.Windows.Forms.Button button_update_fp;
        private System.Windows.Forms.Button button_delete_fp;
        private System.Windows.Forms.Button button_add_fp;
        private System.Windows.Forms.DataGridView dataGridView_fp;
        private System.Windows.Forms.TextBox textBox_montoFP;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_descripcionFP;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBox_months;
        private System.Windows.Forms.ComboBox comboBox_months2;
    }
}