using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using Vuforia;

public class vbPanelManager : MonoBehaviour
{

    public GameObject vbBtnObj;
    public GameObject infoPlane;

    // Start is called before the first frame update
    void Start()
    {
        vbBtnObj = GameObject.Find("BtnInformation");
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonPressed(OnButtonPressed);
        vbBtnObj.GetComponent<VirtualButtonBehaviour>().RegisterOnButtonReleased(OnButtonReleased);

        infoPlane = GameObject.Find("Information");
        infoPlane.SetActive(false);
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button pressed");
        infoPlane.SetActive(true);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("Button released");
        infoPlane.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
