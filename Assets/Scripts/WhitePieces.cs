using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WhitePieces : MonoBehaviour
{
    public GameObject Piece;
    public GameObject CameraBlack;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Black" && CameraBlack.activeInHierarchy == true)
        {

            //WhitePiece.SetActive(false);
            Piece.SetActive(false);
        }
    }
}
