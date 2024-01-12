using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//anv�nder text eftersom text �r ett UI element

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public float fallspeed = 1f;

    public void SetWord (string word) //s� att ordet man ska skrivas displayas i form utav text
    {
        text.text = word;
    }
    public void RemoveLetter () //g�r s� att visuellt f�rsvinner varje bokstav
    {
        text.text = text.text.Remove(0, 1); //f�r att bara ta bort en bokstav fram�t
        text.color = Color.red; //helt enkelt blir bokstav r�d n�r den �r borta
    }
    public void RemoveWord ()
    {
        Destroy(gameObject);
    }

    private void Update() //g�r s� att prfaben r�r sig (ner)
    {
        transform.Translate(0f, -fallspeed * Time.deltaTime, 0f);
        if (text.transform.position.y <= -5f)

        // om ord faller under sk�rmen end game (mer som pause game)
        {
            Time.timeScale = 0;

}
    }

}
