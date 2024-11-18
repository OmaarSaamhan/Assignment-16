using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assignment18
{

    public class Officer : Character
    {
        public Officer(string officerName, int officerHealth, Position officerPosition) : base(officerName, officerHealth, officerPosition) { }

        public override void DisplayInfo()
        {
            Debug.Log("Officer");
            base.DisplayInfo();
        }

    }


}
