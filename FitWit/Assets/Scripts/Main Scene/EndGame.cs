using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject EndGamePanel;
    private void OnTriggerEnter(Collider other)
    {
        if ((GameManager.p1MoveCount > 10)||(GameManager.p2MoveCount > 10))
        {
            EndGamePanel.SetActive(true);
            Dice.rollButton.gameObject.SetActive(false);
        }
    }
}
