using Microsoft.Office.Interop.Excel;
using System;
using System.Data.OleDb;
using System.Globalization;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace Selling_Tracker
{
    public partial class App : Form
    {


        public OleDbConnection con;
        public double costTotal;
        public double soldTotal;
        public double profit;
        public int items;
        public int milesTotal;

        public App()
        {

            //ExcelDocument workbook = new ExcelDocument(2);
            /* workbook.easy_getSheetAt(0).setSheetName("Hello World");
             workbook.easy_getSheetAt(1).setSheetName("Second tab");
             workbook.easy_WriteXLSXFile(@"..\..\Excel\sales.xlsx");
             String sError = workbook.easy_getError();
             if (sError.Equals(""))
                 Console.Write("\nFile successfully created. Press Enter to Exit...");
             else
                 Console.Write("\nError encountered: " + sError + "\nPress Enter to Exit...");

             // Dispose memory
             workbook.Dispose(); */
            con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Itemsdatabase.accdb; Persist Security Info = True");

            InitializeComponent();
            Item_ListView.View = View.Details;
            Item_ListView.Columns.Add("ID");
            Item_ListView.Columns.Add("Name");
            Item_ListView.Columns.Add("Miles");
            Item_ListView.Columns.Add("Cost Price");
            Item_ListView.Columns.Add("Status");
            Item_ListView.Columns.Add("Sold Price");
            Item_ListView.Columns.Add("Profit");
            Item_ListView.Columns.Add("Sold Date");

            Item_ListView.FullRowSelect = true;

            fillList();
        }
        public void fillList()
        {
            Item_ListView.Items.Clear();
            Item_ListView.Enabled = true;
            editItem1.Visible = false;
            costTotal = 0;
            soldTotal = 0;
            profit = 0;
            items = 0;
            string sql = "SELECT costPrice, soldPrice, itemID, itemName, dateAdded, dateSold, sold, miles FROM tbl_items;";
            string status = "NO";

            try
            {
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    costTotal += reader.GetDouble(0);
                    soldTotal += reader.GetDouble(1);
                    milesTotal += reader.GetInt32(7);
                    if (reader.GetBoolean(6) == true)
                    {
                        status = "Yes";
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = reader.GetInt32(2).ToString();
                        lvi.SubItems.Add(reader.GetString(3));
                        lvi.SubItems.Add(reader.GetInt32(7).ToString());
                        lvi.SubItems.Add(String.Format("{0:C}", reader.GetDouble(0)));
                        lvi.SubItems.Add(status);
                        lvi.SubItems.Add(String.Format("{0:C}", reader.GetDouble(1)));
                        lvi.SubItems.Add(String.Format("{0:C}", (reader.GetDouble(1) - reader.GetDouble(0))));
                        lvi.SubItems.Add(reader.GetDateTime(5).ToShortDateString());
                        Item_ListView.Items.Add(lvi);
                    }
                    else
                    {
                        status = "No";
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = reader.GetInt32(2).ToString();
                        lvi.SubItems.Add(reader.GetString(3));
                        lvi.SubItems.Add(reader.GetInt32(7).ToString());
                        lvi.SubItems.Add(String.Format("{0:C}", reader.GetDouble(0)));
                        lvi.SubItems.Add(status);
                        Item_ListView.Items.Add(lvi);
                    }
                    items++;


                }
                con.Close();
                profit = soldTotal - costTotal;
                CostTotal_Label.Text = String.Format("{0:C}", costTotal);
                Sold_Total_Label.Text = String.Format("{0:C}", soldTotal);
                Profit_Total_Label.Text = String.Format("{0:C}", profit);
                Total_Miles_Label.Text = milesTotal.ToString();
                if (profit < 0)
                {
                    Profit_Total_Label.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    Profit_Total_Label.ForeColor = System.Drawing.Color.Green;
                }
                Item_ListView.AutoResizeColumn(0, ColumnHeaderAutoResizeStyle.HeaderSize);
                Item_ListView.AutoResizeColumn(1, ColumnHeaderAutoResizeStyle.ColumnContent);
                Item_ListView.AutoResizeColumn(2, ColumnHeaderAutoResizeStyle.HeaderSize);
                Item_ListView.AutoResizeColumn(3, ColumnHeaderAutoResizeStyle.HeaderSize);
                Item_ListView.AutoResizeColumn(4, ColumnHeaderAutoResizeStyle.HeaderSize);
                Item_ListView.AutoResizeColumn(5, ColumnHeaderAutoResizeStyle.HeaderSize);
                Item_ListView.AutoResizeColumn(6, ColumnHeaderAutoResizeStyle.HeaderSize);
                Item_ListView.AutoResizeColumn(7, ColumnHeaderAutoResizeStyle.HeaderSize);
            }
            catch (Exception e)
            {
                System.Console.WriteLine(e.Message);
                MessageBox.Show("Error 101 - Database Can't be reached. Try Again " + e.Message);
                Environment.Exit(-1);
            }

        }
        private string[,] ExcelData()
        {
            string sql = "SELECT itemName, sold, costPrice, soldPrice, miles, dateSold FROM tbl_items;";
            string[,] data = new string[500, 7];
            data[0, 0] = "Item";
            data[0, 1] = "Sold?";
            data[0, 2] = "Price";
            data[0, 3] = "Sold";
            data[0, 4] = "Miles";
            data[0, 5] = "Profit";
            data[0, 6] = "Sold Date";
            int i = 1;
            try
            {
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                OleDbDataReader reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    data[i, 0] = reader.GetString(0);
                    data[i, 1] = reader.GetBoolean(1).ToString();
                    data[i, 2] = reader.GetDouble(2).ToString();
                    data[i, 3] = reader.GetDouble(3).ToString();
                    data[i, 4] = reader.GetInt32(4).ToString();
                    data[i, 5] = (reader.GetDouble(3) - reader.GetDouble(2)).ToString();
                    data[i, 6] = (reader.GetDateTime(5).ToShortDateString());
                    i++;
                }
                con.Close();
                return data;

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                con.Close();
                return null;
            }
        }
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string[,] data = ExcelData();
            int colNum = 0;
            int rowNum = 0;


            if (data != null)
            {
                object oMissing = System.Reflection.Missing.Value;

                Excel.Application excelApp = null;
                Excel.Range range = null;
                Excel.Workbook workbook = null;
                Excel.Worksheet worksheet = null;


                int worksheetCount = 0;
                try
                {
                    excelApp = new Excel.Application();
                    excelApp.DisplayAlerts = true;
                    excelApp.Visible = false;
                    excelApp.UserControl = false;
                    workbook = excelApp.Workbooks.Add();

                    worksheetCount = workbook.Worksheets.Count;

                    worksheet = workbook.Sheets.Add();

                    for (int i = 0; i < data.GetLength(0); i++)
                    {
                        rowNum = i + 1;
                        if (i > items)
                        {
                            break;
                        }
                        for (int j = 0; j < data.GetLength(1); j++)
                        {

                            colNum = j + 1;

                            worksheet.Cells[rowNum, colNum] = data[i, j];
                            if (rowNum == 1)
                            {
                                worksheet.Cells[rowNum, colNum].Interior.Color = Excel.XlRgbColor.rgbAqua;
                                worksheet.Cells[rowNum, colNum].HorizontalAlignment = XlHAlign.xlHAlignCenter;
                                worksheet.Cells[rowNum, colNum].EntireRow.Font.Bold = true;
                            }
                            if (colNum > 2 && rowNum > 1 && colNum != 5 && colNum != 7)
                            {
                                worksheet.Cells[rowNum, colNum].NumberFormat = "[$$-en-US] #,##0.00";
                            }

                        }


                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                colNum = 2;
                rowNum++;
                //MessageBox.Show(rowNum.ToString() + " " + colNum.ToString());
                worksheet.Cells[rowNum, colNum] = "Total Cost";
                worksheet.Cells[rowNum, colNum + 1] = "Total Sold";
                worksheet.Cells[rowNum, colNum + 2] = "Total Profit";
                worksheet.Cells[rowNum, colNum + 3] = "Total Miles";
                worksheet.Cells[rowNum, colNum].Interior.Color = Excel.XlRgbColor.rgbAqua;
                worksheet.Cells[rowNum, colNum].EntireRow.Font.Bold = true;
                worksheet.Cells[rowNum, colNum + 1].Interior.Color = Excel.XlRgbColor.rgbAqua;
                worksheet.Cells[rowNum, colNum + 2].Interior.Color = Excel.XlRgbColor.rgbAqua;
                worksheet.Cells[rowNum, colNum + 3].Interior.Color = Excel.XlRgbColor.rgbAqua;
                rowNum++;
                worksheet.Cells[rowNum, colNum] = "=SUM(C1:C" + (rowNum - 2) + ")";
                worksheet.Cells[rowNum, colNum + 1] = "=SUM(D1:D" + (rowNum - 2) + ")";
                worksheet.Cells[rowNum, colNum + 2] = "=(SUM(D1:D" + (rowNum - 2) + ") - SUM(C1:C" + (rowNum - 2) + "))";
                worksheet.Cells[rowNum, colNum + 3] = "=SUM(E1:E" + (rowNum - 2) + ")";
                worksheet.Cells[rowNum, colNum].NumberFormat = "[$$-en-US] #,##0.00";
                worksheet.Cells[rowNum, colNum + 1].NumberFormat = "[$$-en-US] #,##0.00";
                worksheet.Cells[rowNum, colNum + 2].NumberFormat = "[$$-en-US] #,##0.00";

                worksheet.Columns[1].AutoFit();
                worksheet.Columns[2].AutoFit();
                worksheet.Columns[3].AutoFit();
                worksheet.Columns[4].AutoFit();
                worksheet.Columns[5].AutoFit();
                worksheet.Columns[6].AutoFit();
                worksheet.Columns[7].AutoFit();
                excelApp.Visible = true;
            }
            else
            {
                MessageBox.Show("An Error Has Occurred");
            }
        }
        public void EnableItemList()
        {
            Item_ListView.Enabled = true;
        }


        private void Item_ListBox_DoubleClick(object sender, EventArgs e)
        {
            if (Item_ListView.Enabled)
            {


                //MessageBox.Show(Item_ListView.FocusedItem.Text);

                editItem1.selectedItem = Int32.Parse(Item_ListView.FocusedItem.Text);
                //MessageBox.Show(Item_ListView.FocusedItem.SubItems[1].Text);
                editItem1.itemName = Item_ListView.FocusedItem.SubItems[1].Text;
                editItem1.miles = Int32.Parse(Item_ListView.FocusedItem.SubItems[2].Text);
                //MessageBox.Show(Item_ListView.FocusedItem.SubItems[6].Text);
                //MessageBox.Show(Item_ListView.FocusedItem.SubItems[3].Text);
                editItem1.itemCost = Double.Parse(Item_ListView.FocusedItem.SubItems[3].Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency);
                if (Item_ListView.FocusedItem.SubItems[4].Text == "Yes")
                {
                    editItem1.itemStatus = true;
                    editItem1.itemSold = Double.Parse(Item_ListView.FocusedItem.SubItems[5].Text, NumberStyles.AllowCurrencySymbol | NumberStyles.Currency);
                    editItem1.soldDate = Convert.ToDateTime(Item_ListView.FocusedItem.SubItems[7].Text);
                }
                else
                {
                    editItem1.itemStatus = false;
                    editItem1.itemStatus = false;
                }


                //editItem1.itemStatus = do
                Item_ListView.Enabled = false;
                editItem1.BringToFront();
                editItem1.Visible = true;
            }
        }
    }
}
