
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
        clockLabel.text
            = dateTime.Hour.ToString("00") + ":"
            + dateTime.Minute.ToString("00") + ":"
            + dateTime.Second.ToString("00")+":"
            + dateTime.Millisecond.ToString("000");
        float ms = dateTime.Millisecond;
        float second = dateTime.Second+ms/1000.0f;
        float minute = dateTime.Minute+second/60.0f;
        float hour = dateTime.Hour + minute / 60.0f; ;

        arrow1.rotation = Quaternion.Euler(0, 0, hour * -(360 / 12));
        arrow2.rotation = Quaternion.Euler(0, 0, minute * -(360 / 60));
        arrow3.rotation = Quaternion.Euler(0, 0, second * -(360 / 60));
        arrow4.rotation = Quaternion.Euler(0, 0, ms* -(360.0f /1000.0f));
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
