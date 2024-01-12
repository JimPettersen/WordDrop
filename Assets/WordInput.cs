using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordInput : MonoBehaviour//f�r att programmet ska veta att keyboardet �r inputen
{
    public WordManager wordManager;

    void Update()
    {
       foreach(char letter in Input.inputString)
        {
            Debug.Log(letter); //s� att alla chars man skriver med keyboarden kommer up i consolen
            wordManager.TypeLetter(letter);
        }
    }
}
