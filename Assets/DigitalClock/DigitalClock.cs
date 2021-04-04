using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

using CommonTools;
using ClockSystem;

namespace DigitalClock
{
    public class DigitalClock : MonoBehaviour
    {
        private ClockProvider clockProvider;
        [SerializeField]
        TextMeshProUGUI hourLabel;
        [SerializeField]
        TextMeshProUGUI coron1Label;
        [SerializeField]
        TextMeshProUGUI minuteLabel;
        [SerializeField]
        TextMeshProUGUI coron2Label;
        [SerializeField]
        TextMeshProUGUI secondLabel;
        [SerializeField]
        ValueDisplay millisecondDisplay;



        // Start is called before the first frame update
        void Start()
        {
            clockProvider = ClockProvider.instance;
            clockProvider.hour.OnChange += (int h) => {
                hourLabel.text = h.ToString();
            };
            clockProvider.minute.OnChange += (int m) => {
                minuteLabel.text = m.ToString("00");
            };
            clockProvider.second.OnChange += (int s) => {
                secondLabel.text = s.ToString("00");
            };
            clockProvider.UpdateHandler += (ClockProvider cp) => {
                millisecondDisplay.SetValue((float)cp.millisecond / 1000.0f);
            };

        }
    }
}
