using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arCamera : MonoBehaviour
{
    public GameObject cameraar;
    void Start()
    {
        cameraar = GameObject.Find("ARCamera");
        cameraar.SetActive(false);
    }

}
