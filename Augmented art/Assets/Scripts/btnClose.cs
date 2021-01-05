using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnClose : MonoBehaviour
{

    public Button btnCl;
    public GameObject panel;
    //public GameObject btnInfo;

    // Start is called before the first frame update
    void Start()
    {
        btnCl = btnCl.GetComponent<Button>();
        btnCl.onClick.AddListener(ClosePanel);

        panel = GameObject.Find("PanelInfo");
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
