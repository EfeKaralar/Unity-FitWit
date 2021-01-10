using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AreYouSureMenu : MonoBehaviour
{
    public GameObject Back2Menu;
    public GameObject YesButton;
    public GameObject NoButton;
    public GameObject RollDiceButton;
    public GameObject Die;
    public void BackMenu()
    {
        RollDiceButton.SetActive(false);
        Die.SetActive(false);
        Back2Menu.SetActive(true);
    }
    public void Yes()
    {
        SceneManager.LoadScene(0);
    }
    public void No()
    {
        RollDiceButton.SetActive(true);
        Die.SetActive(true);
        Back2Menu.SetActive(false);
    }
}
