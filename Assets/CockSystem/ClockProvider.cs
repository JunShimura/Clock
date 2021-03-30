
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;

namespace ClockSystem
{
    /// <summary>
    /// Clcck provider
    /// </summary>
    public class ClockProvider : MonoBehaviour
    {
        public bool realTime = true;
        public float waitTime = 100.0f;

        // singlton
        static private ClockProvider _S = null;
        static public ClockProvider instance
        {
            get { return _S; }
        }
        private DateTime dateTime = new System.DateTime();
        int tickCount;
        int deltaTickCount;

        // Actions
        public event Action<ClockProvider> UpdateHandler;
        public ValueChangeAction<int> hour;
        public ValueChangeAction<int> minute;
        public ValueChangeAction<int> second;
        public int millisecond
        {
            get { return dateTime.Millisecond; }
        }
        // clock values as float
        static public float fHour
        {
            get; private set;
        }
        static public float fMinute
        {
            get; private set;
        }
        static public float fSecond
        {
            get; private set;
        }
        private void Awake()
        {
            if (_S == null) {
                _S = this;
                dateTime = new System.DateTime();
            }
            else {
                Destroy(this);
                return;
            }
            hour = new ValueChangeAction<int>();
            minute = new ValueChangeAction<int>();
            second = new ValueChangeAction<int>();


        }

        void Start()
        {
            dateTime = System.DateTime.Now;
            tickCount = Environment.TickCount;
            StartCoroutine(TimeUpdate());
        }

        /*        void Update()
                {
                    if (realTime) {
                        dateTime = dateTime.AddMilliseconds((double)(Time.deltaTime*1000.0f));
                        hour.val = dateTime.Hour;
                        minute.val = dateTime.Minute;
                        second.val = dateTime.Second;
                        SetFloatTime(dateTime);
                        UpdateHandler(_S);
                    }
                }*/
        private IEnumerator TimeUpdate()
        {
            while (true) {
                if (realTime) {
                    deltaTickCount = Environment.TickCount - tickCount;
                    dateTime = dateTime.AddMilliseconds((double)deltaTickCount);
                    tickCount = Environment.TickCount;
                    hour.val = dateTime.Hour;
                    minute.val = dateTime.Minute;
                    second.val = dateTime.Second;
                    SetFloatTime(dateTime);
                    UpdateHandler(_S);
                }
                yield return new WaitForSeconds(waitTime);
            }
        }

        void SetFloatTime(DateTime dt)
        {
            fSecond = dt.Second + dateTime.Millisecond / 1000.0f;
            fMinute = dt.Minute + fSecond / 60.0f;
            fHour = dt.Hour + fMinute / 60.0f;
        }

    }

}