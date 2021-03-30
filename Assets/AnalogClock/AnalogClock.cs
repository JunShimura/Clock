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
            hand3.SetValue((float)s / 60);
        };
        clockProvider.minute.OnChange += (int s) => {
            hand2.SetValue((float)s / 60);
        };
        clockProvider.hour.OnChange += (int s) => {
            hand1.SetValue((float)s / 12);
        };
    }
}
