using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Session2.Models
{
    class Email
    {
        private String recievedEmail;
        private String title;
        private String content;

        public Email(string recievedEmail, string title, string content)
        {
            this.recievedEmail = recievedEmail;
            this.title = title;
            this.content = content;
        }

        public string RecievedEmail // properties
        {
            get => recievedEmail;
            set => recievedEmail = value;
        }

        public string Title// properties
        {
            get => title;
            set => title = value;
        }

        public string Content// properties
        {
            get => content;
            set => content = value;
        }

    }
}
