using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayVideo: MonoBehaviour
{
    public GameObject VideoPanel;
    public Text Time;
    public float videoTime = 15f;
    void ActivateButton()
    {
        Dice.rollButton.gameObject.SetActive(true);
    }
    void DeactivateVideo()
    {
        VideoPanel.SetActive(false);
    }

    private void OnTriggerEnter()
    {
        VideoPanel.SetActive(true);
        Dice.rollButton.gameObject.SetActive(false);
        Invoke("ActivateButton", videoTime);
        //StartCoroutine(Timer()); //to show the time remaining, will be implemented later.
        Invoke("DeactivateVideo", videoTime);
    }
    /*public IEnumerator Timer()
    {

    }*/
    //This works for all the video panels
}
