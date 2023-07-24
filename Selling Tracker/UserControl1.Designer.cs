namespace Selling_Tracker
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.ItemName_TextBox = new System.Windows.Forms.TextBox();
            this.ItemCost_TextBox = new System.Windows.Forms.TextBox();
            this.Miles_TextBox = new System.Windows.Forms.TextBox();
            this.Profit_Texbox = new System.Windows.Forms.TextBox();
            this.SoldAmount_TextBox = new System.Windows.Forms.TextBox();
            this.Status_CheckBox = new System.Windows.Forms.CheckBox();
            this.AddItem_Button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Sold_GroupBox = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.Sold_Date_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.Sold_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Item";
            // 
            // ItemName_TextBox
            // 
            this.ItemName_TextBox.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName_TextBox.Location = new System.Drawing.Point(54, 127);
            this.ItemName_TextBox.Name = "ItemName_TextBox";
            this.ItemName_TextBox.Size = new System.Drawing.Size(183, 33);
            this.ItemName_TextBox.TabIndex = 1;
            this.ItemName_TextBox.TextChanged += new System.EventHandler(this.ItemName_TextBox_TextChanged);
            this.ItemName_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemName_TextBox_KeyPress);
            // 
            // ItemCost_TextBox
            // 
            this.ItemCost_TextBox.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCost_TextBox.Location = new System.Drawing.Point(54, 193);
            this.ItemCost_TextBox.Name = "ItemCost_TextBox";
            this.ItemCost_TextBox.Size = new System.Drawing.Size(104, 33);
            this.ItemCost_TextBox.TabIndex = 2;
            this.ItemCost_TextBox.TextChanged += new System.EventHandler(this.ItemCost_TextBox_TextChanged);
            this.ItemCost_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemCost_TextBox_KeyPress);
            // 
            // Miles_TextBox
            // 
            this.Miles_TextBox.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Miles_TextBox.Location = new System.Drawing.Point(54, 256);
            this.Miles_TextBox.Name = "Miles_TextBox";
            this.Miles_TextBox.Size = new System.Drawing.Size(104, 33);
            this.Miles_TextBox.TabIndex = 3;
            this.Miles_TextBox.TextChanged += new System.EventHandler(this.ItemCost_TextBox_TextChanged);
            this.Miles_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemCost_TextBox_KeyPress);
            // 
            // Profit_Texbox
            // 
            this.Profit_Texbox.Enabled = false;
            this.Profit_Texbox.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profit_Texbox.Location = new System.Drawing.Point(15, 117);
            this.Profit_Texbox.Name = "Profit_Texbox";
            this.Profit_Texbox.Size = new System.Drawing.Size(104, 33);
            this.Profit_Texbox.TabIndex = 4;
            // 
            // SoldAmount_TextBox
            // 
            this.SoldAmount_TextBox.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SoldAmount_TextBox.Location = new System.Drawing.Point(15, 53);
            this.SoldAmount_TextBox.Name = "SoldAmount_TextBox";
            this.SoldAmount_TextBox.Size = new System.Drawing.Size(104, 33);
            this.SoldAmount_TextBox.TabIndex = 5;
            this.SoldAmount_TextBox.TextChanged += new System.EventHandler(this.ItemCost_TextBox_TextChanged);
            this.SoldAmount_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemCost_TextBox_KeyPress);
            // 
            // Status_CheckBox
            // 
            this.Status_CheckBox.AutoSize = true;
            this.Status_CheckBox.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_CheckBox.Location = new System.Drawing.Point(54, 305);
            this.Status_CheckBox.Name = "Status_CheckBox";
            this.Status_CheckBox.Size = new System.Drawing.Size(79, 29);
            this.Status_CheckBox.TabIndex = 6;
            this.Status_CheckBox.Text = "Sold?";
            this.Status_CheckBox.UseVisualStyleBackColor = true;
            this.Status_CheckBox.CheckedChanged += new System.EventHandler(this.Status_CheckBox_CheckedChanged);
            // 
            // AddItem_Button
            // 
            this.AddItem_Button.BackColor = System.Drawing.Color.SteelBlue;
            this.AddItem_Button.Enabled = false;
            this.AddItem_Button.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItem_Button.ForeColor = System.Drawing.Color.White;
            this.AddItem_Button.Location = new System.Drawing.Point(382, 370);
            this.AddItem_Button.Name = "AddItem_Button";
            this.AddItem_Button.Size = new System.Drawing.Size(118, 37);
            this.AddItem_Button.TabIndex = 7;
            this.AddItem_Button.Text = "Add Item";
            this.AddItem_Button.UseVisualStyleBackColor = false;
            this.AddItem_Button.Click += new System.EventHandler(this.AddItem_Button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Item Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Item Cost";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Sold Amount";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 14;
            this.label5.Text = "Miles";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 25);
            this.label6.TabIndex = 15;
            this.label6.Text = "Profit";
            // 
            // Sold_GroupBox
            // 
            this.Sold_GroupBox.Controls.Add(this.label7);
            this.Sold_GroupBox.Controls.Add(this.Sold_Date_TimePicker);
            this.Sold_GroupBox.Controls.Add(this.Profit_Texbox);
            this.Sold_GroupBox.Controls.Add(this.SoldAmount_TextBox);
            this.Sold_GroupBox.Controls.Add(this.label6);
            this.Sold_GroupBox.Controls.Add(this.label4);
            this.Sold_GroupBox.Location = new System.Drawing.Point(243, 71);
            this.Sold_GroupBox.Name = "Sold_GroupBox";
            this.Sold_GroupBox.Size = new System.Drawing.Size(257, 242);
            this.Sold_GroupBox.TabIndex = 16;
            this.Sold_GroupBox.TabStop = false;
            this.Sold_GroupBox.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 19;
            this.label7.Text = "Sold Date";
            // 
            // Sold_Date_TimePicker
            // 
            this.Sold_Date_TimePicker.Location = new System.Drawing.Point(15, 192);
            this.Sold_Date_TimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.Sold_Date_TimePicker.Name = "Sold_Date_TimePicker";
            this.Sold_Date_TimePicker.Size = new System.Drawing.Size(200, 20);
            this.Sold_Date_TimePicker.TabIndex = 18;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Sold_GroupBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.AddItem_Button);
            this.Controls.Add(this.Status_CheckBox);
            this.Controls.Add(this.Miles_TextBox);
            this.Controls.Add(this.ItemCost_TextBox);
            this.Controls.Add(this.ItemName_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(591, 442);
            this.Sold_GroupBox.ResumeLayout(false);
            this.Sold_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ItemName_TextBox;
        private System.Windows.Forms.TextBox ItemCost_TextBox;
        private System.Windows.Forms.TextBox Miles_TextBox;
        private System.Windows.Forms.TextBox Profit_Texbox;
        private System.Windows.Forms.TextBox SoldAmount_TextBox;
        private System.Windows.Forms.CheckBox Status_CheckBox;
        private System.Windows.Forms.Button AddItem_Button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox Sold_GroupBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Sold_Date_TimePicker;
    }
}
