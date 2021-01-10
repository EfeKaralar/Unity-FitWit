using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool isPlayerOnesTurn = true;

    public GameObject exitCanvas;
    public GameObject mainCam;
    //bool isLastLane = false;

    public static int p1MoveCount = 0;
    public static int p2MoveCount = 0;
    public static int DiceResult;

    Vector3 finalTile;

    private void Start()
    {
        finalTile.Set(5f, -10f, 5f);
    }
    public void OnClick()
    {
        StartCoroutine(MovePlayer());
    }

    public static string GetTurn()
    {
        if (isPlayerOnesTurn)
        {
            isPlayerOnesTurn = false;
            return "Player1";
        }
        else
        {
            isPlayerOnesTurn = true;
            return "Player2";
        }
    }
    //int line = 1; // 1, 2, 3, 4 representing each line
    public IEnumerator MovePlayer()
    {
        //disables button
        //rollButton.SetActive(false);
        string playerStr = GameManager.GetTurn();
        GameObject playerObj = GameObject.Find(playerStr);
        Transform playerTrans = playerObj.transform;
        //ascend
        playerTrans.transform.Translate(0, 0.75f, 0);
        yield return new WaitForSeconds(1f);
        int moveCount = 0;
        int c = 1;
        //moves the player tile by tile
        for (int i = 1; i <= DiceResult; i++)
        {
            //increase Movecount
            if (playerStr.Equals("Player1"))
            {
                Debug.Log("P1Moved");
                p1MoveCount += 1;
                moveCount = p1MoveCount;
                CameraMovement.changeCam(mainCam, p1MoveCount);
            }
            if (playerStr.Equals("Player2"))
            {
                Debug.Log("P2Moved");
                p2MoveCount += 1;
                moveCount = p2MoveCount;
                CameraMovement.changeCam(mainCam, p2MoveCount);
            }

            if (moveCount<=10)//((playerTrans.position.x >= -5.0f) && (playerTrans.position.z > 4.75f))
            {
                playerTrans.Translate(-1, 0, 0);
                yield return new WaitForSeconds(0.5f);

            }
            if ((playerTrans.position.x < -4.75f) && (playerTrans.position.z >= -5.0f))
            {
                playerTrans.transform.Translate(0, 0, -1);
                yield return new WaitForSeconds(0.5f);
            }
            if ((playerTrans.position.x <= 5.0f) && (playerTrans.position.z < -4.75f))
            {
                playerTrans.Translate(1, 0, 0);
                yield return new WaitForSeconds(0.5f);

            }
            if ((playerTrans.position.x > 4.75f) && (playerTrans.position.z <= 5.0f))
            {
                playerTrans.transform.Translate(0, 0, 1);
                yield return new WaitForSeconds(0.5f);
                //isLastLane = true;
            }
            if ((p1MoveCount == 42)||(p2MoveCount == 42))
            {
                c = 2;
                break;
            }
        }
        switch (c)
        {
            case 1:
                //descend and enable button
                playerTrans.transform.Translate(0, -0.75f, 0);
                Dice.rollButton.interactable = true;
                //plays video
                //PlayVideo.StartVideo(moveCount);
                //Invoke("PlayVideo.VideoPanel1.SetActive(false)", 10f);
                break;
            case 2:
                exitCanvas.SetActive(true);
                Dice.rollButton.interactable = false;
                break;
        }
    }
    bool IsBiggerV3(Vector3 A, Vector3 B)
    {
        if ((A.x > B.x) && (A.y > B.y) && (A.z > B.z))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}