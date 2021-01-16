using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnVideoNight : MonoBehaviour
{
    public Button btnVd;
    public GameObject panel;

    void Start()
    {
        btnVd = btnVd.GetComponent<Button>();
        btnVd.onClick.AddListener(ShowPanel);

        panel = GameObject.Find("PanelVideoNight");
        panel.SetActive(false);
    }

    void ShowPanel()
    {
        panel.SetActive(true);
    }

}
