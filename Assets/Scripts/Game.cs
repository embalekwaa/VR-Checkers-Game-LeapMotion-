using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class Game : MonoBehaviour
{
    public GameObject Player2BTN, Player1BTN;
    public GameObject CameraBlack, CameraWhite;
    public GameObject Hands;
    public GameObject Text1;
    public GameObject Text2;
    public Text Player1Display;

    // 
    public GameObject Piece;

    private  void Start()
   {
        CameraBlack.SetActive(true);
        CameraWhite.SetActive(false);

        Player1Display.text = "" + PlayerPrefs.GetString("player1_ref");

   }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "White" && CameraWhite.activeInHierarchy == true)
        {
            Piece.SetActive(false);
            //BlackPiece.SetActive(true);
        }
    }

    public void WhitePlay
        ()
    {
        CameraBlack.SetActive(false);
        CameraWhite.SetActive(true);

        Player2BTN.SetActive(false);
        Player1BTN.SetActive(true);

        Text1.SetActive(false);
        Text2.SetActive(true);

        Hands.transform.Rotate(0.0f, 180.0f, 0.0f);
        Hands.transform.Rotate(0.0f, 0.0f, 0.0f);

        Player1Display.text = " " + PlayerPrefs.GetString("player2_ref");

    }

    public void BlackPlay()
    {
        CameraBlack.SetActive(true);
        CameraWhite.SetActive(false);

        Player2BTN.SetActive(true);
        Player1BTN.SetActive(false);

        Text1.SetActive(true);
        Text2.SetActive(false);

       Hands.transform.Rotate(0.0f, 0.0f, 0.0f);
       Hands.transform.Rotate(0.0f, 180.0f, 0.0f);

        Player1Display.text = " ";

        Player1Display.text = " " + PlayerPrefs.GetString("player1_ref");

    }

}
