using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{

    public GameObject wordPrefab; //själva text prefaben
    public Transform wordCanvas; //för att dom ska hoppa in i Canvasen
   public WordDisplay SpawnWord () //inte ett void för att vi ska kunna nå den från "WordManager"
    {
        Vector3 randomPosition = new Vector3(Random.Range(-4.5f, 4.5f), 4.5f);

        GameObject wordObj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, wordCanvas);//för att skapa object under själva runtimen och för att den ska koppa upp på canvasen och att varje object ska spawna randomly utan rotation
       WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

        return wordDisplay;
    }
}
