using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Initializer : MonoBehaviour
{

    public GameObject objectToInsntantiate;


    public void InitializeTheObject()
    {
        GameObject b = GameObject.Instantiate(objectToInsntantiate, this.transform.position, Quaternion.identity);
    }


    // Update is called once per frame
    void Update()
    {
          
    }
}
