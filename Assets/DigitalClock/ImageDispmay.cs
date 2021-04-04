using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using CommonTools;
using DigitalClock;

[RequireComponent(typeof(Image))]
public class ImageDispmay : ValueDisplay
{
    Image image;

    private void Start()
    {
        image = GetComponent<Image>(); 
    }
    public override float SetValue(float val)
    {
        image.fillAmount = val;
        return val;
   }
}
