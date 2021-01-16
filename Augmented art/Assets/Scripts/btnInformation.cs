using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnInformation : MonoBehaviour
{

    public Button btnInfo;
    public GameObject panel;

    // Start is called before the first frame update
    void Start()
    {
        btnInfo = btnInfo.GetComponent<Button>();
        btnInfo.onClick.AddListener(ShowPanel);

        panel = GameObject.Find("PanelInfo");
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void ShowPanel()
    {
        //btnInfo.gameObject.SetActive(false);
        panel.SetActive(true);
    }

}
