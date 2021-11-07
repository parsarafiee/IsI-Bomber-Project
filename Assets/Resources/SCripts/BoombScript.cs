using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class BoombScript : MonoBehaviour
{    
    // Start is called before the first frame update

    public float explosionRadius =1;
    public GameObject explosionSprite;
    public float bombExplosionSpriteTimeAlive = 3;


    bool bombExploaded;
   // float timer=0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Expload() {
        GameObject _explosionSprite = GameObject.Instantiate(explosionSprite, transform.position, Quaternion.identity);
        GameObject.Destroy(gameObject);
    }
}
