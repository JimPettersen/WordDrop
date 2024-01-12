using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GAMEOVERScript : MonoBehaviour
{

    public GameObject prefab;
    public Vector3 position;
    GameObject obj;
    private void Update()
    {
        if(Time.timeScale == 0 && !obj)
        {
            Transform parent = GameObject.FindGameObjectWithTag("Finish").transform;
            obj = Instantiate(prefab, position, Quaternion.identity);
            obj.transform.parent = parent;
        }
    }

    public void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawSphere(position, 1f);
    }
}
