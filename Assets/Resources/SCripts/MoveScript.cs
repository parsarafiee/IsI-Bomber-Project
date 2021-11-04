using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    // Start is called before the first frame update

    public float speed;
    public Rigidbody2D rb;
    
    public void MoveVlo(Vector2 move)
    {
        
        rb.velocity = move * speed;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
