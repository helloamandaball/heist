using System;
using System.Collections.Generic;
// using System.Linq;

namespace Heist
{
    class Program
    {
        static void Main(string[] args)
        {
            //Phase 1: Create a way to store a single team member. A team member will have a name, a skill Level and a courage factor. The skill Level will be a positive integer and the courage factor will be a decimal between 0.0 and 2.0. **TeamMember.cs holds the TeamMember Class**
            List<TeamMember> myTeam = new List<TeamMember>();
            //Phase 1: Print the message "Plan Your Heist!".
            Console.WriteLine("Plan Your Heist!");
            Console.WriteLine("****************");
            //Phase 6: At the beginning of the program, prompt the user to enter the difficulty level of the bank.
            Console.WriteLine($"How difficult would you like the bank to be? Choose from 1 to 10");
            //Phase 3: Store a value for the bank's difficulty level. Set this value to 100.
            int bankDifficulty = int.Parse(Console.ReadLine());
            // Console.Clear();
            //Phase 2: loop part
            for (int i = 0; i == i; i++){
                //Phase 1: Prompt the user to enter a team member's name and save that name.
                Console.WriteLine($"Enter team member {i +1}'s name:");
                string Name = Console.ReadLine();
                //Phase 2: Stop collecting team members when a blank name is entered.
                if (Name == "")
                {
                    break;
                } 
                //Phase 1: Prompt the user to enter a team member's skill level and save that skill level with the name.
                Console.WriteLine("What is their skill level? (Enter a number between 1 and 10)");
                int Skill = int.Parse(Console.ReadLine());
                //Phase 1: Prompt the user to enter a team member's courage factor and save that courage factor with the name.
                Console.WriteLine("What is their courage level? (Enter a number between 0.0 and 2.0");
                double Courage = int.Parse(Console.ReadLine());
                //Phase 1: Display the team member's information.
                    Console.WriteLine($"Team member {i +1}'s Name: {Name}, Skill level: {Skill}, Courage level: {Courage}");
                //Phase 2: Create a way to store several team members, see TeamMember.cs line 13
                var newMember = new TeamMember();
                newMember.createTeamMember(Name, Skill, Courage);
                    // Console.WriteLine(newMember.Name);
                myTeam.Add(newMember);
            }
            //Phase 5: Run the scenario multiple times.
            //Phase 5: After the user enters the team information, prompt them to enter the number of trial runs the program should perform.
            Console.WriteLine($"How many times would you like to try your heist?");
            int trials = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Console.Clear();
            //Phase 2: Display each team member's information.
                // foreach (TeamMember member in myTeam)
                // {
                //     Console.WriteLine($"Name: {member.Name}");
                //     Console.WriteLine($"Skill Level: {member.Skill}");
                //     Console.WriteLine($"Courage Level: {member.Courage}");
                //     Console.WriteLine();
                // }
            //Phase 2: Display a message containing the number of members of the team.
            Console.WriteLine($"Total number of team members = {myTeam.Count}");
            //Phase 3: Stop displaying each team member's information.
                //Idk about this one, I missed a step.
            //Phase 3: Sum the skill levels of the team. Save that number.
            int totalTeamSkills = 0;
            foreach (TeamMember member in myTeam)
            {
                totalTeamSkills += member.Skill;
            }
            //Phase 6: failTrials & successfulTrials
            var failedTrials = 0;
            var successfulTrials = 0;
            //Phase 5: Loop through the difficulty / skill level calculation based on the user-entered number of trial runs. Choose a new luck value each time.
            for(int i = 0; i < trials; i++)
            {
                //Phase 4: Create a random number between -10 and 10 for the heist's luck value.
                int luckFactor = new Random().Next(-10, 10);
                //Phase 4: Add this number to the bank's difficulty level.
                int totalBankDifficulty = bankDifficulty + luckFactor;
                //Phase 3: Compare the number with the bank's difficulty level. If the team's skill level is greater than or equal to the bank's difficulty level, Display a success message, otherwise display a failure message.
                    // if (totalTeamSkills > bankDifficulty)
                    // {
                    //     Console.WriteLine("You just got away with it!");
                    // }
                    // else{
                    //     Console.WriteLine("Hope you like jail.");
                    // }
                //Phase 5:
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"Attempt {i +1} of {trials}");
                Console.WriteLine();
                //Phase 4: Before displaying the success or failure message, display a report that shows: The team's combined skill level & The bank's difficulty level
                Console.WriteLine($"Combined skill level = {totalTeamSkills}");
                Console.WriteLine($"Bank Difficulty = {totalBankDifficulty}");
                Console.WriteLine();
                if (totalTeamSkills > totalBankDifficulty)
                {
                    Console.WriteLine("~~ $$$You just got richer!$$$ ~~");
                    successfulTrials += 1;
                }
                else
                {
                    Console.WriteLine("~~ Hope you like jail. ~~");
                    failedTrials += 1;
                }
            }
            //Phase 6: At the end of the program, display a report showing the number of successful runs and the number of failed runs.
            Console.WriteLine();
            Console.WriteLine($"Your team succeeded {successfulTrials} times.");
            Console.WriteLine($"Your team failed {failedTrials} times.");
            Console.WriteLine();
        }
    }
}

//This would go above the code: List<TeamMember> myTeam = new List<TeamMember>();
    // List<TeamMember> team = new List<TeamMember>
        // {
        //     new TeamMember {
        //         Name = "Amanda",
        //         Skill = 9,
        //         Courage = 1
        //     },
        //     new TeamMember {
        //         Name = "Leo the Dog",
        //         Skill = 3,
        //         Courage = 0.5
        //     },
        //     new TeamMember {
        //         Name = "Mark",
        //         Skill = 8,
        //         Courage = 1.8
        //     },
        //     new TeamMember {
        //         Name = "Grace",
        //         Skill = 5,
        //         Courage = 1.0
        //     },
        //     new TeamMember {
        //         Name = "Carson",
        //         Skill = 6,
        //         Courage = 1.6
        //     },
        //     new TeamMember {
        //         Name = "Haden",
        //         Skill = 7,
        //         Courage = 1.5
        //     }
        // };