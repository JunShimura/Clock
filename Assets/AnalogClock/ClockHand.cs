using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using CommonTools;
using ClockSystem;
namespace AnalogClock
{
    public class ClockHand : ValueDisplay
    {
        private Vector3 v = new Vector3();
        private float savedValue;
        public override float SetValue(float val)
        {
            if (val != savedValue) {
                v = this.transform.rotation.eulerAngles;
                v.z = (savedValue - val) * 360;
                this.transform.Rotate(v);
                savedValue = val;
            }
            return val;
        }

    }
}
