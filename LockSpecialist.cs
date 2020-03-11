using System;
namespace HiestPartII {
    public class LockSpecialist : IRobber {
        public string Name { get; set; }
        public int SkillLevel { get; set; }
        public int PercentageCut { get; set; }

        public void PerformSkill (Bank bank) {
            int score = (bank.VaultScore - SkillLevel);
            if (score <= 0) {
                Console.WriteLine ($"{Name} has opened the Vault!");
            } else {

                Console.WriteLine ($"{Name} is Picking the Lock. Decrease the Security by {SkillLevel}");
            }
        }
    }
}