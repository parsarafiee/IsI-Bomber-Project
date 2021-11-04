using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoombScript : MonoBehaviour
{    
    // Start is called before the first frame update

    public float InputTimeToExpload = 3;
    public float explosionRadius =1;
    float timer=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer> InputTimeToExpload)
        {
            Expload();
            this.gameObject.SetActive(false);
        }
    }

    void Expload() {
        Collider2D[] hitObjectArray = Physics2D.OverlapCircleAll(this.transform.position, explosionRadius);
        for (int i = 0; i < hitObjectArray.Length; i++)
        {
            Debug.Log(hitObjectArray[i].name);
        }                                                                      
    }
}
