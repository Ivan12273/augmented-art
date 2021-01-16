﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnCloseAmerican : MonoBehaviour
{
    public Button btnCl;
    public GameObject panel;

    void Start()
    {
        btnCl = btnCl.GetComponent<Button>();
        btnCl.onClick.AddListener(ClosePanel);

        panel = GameObject.Find("PanelInfoAmerican");
    }

    void ClosePanel()
    {
        panel.SetActive(false);
    }
}
