using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnCloseVideoCafe : MonoBehaviour
{
    public Button btnClVd;
    public GameObject panel;

    void Start()
    {
        btnClVd = btnClVd.GetComponent<Button>();
        btnClVd.onClick.AddListener(ClosePanel);

        panel = GameObject.Find("PanelVideoCafe");
    }

    void ClosePanel()
    {
        panel.SetActive(false);
    }
}
