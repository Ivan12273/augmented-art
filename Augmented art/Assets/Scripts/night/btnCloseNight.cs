﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnCloseNight : MonoBehaviour
{

    public Button btnCl;
    public GameObject panel;
    void Start()
    {
        btnCl = btnCl.GetComponent<Button>();
        btnCl.onClick.AddListener(ClosePanel);

        panel = GameObject.Find("PanelInfoNight");
    }

    void ClosePanel()
    {
        panel.SetActive(false);
    }

}
