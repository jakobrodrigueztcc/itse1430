using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameManager.Host.Winforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            LoadUI();
        }

        void LoadUI()
        {
            Game game = new Game();

            game.Name = "TimeSplitters 2";
            game.Price = 59.99M;

            var name = game.Name;
            if (name.Length == 0)
                /* is empty*/;


            game.Validate();
        }

        private void OnFileExit(object sender, EventArgs e)
        {

            Close();
        }

        private void OnHelpAbout(object sender, EventArgs e)
        {
            AboutBox form = new AboutBox();
            form.ShowDialog();
        }

        private void OnGameAdd(object sender, EventArgs e)
        {
            //Display UI
            var form = new GameForm();

            /* form.Show(); does the same thing as form.ShowDialog()
                            but allows the user to continue using main window. (modeless) */
            
            if (form.ShowDialog() != DialogResult.OK) //Modal
                return;

            //If OK then "add" to system
            _game = form.Game;
        }

        private Game _game;

        private void OnGameEdit(object sender, EventArgs e)
        {
            //Display UI
            var form = new GameForm();

            //Game to edit
            form.Game = _game;

            if (form.ShowDialog(this) != DialogResult.OK)
                return;
            
            _game = form.Game;
        }

        private void OnGameDelete(object sender, EventArgs e)
        {
            //Get selected game, if any
            var selected = GetSelectedGame();
            if (selected == null)
                return;

            //Display confirmation
            if(MessageBox.Show($"Are you sure youu want to delete {selected.Name}?", 
                "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }
            //TODO: Delete
            _game = null;

        }
        private Game GetSelectedGame()
        {
            return _game;
        }
    }
}
