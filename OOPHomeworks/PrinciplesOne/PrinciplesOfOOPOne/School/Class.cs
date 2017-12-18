using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class Class
    {
        private List<Teacher> teachers;
        private string uniqueIdent;
     
        public Class(string uniqueIdent)
        {
            this.UniqueIdent = uniqueIdent;
        }

        public string UniqueIdent { get => uniqueIdent; set => uniqueIdent = value; }
        internal List<Teacher> Teachers { get => teachers; set => teachers = value; }
    }
}
