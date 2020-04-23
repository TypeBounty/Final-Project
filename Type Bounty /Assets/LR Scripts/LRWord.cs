﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class LRWord
{
    public string word;
    private int typeIndex;
    LRWordDisplay display;

    public LRWord(string _word, LRWordDisplay _display)
    {
        word = _word;
        typeIndex = 0;

        display = _display;
        display.SetWord(word);
    }

    public char GetNextLetter()
    {

        return word[typeIndex];
    }

    public void TypeLetter()
    {
        typeIndex++;
        //remove letter on screen
        display.RemoveLetter();
    }

    public bool WordTyped()
    {
        bool wordTyped = (typeIndex >= word.Length);
        if (wordTyped)
        {
            //remove word on screen
            display.RemoveWord();
        }
        return wordTyped;
    }
}