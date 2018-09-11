using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using Models;
using System.Collections.ObjectModel;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;

namespace ViewModels
{
    public class MainWindowViewModel
    {
        public MemberList memberList;
        public MemberGroups memberGroups;
        public List<String> ActivityList;

        public MainWindowViewModel()
        {
            memberList = new MemberList();
            BuildTestMembers(memberList);
            PickRosterFile();

            memberGroups = new MemberGroups();
            SortAndGroupMemberList(memberList, memberGroups);

            List<string> tempActivities = new List<string>();
            BuildTestActivities(tempActivities);
            ActivityList = tempActivities.Distinct().ToList();
            ActivityList.Sort();
        }

        private void SortAndGroupMemberList(MemberList memberList, MemberGroups memberGroups)
        {
            memberList.Members = memberList.Members
                .OrderBy(m => m.MemberName)
                .ThenBy(m => m.Badge)
                .ToList();

            var grp = from Member in memberList.Members
                      group Member by Member.NameIndex
                      into grouped
                      orderby grouped.Key
                      select new MemberList
                      {
                          NameIndex = grouped.Key,
                          Members = grouped.ToList()
                      };
            memberGroups.MemberCollection = grp.ToList();
                                 
        }

        private async void PickRosterFile()
        {

        }

        private void BuildTestMembers(MemberList memberList)
        {
            memberList.Members = new List<Models.Member>
            {
                new Models.Member { MemberName = "Ibos,Robert", Badge = 289,
                    Activities = new ObservableCollection<TrainingActivity> { new TrainingActivity
                                                                {
                                                                    TrainingDate = new DateTime(2016, 1, 15),
                                                                    TrainingName = "Hearing Conservation",
                                                                    Passed = true
                                                                },
                                                              new TrainingActivity
                                                                {
                                                                    TrainingDate = new DateTime(2017, 8, 31),
                                                                    TrainingName = "SCBA Refresher",
                                                                    Passed = true
                                                                },
                                                              new TrainingActivity
                                                                {
                                                                    TrainingDate = new DateTime(2017, 10, 01),
                                                                    TrainingName = "SCBA Annual Fit Test",
                                                                    Passed = true
                                                                }
                                                             } },
                new Models.Member { MemberName = "Stewart, Timothy", Badge = 999 },
                new Models.Member { MemberName = "Ibos,Robert", Badge = 286 },
                new Models.Member { MemberName = "Stewart, Craig", Badge = 366 },
                new Models.Member { MemberName = "Olson, John", Badge = 100 }
            };
        }

        private void BuildTestActivities(List<String> TrainingActivityList)
        {
            List<String> activity = new List<string>
            {
                "NIMS 800",
                "Hearing Conservation",
                "SCBA & Breathing Air Refresher",
                "SCBA & Breathing Air Refresher"
            };

        }
    }
}
