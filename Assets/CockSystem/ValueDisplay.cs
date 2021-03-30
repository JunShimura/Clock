using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ClockSystem
{
    /// <summary>
    /// Display value
    /// </summary>
    [System.Serializable]
    public abstract class ValueDisplay : MonoBehaviour
    {
        private float _val;
        
        public float val
        {
            set { _val = SetValue(value); }
            get { return _val; }
        }

        abstract public float SetValue(float val);
    }
}
