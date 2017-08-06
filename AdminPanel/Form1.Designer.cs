namespace AdminPanel
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tb_AuthToken = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button6 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_username = new System.Windows.Forms.Label();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.userFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteSelectedUserToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.banSelectedUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unBanSelectedUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editUsersUsernameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.clearTheGridToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-3, -1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(409, 319);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.tb_AuthToken);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(401, 293);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Program Auth Generation";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(11, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(375, 40);
            this.button2.TabIndex = 3;
            this.button2.Text = "Grab Auth Token";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(93, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Authentication Token:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(375, 40);
            this.button1.TabIndex = 1;
            this.button1.Text = "Generate Auth Token";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tb_AuthToken
            // 
            this.tb_AuthToken.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_AuthToken.Location = new System.Drawing.Point(11, 127);
            this.tb_AuthToken.Name = "tb_AuthToken";
            this.tb_AuthToken.ReadOnly = true;
            this.tb_AuthToken.Size = new System.Drawing.Size(375, 26);
            this.tb_AuthToken.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.button6);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.lb_username);
            this.tabPage2.Controls.Add(this.tb_password);
            this.tabPage2.Controls.Add(this.tb_username);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(401, 293);
            this.tabPage2.TabIndex = 2;
            this.tabPage2.Text = "Create A User";
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(11, 142);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(375, 136);
            this.button6.TabIndex = 5;
            this.button6.Text = "Create User";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 25);
            this.label2.TabIndex = 4;
            this.label2.Text = "Password:";
            // 
            // lb_username
            // 
            this.lb_username.AutoSize = true;
            this.lb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_username.Location = new System.Drawing.Point(11, 6);
            this.lb_username.Name = "lb_username";
            this.lb_username.Size = new System.Drawing.Size(116, 25);
            this.lb_username.TabIndex = 3;
            this.lb_username.Text = "Username:";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(11, 101);
            this.tb_password.Name = "tb_password";
            this.tb_password.Size = new System.Drawing.Size(375, 26);
            this.tb_password.TabIndex = 2;
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(11, 34);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(375, 26);
            this.tb_username.TabIndex = 1;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.Controls.Add(this.button5);
            this.tabPage3.Controls.Add(this.button4);
            this.tabPage3.Controls.Add(this.button3);
            this.tabPage3.Controls.Add(this.listView1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(401, 293);
            this.tabPage3.TabIndex = 1;
            this.tabPage3.Text = "User Info";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(3, 252);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(392, 35);
            this.button5.TabIndex = 3;
            this.button5.Text = "Get Offline Users";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(3, 215);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(392, 35);
            this.button4.TabIndex = 2;
            this.button4.Text = "Get Online Users";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(3, 178);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(392, 35);
            this.button3.TabIndex = 1;
            this.button3.Text = "Get All Users";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(398, 175);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "ID";
            this.columnHeader1.Width = 42;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "User";
            this.columnHeader2.Width = 157;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Online Status";
            this.columnHeader3.Width = 93;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Ban Status";
            this.columnHeader4.Width = 77;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userFunctionsToolStripMenuItem,
            this.toolStripSeparator1,
            this.clearTheGridToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(153, 76);
            // 
            // userFunctionsToolStripMenuItem
            // 
            this.userFunctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteSelectedUserToolStripMenuItem1,
            this.banSelectedUserToolStripMenuItem,
            this.unBanSelectedUserToolStripMenuItem,
            this.editUsersUsernameToolStripMenuItem});
            this.userFunctionsToolStripMenuItem.Name = "userFunctionsToolStripMenuItem";
            this.userFunctionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.userFunctionsToolStripMenuItem.Text = "User Functions";
            // 
            // deleteSelectedUserToolStripMenuItem1
            // 
            this.deleteSelectedUserToolStripMenuItem1.Name = "deleteSelectedUserToolStripMenuItem1";
            this.deleteSelectedUserToolStripMenuItem1.Size = new System.Drawing.Size(228, 22);
            this.deleteSelectedUserToolStripMenuItem1.Text = "Delete Selected User";
            this.deleteSelectedUserToolStripMenuItem1.Click += new System.EventHandler(this.deleteSelectedUserToolStripMenuItem1_Click);
            // 
            // banSelectedUserToolStripMenuItem
            // 
            this.banSelectedUserToolStripMenuItem.Name = "banSelectedUserToolStripMenuItem";
            this.banSelectedUserToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.banSelectedUserToolStripMenuItem.Text = "Ban Selected User";
            this.banSelectedUserToolStripMenuItem.Click += new System.EventHandler(this.banSelectedUserToolStripMenuItem_Click);
            // 
            // unBanSelectedUserToolStripMenuItem
            // 
            this.unBanSelectedUserToolStripMenuItem.Name = "unBanSelectedUserToolStripMenuItem";
            this.unBanSelectedUserToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.unBanSelectedUserToolStripMenuItem.Text = "Unban Selected User";
            this.unBanSelectedUserToolStripMenuItem.Click += new System.EventHandler(this.unBanSelectedUserToolStripMenuItem_Click);
            // 
            // editUsersUsernameToolStripMenuItem
            // 
            this.editUsersUsernameToolStripMenuItem.Name = "editUsersUsernameToolStripMenuItem";
            this.editUsersUsernameToolStripMenuItem.Size = new System.Drawing.Size(228, 22);
            this.editUsersUsernameToolStripMenuItem.Text = "Edit Selected Users Username";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(149, 6);
            // 
            // clearTheGridToolStripMenuItem
            // 
            this.clearTheGridToolStripMenuItem.Name = "clearTheGridToolStripMenuItem";
            this.clearTheGridToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.clearTheGridToolStripMenuItem.Text = "Clear The Grid";
            this.clearTheGridToolStripMenuItem.Click += new System.EventHandler(this.clearTheGridToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(399, 311);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "  ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        public System.Windows.Forms.TextBox tb_AuthToken;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_username;
        public System.Windows.Forms.TextBox tb_password;
        public System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clearTheGridToolStripMenuItem;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem userFunctionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteSelectedUserToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem banSelectedUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unBanSelectedUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editUsersUsernameToolStripMenuItem;
    }
}

