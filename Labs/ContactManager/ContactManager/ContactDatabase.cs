using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    class ContactDatabase : IContactDatabase
    {
        public Contact Add( Contact contact )
        {
            throw new NotImplementedException();
        }

        public Contact Get( int id )
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Contact> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove( int id )
        {
            throw new NotImplementedException();
        }

        public Contact Update( int id, Contact contact )
        {
            throw new NotImplementedException();
        }
    }
}
