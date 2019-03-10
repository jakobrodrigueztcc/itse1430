/* Jakob Rodriguez
 * ITSE 1430
 * 3/9/2018
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

namespace CharacterCreator.Winforms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private CharacterDatabase _kaiju = new CharacterDatabase();

        private void OnFileExit( object sender, EventArgs e )
        {
            Close();
        }

        private void OnHelpAbout( object sender, EventArgs e )
        {
            var form = new AboutBox();
            form.ShowDialog();
        }

        private void OnLoad( object sender, EventArgs e )
        {
            /*base.OnLoad(e);*/
            BindList();
        }

        private void BindList()
        {
            //Bind to listbox
            _listCharacters.Items.Clear();

            //nameof(Character.Name) == "Name"
            _listCharacters.DisplayMember = nameof(Character.Name);

            _listCharacters.Items.AddRange(_kaiju.GetAll());
        }


        private void OnCharacterNew( object sender, EventArgs e )
        {
            //Display UI
            var form = new CharacterForm();
            form.Text = "Create New Kaiju";

            while (true)
            {
                //Modal
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

        private void DisplayError( Exception ex )
        {
            MessageBox.Show(this, ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void OnSafeAdd( CharacterForm form )
        {
            try
            {
                _kaiju.Add(form.Kaiju);
            } catch (Exception e)
            {
                throw e;
            };
        }

        private void OnCharacterEdit( object sender, EventArgs e )
        {
            var form = new CharacterForm();
            form.Text = "Edit Kaiju";

            var kaiju = GetSelectedCharacter();
            if (kaiju == null)
                return;

            //Character to edit
            form.Kaiju = kaiju;

            while (true)
            {
                if (form.ShowDialog(this) != DialogResult.OK)
                    return;

                try
                {
                    //UpdateGame(game, form.Game);            
                    _kaiju.Update(kaiju.Id, form.Kaiju);
                    break;
                } catch (Exception ex)
                {
                    DisplayError(ex);
                };
            };

            BindList();
        }

        private void OnCharacterDelete( object sender, EventArgs e )
        {
            //Get selected character
            var selected = GetSelectedCharacter();
            if (selected == null)
                return;

            //Display confirmation
            if (MessageBox.Show(this, $"Are you sure you want to delete \"{selected.Name}\"?",
                               "Delete Kaiju", MessageBoxButtons.YesNo,
                               MessageBoxIcon.Question) != DialogResult.Yes)
                return;
            
            _kaiju.Delete(selected.Id);
            BindList();
        }

        private Character GetSelectedCharacter()
        {
            var value = _listCharacters.SelectedItem;
            var kaiju = value as Character;
            var kaiju2 = (value is Character) ? (Character)value : null;

            return _listCharacters.SelectedItem as Character;
        }

        private void OnCharacterSelected( object sender, EventArgs e )
        {

        }
       
    }
}
