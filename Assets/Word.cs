using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable] // så att variableran ska kunna vissas i unity inspectorn 
public class Word { //ingen componets utab bara en class

    public string word;
    private int typeIndex; //vilket bokstav man är på

    WordDisplay display;

    public Word (string _word, WordDisplay _dispay) // definerar vad som händer när vi skapar ett nytt ord 
    {
        word = _word;
        typeIndex = 0;

        display = _dispay;
        display.SetWord(word);//mata display ett ord
    }

    public char GetNextLetter ()
    {
        return word[typeIndex]; //vissar vilken index/bokstav du är på
    }

    public void TypeLetter ()
    {
        typeIndex++;
        //ta bort ordet du skrev 
        display.RemoveLetter(); //ta bort prefab
    }

    public bool WordTyped () //skapa själva ta bort funktionen 
    {
        bool WordTyped = (typeIndex >= word.Length); //kolla om typeindexen (bokstaven man är på) är större eller = ordets Leangth (har man plussat på "typeletter" så mycket så att det är lika med eller större en själva ordets idnex)
        if (WordTyped)
        {
            //ta bort ordet
            display.RemoveWord(); //ta bort det från skärmen
        }
        return WordTyped;
    }
}
