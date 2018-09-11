using System.Collections.Generic;

namespace Models
{
    public class MemberGroups : BaseModel
    {
        private List<MemberList> memberCollection;

        public List<MemberList> MemberCollection
        {
            get { return memberCollection; }
            set { memberCollection = value; }
        }

        private string nameIndex;

        public string NameIndex
        {
            get { return nameIndex; }
            set { nameIndex = value; }
        }


    }
}
