using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace AllienProblem
{
    public class FlyweightIndirect : SimpleFlyweight
    {
        protected override void Start()
        {
            base.Start();

            for (int i = 0; i < NumberAlliens; i++)
            {
                Allien allien = new Allien();

                //With Flyweight - Indirect Assignment
                allien.SetEyePosition(eyePositions);
                allien.SetLegPosition(legPositions);
                allien.SetArmPosition(armPositions);

                allAlliens.Add(allien);
            }


            //Debug.Log("Call from: FlyweightIndirect");
        }
    }
}