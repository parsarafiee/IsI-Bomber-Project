using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DestructableTileMap : MonoBehaviour
{

    public Tilemap tilemap;
    public Grid grid;
    public Tilemap undestructableTile;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void DestroyTileMap(int range, Vector3 pos)
    {
        Vector3Int position1 = grid.WorldToCell(pos);
        Debug.Log(position1);

        
        for (int i =1; i <= range; i++)
        {
            if (undestructableTile.GetTile(position1 + new Vector3Int(i, 0, 0)))
            {
                break;
            }
            if (tilemap.GetTile(position1 + new Vector3Int(i,0 , 0)) )
            {
                tilemap.SetTile(position1 + new Vector3Int(i,0, 0), null);
                break;
            }
            

        }

        for (int i =-1; i >= -range; i--)
        {
            if (undestructableTile.GetTile(position1 + new Vector3Int(i, 0, 0)))
            {
                break;
            }
            if (tilemap.GetTile(position1 + new Vector3Int(i, 0, 0)))
            {
                tilemap.SetTile(position1 + new Vector3Int(i,0, 0), null);
                break;
            }
        }

        for (int i = 1; i <= range; i++)
        {
            if (undestructableTile.GetTile(position1 + new Vector3Int(0, i, 0)))
            {
                break;
            }
            if (tilemap.GetTile(position1 + new Vector3Int(0, i, 0)))
            {
                tilemap.SetTile(position1 + new Vector3Int(0,i, 0), null);
                break;
            }
        }

        for (int i = -1; i >= -range; i--)
        {
            if (undestructableTile.GetTile(position1 + new Vector3Int(0, i, 0)))
            {
                break;
            }
            if (tilemap.GetTile(position1 + new Vector3Int(0, i, 0)))
            {
                tilemap.SetTile(position1 + new Vector3Int(0,i, 0), null);
                break;
            }
        }

    }


    // Update is called once per frame
    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Vector3 worldPoint = ray.GetPoint(-ray.origin.z / ray.direction.z);
        Vector3Int position = grid.WorldToCell(worldPoint);

        tilemap.SetTile(position, null);
    }
}
