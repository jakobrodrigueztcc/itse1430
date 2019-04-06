using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactManager.UI
{
    public partial class MessageForm : Form
    {
        public MessageForm()
        {
            InitializeComponent();
        }

        /// <summary>Gets or sets the contact.</summary>
        public Contact Contact { get; set; }
        public Message Message { get; set; }

        private void OnSend( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;

            Message = new Message
            {
                Contact = Contact,
                Subject = _tbSubject.Text,
                Body = _tbBody.Text
            };

            /***Message = "Recipient: " + _tbContact.Text + Environment.NewLine
                    + "Subject: " + _tbSubject.Text + Environment.NewLine
                    + "Message: " + _tbBody.Text + Environment.NewLine
                    + "----------------------------------------------------"; ***/
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        protected override void OnLoad( EventArgs e )
        {
            base.OnLoad(e);

            if (Contact != null)
                LoadData(Contact);
            ValidateChildren();
        }

        private void LoadData( Contact contact )
        {
            _tbContact.Text = contact.Name + " <" + contact.Email + ">";
        }

        private void OnValidateSubject( object sender, CancelEventArgs e )
        {
            var tb = sender as TextBox;
            if (tb.Text.Length == 0)
            {
                _errors.SetError(tb, "Subject is required.");
                e.Cancel = true;
            } else
                _errors.SetError(tb, "");
        }
    }
}
