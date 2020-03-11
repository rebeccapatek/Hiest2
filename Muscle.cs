using System;
namespace HiestPartII {
    public class Muslce : IRobber {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill (Bank bank) {
            int score = (bank.SecurityGuardScore - SkillLevel);
            if (score <= 0) {
                Console.WriteLine ($"{Name} has disabled the Security Guards with ninja moves!");
            } else {

                Console.WriteLine ($"{Name} is Muscling through the Security Gaurds. Decrease the Security by {SkillLevel}");
            }

        }
    }
}