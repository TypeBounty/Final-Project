﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class a3 : MonoBehaviour
{
    List<string> thirdchoice = new List<string>() {"It runs when the condition is false", "When the condition is false", "while loops at least once even if condition is false & Do-while stops if its false", "Needs a condition & a while loop" };
    // Start is called before the first frame update
    void Start()
    {
        GetComponent<TextMesh>().text = thirdchoice[0];
    }

    // Update is called once per frame
    void Update()
    {
        if (qq.randQuestion > -1)
        {
            GetComponent<TextMesh>().text = thirdchoice[qq.randQuestion];
        }

        if (qq.trigger == "n")
        {
            GetComponent<BoxCollider2D>().enabled = true;
        }
        else
        {
            GetComponent<BoxCollider2D>().enabled = false;
        }
    }

    void OnMouseDown()
    {
        qq.selectedAnswer = gameObject.name;
        qq.choiceSelected = "y";
        qq.trigger = "y";
        GetComponent<BoxCollider2D>().isTrigger = false;
    }
}
