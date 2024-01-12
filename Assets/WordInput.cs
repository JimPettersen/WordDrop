using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour//för att programmet ska veta att keyboardet är inputen
{
    public WordManager wordManager;

    void Update()
    {
       foreach(char letter in Input.inputString)
        {
            Debug.Log(letter); //så att alla chars man skriver med keyboarden kommer up i consolen
            wordManager.TypeLetter(letter);
        }
    }
}
