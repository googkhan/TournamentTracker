using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models

{
    public class TeamModel
    {
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();

        public string TeamName { get; set; }

        //public TeamModel()
        //{
        //    TeamMembers = new List<Person>();
        //}

    }
}
