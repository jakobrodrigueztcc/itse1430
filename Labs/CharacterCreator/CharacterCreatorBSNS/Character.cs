/* Jakob Rodriguez
 * ITSE 1430
 * 3/9/2018
 */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharacterCreator
{
    public class Character
    {
        private string _name = "";
        private string _description = "";

        public int Id { get; set; }
        /// <summary>Gets or sets the name of the character.</summary>
        public string Name
        {
            get { return _name ?? ""; }
            set { _name = value ?? ""; }
        }

        /// <summary>Gets or sets the description.</summary>
        public string Description
        {
            get { return _description ?? ""; }
            set { _description = value; }
        }
        /// <summary>Gets or sets the class (combobox index).</summary>
        public int Class { get; set; }

        /// <summary>Gets or sets the species (combobox index).</summary>
        public int Species { get; set; }

        /// <summary>Gets or sets the weapon (combobox index).</summary>
        public int Weapon { get; set; }

        /// <summary>Gets or sets the strength attribute.</summary>
        public int Strength { get; set; }

        /// <summary>Gets or sets the defense attribute.</summary>
        public int Defense { get; set; }

        /// <summary>Gets or sets the speed attribute.</summary>
        public int Speed { get; set; }

        /// <summary>Dtermines if capable of flight.</summary>
        public bool Flight { get; set; }

        /// <summary>Gets or sets the intelligence attribute.</summary>
        public int Intelligence { get; set; }

        /// <summary>Gets or sets the social attribute.</summary>
        public int Social { get; set; }

        public bool Validate()
        {
            //Name is required
            if (String.IsNullOrEmpty(Name))
                return false;
            return true;
        }
        public override string ToString()
        {
            return Name;
        }

    }
}
