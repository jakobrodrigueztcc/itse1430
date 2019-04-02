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
        public MainForm()
        {
            InitializeComponent();
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
            //open contact form
        }

        private void OnContactEdit( object sender, EventArgs e )
        {
            //open contact form with loaded data
        }

        private void OnContactDelete( object sender, EventArgs e )
        {
           //ask if user is sure they want to delete
        }

        private void OnGameSelected( object sender, EventArgs e )
        {
            
        }

        private void OnContactSendMsg( object sender, EventArgs e )
        {
            //open message form
        }
    }
}
