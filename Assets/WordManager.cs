using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WordManager : MonoBehaviour
{
    public List<Word> words; // ska hålla alla våra ord och jag vill att det ska kunna hålla koll på lite statistik derför är det en annan class
    
    public WordSpawner wordSpawner; //referens till WordSpawner 

    private bool hasActiveWord;  //om du får börjar skriva på ett nytt ord som faller eller om du redan har börjat skriva på ett ord
    private Word ActiveWord;


    public void AddWord () // metoden som skapar orden 
    {
        Word word = new Word (WordGenerator.GetRandomWord(), wordSpawner.SpawnWord()); //använder GetRandomWord iställer för att jag ska skriva in manuelt och gör så att när ett ord läggs till, skapas också ett text element
        Debug.Log(word.word);

        words.Add(word);
    }
     
    public void TypeLetter (char letter) // för att definera vilket ord på skärmen du börjar skriva på ( börjar du skriva på ett ord kan du säklart inte byta)
    {
        if (hasActiveWord) //om spelaren redan har börjat skriva på ett ord
        {
            if (ActiveWord.GetNextLetter() == letter) //kolla om det ordet man skrev var det ord som var nästa i ordet och sedan ta bort den bokstaven
                ActiveWord.TypeLetter();
        }
        else
        {
            foreach (Word word in words)
            {
                if (word.GetNextLetter() == letter)//för att kolla om ordet du skrev vad orden som kommer näst på ordets index
                {
                    ActiveWord = word;
                    hasActiveWord = true; //om du skriver på ett ord
                    word.TypeLetter(); //plussar på ordets index med 1 
                    break;
                }
            }
        }
        if (hasActiveWord && ActiveWord.WordTyped()) //om ordet skrivs klart
        {
            hasActiveWord = false; 
            words.Remove(ActiveWord); //ta bort ordet från listan
            

        }


    }
}
