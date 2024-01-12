using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordGenerator : MonoBehaviour
{
    //alla ord som skappas 
    private static string[] wordList = { "ready", "academy", "pan", "powder", "pill", "forward", "insurance", "earth", "flax", "force",
"slump", "neck", "assembly", "strength", "avant-garde", "research", "morning", "secular", "obstacle",
 "stage", "fruit", "vain", "inflation", "oven", "watch", "decisive", "sentiment", "vacuum", "inside",
"folklore", "filter", "technique", "dominant", "memorial", "deputy", "voucher", "heel", "nationalist", "recognize", "hover"};

    public static string GetRandomWord () 
    {
        int randomIndex = Random.Range(0, wordList.Length); //använder random index för att plocka utt en string från "wordList"
        string randomWord = wordList[randomIndex];

        return randomWord;
    }
}
