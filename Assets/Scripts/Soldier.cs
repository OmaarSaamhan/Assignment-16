using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{

    public class Soldier : Character
    {
        public Soldier(string soldierName, int soldierHealth, Position soldierPosition) : base(soldierName, soldierHealth, soldierPosition) { }

        public override void DisplayInfo()
        {
            Debug.Log("Soldier");
            base.DisplayInfo();
        }

    }
}
