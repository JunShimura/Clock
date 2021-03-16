
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClockDisplay : MonoBehaviour
{
    [SerializeField]
    Text clockLabel;
    [SerializeField]
    Transform arrow1;
    [SerializeField]
    Transform arrow2;
    [SerializeField]
    Transform arrow3;

    System.DateTime dateTime = new System.DateTime();

    // Start is called before the first frame update
    void Start()
    {
        dateTime = System.DateTime.Now;
    }

    // Update is called once per frame
    void Update()
    {
        dateTime = System.DateTime.Now;
        int hour = dateTime.Hour;
        int minute = dateTime.Minute;
        int second = dateTime.Second;
        clockLabel.text
            = hour.ToString("00") + ":"
            + minute.ToString("00") + ":"
            + second.ToString("00");
        arrow1.rotation = Quaternion.Euler(0, 0, dateTime.Hour*-(360/12));
        arrow2.rotation = Quaternion.Euler(0, 0, dateTime.Minute * -(360 / 60));
        arrow3.rotation = Quaternion.Euler(0, 0, dateTime.Second * -(360 / 60));
    }
}
