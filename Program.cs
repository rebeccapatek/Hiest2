using System;
using System.Collections.Generic;

namespace HiestPartII {
    class Program {
        static void Main (string[] args) {
            var Roladex = new List<IRobber> ();
            var Rebecca = new Hacker {
                Name = "Rebecca",
                SkillLevel = 45,
                PercentageCut = 50,
            };
            Roladex.Add (Rebecca);
            var Coffey = new Hacker {
                Name = "Coffey",
                SkillLevel = 45,
                PercentageCut = 10,

            };
            Roladex.Add (Coffey);
            var Daniel = new LockSpecialist {
                Name = "Daniel",
                SkillLevel = 55,
                PercentageCut = 90,
            };
            Roladex.Add (Daniel);
            var Spencer = new LockSpecialist {
                Name = "Spence",
                SkillLevel = 90,
                PercentageCut = 75,
            };
            Roladex.Add (Spencer);
            var Eli = new Muslce {
                Name = "Eli",
                SkillLevel = 80,
                PercentageCut = 20
            };
            Roladex.Add (Eli);
            while (true) {
                Console.WriteLine ($"{Roladex.Count} possible Robbers in my crew");
                foreach (var robber in Roladex) {
                    Console.WriteLine ($"{robber.Name}");
                }
                Console.WriteLine ("Enter the name of a potential New Recruit");
                var newRobber = Console.ReadLine ();
                if (string.IsNullOrEmpty (newRobber)) {
                    break;
                } else {
                    Console.WriteLine ("What Specialty do you want the new Robber to have?  Your choices are:");
                    Console.WriteLine ("Hacker (Disables alarms)");
                    Console.WriteLine ("Muscle (Disarms guards)");
                    Console.WriteLine ("Lock Specialist (cracks vault)");
                    string newRobberSpecialty;
                    while (true) {
                        newRobberSpecialty = Console.ReadLine ().ToLower ();
                        if (newRobberSpecialty == "hacker" || newRobberSpecialty == "muscle" || newRobberSpecialty == "lock specialist") {
                            break;

                        } else {
                            Console.WriteLine ("Try again to choose a specialty: Hacker, Muscle, Lock Specialist");
                        }
                    }
                    Console.WriteLine ("Enter the crew member's skill level from 1-100");
                    int newRobberSkillLevel;
                    while (true) {
                        try {
                            newRobberSkillLevel = int.Parse (Console.ReadLine ());
                            if (newRobberSkillLevel > 0 && newRobberSkillLevel <= 100) {
                                break;
                            } else {
                                Console.WriteLine ("Not a valid entry.   Please try a number 1-100");
                            }
                        } catch {
                            Console.WriteLine ("Not a valid entry");
                        }
                    }

                    Console.WriteLine ("What percentage cut does the crewmember want 1-50");
                    int newRobberPercentageCut;
                    while (true) {
                        try {
                            newRobberPercentageCut = int.Parse (Console.ReadLine ());
                            if (newRobberPercentageCut > 0 && newRobberPercentageCut <= 50) {
                                break;
                            } else {
                                Console.WriteLine ("Not a valid entry, please enter a number 1-50");
                            }
                        } catch {
                            Console.WriteLine ("Not a valid entry");
                        }
                    }
                    if (newRobberSpecialty == "hacker") {
                        Hacker hacker = new Hacker {
                        Name = $"{newRobber}",
                        SkillLevel = newRobberSkillLevel,
                        PercentageCut = newRobberPercentageCut
                        };
                        Roladex.Add (hacker);
                    } else if (newRobberSpecialty == "muscle") {
                        Muslce muslce = new Muslce {
                        Name = $"{newRobber}",
                        SkillLevel = newRobberSkillLevel,
                        PercentageCut = newRobberPercentageCut
                        };
                        Roladex.Add (muslce);
                    } else if (newRobberSpecialty == "lock specialist") {
                        LockSpecialist lockSpecialist = new LockSpecialist {
                        Name = $"{newRobber}",
                        SkillLevel = newRobberSkillLevel,
                        PercentageCut = newRobberPercentageCut
                        };
                        Roladex.Add (lockSpecialist);
                    }
                }

            }
        }
    }
}