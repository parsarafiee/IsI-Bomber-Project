using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class ExplosionsEffects : MonoBehaviour
{
    public int explosionRange;
    public string[] TagList = { "Player", "Enemy" };

    bool exploaded;
    DestructableTileMap dt;



    // Start is called before the first frame update
    void Awake()
    {
        //for (int i = 0; i < TagList.Length; i++)
        //{
        //    Debug.Log(TagList[i]);
        //}
        dt = FindObjectOfType<DestructableTileMap>();
    }

    public void ExplodeTileMap()
    {
        //exploaded = true;
        dt.DestroyTileMap(explosionRange, gameObject.transform.position);
    }
    public void DestroyObjects()
    {
        for (int j = 0; j <= explosionRange; j++)
        {
            RaycastHit2D p = Physics2D.BoxCast(transform.position + new Vector3(j, 0, 0), new Vector2(1, 1), 0, Vector2.right);
            if (p.collider.name == "Indestructible"|| p.collider.name == "Destructible")
            {
                break;
            }
            foreach (var item in TagList)
            {
                if (p.collider.tag == item)
                {
                    GameObject.Destroy(p.collider.gameObject);
                }

            }
        }
        for (int j = 0; j >= -explosionRange; j--)
        {
            RaycastHit2D p = Physics2D.BoxCast(transform.position + new Vector3(j, 0, 0), new Vector2(1, 1), 0, Vector2.left);
            if (p.collider.name == "Indestructible" || p.collider.name == "Destructible")
            {
                break;
            }
            foreach (var item in TagList)
            {
                if (p.collider.tag == item)
                {
                    GameObject.Destroy(p.collider.gameObject);
                }

            }

        }
        for (int j = 0; j <= explosionRange; j++)
        {
            RaycastHit2D p = Physics2D.BoxCast(transform.position + new Vector3(0, j, 0), new Vector2(1, 1), 0, Vector2.up);
            if (p.collider.name == "Indestructible" || p.collider.name == "Destructible")
            {
                Debug.Log("Hit Wall");
                break;
            }
            foreach (var item in TagList)
            {
                if (p.collider.tag == item)
                {
                    Debug.Log("Hit: " + p.collider.name);
                    GameObject.Destroy(p.collider.gameObject);
                }

            }
        }
        for (int j = 0; j >= -explosionRange; j--)
        {
            RaycastHit2D p = Physics2D.BoxCast(transform.position + new Vector3(0, j, 0), new Vector2(1, 1), 0, Vector2.down);
            if (p.collider.name == "Indestructible" || p.collider.name == "Destructible")
            {
                break;
            }

            foreach (var item in TagList)
            {
                if (p.collider.tag == item)
                {
                    GameObject.Destroy(p.collider.gameObject);
                }

            }
                

        }

    }




    // Update is called once per frame
    void Update()
    {


    }
}
