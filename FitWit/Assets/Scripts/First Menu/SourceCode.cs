using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourceCode : MonoBehaviour
{
    public void GoToSourceCode()
    {
        string url = "https://github.com/EfeKaralar"; //CHANGE THIS LATER, THIS LINK IS FOR THE PROFILE NOW!
        Application.OpenURL(url);
    }
}
