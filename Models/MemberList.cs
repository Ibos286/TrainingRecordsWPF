using System;
using System.Collections.Generic;

namespace Models
{
    public class MemberList : BaseModel
    {
        private List<Member> members;

        public List<Member> Members
        {
            get { return members; }
            set { members = value; }
        }

        private string nameIndex;

        public string NameIndex
        {
            get { return nameIndex; }
            set { nameIndex = value; }
        }

    }
}
