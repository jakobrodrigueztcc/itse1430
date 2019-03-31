using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactManager
{
    class Message
    {

        /// <summary>Gets or sets the contact.</summary>
        public string Contact
        {
            get { return _contact ?? ""; }
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
        private string _contact = "";
        private string _subject = "";
        private string _body = "";
    }
}
