using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HowToPlay : MonoBehaviour
{
    public GameObject Panel;
    public void GoToHowTo()
    {
        Panel.SetActive(true);
    }
    public void GoBack()
    {
        Panel.SetActive(false);
    }
}
