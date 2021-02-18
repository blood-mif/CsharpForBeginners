using System;
namespace ToDoList
{
    // Список задач
    public class IssueList
    {
        private Issue[] _issues;

        public IssueList(int max)
        {
            _issues = new Issue[max];

            _issues[0] = new Issue
            {
                Title = "Test1",

            };
            _issues[1] = new Issue
            {
                Title = "Test2",

            };
            _issues[2] = new Issue
            {
                Title = "Test3",

            };
            _issues[3] = new Issue
            {
                Title = "Test4",

            };

        }

        public Issue[] GetIssues()
        {
            int issuesCount = Count();

            Issue[] result = new Issue[issuesCount];

            for (int i = 0; i < issuesCount; i++)
            {
                result[i] = _issues[i];
            }

            return result;
        }


        public void Add(Issue newIssue)
        {
            int issuesCount = Count();
            _issues[issuesCount] = newIssue;

        }
        private int Count()
        {
            int counter = 0;

            for (int i = 0; i < _issues.Length; i++)
            {
                if (_issues[i] != null)
                {
                    counter++;
                }
            }
            return counter;
        }

        public void EditTitle(int selectedIssueNumber, string newTitle)
        {
            if (selectedIssueNumber > 0 && string.IsNullOrWhiteSpace(newTitle) == false)
            {
                _issues[selectedIssueNumber - 1].Title = newTitle;
            }
        }

        internal void Delete(int selectedIssueNumber)
        {
            
            
            _issues[selectedIssueNumber - 1] = null;

            for (int i = 0; i < _issues.Length; i++)
            {

            }
            /*
            string[] newNames = new string[names.Length - 1];

            for (int i = 0; i < newNames.Length; i++)
            {
                if (indexValue == i)
                {

                    for (int j = i; j < newNames.Length; j++)
                    {
                        newNames[i] = names[i + 1];
                        i++;
                    }
                    break;
                }
                newNames[i] = names[i];
            }

            names = newNames;
            */
        }
    }
}
