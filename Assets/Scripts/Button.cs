using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // Declaring inputfields
    public InputField Player2_InputField ;
    public InputField Player1_InputField;

    //Declaring Text
    public Text DisplayText;

    // public Text PlayerName;
   

    public void Register()
    {
        if(Player1_InputField.text != "" && Player2_InputField.text != "")
        {
            PlayerPrefs.SetString("player1_ref", Player1_InputField.text);
            PlayerPrefs.SetString("player2_ref", Player2_InputField.text);

            Player1_InputField.text = "";
            Player2_InputField.text = "";

            SceneManager.LoadScene("CheckersBoard");

        }
        else
        {
            DisplayText.text = "Please enter information!";
        }
    }

}
