using System;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selling_Tracker
{
    public partial class EditItem : UserControl
    {
        public OleDbConnection con;
        public int selectedItem { get; set; }
        public string itemName { get; set; }
        public double itemCost { get; set; }
        public double itemSold { get; set; }
        public bool itemStatus { get; set; }
        public int miles { get; set; }
        public DateTime soldDate { get; set; }

        public EditItem()
        {
            con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Itemsdatabase.accdb; Persist Security Info = True");
            InitializeComponent();

        }
        private void ItemName_TextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitReady();

        }
        private void SubmitReady()
        {
            if (Status_CheckBox.Checked == true && SoldAmount_TextBox.Text.Length > 0 && ItemCost_TextBox.Text.Length > 0 && ItemName_TextBox.Text.Length > 0 && Miles_TextBox.Text.Length > 0)
            {
                AddItem_Button.Enabled = true;


            }
            else if (Status_CheckBox.Checked == false && ItemCost_TextBox.Text.Length > 0 && ItemName_TextBox.Text.Length > 0 && Miles_TextBox.Text.Length > 0)
            {
                AddItem_Button.Enabled = true;

            }
            else
            {
                AddItem_Button.Enabled = false;
            }
        }

        private void Cancel_Button_Click(object sender, System.EventArgs e)
        {
            App app = this.ParentForm as App;
            this.Visible = false;
            this.SendToBack();
            app.fillList();
            app.EnableItemList();

        }
        private void ItemCost_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBoxBase).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void ItemCost_TextBox_TextChanged(object sender, System.EventArgs e)
        {
            if (ItemCost_TextBox.Text.Length > 0 && SoldAmount_TextBox.Text.Length > 0)
            {
                try
                {
                    Profit_Texbox.Text = string.Format("{0:C}", (Convert.ToDouble(SoldAmount_TextBox.Text) - Convert.ToDouble(ItemCost_TextBox.Text)));
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            SubmitReady();
        }

        private void EditItem_VisibleChanged(object sender, System.EventArgs e)
        {
            if (this.Visible)
            {
                ItemName_TextBox.Text = itemName;
                ItemCost_TextBox.Text = itemCost.ToString();
                Miles_TextBox.Text = miles.ToString();
                if (itemStatus)
                {

                    Status_CheckBox.Checked = true;
                    Sold_GroupBox.Visible = true;
                    SoldAmount_TextBox.Text = itemSold.ToString();
                    Profit_Texbox.Text = ((itemSold - itemCost).ToString());
                    Sold_Date_TimePicker.Value = soldDate;
                }

            }
            else
            {
                Sold_GroupBox.Visible = false;
                ItemName_TextBox.Clear();
                ItemCost_TextBox.Clear();
                Miles_TextBox.Clear();
                Profit_Texbox.Clear();
                SoldAmount_TextBox.Clear();
                Status_CheckBox.Checked = false;
            }
        }

        private void Status_CheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            if (Status_CheckBox.Checked == true)
            {
                Sold_GroupBox.Visible = true;
            }
            else
            {
                Sold_GroupBox.Visible = false;


            }
        }


        private async Task<bool> WriteToDB(string sql)
        {
            App app = this.ParentForm as App;

            try
            {
                OleDbCommand cmd = new OleDbCommand(sql, con);
                con.Open();
                cmd.ExecuteReader();

                //MessageBox.Show("Item Added");
                con.Close();
                return true;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;

            }
        }

        private async void AddItem_Button_Click(object sender, EventArgs e)
        {
            //test
            App app = this.ParentForm as App;
            DateTime dateTime = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            string sql = "";
            bool status = true;

            bool res;
            if (Status_CheckBox.Checked == false)
            {
                sql = "UPDATE tbl_items SET itemName = '" + ItemName_TextBox.Text.ToString() + "', costPrice = " + Convert.ToDouble(ItemCost_TextBox.Text) + ", miles = " + Convert.ToInt32(Miles_TextBox.Text) + ", sold = FALSE WHERE itemID = " + selectedItem + ";";
                Task<bool> task = WriteToDB(sql);
                res = await task;
                if (res)
                {
                    app.fillList();
                }
            }
            else
            {
                sql = "UPDATE tbl_items SET itemName = '" + ItemName_TextBox.Text.ToString() + "', costPrice = " + Convert.ToDouble(ItemCost_TextBox.Text) + ", miles = " + Convert.ToInt32(Miles_TextBox.Text) + ", soldPrice = " + Convert.ToDouble(SoldAmount_TextBox.Text) + ", dateSold = '" + Convert.ToDateTime(Sold_Date_TimePicker.Value) + "', sold = TRUE WHERE itemID = " + selectedItem + "; ";
                Task<bool> task = WriteToDB(sql);
                res = await task;
                if (res)
                {
                    app.fillList();
                }
            }

        }
    }
}
