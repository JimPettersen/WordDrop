using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour
{
    public WordManager wordManager; //reference till wordmanager

    public float wordDelay = 1.5f; //tid mellan varje ord spawn
    private float nextWordTime = 0f; // när första ordet ska spawnas


    private void Update()
    {
        if (Time.time >= nextWordTime) // om tiden är mer eller lika med tiden där vi vill spawna ett nytt ord 
        {
            wordManager.AddWord(); //lägg till ett ord
            nextWordTime = Time.time + wordDelay; //set våran nextwordtime till tid plus våran worddelay alltså 0 +1.5 sek
            wordDelay *= .99f; //gör så att ord faller successivt snabbar desto långre tid som har gått
        }
    }
}
