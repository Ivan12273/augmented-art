using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnInformationNight : MonoBehaviour
{

    public Button btnInfo;
    public GameObject panel;

    void Start()
    {
        btnInfo = btnInfo.GetComponent<Button>();
        btnInfo.onClick.AddListener(ShowPanel);

        panel = GameObject.Find("PanelInfoNight");
        panel.SetActive(false);
    }

    void ShowPanel()
    {
        panel.SetActive(true);
    }

}
