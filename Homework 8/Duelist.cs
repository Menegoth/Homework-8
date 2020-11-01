using System;
using System.Collections.Generic;
using System.Text;

namespace Homework_8 {
    class Duelist {

        //instance variables
        public string Name { get; set; }
        public double Accuracy { get; set; }
        public bool IsAlive { get; set; }

        //constructor
        public Duelist(string name, double accuracy, bool isAlive) {
            Name = name;
            Accuracy = accuracy;
            IsAlive = isAlive;
        }

        /// <summary>
        /// shoot at target
        /// </summary>
        /// <param name="target">targe to shoot at</param>
        public void ShootAtTarget(Duelist target) {

            Random generator = new Random();

            if (Accuracy >= generator.Next(101)) {
                target.IsAlive = false;
            }

        }

    }
}
