using System;
namespace HiestPartII {
    public class Hacker : IRobber {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill (Bank bank) {
            int score = (bank.AlarmScore - SkillLevel);
            if (score <= 0) {
                Console.WriteLine ($"{Name} has disabled the alarm system!");
            } else {

                Console.WriteLine ($"{Name} is Hacking the Alarm System. Decrease the Security by {SkillLevel}");
            }

        }
    }
}