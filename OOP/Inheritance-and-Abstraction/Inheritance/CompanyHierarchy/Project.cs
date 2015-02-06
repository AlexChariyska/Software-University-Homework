namespace CompanyHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    class Project : IProject
    {
        private string projectName;
        private string projectStartDate;
        private string details;
        private State state;
        public Project(string projectName, string startDate, State state, string details)
        {
            this.ProjectName = projectName;
            this.ProjectStartDate = projectStartDate;
            this.State = state;
            this.Details = details;
        }
        public string ProjectName
        {
            get
            {
                return this.projectName;
            }
            set
            {
                this.projectName = value;
            }
        }

        public string ProjectStartDate
        {
            get
            {
                return this.projectStartDate;
            }
            set
            {
                this.projectStartDate = value;
            }
        }
        public void CloseProject()
        {
            this.State = State.Closed;
        }

        public string Details
        {
            get
            {
                return this.details;
            }
            set
            {
                this.details = value;
            }
        }

        public State State
        {
            get
            {
                return this.state;
            }
            set
            {
                this.state = value;
            }
        }
        public override string ToString()
        {
            return string.Format(
                "Projects: {0}, started: {1:dd.MM.yyyy}, State: {2}, Details: {3}",
                this.ProjectName,
                this.ProjectStartDate,
                this.State,
                this.Details);
        }
    }
}
