using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class WordManager : MonoBehaviour
{
    public List<Word> words; // ska h�lla alla v�ra ord och jag vill att det ska kunna h�lla koll p� lite statistik derf�r �r det en annan class
    
    public WordSpawner wordSpawner; //referens till WordSpawner 

    private bool hasActiveWord;  //om du f�r b�rjar skriva p� ett nytt ord som faller eller om du redan har b�rjat skriva p� ett ord
    private Word ActiveWord;


    public void AddWord () // metoden som skapar orden 
    {
        Word word = new Word (WordGenerator.GetRandomWord(), wordSpawner.SpawnWord()); //anv�nder GetRandomWord ist�ller f�r att jag ska skriva in manuelt och g�r s� att n�r ett ord l�ggs till, skapas ocks� ett text element
        Debug.Log(word.word);

        words.Add(word);
    }
     
    public void TypeLetter (char letter) // f�r att definera vilket ord p� sk�rmen du b�rjar skriva p� ( b�rjar du skriva p� ett ord kan du s�klart inte byta)
    {
        if (hasActiveWord) //om spelaren redan har b�rjat skriva p� ett ord
        {
            if (ActiveWord.GetNextLetter() == letter) //kolla om det ordet man skrev var det ord som var n�sta i ordet och sedan ta bort den bokstaven
                ActiveWord.TypeLetter();
        }
        else
        {
            foreach (Word word in words)
            {
                if (word.GetNextLetter() == letter)//f�r att kolla om ordet du skrev vad orden som kommer n�st p� ordets index
                {
                    ActiveWord = word;
                    hasActiveWord = true; //om du skriver p� ett ord
                    word.TypeLetter(); //plussar p� ordets index med 1 
                    break;
                }
            }
        }
        if (hasActiveWord && ActiveWord.WordTyped()) //om ordet skrivs klart
        {
            hasActiveWord = false; 
            words.Remove(ActiveWord); //ta bort ordet fr�n listan
            

        }


    }
}
