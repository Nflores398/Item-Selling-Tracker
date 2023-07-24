using System;
using System.Data.OleDb;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Selling_Tracker
{
    public partial class UserControl1 : UserControl
    {
        public OleDbConnection con;
        public UserControl1()
        {
            InitializeComponent();
            con = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Itemsdatabase.accdb; Persist Security Info = True");
            //App app = this.ParentForm as App;
            //app.fillList();
        }

        private void Status_CheckBox_CheckedChanged(object sender, System.EventArgs e)
        {
            SubmitReady();
            if (Status_CheckBox.Checked == true)
            {
                Sold_GroupBox.Visible = true;
            }
            else { Sold_GroupBox.Visible = false; }
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

        private void ItemName_TextBox_KeyPress(object sender, KeyPressEventArgs e)
        {

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
                Profit_Texbox.Text = string.Format("{0:C}", (Convert.ToDouble(SoldAmount_TextBox.Text) - Convert.ToDouble(ItemCost_TextBox.Text)));
            }
            SubmitReady();
        }

        private async void AddItem_Button_Click(object sender, EventArgs e)
        {
            App app = this.ParentForm as App;
            DateTime dateTime = DateTime.Now;
            string format = "yyyy-MM-dd HH:mm:ss";
            string sql = "";
            bool status = true;
            //MessageBox.Show(Sold_Date_TimePicker.Value.ToShortDateString());

            bool res;
            if (Status_CheckBox.Checked == false)
            {
                sql = "INSERT INTO tbl_items (itemName, miles, costPrice) VALUES ('" + ItemName_TextBox.Text.ToString() + "', " + Convert.ToInt32(Miles_TextBox.Text) + ", " + Convert.ToDouble(ItemCost_TextBox.Text) + ");";
                Task<bool> task = WriteToDB(sql);
                res = await task;
                if (res)
                {
                    app.fillList();
                }
            }
            else
            {
                sql = "INSERT INTO tbl_items (itemName, miles, costPrice, soldPrice, sold, dateSold) VALUES ('" + ItemName_TextBox.Text.ToString() + "', " + Convert.ToInt32(Miles_TextBox.Text) + ", " + Convert.ToDouble(ItemCost_TextBox.Text) + ", " + Convert.ToDouble(SoldAmount_TextBox.Text) + ", " + status + ", '" + Convert.ToDateTime(Sold_Date_TimePicker.Value) + "');";
                Task<bool> task = WriteToDB(sql);
                res = await task;
                if (res)
                {
                    app.fillList();
                }
            }
            ItemName_TextBox.Clear();
            Status_CheckBox.Checked = false;
            Miles_TextBox.Clear();
            ItemCost_TextBox.Clear();
            SoldAmount_TextBox.Clear();
        }

        private void ItemName_TextBox_TextChanged(object sender, EventArgs e)
        {
            SubmitReady();

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
    }
}
