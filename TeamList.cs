using System;
using System.Collections.Generic;

namespace Heist
{
    public class TeamList 
    {
        //Phase 2: Create a way to store several team members.
        List<TeamMember> MyTeam {get; set;} = new List<TeamMember>();

        //Phase 2: Collect several team members' information.
        public void AddTeamMember (TeamMember person)
        {
            MyTeam.Add(person);
        }
    }
}