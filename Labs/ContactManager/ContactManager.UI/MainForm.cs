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
    public partial class MainForm : Form
    {
        private ContactDatabase _contacts = new ContactDatabase();

        public MainForm()
        {
            InitializeComponent();
            _tbSentMessages.Text =    "Sent messages will be displayed below."
                                    + Environment.NewLine
                                    + "=================================================";
        }

        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            var form = new AboutBox();
            form.ShowDialog();
        }
        

        private void OnContactAdd( object sender, EventArgs e )
        {
            //Display UI
            var form = new ContactForm();

            while (true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                //Add
                try
                {
                    OnSafeAdd(form);
                    break;
                } catch (Exception ex)
                {
                    //Recover from errors
                    DisplayError(ex);
                };
            };
            BindList();

        }

        private void OnContactEdit( object sender, EventArgs e )
        {
            //open contact form with loaded data
            var form = new ContactForm();
            form.Text = "Edit Contact";

            var contact = GetSelectedContact();
            if (contact == null)
                return;
            
            form.Contact = contact;

            while (true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;
                try
                {          
                    _contacts.Update(contact.Id, form.Contact);
                    break;
                } catch (Exception ex)
                {
                    DisplayError(ex);
                };
            };

            BindList();
        }

        private void OnContactDelete( object sender, EventArgs e )
        {
            var selected = GetSelectedContact();
            if (selected == null)
                return;

            //ask if user is sure they want to delete
            if (MessageBox.Show(this, $"Are you sure you want to delete \"{selected.Name}\"?",
                               "Delete Contact", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) != DialogResult.Yes)
                return;

            _contacts.Remove(selected.Id);
            BindList();
        }

        private void OnContactSelected( object sender, EventArgs e )
        {
            //...
        }

        private void OnContactSendMsg( object sender, EventArgs e )
        {
            //open message form
            var form = new MessageForm();
            form.Text = "Send Message";

            var contact = GetSelectedContact();
            if (contact == null)
                return;

            form.Contact = contact;

            while (true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;
                try
                {
                    string message = Environment.NewLine
                        + "Recipient:  " + form.Message.Contact.Name + " <" + form.Message.Contact.Email + ">" + Environment.NewLine
                        + "Subject:  " + form.Message.Subject + Environment.NewLine
                        + "Message:  " + form.Message.Body + Environment.NewLine
                        + "_______________________________________________";
                    _tbSentMessages.AppendText(message);
                    break;
                } catch (Exception ex)
                {
                    DisplayError(ex);
                };
            };
        }

        private void BindList()
        {
            //Bind to listbox
            _listContacts.Items.Clear();

            _listContacts.DisplayMember = nameof(Contact.Name);

            _listContacts.Items.AddRange(_contacts.GetAll());
        }

        private void OnLoad( object sender, EventArgs e )
        {
            BindList();
        }

        private void OnSafeAdd( ContactForm form )
        {
            try
            {
                _contacts.Add(form.Contact);
            } catch (Exception e)
            {
                throw new Exception("Error!", e);
            };
        }


        private Contact GetSelectedContact()
        {
            var value = _listContacts.SelectedItem;
            var person1 = value as Contact;
            var person2 = (value is Contact) ? (Contact)value : null;

            return _listContacts.SelectedItem as Contact;
        }

        private void DisplayError( Exception ex )
        {
            MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
