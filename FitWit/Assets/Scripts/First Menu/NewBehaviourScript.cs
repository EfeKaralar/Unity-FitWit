using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public GameObject HowToPlayPanel;
    private void Start()
    {
        HowToPlayPanel = GameObject.Find("HowToPlayPanel");
    }
    public void HowToPlayMenu()
    {
        HowToPlayPanel.SetActive(true);
    }
    public void GoBack()
    {
        HowToPlayPanel.SetActive(false);
    }
}
