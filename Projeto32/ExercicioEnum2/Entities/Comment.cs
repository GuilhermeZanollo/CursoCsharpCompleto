using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto32.Entities
{
    internal class Comment
    {
        public string Text { get; private set; }

        public Comment()
        {

        }

        public Comment(string text)
        {
            Text = text;
        }
    }
}
