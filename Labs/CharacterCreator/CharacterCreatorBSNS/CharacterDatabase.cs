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
    public class CharacterDatabase
    {
        public CharacterDatabase()
        {
            var kaiju = new Character
            {
                Name = "Godzilla",
                Description = "Prehistoric marine reptile, reborn in Bikini Atoll in 1954. (...yes, the checkbox for flight is checked. Look up \"Godzilla something you don't see every day\" on YouTube.)",
                Species = 0,
                Class = 5,
                Weapon = 0,
                Strength = 76,
                Defense = 74,
                Speed = 42,
                Flight = true,
                Intelligence = 40,
                Social = 24
            };
            Add(kaiju);

            kaiju = new Character
            {
                Name = "King Ghidorah",
                Description = "Three-headed dragon from space, landed in Kurobe in 1964",
                Species = 13,
                Class = 1,
                Weapon = 1,
                Strength = 92,
                Defense = 91,
                Speed = 83,
                Flight = true,
                Intelligence = 33,
                Social = 5
            };
            Add(kaiju);

            kaiju = new Character
            {
                Name = "Mothra (Imago)",
                Description = "Divine moth in her adult stage, worshipped for millennia at Infant Island",
                Species = 14,
                Class = 4,
                Weapon = 9,
                Strength = 25,
                Defense = 32,
                Speed = 66,
                Flight = true,
                Intelligence = 79,
                Social = 89
            };
            Add(kaiju);

            kaiju = new Character
            {
                Name = "Anguirus",
                Description = "Irradiated ankylosaurus, landed in Osaka in 1955",
                Species = 0,
                Class = 0,
                Weapon = 2,
                Strength = 45,
                Defense = 45,
                Speed = 60,
                Intelligence = 25,
                Social = 47
            };
            Add(kaiju);

            kaiju = new Character
            {
                Name = "Nessie",
                Description = "The Loch Ness monster, first sighted in 1934",
                Species = 2,
                Class = 4,
                Weapon = 10,
                Strength = 6,
                Defense = 3,
                Speed = 20,
                Intelligence = 15,
                Social = 1
            };
            Add(kaiju);
        }
        public Character Add( Character kaiju )
        {
            //Validate input
            if (kaiju == null)
                throw new ArgumentNullException(nameof(kaiju));

            //Character must be valid
            if (!kaiju.Validate())
                throw new Exception("Kaiju is invalid.");

            //Character names must be unique
            var existing = GetIndex(kaiju.Name);
            if (existing >= 0)
                throw new Exception("Kaiju must be unique.");

            for (var index = 0; index < _items.Length; ++index)
            {
                if (_items[index] == null)
                {
                    kaiju.Id = ++_nextId;
                    _items[index] = Clone(kaiju);
                    break;
                };
            };

            return kaiju;
        }

        public void Delete( int id )
        {
            var index = GetIndex(id);
            if (index >= 0)
                _items[index] = null;
        }

        public Character Get( int id )
        {
            var index = GetIndex(id);
            if (index >= 0)
                return Clone(_items[index]);

            return null;
        }

        public Character[] GetAll()
        {
            //How many kaiju?
            int count = 0;
            foreach (var item in _items)
                if (item != null)
                    ++count;

            var tempIndex = 0;
            var temp = new Character[count];
            for (var index = 0; index < _items.Length; ++index)
                if (_items[index] != null)
                    temp[tempIndex++] = Clone(_items[index]);

            return temp;
        }

        public Character Update( int id, Character kaiju )
        {
            //Validate
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");
            if (kaiju == null)
                throw new ArgumentNullException(nameof(kaiju));
            if (!kaiju.Validate())
                throw new Exception("Kaiju is not valid.");

            var index = GetIndex(id);
            if (index < 0)
                throw new Exception("Kaiju does not exist.");

            //Game names must be unique
            var existingIndex = GetIndex(kaiju.Name);
            if (existingIndex >= 0 && existingIndex != index)
                throw new Exception("The kaiju's name must be unique.");

            kaiju.Id = id;
            var existing = _items[index];
            Clone(existing, kaiju);

            return kaiju;
        }

        private Character Clone( Character kaiju )
        {
            var newKaiju = new Character();
            Clone(newKaiju, kaiju);

            return newKaiju;
        }

        private void Clone( Character target, Character source )
        {
            target.Id = source.Id;
            target.Name = source.Name;
            target.Description = source.Description;
            target.Species = source.Species;
            target.Class = source.Class;
            target.Weapon = source.Weapon;
            target.Strength = source.Strength;
            target.Defense = source.Defense;
            target.Speed = source.Speed;
            target.Flight = source.Flight;
            target.Intelligence = source.Intelligence;
            target.Social = source.Social;
        }

        private int GetIndex( int id )
        {
            for (var index = 0; index < _items.Length; ++index)
                if (_items[index]?.Id == id)
                    return index;

            return -1;
        }

        private int GetIndex( string name )
        {
            for (var index = 0; index < _items.Length; ++index)
                if (String.Compare(_items[index]?.Name, name, true) == 0)
                    return index;

            return -1;
        }

        private readonly Character[] _items = new Character[100];
        private int _nextId = 0;
    }
}
