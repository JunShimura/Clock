using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using ClockSystem;

public class DigitalClock : MonoBehaviour
{
    TextMeshProUGUI clockLabel;

    // Start is called before the first frame update
    void Start()
    {
        clockLabel = GetComponent<TextMeshProUGUI>();
        ClockProvider.instance.UpdateHandler += UpdateClock;
    }

    // Update is called once per frame
    void UpdateClock(ClockProvider clockProvider)
    {
        clockLabel.text
                    = clockProvider.hour.val.ToString("00") + ":"
                    + clockProvider.minute.val.ToString("00") + ":"
                    + clockProvider.second.val.ToString("00") + ":"
                    + clockProvider.millisecond.ToString("000");
    }
}
