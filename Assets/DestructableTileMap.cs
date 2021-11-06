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
        List<Vector2> a = new List<Vector2>() ;
        List<Vector2> b = new List<Vector2>() ;
        
        
        for (int i = -range; i < range; i++)
        {
            a.Add(new Vector2( i, 0));
            b.Add(new Vector2(0, i));
        }
        a.AddRange(b);

        for (int i = 0; i < a.Count; i++)
        {
            tilemap.SetTile(position1 + new Vector3Int((int)a[i].x, (int)a[i].y ,0), null);
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
        //        

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
