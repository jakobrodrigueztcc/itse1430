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
    public partial class CharacterForm : Form
    {

        public CharacterForm()
        {
            InitializeComponent();
        }

        /// <summary>Gets or sets the property being edited.</summary>
        public Character Kaiju { get; set; }


        private void OnSave( object sender, EventArgs e )
        {
            if (!ValidateChildren())
                return;
            var kaiju = SaveData();
            //Validate at UI level

            //Validate at business level
            if (!kaiju.Validate())
            {
                MessageBox.Show("Kaiju is invalid.", "Error", MessageBoxButtons.OK);
                return;
            };
            Kaiju = kaiju;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OnCancel( object sender, EventArgs e )
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        //Loads UI with character
        private void LoadData( Character kaiju )
        {
            _txtName.Text = kaiju.Name;
            _txtDescription.Text = kaiju.Description;
            _cbSpecies.SelectedIndex = kaiju.Species;   //The ComboBox options are in the designer.
            _cbClass.SelectedIndex = kaiju.Class;       //Here the indexes of the selected options are stored
            _cbWeapon.SelectedIndex = kaiju.Weapon;     //to tell which options were, well, selected.
            _nudStrength.Value = kaiju.Strength;
            _nudDefense.Value = kaiju.Defense;
            _nudSpeed.Value = kaiju.Speed;
            _cbFlight.Checked = kaiju.Flight;
            _nudIntelligence.Value = kaiju.Intelligence;
            _nudSocial.Value = kaiju.Social;
        }

        //Saves UI into new character
        private Character SaveData()
        {
            var kaiju = new Character
            {
                Name = _txtName.Text,
                Description = _txtDescription.Text,
                Species = _cbSpecies.SelectedIndex,
                Class = _cbClass.SelectedIndex,
                Weapon = _cbWeapon.SelectedIndex,
                Strength = (int)_nudStrength.Value,
                Defense = (int)_nudDefense.Value,
                Speed = (int)_nudSpeed.Value,
                Flight = _cbFlight.Checked,
                Intelligence = (int)_nudIntelligence.Value,
                Social = (int)_nudSocial.Value
            };
            
            return kaiju;
        }

        protected override void OnLoad( EventArgs e ) //is designed to be called just before the for renders
        {
            base.OnLoad(e);

            if (Kaiju != null)
                LoadData(Kaiju);
            ValidateChildren();
        }

        private void OnValidateName( object sender, System.ComponentModel.CancelEventArgs e )
        {
            var tb = sender as TextBox;
            if (tb.Text.Length == 0)
            {
                _errors.SetError(tb, "Name is required.");
                e.Cancel = true;
            } else
                _errors.SetError(tb, "");

        }
    }
}
