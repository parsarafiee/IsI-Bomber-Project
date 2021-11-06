using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class DestructableTileMap : MonoBehaviour
{

    public Tilemap tilemap;
    public Grid grid;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void DestroyTileMap(int range, Vector3 pos)
    {
        Vector3Int position1 = grid.WorldToCell(pos);
        Debug.Log(position1);
        int[] a;
        int[] b;
        for (int i = -range; i < range; i++)
        {
            

        }
        //for (int x = -range; x < range; x++)
        //{
        //    a = x;
        //    for (int y = -range; y < range; y++)
        //    {
        //        b = y;
        //        if ((y > 0 || y < 0) && x != 0)
        //        {
        //            a = 0;
        //        }
        //        if ((x > 0 || x < 0) && y != 0)
        //        {
        //            b = 0;
        //        }
        //        Debug.Log(new Vector2(a,b));
        //       // tilemap.SetTile(position1+new Vector3Int(a,b,0), null);

        //    }
        //}

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
