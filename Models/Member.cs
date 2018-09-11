using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class Member : BaseModel
    {
        private string memberName;

        public string MemberName
        {
            get { return memberName; }
            set { memberName = value;
                RaisePropertyChanged("MemberName");
            }
        }

        private int badge;

        public int Badge
        {
            get { return badge; }
            set { badge = value; }
        }

        private ObservableCollection<TrainingActivity> activities;

        public ObservableCollection<TrainingActivity> Activities
        {
            get { return activities; }
            set { activities = value;
                RaisePropertyChanged("Activities");
            }
        }

        public string NameIndex { get => $"{memberName[0]}"; }
    }
}
