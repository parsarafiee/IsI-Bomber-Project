using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public Rigidbody2D rb;
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
        if (Input.GetKeyDown(KeyCode.A))
        {
            rb.velocity = new Vector3(1f, 0, 0);
        }
    }
}
