namespace ContactManager.UI
{
    partial class MessageForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this._tbContact = new System.Windows.Forms.TextBox();
            this._tbSubject = new System.Windows.Forms.TextBox();
            this._tbBody = new System.Windows.Forms.TextBox();
            this._btnSend = new System.Windows.Forms.Button();
            this._btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Subject";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Body";
            // 
            // _tbContact
            // 
            this._tbContact.Location = new System.Drawing.Point(62, 9);
            this._tbContact.Name = "_tbContact";
            this._tbContact.ReadOnly = true;
            this._tbContact.Size = new System.Drawing.Size(300, 20);
            this._tbContact.TabIndex = 3;
            // 
            // _tbSubject
            // 
            this._tbSubject.Location = new System.Drawing.Point(61, 36);
            this._tbSubject.Name = "_tbSubject";
            this._tbSubject.Size = new System.Drawing.Size(301, 20);
            this._tbSubject.TabIndex = 4;
            // 
            // _tbBody
            // 
            this._tbBody.Location = new System.Drawing.Point(61, 63);
            this._tbBody.Multiline = true;
            this._tbBody.Name = "_tbBody";
            this._tbBody.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this._tbBody.Size = new System.Drawing.Size(301, 160);
            this._tbBody.TabIndex = 5;
            // 
            // _btnSend
            // 
            this._btnSend.Location = new System.Drawing.Point(206, 229);
            this._btnSend.Name = "_btnSend";
            this._btnSend.Size = new System.Drawing.Size(75, 23);
            this._btnSend.TabIndex = 6;
            this._btnSend.Text = "&Send";
            this._btnSend.UseVisualStyleBackColor = true;
            this._btnSend.Click += new System.EventHandler(this.OnSend);
            // 
            // _btnCancel
            // 
            this._btnCancel.Location = new System.Drawing.Point(287, 229);
            this._btnCancel.Name = "_btnCancel";
            this._btnCancel.Size = new System.Drawing.Size(75, 23);
            this._btnCancel.TabIndex = 7;
            this._btnCancel.Text = "&Cancel";
            this._btnCancel.UseVisualStyleBackColor = true;
            this._btnCancel.Click += new System.EventHandler(this.OnCancel);
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(382, 261);
            this.Controls.Add(this._btnCancel);
            this.Controls.Add(this._btnSend);
            this.Controls.Add(this._tbBody);
            this.Controls.Add(this._tbSubject);
            this.Controls.Add(this._tbContact);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MessageForm";
            this.Text = "MessageForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox _tbContact;
        private System.Windows.Forms.TextBox _tbSubject;
        private System.Windows.Forms.TextBox _tbBody;
        private System.Windows.Forms.Button _btnSend;
        private System.Windows.Forms.Button _btnCancel;
    }
}