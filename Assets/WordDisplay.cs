using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;//använder text eftersom text är ett UI element

public class WordDisplay : MonoBehaviour
{
    public Text text;
    public float fallspeed = 1f;

    public void SetWord (string word) //så att ordet man ska skrivas displayas i form utav text
    {
        text.text = word;
    }
    public void RemoveLetter () //gör så att visuellt försvinner varje bokstav
    {
        text.text = text.text.Remove(0, 1); //för att bara ta bort en bokstav framåt
        text.color = Color.red; //helt enkelt blir bokstav röd när den är borta
    }
    public void RemoveWord ()
    {
        Destroy(gameObject);
    }

    private void Update() //gör så att prfaben rör sig (ner)
    {
        transform.Translate(0f, -fallspeed * Time.deltaTime, 0f);
        if (text.transform.position.y <= -5f)

        // om ord faller under skärmen end game (mer som pause game)
        {
            Time.timeScale = 0;

}
    }

}
