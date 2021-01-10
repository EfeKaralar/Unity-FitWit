using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dice : MonoBehaviour
{
    bool CoRoutineAllowed = true;
    string[] diceResults = { "1", "2", "3", "4", "5", "6", "7", "8", "9" };
    public Text DiceRoll;
    public static Button rollButton;
    int min = 1; int max = 6;


    private void Start()
    {
        rollButton = GameObject.Find("Roll Dice").GetComponent<Button>();
    }
    public void startCoRoutine()
    {
        if (CoRoutineAllowed)
        {
            StartCoroutine("RollTheDice");
        }
    }
    public IEnumerator RollTheDice()
    {
        rollButton.interactable = false;
        CoRoutineAllowed = false;
        int randomDiceSide = 0;
        CheatedDice(GameManager.isPlayerOnesTurn);
        for (int i = 0; i<20; ++i)
        {
            randomDiceSide = Random.Range(min, max);
            DiceRoll.text = diceResults[randomDiceSide];
            yield return new WaitForSeconds(0.03f);
        }
        GameManager.DiceResult = randomDiceSide + 1;
        CoRoutineAllowed = true;
    }
    public void CheatedDice(bool b)
    {
        if (b)
        {
            int remainder = GameManager.p1MoveCount % 5;
            switch (remainder)
            {
                case 0:
                    min = 1; max = 5;
                    break;
                case 1:
                    min = 5; max = 9;
                    break;
                case 2:
                    min = 4; max = 8;
                    break;
                case 3:
                    min = 3; max = 7;
                    break;
                case 4:
                    min = 2; max = 6;
                    break;
            }
        }
        else
        {
            int remainder = GameManager.p2MoveCount % 5;
            switch (remainder)
            {
                case 0:
                    min = 1; max = 5;
                    break;
                case 1:
                    min = 5; max = 9;
                    break;
                case 2:
                    min = 4; max = 8;
                    break;
                case 3:
                    min = 3; max = 7;
                    break;
                case 4:
                    min = 2; max = 6;
                    break;
            }
        }
    }
}
