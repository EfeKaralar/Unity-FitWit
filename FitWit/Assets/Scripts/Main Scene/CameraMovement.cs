using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public static GameObject mainCamera;
    public GameObject p1;
    public GameObject p2;

    static Vector3 Line1P; //POSITION of camera to see the mentioned line
    static Vector3 Line2P;
    static Vector3 Line3P;
    static Vector3 Line4P;

    static Vector3 Line1R; //ROTATION of camera to see the mentioned line
    static Vector3 Line2R;
    static Vector3 Line3R;
    static Vector3 Line4R;

    Vector3 p1V;
    Vector3 p2V;
    private void Start()
    {
        /*Line1B.Set(-4.5f, -10f, 4.5f);//X Smaller Z Bigger
        Line2B.Set(-4.5f, -10f, -4.5f);//Both Smaller
        Line3B.Set(4.5f, -10f, -4.5f); // X Bigger Z Smaller
        Line4B.Set(4.5f, -10f, 4.5f); // Both Bigger*/

        Line1P.Set(0f, 6f, 12f);
        Line2P.Set(-12f, 6f, 0f);
        Line3P.Set(0f, 6f, -12f);
        Line4P.Set(12f, 6f, 0f);

        Line1R.Set(25f, 180f, 0f);
        Line2R.Set(25f, 90f, 0f);
        Line3R.Set(25f, 0f, 0f);
        Line4R.Set(25f, 270f, 0f);

        //mainCamera.transform.position = Line1P;
        //mainCamera.transform.eulerAngles = Line1R;
    }
    private void FixedUpdate()
    {
        p1V = p1.transform.position;
        p2V = p2.transform.position;

    }
    public static void changeCam(GameObject c, int m)
    {
        if (m <= 10)
        {
            c.transform.position = Line1P;
            c.transform.eulerAngles = Line1R;
        }
        else if (m <= 21)
        {
            c.transform.position = Line2P;
            c.transform.eulerAngles = Line2R;
        }
        else if (m <= 32)
        {
            c.transform.position = Line3P;
            c.transform.eulerAngles = Line3R;
        }
        else
        {
            c.transform.position = Line4P;
            c.transform.eulerAngles = Line4R;
        }
    }
}