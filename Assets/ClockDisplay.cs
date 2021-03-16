
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
        clockLabel.text
            = dateTime.Hour.ToString() + ":"
            + dateTime.Minute.ToString() + ":"
            + dateTime.Second.ToString();
    }
}
