using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warning : MonoBehaviour
{
    public GameObject Panel;
    public void Accept()
    {
        Panel.SetActive(false);
    }
}
