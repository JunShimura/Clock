
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace ClockSystem
{
/// <summary>
/// Clcck provider
/// </summary>
    public class ClockProvider : MonoBehaviour
    {
        // singlton
        static  private ClockProvider _S =null;
        static private System.DateTime dateTime = new System.DateTime();

        static public int hour
        {
            get { return dateTime.Hour; }
        }
        static public int minuite
        {
            get { return dateTime.Minute; }
        }
        static public int second
        {
            get { return dateTime.Second; }
        }
        static public int millisecond
        {
            get { return dateTime.Millisecond; }
        }
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
            if (_S == null)
            {
                _S = new ClockProvider();
                dateTime = new System.DateTime();
            }
            else
            {
                Destroy(this);
            }
        }

        void Start()
        {
            dateTime = System.DateTime.Now;
        }

        void Update()
        {
            dateTime = System.DateTime.Now;
            fSecond = dateTime.Second + dateTime.Millisecond/1000.0f;
            fMinute = dateTime.Minute + fSecond / 60.0f;
            fHour = dateTime.Hour + fMinute / 60.0f; ;
        }

    }

}