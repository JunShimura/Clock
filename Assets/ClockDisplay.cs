
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
    [SerializeField]
    Transform arrow4;

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
        float hour = dateTime.Hour;
        float minute = dateTime.Minute;
        float second = dateTime.Second;
        float ms = dateTime.Millisecond;
        clockLabel.text
            = hour.ToString("00") + ":"
            + minute.ToString("00") + ":"
            + second.ToString("00")+":"
        +ms.ToString("000");
        arrow1.rotation = Quaternion.Euler(0, 0, (hour+(minute+second/60)/60) * -(360 / 12));
        arrow2.rotation = Quaternion.Euler(0, 0, minute * -(360 / 60));
        arrow3.rotation = Quaternion.Euler(0, 0, second * -(360 / 60));
        arrow4.rotation = Quaternion.Euler(0, 0, -ms* (360.0f /1000.0f));
    }

/*    void Update()
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
    }*/
}
