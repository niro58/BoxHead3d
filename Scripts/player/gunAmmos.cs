using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gunAmmos : MonoBehaviour
{
    public int smgAmmos;

    private GameObject gunsPanel;
    private void Start()
    {
        gunsPanel = GameObject.Find("Canvas").transform.Find("gunsPanel").gameObject;
    }
    private void Update()
    {
        gunsPanel.transform.Find("smgAmmosText").GetComponent<Text>().text = smgAmmos.ToString();
    }
}
