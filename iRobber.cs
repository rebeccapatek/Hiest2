namespace HiestPartII {
    public interface IRobber {
        string Name { get; set; }
        int SkillLevel { get; set; }
        int PercentageCut { get; set; }

        //This is a method called Perform Skill, it takes Bank as a parameter
        void PerformSkill (Bank bank);

    }
}