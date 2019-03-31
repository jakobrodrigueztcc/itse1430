/* Jakob Rodriguez
 * ITSE 1430
 * 3/30/2019
 */

namespace ContactManager.UI
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contactsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miContactsAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this._miContactsDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this._miHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.sendMessageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this._miContactsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this._listContacts = new System.Windows.Forms.ListBox();
            this._tbSentMessages = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.contactsToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miFileExit});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // _miFileExit
            // 
            this._miFileExit.Name = "_miFileExit";
            this._miFileExit.Size = new System.Drawing.Size(180, 22);
            this._miFileExit.Text = "E&xit";
            this._miFileExit.Click += new System.EventHandler(this.OnFileExit);
            // 
            // contactsToolStripMenuItem
            // 
            this.contactsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miContactsAdd,
            this._miContactsEdit,
            this.toolStripSeparator2,
            this.sendMessageToolStripMenuItem,
            this.toolStripSeparator1,
            this._miContactsDelete});
            this.contactsToolStripMenuItem.Name = "contactsToolStripMenuItem";
            this.contactsToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.contactsToolStripMenuItem.Text = "&Contacts";
            // 
            // _miContactsAdd
            // 
            this._miContactsAdd.Name = "_miContactsAdd";
            this._miContactsAdd.ShortcutKeys = System.Windows.Forms.Keys.Insert;
            this._miContactsAdd.Size = new System.Drawing.Size(214, 22);
            this._miContactsAdd.Text = "&Add";
            this._miContactsAdd.Click += new System.EventHandler(this.OnContactAdd);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(211, 6);
            // 
            // _miContactsDelete
            // 
            this._miContactsDelete.Name = "_miContactsDelete";
            this._miContactsDelete.ShortcutKeys = System.Windows.Forms.Keys.Delete;
            this._miContactsDelete.Size = new System.Drawing.Size(214, 22);
            this._miContactsDelete.Text = "&Delete";
            this._miContactsDelete.Click += new System.EventHandler(this.OnContactDelete);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._miHelpAbout});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // _miHelpAbout
            // 
            this._miHelpAbout.Name = "_miHelpAbout";
            this._miHelpAbout.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this._miHelpAbout.Size = new System.Drawing.Size(180, 22);
            this._miHelpAbout.Text = "A&bout";
            this._miHelpAbout.Click += new System.EventHandler(this.OnHelpAbout);
            // 
            // sendMessageToolStripMenuItem
            // 
            this.sendMessageToolStripMenuItem.Name = "sendMessageToolStripMenuItem";
            this.sendMessageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Space)));
            this.sendMessageToolStripMenuItem.Size = new System.Drawing.Size(214, 22);
            this.sendMessageToolStripMenuItem.Text = "&Send message";
            this.sendMessageToolStripMenuItem.Click += new System.EventHandler(this.OnContactSendMsg);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(211, 6);
            // 
            // _miContactsEdit
            // 
            this._miContactsEdit.Name = "_miContactsEdit";
            this._miContactsEdit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Insert)));
            this._miContactsEdit.Size = new System.Drawing.Size(214, 22);
            this._miContactsEdit.Text = "&Edit";
            this._miContactsEdit.Click += new System.EventHandler(this.OnContactEdit);
            // 
            // _listContacts
            // 
            this._listContacts.FormattingEnabled = true;
            this._listContacts.Location = new System.Drawing.Point(0, 40);
            this._listContacts.Name = "_listContacts";
            this._listContacts.Size = new System.Drawing.Size(400, 407);
            this._listContacts.TabIndex = 1;
            this._listContacts.SelectedIndexChanged += new System.EventHandler(this.OnGameSelected);
            this._listContacts.DoubleClick += new System.EventHandler(this.OnContactEdit);
            // 
            // _tbSentMessages
            // 
            this._tbSentMessages.ImeMode = System.Windows.Forms.ImeMode.Off;
            this._tbSentMessages.Location = new System.Drawing.Point(400, 40);
            this._tbSentMessages.Multiline = true;
            this._tbSentMessages.Name = "_tbSentMessages";
            this._tbSentMessages.ReadOnly = true;
            this._tbSentMessages.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._tbSentMessages.Size = new System.Drawing.Size(400, 407);
            this._tbSentMessages.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contacts";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(406, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sent messages";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this._tbSentMessages);
            this.Controls.Add(this._listContacts);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Contact Manager";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _miFileExit;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _miHelpAbout;
        private System.Windows.Forms.ToolStripMenuItem contactsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem _miContactsAdd;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem _miContactsDelete;
        private System.Windows.Forms.ToolStripMenuItem _miContactsEdit;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem sendMessageToolStripMenuItem;
        private System.Windows.Forms.ListBox _listContacts;
        private System.Windows.Forms.TextBox _tbSentMessages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

