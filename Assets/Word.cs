using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // s� att variableran ska kunna vissas i unity inspectorn 
public class Word { //ingen componets utab bara en class

    public string word;
    private int typeIndex; //vilket bokstav man �r p�

    WordDisplay display;

    public Word (string _word, WordDisplay _dispay) // definerar vad som h�nder n�r vi skapar ett nytt ord 
    {
        word = _word;
        typeIndex = 0;

        display = _dispay;
        display.SetWord(word);//mata display ett ord
    }

    public char GetNextLetter ()
    {
        return word[typeIndex]; //vissar vilken index/bokstav du �r p�
    }

    public void TypeLetter ()
    {
        typeIndex++;
        //ta bort ordet du skrev 
        display.RemoveLetter(); //ta bort prefab
    }

    public bool WordTyped () //skapa sj�lva ta bort funktionen 
    {
        bool WordTyped = (typeIndex >= word.Length); //kolla om typeindexen (bokstaven man �r p�) �r st�rre eller = ordets Leangth (har man plussat p� "typeletter" s� mycket s� att det �r lika med eller st�rre en sj�lva ordets idnex)
        if (WordTyped)
        {
            //ta bort ordet
            display.RemoveWord(); //ta bort det fr�n sk�rmen
        }
        return WordTyped;
    }
}
