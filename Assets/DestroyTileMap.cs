using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DestroyTileMap : MonoBehaviour
{
    public Grid m_level;
    public Tilemap destructableTile;
    public int explosionRange;
    void Start()
    {

    }

    public void Destroy()
    {
        Vector3Int position = m_level.WorldToCell(gameObject.transform.position);
        for (int x = -explosionRange; x < explosionRange; x++)
        {
            for (int y = -explosionRange; y < explosionRange; y++)
            {
                if ((y > 0 ||y<0) && x !=0)
                {
                    x = 0;
                }
                if ((x > 0 || x < 0) && y !=0)
                {
                    y = 0;
                }
                destructableTile.SetTile(new Vector3Int(x,y,0), null);

            }
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
