/// Week 8		Lab 
/// File Name: Program.cs
/// @author: Antonio Monteiro

using System;
using System.Collections.Generic;

namespace Homework_8 {
    class Program {
        static void Main(string[] args) {

            //count wins
            int aaronWins = 0;
            int bobWins = 0;
            int charlieWins = 0;
            

            for (int i = 0; i < 10000; i++) {

                //create duelists
                Duelist aaron = new Duelist("Aaron", 33.3, true);
                Duelist bob = new Duelist("Bob", 50, true);
                Duelist charlie = new Duelist("Charlie", 99.5, true);

                //first shot
                int shot = 1;

                int deaths = 0;
                while (deaths < 2) {


                    //check each person in order
                    if (aaron.IsAlive && deaths < 2 && shot != 1) {
                        if (charlie.IsAlive) {
                            aaron.ShootAtTarget(charlie);
                            if (!charlie.IsAlive) {
                                deaths++;
                            }
                        } else {
                            aaron.ShootAtTarget(bob);
                            if (!bob.IsAlive) {
                                deaths++;
                            }
                        }
                    }

                    if (bob.IsAlive && deaths < 2) {
                        if (charlie.IsAlive) {
                            bob.ShootAtTarget(charlie);
                            if (!charlie.IsAlive) {
                                deaths++;
                            }
                        }
                        else {
                            bob.ShootAtTarget(aaron);
                            if (!aaron.IsAlive) {
                                deaths++;
                            }
                        }
                    }

                    if (charlie.IsAlive && deaths < 2) {
                        if (bob.IsAlive) {
                            charlie.ShootAtTarget(bob);
                            if (!bob.IsAlive) {
                                deaths++;
                            }
                        }
                        else {
                            charlie.ShootAtTarget(aaron);
                            if (!aaron.IsAlive) {
                                deaths++;
                            }
                        }
                    }

                    //no longer first shot
                    shot--;

                }

                //check winner
                if (aaron.IsAlive) {
                    aaronWins++;
                } else if (bob.IsAlive) {
                    bobWins++;
                } else {
                    charlieWins++;
                }

            }

            //output results
            Console.WriteLine("Aaron won " + aaronWins + " times out of 10000. " + (aaronWins / 10000.0) * 100);
            Console.WriteLine("Bob won " + bobWins + " times out of 10000. " + (bobWins / 10000.0) * 100);
            Console.WriteLine("Charlie won " + charlieWins + " times out of 10000. " + (charlieWins / 10000.0) * 100);

        }

    }
}
