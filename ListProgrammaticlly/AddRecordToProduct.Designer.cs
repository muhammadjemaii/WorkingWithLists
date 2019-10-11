namespace WorkingWithLists.ListProgrammaticlly
{
    partial class AddRecordToProduct
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.btn_filter_price = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_price_filter = new System.Windows.Forms.TextBox();
            this.btn_showProducts = new System.Windows.Forms.Button();
            this.btn_add = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_price = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.rtxt_listSites = new System.Windows.Forms.RichTextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txt_old_name = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_recent_name = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_rename = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.BackColor = System.Drawing.SystemColors.Window;
            this.splitContainer1.Panel2.Controls.Add(this.btn_cancel);
            this.splitContainer1.Panel2.Controls.Add(this.btn_ok);
            this.splitContainer1.Panel2.Controls.Add(this.btn_clear);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(3);
            this.splitContainer1.Size = new System.Drawing.Size(783, 393);
            this.splitContainer1.SplitterDistance = 330;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.IsSplitterFixed = true;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.AliceBlue;
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Controls.Add(this.btn_filter_price);
            this.splitContainer2.Panel1.Controls.Add(this.label3);
            this.splitContainer2.Panel1.Controls.Add(this.txt_price_filter);
            this.splitContainer2.Panel1.Controls.Add(this.btn_showProducts);
            this.splitContainer2.Panel1.Controls.Add(this.btn_add);
            this.splitContainer2.Panel1.Controls.Add(this.label2);
            this.splitContainer2.Panel1.Controls.Add(this.txt_price);
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.txt_title);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.rtxt_listSites);
            this.splitContainer2.Size = new System.Drawing.Size(783, 330);
            this.splitContainer2.SplitterDistance = 380;
            this.splitContainer2.TabIndex = 2;
            // 
            // btn_filter_price
            // 
            this.btn_filter_price.Location = new System.Drawing.Point(88, 136);
            this.btn_filter_price.Name = "btn_filter_price";
            this.btn_filter_price.Size = new System.Drawing.Size(114, 27);
            this.btn_filter_price.TabIndex = 9;
            this.btn_filter_price.Text = "Show by Price";
            this.btn_filter_price.UseVisualStyleBackColor = true;
            this.btn_filter_price.Click += new System.EventHandler(this.Btn_filter_price_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Price filter";
            // 
            // txt_price_filter
            // 
            this.txt_price_filter.Location = new System.Drawing.Point(88, 111);
            this.txt_price_filter.Name = "txt_price_filter";
            this.txt_price_filter.Size = new System.Drawing.Size(114, 20);
            this.txt_price_filter.TabIndex = 7;
            // 
            // btn_showProducts
            // 
            this.btn_showProducts.Location = new System.Drawing.Point(88, 63);
            this.btn_showProducts.Name = "btn_showProducts";
            this.btn_showProducts.Size = new System.Drawing.Size(114, 27);
            this.btn_showProducts.TabIndex = 6;
            this.btn_showProducts.Text = "Show all";
            this.btn_showProducts.UseVisualStyleBackColor = true;
            this.btn_showProducts.Click += new System.EventHandler(this.Btn_showProducts_Click);
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(254, 61);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(114, 27);
            this.btn_add.TabIndex = 5;
            this.btn_add.Text = "Add ";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Price";
            // 
            // txt_price
            // 
            this.txt_price.Location = new System.Drawing.Point(88, 38);
            this.txt_price.Name = "txt_price";
            this.txt_price.Size = new System.Drawing.Size(280, 20);
            this.txt_price.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(88, 12);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(280, 20);
            this.txt_title.TabIndex = 0;
            // 
            // rtxt_listSites
            // 
            this.rtxt_listSites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_listSites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_listSites.Location = new System.Drawing.Point(0, 0);
            this.rtxt_listSites.Name = "rtxt_listSites";
            this.rtxt_listSites.Size = new System.Drawing.Size(399, 330);
            this.rtxt_listSites.TabIndex = 0;
            this.rtxt_listSites.Text = "";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(665, 19);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(114, 27);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click_1);
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.Location = new System.Drawing.Point(545, 19);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(114, 27);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.Btn_ok_Click_1);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clear.Location = new System.Drawing.Point(14, 19);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(114, 27);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_rename);
            this.groupBox1.Controls.Add(this.txt_old_name);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txt_recent_name);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(8, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(366, 112);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Edit Field Name";
            // 
            // txt_old_name
            // 
            this.txt_old_name.Location = new System.Drawing.Point(86, 18);
            this.txt_old_name.Name = "txt_old_name";
            this.txt_old_name.Size = new System.Drawing.Size(274, 20);
            this.txt_old_name.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(4, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Old name";
            // 
            // txt_recent_name
            // 
            this.txt_recent_name.Location = new System.Drawing.Point(86, 44);
            this.txt_recent_name.Name = "txt_recent_name";
            this.txt_recent_name.Size = new System.Drawing.Size(274, 20);
            this.txt_recent_name.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Recent name";
            // 
            // btn_rename
            // 
            this.btn_rename.Location = new System.Drawing.Point(86, 70);
            this.btn_rename.Name = "btn_rename";
            this.btn_rename.Size = new System.Drawing.Size(114, 27);
            this.btn_rename.TabIndex = 11;
            this.btn_rename.Text = "Rename";
            this.btn_rename.UseVisualStyleBackColor = true;
            this.btn_rename.Click += new System.EventHandler(this.Btn_rename_Click);
            // 
            // AddRecordToProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(783, 393);
            this.Controls.Add(this.splitContainer1);
            this.Name = "AddRecordToProduct";
            this.Text = "Add Record To Product";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.RichTextBox rtxt_listSites;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Button btn_showProducts;
        private System.Windows.Forms.Button btn_filter_price;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_price_filter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txt_old_name;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_recent_name;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_rename;
    }
}