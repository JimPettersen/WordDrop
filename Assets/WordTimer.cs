using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordTimer : MonoBehaviour
{
    public WordManager wordManager; //reference till wordmanager

    public float wordDelay = 1.5f; //tid mellan varje ord spawn
    private float nextWordTime = 0f; // n�r f�rsta ordet ska spawnas


    private void Update()
    {
        if (Time.time >= nextWordTime) // om tiden �r mer eller lika med tiden d�r vi vill spawna ett nytt ord 
        {
            wordManager.AddWord(); //l�gg till ett ord
            nextWordTime = Time.time + wordDelay; //set v�ran nextwordtime till tid plus v�ran worddelay allts� 0 +1.5 sek
            wordDelay *= .99f; //g�r s� att ord faller successivt snabbar desto l�ngre tid som har g�tt
        }
    }
}
