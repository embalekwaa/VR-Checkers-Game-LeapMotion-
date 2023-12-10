using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KINGSCRIPT : MonoBehaviour
{
    public GameObject ZoneBlock;
    public GameObject Pawns;
    private Vector3 scaleChange;
    //public AudioSource sound;

    public void OnCollisionEnter(Collision col)
    {
        if (col.collider.name == "KingWhite")
        {
            Pawns.SetActive(true);

            Pawns.transform.localScale = new Vector3(0.08f, 0.03f, 0.08f);
            //sound.Play();
        }
    }
}


