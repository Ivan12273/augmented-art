using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnInformationAmerican : MonoBehaviour
{
    public Button btnInfo;
    public GameObject panel;

    void Start()
    {
        btnInfo = btnInfo.GetComponent<Button>();
        btnInfo.onClick.AddListener(ShowPanel);

        panel = GameObject.Find("PanelInfoAmerican");
        panel.SetActive(false);
    }

    void ShowPanel()
    {
        panel.SetActive(true);
    }
}
