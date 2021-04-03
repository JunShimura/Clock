using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using ClockSystem;

public class AnalogClock : MonoBehaviour
{
    ClockProvider clockProvider;

    [SerializeField]
    ClockHand hand1;
    [SerializeField]
    ClockHand hand2;
    [SerializeField]
    ClockHand hand3;
    [SerializeField]
    ClockHand hand4;

    void Start()
    {
        clockProvider = ClockProvider.instance;
        clockProvider.second.OnChange += (int s) => {
            hand2.SetValue(ClockProvider.fMinute / 60);
            hand3.SetValue(ClockProvider.fSecond / 60);
        };
        clockProvider.minute.OnChange += (int s) => {
            hand1.SetValue(ClockProvider.fHour/12);
        };
        clockProvider.UpdateHandler += (ClockProvider cp) => {
            hand4.SetValue((float)ClockProvider.millisecond / 1000.0f);
        };
    }
}
