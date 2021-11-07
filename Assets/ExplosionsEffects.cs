using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ExplosionsEffects : MonoBehaviour
{
    public int explosionRange;
    public LayerMask layermask;

    bool exploaded;
    DestructableTileMap dt;

    // Start is called before the first frame update
    void Awake()
    {
        dt=FindObjectOfType<DestructableTileMap>();
    }

    public void ExplodeTileMap()
    {
        exploaded = true;
        dt.DestroyTileMap(explosionRange, gameObject.transform.position);
    }
    public void DestroyObjects()       
    {

    }




    // Update is called once per frame
    void Update()
    {
        if (exploaded)
        {
            DestroyObjects();
        }
        
    }
}
