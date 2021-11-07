using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{

    public GameObject objectToInsntantiate;
    


    public void InitializeTheObject(Transform tr)
    {
        Debug.Log("ali");
        GameObject b = GameObject.Instantiate(objectToInsntantiate, tr.position, Quaternion.identity);
        b.tag = "Player";
        
    }


    // Update is called once per frame
    void Update()
    {
          
    }
}
