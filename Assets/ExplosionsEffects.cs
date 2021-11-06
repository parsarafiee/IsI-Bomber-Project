using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ExplosionsEffects : MonoBehaviour
{
    public int explosionRange;

    DestructableTileMap dt;
    // Start is called before the first frame update
    void Awake()
    {
        dt=FindObjectOfType<DestructableTileMap>();

    }

    public void ExplodeTileMap()
    {
        dt.DestroyTileMap(explosionRange, gameObject.transform.position);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
