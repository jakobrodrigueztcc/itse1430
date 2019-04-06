/* Jakob Rodriguez
 * ITSE 1430
 * 4/5/2019
 */
 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class ContactDatabase /***: IContactDatabase ***/
    {
        public ContactDatabase()
        {
            var guy = new Contact
            {
                Name = "Barry B. Benson",
                Email = "bbb@beemovie.biz"
            };
            Add(guy);

            guy = new Contact
            {
                Name = "John J. Johnson",
                Email = "john.j.johnson@johnjjohnson.com"
            };
            Add(guy);
        }

            public Contact Add( Contact contact )
        {
            //Validate
            if (contact == null || !contact.Validate())
                throw new ArgumentNullException(nameof(contact));

            //Game names must be unique
            var existing = FindByName(contact.Name);
            if (existing != null)
                throw new Exception("Contact must be unique.");



            for (var index = 0; index < _items.Length; ++index)
            {
                if (_items[index] == null)
                {
                    contact.Id = ++_nextId;
                    _items[index] = Clone(contact);
                    break;
                };
            };

            return contact;
        }

        public Contact Get( int id )
        {
            var index = GetIndex(id);
            if (index >= 0)
                return Clone(_items[index]);

            return null;
        }

        public Contact[] GetAll()
        {
            //Not using text files
            int count = 0;
            foreach (var item in _items)
                if (item != null)
                    ++count;

            var tempIndex = 0;
            var temp = new Contact[count];
            for (var index = 0; index < _items.Length; ++index)
                if (_items[index] != null)
                    temp[tempIndex++] = Clone(_items[index]);

            return temp;
        }

        private Contact FindByName( string name )
        {
            return (from game in GetAll()
                    where String.Compare(game.Name, name, true) == 0
                    //orderby game.Name, game.Id descending
                    select game).FirstOrDefault();
        }
        public void Remove( int id )
        {

            var index = GetIndex(id);
            if (index >= 0)
                _items[index] = null;
        }

        public Contact Update( int id, Contact contact )
        {
            if (id <= 0)
                throw new ArgumentOutOfRangeException(nameof(id), "Id must be > 0.");
            if (contact == null || !contact.Validate())
                throw new ArgumentNullException(nameof(contact));

            //contact.Validate();

            var index = GetIndex(id);
            if (index < 0)
                throw new Exception("Contact does not exist.");

            //Game names must be unique
            var existingIndex = GetIndex(contact.Name);
            if (existingIndex >= 0 && existingIndex != index)
                throw new Exception("The contact's name needs to be unique.");

            contact.Id = id;
            var existing = _items[index];
            Clone(existing, contact);

            return contact;
        }

        private Contact Clone( Contact contact )
        {
            var newContact = new Contact();
            Clone(newContact, contact);

            return newContact;
        }

        private void Clone( Contact target, Contact source )
        {
            target.Id = source.Id;
            target.Name = source.Name;
            target.Email = source.Email;
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

        private readonly Contact[] _items = new Contact[1000];
        private int _nextId = 0;
    }
}
