using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnVideo : MonoBehaviour
{

    public Button btnVd;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        btnVd = btnVd.GetComponent<Button>();
        btnVd.onClick.AddListener(ShowPanel);

        panel = GameObject.Find("PanelVideo");
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShowPanel()
    {
        //btnVd.gameObject.SetActive(false);
        panel.SetActive(true);
    }

}
