namespace Selling_Tracker
{
    partial class EditItem
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
            this.Sold_GroupBox = new System.Windows.Forms.GroupBox();
            this.Profit_Texbox = new System.Windows.Forms.TextBox();
            this.SoldAmount_TextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Cancel_Button = new System.Windows.Forms.Button();
            this.AddItem_Button = new System.Windows.Forms.Button();
            this.Status_CheckBox = new System.Windows.Forms.CheckBox();
            this.Miles_TextBox = new System.Windows.Forms.TextBox();
            this.ItemCost_TextBox = new System.Windows.Forms.TextBox();
            this.ItemName_TextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Sold_Date_TimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.Sold_GroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sold_GroupBox
            // 
            this.Sold_GroupBox.Controls.Add(this.label7);
            this.Sold_GroupBox.Controls.Add(this.Sold_Date_TimePicker);
            this.Sold_GroupBox.Controls.Add(this.Profit_Texbox);
            this.Sold_GroupBox.Controls.Add(this.SoldAmount_TextBox);
            this.Sold_GroupBox.Controls.Add(this.label6);
            this.Sold_GroupBox.Controls.Add(this.label4);
            this.Sold_GroupBox.Location = new System.Drawing.Point(248, 51);
            this.Sold_GroupBox.Name = "Sold_GroupBox";
            this.Sold_GroupBox.Size = new System.Drawing.Size(244, 281);
            this.Sold_GroupBox.TabIndex = 27;
            this.Sold_GroupBox.TabStop = false;
            this.Sold_GroupBox.Visible = false;
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(54, 209);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 25);
            this.label5.TabIndex = 26;
            this.label5.Text = "Miles";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(54, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 25);
            this.label3.TabIndex = 25;
            this.label3.Text = "Item Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 25);
            this.label2.TabIndex = 24;
            this.label2.Text = "Item Name";
            // 
            // Cancel_Button
            // 
            this.Cancel_Button.BackColor = System.Drawing.Color.SteelBlue;
            this.Cancel_Button.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cancel_Button.ForeColor = System.Drawing.Color.White;
            this.Cancel_Button.Location = new System.Drawing.Point(387, 349);
            this.Cancel_Button.Name = "Cancel_Button";
            this.Cancel_Button.Size = new System.Drawing.Size(118, 37);
            this.Cancel_Button.TabIndex = 23;
            this.Cancel_Button.Text = "Cancel";
            this.Cancel_Button.UseVisualStyleBackColor = false;
            this.Cancel_Button.Click += new System.EventHandler(this.Cancel_Button_Click);
            // 
            // AddItem_Button
            // 
            this.AddItem_Button.BackColor = System.Drawing.Color.SteelBlue;
            this.AddItem_Button.Enabled = false;
            this.AddItem_Button.Font = new System.Drawing.Font("Nirmala UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddItem_Button.ForeColor = System.Drawing.Color.White;
            this.AddItem_Button.Location = new System.Drawing.Point(231, 349);
            this.AddItem_Button.Name = "AddItem_Button";
            this.AddItem_Button.Size = new System.Drawing.Size(118, 37);
            this.AddItem_Button.TabIndex = 22;
            this.AddItem_Button.Text = "Update Item";
            this.AddItem_Button.UseVisualStyleBackColor = false;
            this.AddItem_Button.Click += new System.EventHandler(this.AddItem_Button_Click);
            // 
            // Status_CheckBox
            // 
            this.Status_CheckBox.AutoSize = true;
            this.Status_CheckBox.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Status_CheckBox.Location = new System.Drawing.Point(59, 285);
            this.Status_CheckBox.Name = "Status_CheckBox";
            this.Status_CheckBox.Size = new System.Drawing.Size(79, 29);
            this.Status_CheckBox.TabIndex = 21;
            this.Status_CheckBox.Text = "Sold?";
            this.Status_CheckBox.UseVisualStyleBackColor = true;
            this.Status_CheckBox.CheckedChanged += new System.EventHandler(this.Status_CheckBox_CheckedChanged);
            // 
            // Miles_TextBox
            // 
            this.Miles_TextBox.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Miles_TextBox.Location = new System.Drawing.Point(59, 236);
            this.Miles_TextBox.Name = "Miles_TextBox";
            this.Miles_TextBox.Size = new System.Drawing.Size(104, 33);
            this.Miles_TextBox.TabIndex = 20;
            this.Miles_TextBox.TextChanged += new System.EventHandler(this.ItemCost_TextBox_TextChanged);
            this.Miles_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemCost_TextBox_KeyPress);
            // 
            // ItemCost_TextBox
            // 
            this.ItemCost_TextBox.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemCost_TextBox.Location = new System.Drawing.Point(59, 173);
            this.ItemCost_TextBox.Name = "ItemCost_TextBox";
            this.ItemCost_TextBox.Size = new System.Drawing.Size(104, 33);
            this.ItemCost_TextBox.TabIndex = 19;
            this.ItemCost_TextBox.TextChanged += new System.EventHandler(this.ItemCost_TextBox_TextChanged);
            this.ItemCost_TextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.ItemCost_TextBox_KeyPress);
            // 
            // ItemName_TextBox
            // 
            this.ItemName_TextBox.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ItemName_TextBox.Location = new System.Drawing.Point(59, 107);
            this.ItemName_TextBox.Name = "ItemName_TextBox";
            this.ItemName_TextBox.Size = new System.Drawing.Size(183, 33);
            this.ItemName_TextBox.TabIndex = 18;
            this.ItemName_TextBox.TextChanged += new System.EventHandler(this.ItemName_TextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 37);
            this.label1.TabIndex = 17;
            this.label1.Text = "Edit Item";
            // 
            // Sold_Date_TimePicker
            // 
            this.Sold_Date_TimePicker.Location = new System.Drawing.Point(15, 185);
            this.Sold_Date_TimePicker.MinDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            this.Sold_Date_TimePicker.Name = "Sold_Date_TimePicker";
            this.Sold_Date_TimePicker.Size = new System.Drawing.Size(200, 20);
            this.Sold_Date_TimePicker.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 25);
            this.label7.TabIndex = 17;
            this.label7.Text = "Sold Date";
            // 
            // EditItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Sold_GroupBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Cancel_Button);
            this.Controls.Add(this.AddItem_Button);
            this.Controls.Add(this.Status_CheckBox);
            this.Controls.Add(this.Miles_TextBox);
            this.Controls.Add(this.ItemCost_TextBox);
            this.Controls.Add(this.ItemName_TextBox);
            this.Controls.Add(this.label1);
            this.Name = "EditItem";
            this.Size = new System.Drawing.Size(656, 430);
            this.VisibleChanged += new System.EventHandler(this.EditItem_VisibleChanged);
            this.Sold_GroupBox.ResumeLayout(false);
            this.Sold_GroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Sold_GroupBox;
        private System.Windows.Forms.TextBox Profit_Texbox;
        private System.Windows.Forms.TextBox SoldAmount_TextBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Cancel_Button;
        private System.Windows.Forms.Button AddItem_Button;
        private System.Windows.Forms.CheckBox Status_CheckBox;
        private System.Windows.Forms.TextBox Miles_TextBox;
        private System.Windows.Forms.TextBox ItemCost_TextBox;
        private System.Windows.Forms.TextBox ItemName_TextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker Sold_Date_TimePicker;
    }
}
