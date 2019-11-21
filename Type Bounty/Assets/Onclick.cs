using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Onclick : MonoBehaviour
{
    public void OnMouseDown()
    {
        if (textcontrol.scorePer > 69.9)
        {

        }
        else
        {
            SceneManager.LoadScene("Learningc++1");
        }
    }
}
