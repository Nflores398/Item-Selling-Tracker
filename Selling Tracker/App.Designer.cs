namespace Selling_Tracker
{
    partial class App
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
            this.cost_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Profit_Total_Label = new System.Windows.Forms.Label();
            this.Sold_Total_Label = new System.Windows.Forms.Label();
            this.CostTotal_Label = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Item_ListView = new System.Windows.Forms.ListView();
            this.userControl11 = new Selling_Tracker.UserControl1();
            this.editItem1 = new Selling_Tracker.EditItem();
            this.label1 = new System.Windows.Forms.Label();
            this.Total_Miles_Label = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cost_label
            // 
            this.cost_label.AutoSize = true;
            this.cost_label.Font = new System.Drawing.Font("Nirmala UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cost_label.Location = new System.Drawing.Point(80, 41);
            this.cost_label.Name = "cost_label";
            this.cost_label.Size = new System.Drawing.Size(77, 40);
            this.cost_label.TabIndex = 0;
            this.cost_label.Text = "Cost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(331, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 40);
            this.label2.TabIndex = 2;
            this.label2.Text = "Sold";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Nirmala UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(562, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 40);
            this.label4.TabIndex = 4;
            this.label4.Text = "Profit";
            // 
            // Profit_Total_Label
            // 
            this.Profit_Total_Label.AutoSize = true;
            this.Profit_Total_Label.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Profit_Total_Label.Location = new System.Drawing.Point(562, 81);
            this.Profit_Total_Label.Name = "Profit_Total_Label";
            this.Profit_Total_Label.Size = new System.Drawing.Size(88, 37);
            this.Profit_Total_Label.TabIndex = 5;
            this.Profit_Total_Label.Text = "$0.00";
            // 
            // Sold_Total_Label
            // 
            this.Sold_Total_Label.AutoSize = true;
            this.Sold_Total_Label.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sold_Total_Label.ForeColor = System.Drawing.Color.ForestGreen;
            this.Sold_Total_Label.Location = new System.Drawing.Point(331, 81);
            this.Sold_Total_Label.Name = "Sold_Total_Label";
            this.Sold_Total_Label.Size = new System.Drawing.Size(88, 37);
            this.Sold_Total_Label.TabIndex = 6;
            this.Sold_Total_Label.Text = "$0.00";
            // 
            // CostTotal_Label
            // 
            this.CostTotal_Label.AutoSize = true;
            this.CostTotal_Label.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CostTotal_Label.ForeColor = System.Drawing.Color.Red;
            this.CostTotal_Label.Location = new System.Drawing.Point(80, 81);
            this.CostTotal_Label.Name = "CostTotal_Label";
            this.CostTotal_Label.Size = new System.Drawing.Size(88, 37);
            this.CostTotal_Label.TabIndex = 7;
            this.CostTotal_Label.Text = "$0.00";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1354, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // Item_ListView
            // 
            this.Item_ListView.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Item_ListView.HideSelection = false;
            this.Item_ListView.Location = new System.Drawing.Point(37, 145);
            this.Item_ListView.Name = "Item_ListView";
            this.Item_ListView.Size = new System.Drawing.Size(783, 593);
            this.Item_ListView.TabIndex = 19;
            this.Item_ListView.UseCompatibleStateImageBehavior = false;
            this.Item_ListView.DoubleClick += new System.EventHandler(this.Item_ListBox_DoubleClick);
            // 
            // userControl11
            // 
            this.userControl11.Location = new System.Drawing.Point(839, 202);
            this.userControl11.Name = "userControl11";
            this.userControl11.Size = new System.Drawing.Size(506, 446);
            this.userControl11.TabIndex = 16;
            // 
            // editItem1
            // 
            this.editItem1.itemCost = 0D;
            this.editItem1.itemName = null;
            this.editItem1.itemSold = 0D;
            this.editItem1.itemStatus = false;
            this.editItem1.Location = new System.Drawing.Point(839, 228);
            this.editItem1.miles = 0;
            this.editItem1.Name = "editItem1";
            this.editItem1.selectedItem = 0;
            this.editItem1.Size = new System.Drawing.Size(531, 440);
            this.editItem1.TabIndex = 18;
            this.editItem1.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(756, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 40);
            this.label1.TabIndex = 20;
            this.label1.Text = "Miles";
            // 
            // Total_Miles_Label
            // 
            this.Total_Miles_Label.AutoSize = true;
            this.Total_Miles_Label.Font = new System.Drawing.Font("Nirmala UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Total_Miles_Label.Location = new System.Drawing.Point(756, 81);
            this.Total_Miles_Label.Name = "Total_Miles_Label";
            this.Total_Miles_Label.Size = new System.Drawing.Size(88, 37);
            this.Total_Miles_Label.TabIndex = 21;
            this.Total_Miles_Label.Text = "$0.00";
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1354, 761);
            this.Controls.Add(this.Total_Miles_Label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Item_ListView);
            this.Controls.Add(this.userControl11);
            this.Controls.Add(this.CostTotal_Label);
            this.Controls.Add(this.Sold_Total_Label);
            this.Controls.Add(this.Profit_Total_Label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cost_label);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.editItem1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "App";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label cost_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label Profit_Total_Label;
        private System.Windows.Forms.Label Sold_Total_Label;
        private System.Windows.Forms.Label CostTotal_Label;
        private UserControl1 userControl11;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exportToolStripMenuItem;
        private EditItem editItem1;
        private System.Windows.Forms.ListView Item_ListView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Total_Miles_Label;
    }
}

