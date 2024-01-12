using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WordSpawner : MonoBehaviour
{

    public GameObject wordPrefab; //sj�lva text prefaben
    public Transform wordCanvas; //f�r att dom ska hoppa in i Canvasen
   public WordDisplay SpawnWord () //inte ett void f�r att vi ska kunna n� den fr�n "WordManager"
    {
        Vector3 randomPosition = new Vector3(Random.Range(-4.5f, 4.5f), 4.5f);

        GameObject wordObj = Instantiate(wordPrefab, randomPosition, Quaternion.identity, wordCanvas);//f�r att skapa object under sj�lva runtimen och f�r att den ska koppa upp p� canvasen och att varje object ska spawna randomly utan rotation
       WordDisplay wordDisplay = wordObj.GetComponent<WordDisplay>();

        return wordDisplay;
    }
}
