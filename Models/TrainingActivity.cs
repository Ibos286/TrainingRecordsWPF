using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    public class TrainingActivity
    {
        private DateTime trainingDate;

        public DateTime TrainingDate
        {
            get { return trainingDate; }
            set { trainingDate = value; }
        }

        private string trainingName;

        public string TrainingName
        {
            get { return trainingName; }
            set { trainingName = value; }
        }

        private bool passed;

        public bool Passed
        {
            get { return passed; }
            set { passed = value; }
        }


    }
}
