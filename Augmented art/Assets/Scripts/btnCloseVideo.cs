using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnCloseVideo : MonoBehaviour
{

    public Button btnClVd;
    public GameObject panel;
    //public GameObject btnInfo;

    // Start is called before the first frame update
    void Start()
    {
        btnClVd = btnClVd.GetComponent<Button>();
        btnClVd.onClick.AddListener(ClosePanel);

        panel = GameObject.Find("PanelVideo");
        //btnInfo = GameObject.Find("BtnInfo");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ClosePanel()
    {
        panel.SetActive(false);
        //btnInfo.SetActive(true);
    }

}
