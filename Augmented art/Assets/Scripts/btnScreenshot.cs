using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class btnScreenshot : MonoBehaviour
{
    public void Capture()
    {
        NativeToolkit.SaveScreenshot("Screenshot-AA", "Screenshots", "png");
    }
}
