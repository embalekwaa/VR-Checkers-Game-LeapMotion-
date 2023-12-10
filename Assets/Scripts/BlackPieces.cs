using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlackPieces : MonoBehaviour
{
    public GameObject Piece;
    public GameObject CameraWhite;

    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "White" && CameraWhite.activeInHierarchy == true)
        {
            Piece.SetActive(false);
            //BlackPiece.SetActive(true);
        }
    }

}
