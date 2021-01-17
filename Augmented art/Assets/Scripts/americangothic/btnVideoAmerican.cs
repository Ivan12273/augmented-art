using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnVideoAmerican : MonoBehaviour
{
    public Button btnVd;
    public GameObject panel;

    void Start()
    {
        btnVd = btnVd.GetComponent<Button>();
        btnVd.onClick.AddListener(ShowPanel);

        panel = GameObject.Find("PanelVideoAmerican");
        panel.SetActive(false);
    }

    void ShowPanel()
    {
        panel.SetActive(true);
    }
}
