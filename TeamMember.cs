using System;
using System.Collections.Generic;

namespace Heist
{
    public class TeamMember
    {
        //Phase 1: Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0.
        public string Name { get; set; }
        public int Skill { get; set; }
        public double Courage { get; set; }

        public void createTeamMember (string NameInput, int SkillInput, double CourageInput)
        {
            Name = NameInput;
            Skill = SkillInput;
            Courage = CourageInput;
        }
    }
}