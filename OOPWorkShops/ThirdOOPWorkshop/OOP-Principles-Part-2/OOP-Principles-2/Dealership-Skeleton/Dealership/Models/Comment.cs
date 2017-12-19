using Bytes2you.Validation;
using Dealership.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dealership.Models
{
    public class Comment:IComment
    {
        string content;
        

        public Comment(string content)
        {
            this.Content = content;
        }

        public string Content
        {
            get { return this.content; }
            
            set
            {
                Guard.WhenArgument(value, "content").IsNull().Throw();
                this.content = value;
            }
        }

        public string Author { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
       
    }
}
