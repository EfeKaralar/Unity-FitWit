using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SourceCode : MonoBehaviour
{
    public void GoToSourceCode()
    {
        string url = "https://github.com/EfeKaralar/Unity-FitWit";
        Application.OpenURL(url);
    }
}
