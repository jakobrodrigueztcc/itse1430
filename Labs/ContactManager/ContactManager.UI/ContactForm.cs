/* Jakob Rodriguez
 * ITSE 1430
 * 4/5/2019
 */
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
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        /// <summary>Gets or sets the contact.</summary>
        public Contact Contact { get; set; }

        private void OnSave( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;
            var contact = SaveData();

            if (!contact.Validate())
            {
                MessageBox.Show("Contact is invalid.", "Error", MessageBoxButtons.OK);
                return;
            };
            Contact = contact;
            DialogResult = DialogResult.OK;
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
            _tbName.Text = contact.Name;
            _tbEmail.Text = contact.Email;
        }

        private Contact SaveData()
        {
            var contact = new Contact
            {
                Name = _tbName.Text,
                Email = _tbEmail.Text
            };

            return contact;
        }

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();

        }

        private void OnValidateName( object sender, CancelEventArgs e )
        {
            var tb = sender as TextBox;

            if (tb.Text.Length == 0)
            {
                _errors.SetError(tb, "Name is required.");
                e.Cancel = true;
            } else
                _errors.SetError(tb, "");

        }

        private void OnValidateEmail( object sender, CancelEventArgs e )
        {
            var tb = sender as TextBox;

            if (!tb.Text.IsValidEmail())
            {
                _errors.SetError(tb, "Email is invalid.");
                e.Cancel = true;
            } else
                _errors.SetError(tb, "");

        }
    }
}
