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
    public 


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


        // make raycast to see if its collide with anything to destroy +
        //Collider2D[] hitObjectArrayRight = Physics2D.OverlapBoxAll(this.transform.position, Vector2.right,0);
        //Collider2D[] hitObjectArrayDown = Physics2D.OverlapBoxAll(this.transform.position, 0), Vector2.down,0);
        //hitObjectArrayRight = hitObjectArrayRight.Concat(hitObjectArrayDown).ToArray();
        //for (int i = 0; i < hitObjectArrayRight.Length; i++)
        //{
        //    var v = hitObjectArrayRight[i];
        //    Debug.Log(hitObjectArrayRight[i].collider.name);
        //}

        GameObject.Destroy(gameObject);
    }
}
