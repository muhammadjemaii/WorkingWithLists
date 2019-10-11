namespace WorkingWithLists
{
    partial class ListManagers
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbx_listType = new System.Windows.Forms.ComboBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_show = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rtxt_desc = new System.Windows.Forms.RichTextBox();
            this.txt_title = new System.Windows.Forms.TextBox();
            this.btn_add_new_list = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.rtxt_listSites = new System.Windows.Forms.RichTextBox();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_ok = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_list_name = new System.Windows.Forms.TextBox();
            this.btn_show_item = new System.Windows.Forms.Button();
            this.btn_hide_item = new System.Windows.Forms.Button();
            this.btn_hide_all_item = new System.Windows.Forms.Button();
            this.btn_show_all_item = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.splitContainer1.Size = new System.Drawing.Size(800, 450);
            this.splitContainer1.SplitterDistance = 373;
            this.splitContainer1.SplitterWidth = 5;
            this.splitContainer1.TabIndex = 1;
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
            this.splitContainer2.Panel1.Controls.Add(this.groupBox2);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Padding = new System.Windows.Forms.Padding(3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.rtxt_listSites);
            this.splitContainer2.Panel2.Controls.Add(this.textBox1);
            this.splitContainer2.Size = new System.Drawing.Size(800, 373);
            this.splitContainer2.SplitterDistance = 350;
            this.splitContainer2.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbx_listType);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Controls.Add(this.btn_show);
            this.groupBox1.Controls.Add(this.btn_delete);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.rtxt_desc);
            this.groupBox1.Controls.Add(this.txt_title);
            this.groupBox1.Controls.Add(this.btn_add_new_list);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(332, 159);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "List Manager";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Template";
            // 
            // cbx_listType
            // 
            this.cbx_listType.FormattingEnabled = true;
            this.cbx_listType.Location = new System.Drawing.Point(76, 47);
            this.cbx_listType.Name = "cbx_listType";
            this.cbx_listType.Size = new System.Drawing.Size(250, 21);
            this.cbx_listType.TabIndex = 4;
            // 
            // btn_update
            // 
            this.btn_update.Location = new System.Drawing.Point(190, 118);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(64, 29);
            this.btn_update.TabIndex = 9;
            this.btn_update.Text = "Update";
            this.btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_show
            // 
            this.btn_show.Location = new System.Drawing.Point(4, 118);
            this.btn_show.Name = "btn_show";
            this.btn_show.Size = new System.Drawing.Size(64, 29);
            this.btn_show.TabIndex = 8;
            this.btn_show.Text = "Show All";
            this.btn_show.UseVisualStyleBackColor = true;
            this.btn_show.Click += new System.EventHandler(this.Btn_show_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(74, 118);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(64, 29);
            this.btn_delete.TabIndex = 7;
            this.btn_delete.Text = "Delete";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.Btn_delete_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Descript.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // rtxt_desc
            // 
            this.rtxt_desc.Location = new System.Drawing.Point(76, 74);
            this.rtxt_desc.Name = "rtxt_desc";
            this.rtxt_desc.Size = new System.Drawing.Size(250, 38);
            this.rtxt_desc.TabIndex = 4;
            this.rtxt_desc.Text = "";
            // 
            // txt_title
            // 
            this.txt_title.Location = new System.Drawing.Point(76, 19);
            this.txt_title.Name = "txt_title";
            this.txt_title.Size = new System.Drawing.Size(250, 22);
            this.txt_title.TabIndex = 3;
            // 
            // btn_add_new_list
            // 
            this.btn_add_new_list.Location = new System.Drawing.Point(260, 118);
            this.btn_add_new_list.Name = "btn_add_new_list";
            this.btn_add_new_list.Size = new System.Drawing.Size(64, 29);
            this.btn_add_new_list.TabIndex = 2;
            this.btn_add_new_list.Text = "Create";
            this.btn_add_new_list.UseVisualStyleBackColor = true;
            this.btn_add_new_list.Click += new System.EventHandler(this.Btn_add_new_list_Click);
            // 
            // textBox1
            // 
            this.textBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.textBox1.Location = new System.Drawing.Point(0, 351);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(446, 22);
            this.textBox1.TabIndex = 11;
            this.textBox1.Visible = false;
            // 
            // rtxt_listSites
            // 
            this.rtxt_listSites.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtxt_listSites.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtxt_listSites.Location = new System.Drawing.Point(0, 0);
            this.rtxt_listSites.Name = "rtxt_listSites";
            this.rtxt_listSites.Size = new System.Drawing.Size(446, 351);
            this.rtxt_listSites.TabIndex = 0;
            this.rtxt_listSites.Text = "";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btn_cancel.Location = new System.Drawing.Point(680, 18);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(114, 27);
            this.btn_cancel.TabIndex = 4;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.Btn_cancel_Click);
            // 
            // btn_ok
            // 
            this.btn_ok.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_ok.Location = new System.Drawing.Point(560, 18);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(114, 27);
            this.btn_ok.TabIndex = 3;
            this.btn_ok.Text = "OK";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.Btn_ok_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_clear.Location = new System.Drawing.Point(12, 18);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(114, 27);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.Btn_clear_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_hide_all_item);
            this.groupBox2.Controls.Add(this.btn_show_all_item);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_list_name);
            this.groupBox2.Controls.Add(this.btn_hide_item);
            this.groupBox2.Controls.Add(this.btn_show_item);
            this.groupBox2.Location = new System.Drawing.Point(12, 177);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(332, 190);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Show or Hide A List in Quick Launch";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Title";
            // 
            // txt_list_name
            // 
            this.txt_list_name.Location = new System.Drawing.Point(74, 21);
            this.txt_list_name.Name = "txt_list_name";
            this.txt_list_name.Size = new System.Drawing.Size(250, 22);
            this.txt_list_name.TabIndex = 12;
            // 
            // btn_show_item
            // 
            this.btn_show_item.Location = new System.Drawing.Point(260, 49);
            this.btn_show_item.Name = "btn_show_item";
            this.btn_show_item.Size = new System.Drawing.Size(64, 29);
            this.btn_show_item.TabIndex = 11;
            this.btn_show_item.Text = "Show";
            this.btn_show_item.UseVisualStyleBackColor = true;
            this.btn_show_item.Click += new System.EventHandler(this.Btn_show_item_Click);
            // 
            // btn_hide_item
            // 
            this.btn_hide_item.Location = new System.Drawing.Point(190, 49);
            this.btn_hide_item.Name = "btn_hide_item";
            this.btn_hide_item.Size = new System.Drawing.Size(64, 29);
            this.btn_hide_item.TabIndex = 11;
            this.btn_hide_item.Text = "Hide";
            this.btn_hide_item.UseVisualStyleBackColor = true;
            this.btn_hide_item.Click += new System.EventHandler(this.Btn_hide_item_Click);
            // 
            // btn_hide_all_item
            // 
            this.btn_hide_all_item.Location = new System.Drawing.Point(190, 84);
            this.btn_hide_all_item.Name = "btn_hide_all_item";
            this.btn_hide_all_item.Size = new System.Drawing.Size(64, 29);
            this.btn_hide_all_item.TabIndex = 14;
            this.btn_hide_all_item.Text = "Hide All";
            this.btn_hide_all_item.UseVisualStyleBackColor = true;
            this.btn_hide_all_item.Click += new System.EventHandler(this.Btn_hide_all_item_Click);
            // 
            // btn_show_all_item
            // 
            this.btn_show_all_item.Location = new System.Drawing.Point(260, 84);
            this.btn_show_all_item.Name = "btn_show_all_item";
            this.btn_show_all_item.Size = new System.Drawing.Size(64, 29);
            this.btn_show_all_item.TabIndex = 15;
            this.btn_show_all_item.Text = "Show All";
            this.btn_show_all_item.UseVisualStyleBackColor = true;
            this.btn_show_all_item.Click += new System.EventHandler(this.Btn_show_all_item_Click);
            // 
            // ListManagers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ListManagers";
            this.Text = "Working With List";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btn_add_new_list;
        private System.Windows.Forms.RichTextBox rtxt_listSites;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_ok;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtxt_desc;
        private System.Windows.Forms.TextBox txt_title;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_show;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ComboBox cbx_listType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_list_name;
        private System.Windows.Forms.Button btn_show_item;
        private System.Windows.Forms.Button btn_hide_all_item;
        private System.Windows.Forms.Button btn_show_all_item;
        private System.Windows.Forms.Button btn_hide_item;
    }
}

