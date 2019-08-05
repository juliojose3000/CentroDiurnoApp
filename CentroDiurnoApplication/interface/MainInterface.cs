using CentroDiurnoApplication.database;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace CentroDiurnoApplication
{
    public partial class MainInterface : Form
    {

        DataTable mainDataTable;
        DataTable fpDataTable;
        DBFondosExternos DbFondosExternos;
        DBFondosPropios DbFondosPropios;
        List<Panel> listPanel = new List<Panel>();


        public MainInterface()
        {
            DbFondosExternos = new DBFondosExternos();
            DbFondosPropios = new DBFondosPropios();
            mainDataTable = new DataTable();
            fpDataTable = new DataTable();

            InitializeComponent();

            loadHeadersDataTableMain();
            loadHeadersDataTableFP();

            loadDataInComboBox();

            menuItem_fondosExternos.BackColor = Color.CornflowerBlue;

        }

        public void loadDataInComboBox()
        {
            comboBox_months.Items.Add("Enero");
            comboBox_months.Items.Add("Febrero");
            comboBox_months.Items.Add("Marzo");
            comboBox_months.Items.Add("Abril");
            comboBox_months.Items.Add("Mayo");
            comboBox_months.Items.Add("Junio");
            comboBox_months.Items.Add("Julio");
            comboBox_months.Items.Add("Agosto");
            comboBox_months.Items.Add("Septiembre");
            comboBox_months.Items.Add("Octubre");
            comboBox_months.Items.Add("Noviembre");
            comboBox_months.Items.Add("Diciembre");

            DateTime dt = DateTime.Now;
            int currentMonth = dt.Month-1;

            comboBox_months.SelectedIndex = currentMonth;

            //----------------------------------------//

            comboBox_months2.Items.Add("Enero");
            comboBox_months2.Items.Add("Febrero");
            comboBox_months2.Items.Add("Marzo");
            comboBox_months2.Items.Add("Abril");
            comboBox_months2.Items.Add("Mayo");
            comboBox_months2.Items.Add("Junio");
            comboBox_months2.Items.Add("Julio");
            comboBox_months2.Items.Add("Agosto");
            comboBox_months2.Items.Add("Septiembre");
            comboBox_months2.Items.Add("Octubre");
            comboBox_months2.Items.Add("Noviembre");
            comboBox_months2.Items.Add("Diciembre");

            comboBox_months2.SelectedIndex = currentMonth;

        }

        private string getMonth(int monthNumber)
        {
            switch (monthNumber)
            {
                case 1:
                    return "Enero";
                    break;
                case 2:
                    return "Febrero";
                    break;
                case 3:
                    return "Marzo";
                    break;
                case 4:
                    return "Abril";
                    break;
                case 5:
                    return "Mayo";
                    break;
                case 6:
                    return "Junio";
                    break;
                case 7:
                    return "Julio";
                    break;
                case 8:
                    return "Agosto";
                    break;
                case 9:
                    return "Septiembre";
                    break;
                case 10:
                    return "Octubre";
                    break;
                case 11:
                    return "Noviembre";
                    break;
                case 12:
                    return "Diciembre";
                    break;
            }

            return "";
        }

        public void MainInterface_Load(object sender, EventArgs e)
        {

            listPanel.Add(panel1);
            listPanel.Add(panel2);

            listPanel[0].BringToFront();

            RowsColor(dataGridView);
            RowsColor(dataGridView_fp);
        }

        private void gastosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listPanel[0].BringToFront();

            menuItem_fondosPropios.BackColor = Color.LightSteelBlue;
            menuItem_fondosExternos.BackColor = Color.CornflowerBlue;
        }

        private void fondosPropiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listPanel[1].BringToFront();

            menuItem_fondosPropios.BackColor = Color.CornflowerBlue;
            menuItem_fondosExternos.BackColor = Color.LightSteelBlue;
        }

        //This method, allows the user only type numbers in any textbox
        private void textbox_only_numbers(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public void clear_text_box(object sender, EventArgs e)
        {
            clear_text_box();
        }

        private void clear_text_box()
        {
            textBox_description.Text = "";
            textBox_conapan.Text = "";
            textBox_fodesaf.Text = "";
            textBox_jps.Text = "";
            textBox_descripcionFP.Text = "";
            textBox_montoFP.Text = "";
        }

        public void RowsColor(DataGridView dataGrid)
        {
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                if (i % 2 != 0)
                {
                    dataGrid.Rows[i].DefaultCellStyle.BackColor = Color.CadetBlue;
                }
                else
                {
                    dataGrid.Rows[i].DefaultCellStyle.BackColor = Color.LightSteelBlue;
                }
                //Microsoft YaHei, 9.75pt
                dataGrid.Rows[dataGrid.Rows.Count-1].DefaultCellStyle.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, FontStyle.Bold);
            }
        }

        private Boolean isNumberOrDot(char digit)
        {
            if (char.IsDigit(digit))
            {
                return true;
            }
            else if (digit == '.')
            {
                return true;
            }
            return false;
        }

        public void exportGridToPDF(string filename)
        {

            BaseFont bf = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1250, BaseFont.EMBEDDED);
            iTextSharp.text.Font text = new iTextSharp.text.Font(bf, 10, iTextSharp.text.Font.NORMAL);

            //PDFTable fondos externos
            PdfPTable pdfTable = new PdfPTable(dataGridView.Columns.Count);
            pdfTable.DefaultCell.Padding = 7;
            pdfTable.WidthPercentage = 100;
            pdfTable.DefaultCell.BorderWidth = 1;

            //add header
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.Padding = 7;
                pdfTable.AddCell(cell);

            }

            //Add datarow

            foreach (DataGridViewRow row in dataGridView.Rows)
            {

                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(new Phrase(cell.Value.ToString(), text));

                }

            }

            //-------------------------------------------------------------//
            //PDFTable fondos internos
            //-------------------------------------------------------------//
            PdfPTable pdfTable2 = new PdfPTable(dataGridView_fp.Columns.Count);
            pdfTable2.DefaultCell.Padding = 7;
            pdfTable2.WidthPercentage = 100;
            pdfTable2.DefaultCell.BorderWidth = 1;

            //add header format
            foreach (DataGridViewColumn column in dataGridView_fp.Columns)
            {
                PdfPCell cell = new PdfPCell(new iTextSharp.text.Phrase(column.HeaderText));
                cell.BackgroundColor = new iTextSharp.text.BaseColor(240, 240, 240);
                cell.HorizontalAlignment = Element.ALIGN_CENTER;
                cell.Padding = 7;
                pdfTable2.AddCell(cell);

            }

            //Add datarow

            foreach (DataGridViewRow row in dataGridView_fp.Rows)
            {

                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable2.AddCell(new Phrase(cell.Value.ToString(), text));

                }

            }

            //------------------------------------------------------------------//


            var savefiledialoge = new SaveFileDialog();
            savefiledialoge.FileName = filename;
            savefiledialoge.DefaultExt = ".pdf";

            if (savefiledialoge.ShowDialog() == DialogResult.OK)
            {

                try
                {
                    using (FileStream stream = new FileStream(savefiledialoge.FileName, FileMode.Create))
                    {
                        Document pdfdoc = new Document(PageSize.A4, 50f, 50f, 50f, 50f);
                        PdfWriter.GetInstance(pdfdoc, stream);
                        pdfdoc.Open();

                        //--------------------//

                        iTextSharp.text.Font titleFont = FontFactory.GetFont("Arial", 24);
                        iTextSharp.text.Font regularFont = FontFactory.GetFont("Arial", 14);
                        Paragraph title;
                        Paragraph textParagrahp;
                        title = new Paragraph("Asociación Centro De Atención Al Adulto Mayor De Cachí\n\n", titleFont);
                        title.Alignment = Element.ALIGN_CENTER;
                        pdfdoc.Add(title);

                        textParagrahp = new Paragraph("Pagos realizados durante el mes de "+getMonth(DateTime.Now.Month)+"\n\n", FontFactory.GetFont("Arial", 16));
                        textParagrahp.Alignment = Element.ALIGN_CENTER;
                        pdfdoc.Add(textParagrahp);

                        textParagrahp = new Paragraph("Fondos públicos:\n\n", regularFont);
                        pdfdoc.Add(textParagrahp);

                        //-------------------//

                        pdfdoc.Add(pdfTable);

                        textParagrahp = new Paragraph("\nFondos internos:\n\n", regularFont);
                        pdfdoc.Add(textParagrahp);

                        pdfdoc.Add(pdfTable2);
                        pdfdoc.Close();
                        stream.Close();
                    }
                }
                catch(Exception e)
                {
                    Console.Write(e);
                    MessageBox.Show("No se puede guardar el archivo, ya que está siendo usado en este momento por otra aplicación.", "Cierre el archivo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                


            }


        }

        public string myNumberFormat(float xyz)
        {
            //return string.Format("{0:#,0.00}", xyz) + " ₡";

            // Gets a NumberFormatInfo associated with the en-US culture.
            NumberFormatInfo nfi = new CultureInfo("es", false).NumberFormat;

            nfi.CurrencyDecimalSeparator = ".";
            nfi.CurrencyGroupSeparator = " ";
            nfi.CurrencySymbol = "";
            return  Convert.ToDecimal(xyz).ToString("C2",nfi);

        }

        private void deleteRowsFromDataGrid(DataGridView dtg)
        {

            int rowCount = dtg.Rows.Count;
            for (int i = rowCount - 1; i >= 0; i--)
            {
                DataGridViewRow dr = dtg.Rows[i];
                dtg.Rows.Remove(dr);
            }


        }

        private void comboBox_months_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox comboBoxMonths = (ComboBox)sender;

            comboBox_months.SelectedItem = comboBoxMonths.SelectedItem;
            comboBox_months2.SelectedItem = comboBoxMonths.SelectedItem;

            if (dataGridView.Rows.Count != 0)
            {
                deleteRowsFromDataGrid(dataGridView);
            }

            string month = comboBoxMonths.SelectedItem.ToString();

            loadDataInDataTable(month, DateTime.Now.Year);

            loadTotals();

            //-----------------------//

            if (dataGridView_fp.Rows.Count != 0)
            {
                deleteRowsFromDataGrid(dataGridView_fp);
            }

            loadDataInDataTableFP(month, DateTime.Now.Year);

            loadTotalsFP();
        }

        //----------------------------------------------PANEL 1------------------------------------------------//

        private void loadHeadersDataTableMain()
        {
            mainDataTable.Columns.Add("ID");
            mainDataTable.Columns.Add("Descripción");
            mainDataTable.Columns.Add("Conapan");
            mainDataTable.Columns.Add("Fodesaf");
            mainDataTable.Columns.Add("JPS");
            mainDataTable.Columns.Add("Total");

            dataGridView.DataSource = mainDataTable;

            loadDataInDataTable(getMonth(DateTime.Now.Month), DateTime.Now.Year);

            loadTotals();

            //sets the width in the firts ans second column
            DataGridViewColumn idColumn = dataGridView.Columns[0];
            idColumn.Width = 40;
            DataGridViewColumn descColumn = dataGridView.Columns[1];
            descColumn.Width = 200;
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dataGridView.EnableHeadersVisualStyles = false;


            //disable the sorting function when the user press any header
            foreach (DataGridViewColumn column in dataGridView.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        //This method fill the data table with the DB data
        private void loadDataInDataTable(string month, int year)
        {

            List<Payment> listPayments = DbFondosExternos.read(month, year);

            foreach(Payment payment in listPayments)
            {
                string conapan = myNumberFormat(payment.Amount_conapan);
                string fodesaf = myNumberFormat(payment.Amount_fodesaf);
                string jps = myNumberFormat(payment.Amount_jps);
                string total = myNumberFormat(payment.Total);
                mainDataTable.Rows.Add(payment.Id, payment.Description, conapan, fodesaf, jps, total);
            }

        }

        private void loadTotals()
        {
            float totalConapan = 0;
            float totalFodesaf = 0;
            float totalJps = 0;
            float total = 0;

            for(int i = 0; i<mainDataTable.Rows.Count; i++)
            {

                DataRow datarow = mainDataTable.Rows[i];

                string conapan = new string((""+datarow[2]).Where(isNumberOrDot).ToArray()).Replace(",",".");
                string fodesaf = new string(("" + datarow[3]).Where(isNumberOrDot).ToArray()).Replace(",", ".");
                string jps = new string(("" + datarow[4]).Where(isNumberOrDot).ToArray()).Replace(",", ".");
                string tot = new string(("" + datarow[5]).Where(isNumberOrDot).ToArray()).Replace(",", ".");

                totalConapan += float.Parse(conapan==""?"0":conapan);
                totalFodesaf += float.Parse(fodesaf == "" ? "0" : fodesaf);
                totalJps += float.Parse(jps == "" ? "0" : jps);
                total += float.Parse(tot == "" ? "0" : tot);
            }

            mainDataTable.Rows.Add(
                "U",
                "Totales",
                myNumberFormat(totalConapan),
                myNumberFormat(totalFodesaf),
                myNumberFormat(totalJps),
                myNumberFormat(total));

            //dataGridView.Rows[mainDataTable.Rows.Count - 1].DefaultCellStyle.Font = new System.Drawing.Font("Tahoma", 9.75F, FontStyle.Bold);

            RowsColor(dataGridView);

            //dataGridView.Rows[2].DefaultCellStyle.Font = new System.Drawing.Font(dataGridView.Font, FontStyle.Bold);
        }

        private void button_add_Click(object sender, EventArgs e)
        {

            /*if (!InternetConnection.CheckForInternetConnection())
            {
                MessageBox.Show("Verifique su conexión a internet, e inténtelo de nuevo.", "Problema de red", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }*/

            string description = textBox_description.Text;
            string con = textBox_conapan.Text;
            string fod = textBox_fodesaf.Text;
            string jp = textBox_jps.Text;


            if (description == "" || con == "" || fod == "" || jp == "")
            {
                MessageBox.Show("Todos los campos son necesarios para agregar un registro.", "Información imcompleta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            float conapan = float.Parse(con);
            float fodesaf = float.Parse(fod);
            float jps = float.Parse(jp);
            float total = conapan + fodesaf + jps;
            string currentMonth = getMonth(DateTime.Now.Month);
            int currentYear = DateTime.Now.Year;


            if (DbFondosExternos.insert(description, currentMonth, currentYear, conapan, fodesaf, jps, total))
            {
                mainDataTable.Rows.Remove(mainDataTable.Rows[mainDataTable.Rows.Count-1]);

                mainDataTable.Rows.Add(DbFondosExternos.maxId(), description,
                myNumberFormat(conapan),
                myNumberFormat(fodesaf),
                myNumberFormat(jps),
                myNumberFormat(total));

                loadTotals();
                clear_text_box();
            }
            else
            {
                MessageBox.Show("Verifique que la estación tiene conexión a internet e intente de nuevo.", "Error al conectar con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell == null) { return; }// if there isn't a selected cell, do nothing.

            /*if (!InternetConnection.CheckForInternetConnection())
            {
                MessageBox.Show("Verifique su conexión a internet, e inténtelo de nuevo.", "Problema de red", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }//if there isn't internet connection, do nothing*/

            int rowIndex = dataGridView.CurrentCell.RowIndex;

            DataRow datarow = mainDataTable.Rows[rowIndex];

            if("" + datarow[0] == "U"){return;}//if the selected row is the last, do nothing

            int id = int.Parse("" + datarow[0]);

            if (!(MessageBox.Show("Seguro que deseas eliminar este registro permanentemente?", "Por favor, confirme:",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                return;
            }

            if (DbFondosExternos.delete(id))
            {
                dataGridView.Rows.RemoveAt(rowIndex);
                mainDataTable.Rows.Remove(mainDataTable.Rows[mainDataTable.Rows.Count-1]);
                loadTotals();
                clear_text_box();
            }
            else
            {
                MessageBox.Show("Verifique que la estación tiene conexión a internet e intente de nuevo.", "Error al conectar con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            
        }

        private void button_update_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell == null) { return; }

            /*if (!InternetConnection.CheckForInternetConnection())
            {
                MessageBox.Show("Verifique su conexión a internet, e inténtelo de nuevo.", "Problema de red", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }*/

            int rowIndex = dataGridView.CurrentCell.RowIndex;

            DataRow datarow = mainDataTable.Rows[rowIndex];

            if ("" + datarow[0] == "U") { return; }//if the selected row is the last, do nothing

            string description = textBox_description.Text;
            string con = textBox_conapan.Text;
            string fod = textBox_fodesaf.Text;
            string jp = textBox_jps.Text;


            if (description == "" || con == "" || fod == "" || jp == "")
            {
                MessageBox.Show("Todos los campos son necesarios para actualizar un registro.", "Información imcompleta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            float conapan = float.Parse(con.Replace(",", "."));
            float fodesaf = float.Parse(fod.Replace(",", "."));
            float jps = float.Parse(jp.Replace(",", "."));
            float total = conapan + fodesaf + jps;


            int id = int.Parse(""+datarow[0]);

            if(DbFondosExternos.update(id, description, conapan, fodesaf, jps, total))
            {

                datarow[1] = textBox_description.Text;
                datarow[2] = myNumberFormat(conapan);
                datarow[3] = myNumberFormat(fodesaf);
                datarow[4] = myNumberFormat(jps);
                datarow[5] = myNumberFormat(total);
                

                clear_text_box();

                mainDataTable.Rows.Remove(mainDataTable.Rows[mainDataTable.Rows.Count - 1]);
                loadTotals();

            }
            else
            {
                MessageBox.Show("Verifique que la estación tiene conexión a internet e intente de nuevo.", "Error al conectar con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void button_clean_Click(object sender, EventArgs e)
        {
            clear_text_box();
        }

        private void dataGridView_Click(object sender, EventArgs e)
        {
            if (dataGridView.CurrentCell == null) { return; }

            int rowIndex = dataGridView.CurrentCell.RowIndex;

            if (rowIndex == mainDataTable.Rows.Count) { return; }//if the current row selected is the last, do nothing

            DataRow datarow = mainDataTable.Rows[rowIndex];

            if ("" + datarow[0] == "U") { clear_text_box(); return; } //if the row will edit is the totals row, do nothing

            string cigarrillos = new string(("" + datarow[2]).Where(isNumberOrDot).ToArray());
            string conapan = new string(("" + datarow[3]).Where(isNumberOrDot).ToArray());
            string jps = new string(("" + datarow[4]).Where(isNumberOrDot).ToArray());
            
            textBox_description.Text = "" + datarow[1];
            textBox_conapan.Text = cigarrillos;
            textBox_fodesaf.Text = conapan;
            textBox_jps.Text = jps;
        }

        private void button_generatePDF_Click(object sender, EventArgs e)
        {
            exportGridToPDF("Reporte de gastos");
        }

        //----------------------------------------------PANEL 2------------------------------------------------//

        private void button_add_fp_Click(object sender, EventArgs e)
        {
            /*if (!InternetConnection.CheckForInternetConnection())
            {
                MessageBox.Show("Verifique su conexión a internet, e inténtelo de nuevo.", "Problema de red", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }*/

            string description = textBox_descripcionFP.Text;
            string con = textBox_montoFP.Text;
            string currentMonth = getMonth(DateTime.Now.Month);
            int currentYear = DateTime.Now.Year;


            if (description == "" || con == "")
            {
                MessageBox.Show("Todos los campos son necesarios para agregar un registro.", "Información imcompleta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            float conapan = float.Parse(con);

            if (DbFondosPropios.insert(description, currentMonth, currentYear, conapan))
            {
                fpDataTable.Rows.Remove(fpDataTable.Rows[fpDataTable.Rows.Count - 1]);
                fpDataTable.Rows.Add(DbFondosPropios.maxId(), description,
                myNumberFormat(conapan));

                loadTotalsFP();

                clear_text_box();
            }
            else
            {
                MessageBox.Show("Verifique que la estación tiene conexión a internet e intente de nuevo.", "Error al conectar con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void loadHeadersDataTableFP()
        {
            fpDataTable.Columns.Add("ID");
            fpDataTable.Columns.Add("Descripción");
            fpDataTable.Columns.Add("Gasto");

            dataGridView_fp.DataSource = fpDataTable;

            loadDataInDataTableFP(getMonth(DateTime.Now.Month), DateTime.Now.Year);

            loadTotalsFP();

            //sets the width in the firts ans second column
            DataGridViewColumn idColumn = dataGridView_fp.Columns[0];
            idColumn.Width = 40;
            DataGridViewColumn descColumn = dataGridView_fp.Columns[1];
            descColumn.Width = 350;
            dataGridView_fp.ColumnHeadersDefaultCellStyle.BackColor = Color.CadetBlue;
            dataGridView_fp.EnableHeadersVisualStyles = false;


            //disable the sorting function when the user press any header
            foreach (DataGridViewColumn column in dataGridView_fp.Columns)
            {
                column.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void loadDataInDataTableFP(string month, int year)
        {

            List<FPayment> listPayments = DbFondosPropios.read(month, year);

            foreach (FPayment payment in listPayments)
            {
                string amount = myNumberFormat(payment.Amount_payment);
                fpDataTable.Rows.Add(payment.Id, payment.Description, amount);
            }

        }

        private void loadTotalsFP()
        {
            float total = 0;


            for (int i = 0; i < fpDataTable.Rows.Count; i++)
            {

                DataRow datarow = fpDataTable.Rows[i];

                string amount = new string(("" + datarow[2]).Where(isNumberOrDot).ToArray()).Replace(",", ".");

                total += float.Parse(amount == "" ? "0" : amount);
            }

            fpDataTable.Rows.Add(
                "U",
                "Total",
                myNumberFormat(total));


            RowsColor(dataGridView_fp);
        }

        private void button_delete_fp_Click(object sender, EventArgs e)
        {
            if (dataGridView_fp.CurrentCell == null) { return; }// if there isn't a selected cell, do nothing.

            /*if (!InternetConnection.CheckForInternetConnection())
            {
                MessageBox.Show("Verifique su conexión a internet, e inténtelo de nuevo.", "Problema de red", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }//if there isn't internet connection, do nothing*/

            int rowIndex = dataGridView_fp.CurrentCell.RowIndex;

            DataRow datarow = fpDataTable.Rows[rowIndex];

            if ("" + datarow[0] == "U") { return; }//if the selected row is the last, do nothing

            int id = int.Parse("" + datarow[0]);

            if (!(MessageBox.Show("Seguro que deseas eliminar este registro permanentemente?", "Por favor, confirme:",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == System.Windows.Forms.DialogResult.Yes))
            {
                return;
            }

            if (DbFondosPropios.delete(id))
            {
                dataGridView_fp.Rows.RemoveAt(rowIndex);
                fpDataTable.Rows.Remove(fpDataTable.Rows[fpDataTable.Rows.Count - 1]);
                loadTotalsFP();
                clear_text_box();
            }
            else
            {
                MessageBox.Show("Verifique que la estación tiene conexión a internet e intente de nuevo.", "Error al conectar con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void button_update_fp_Click(object sender, EventArgs e)
        {
            if (dataGridView_fp.CurrentCell == null) { return; }

            /*if (!InternetConnection.CheckForInternetConnection())
            {
                MessageBox.Show("Verifique su conexión a internet, e inténtelo de nuevo.", "Problema de red", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }*/

            int rowIndex = dataGridView_fp.CurrentCell.RowIndex;

            DataRow datarow = fpDataTable.Rows[rowIndex];

            if ("" + datarow[0] == "U") { return; }//if the selected row is the last, do nothing

            string description = textBox_descripcionFP.Text;
            string con = textBox_montoFP.Text;


            if (description == "" || con == "")
            {
                MessageBox.Show("Todos los campos son necesarios para actualizar un registro.", "Información imcompleta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            float conapan = float.Parse(con.Replace(",", "."));

            int id = int.Parse("" + datarow[0]);

            if (DbFondosPropios.update(id, description, conapan))
            {

                datarow[1] = textBox_descripcionFP.Text;
                datarow[2] = myNumberFormat(conapan);

                clear_text_box();

                fpDataTable.Rows.Remove(fpDataTable.Rows[fpDataTable.Rows.Count - 1]);
                loadTotalsFP();

            }
            else
            {
                MessageBox.Show("Verifique que la estación tiene conexión a internet e intente de nuevo.", "Error al conectar con la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }


        }

        private void dataGridView_fp_Click(object sender, EventArgs e)
        {
            if (dataGridView_fp.CurrentCell == null) { return; }

            int rowIndex = dataGridView_fp.CurrentCell.RowIndex;

            if (rowIndex == fpDataTable.Rows.Count) { return; }//if the current row selected is the last, do nothing

            DataRow datarow = fpDataTable.Rows[rowIndex];

            if ("" + datarow[0] == "U") { clear_text_box(); return; } //if the row will edit is the totals row, do nothing

            string amount = new string(("" + datarow[2]).Where(isNumberOrDot).ToArray());

            textBox_descripcionFP.Text = "" + datarow[1];
            textBox_montoFP.Text = amount;
        }

        private void button_generate_pdf_fp_Click(object sender, EventArgs e)
        {
            exportGridToPDF("Reporte de gastos");
        }

    }
}
