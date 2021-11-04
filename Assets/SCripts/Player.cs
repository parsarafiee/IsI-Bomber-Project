using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb;
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ReadKeyboard();
    }

    void ReadKeyboard()
    {
        Vector2 velo = new Vector2(0, 0);
        if (Input.GetKey(KeyCode.A))
        {
            velo.x = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            velo.x = 1;
        }
        if (Input.GetKey(KeyCode.W))
        {
            velo.y = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            velo.y = -1;
        }
        rb.velocity = velo;

    }
}
