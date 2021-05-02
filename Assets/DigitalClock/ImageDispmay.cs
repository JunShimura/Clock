using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using CommonTools;
using DigitalClock;

[RequireComponent(typeof(Image))]
public class ImageDisplay : ValueDisplay
{
    Image image;

    private void Awake()
    {
        image = GetComponent<Image>();
        if(image == null) {
            Debug.LogError("Image is not found st Start");
        }
    }
    public override float SetValue(float val)
    {
        if (image == null) {
            Debug.LogError("Image is not found at SetValue");
            return val;
        }
        image.fillAmount = val;
        return val;
   }
}
