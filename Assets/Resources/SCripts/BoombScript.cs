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
    float timer=0;
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
        RaycastHit2D[] hitObjectArrayRight = Physics2D.RaycastAll(this.transform.position+new Vector3(-explosionRadius,0,0), Vector2.right, explosionRadius*2);
        RaycastHit2D[] hitObjectArrayDown = Physics2D.RaycastAll(this.transform.position + new Vector3(0, +explosionRadius, 0), Vector2.down, explosionRadius*2);
        hitObjectArrayRight = hitObjectArrayRight.Concat(hitObjectArrayDown).ToArray();
        for (int i = 0; i < hitObjectArrayRight.Length; i++)
        {
            var v = hitObjectArrayRight[i];
            Debug.Log(hitObjectArrayRight[i].collider.name);
        }

        GameObject.Destroy(gameObject);
    }
}
