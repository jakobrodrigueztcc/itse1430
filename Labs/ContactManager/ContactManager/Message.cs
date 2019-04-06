using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    public class Message
    {

        /// <summary>Gets or sets the contact.</summary>
        public Contact Contact
        {
            get { return _contact ?? null; }
            set { _contact = value; }
        }
        /// <summary>Gets or sets the subject.</summary>
        public string Subject
        {
            get { return _subject ?? ""; }
            set { _subject = value; }
        }
        /// <summary>Gets or sets the body.</summary>
        public string Body
        {
            get { return _body ?? ""; }
            set { _body = value; }
        }
        private Contact _contact = null;
        private string _subject = "";
        private string _body = "";
    }
}
