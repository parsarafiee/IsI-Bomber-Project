using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;


public class InputToV2EventSy : MonoBehaviour
{
    public UnityEvent<Vector2> dirPressed;
    public KeyCode up = KeyCode.W;
    public KeyCode down = KeyCode.S;
    public KeyCode right = KeyCode.D;
    public KeyCode left = KeyCode.A;

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
        if (Input.GetKey(left))
        {
            velo.x = -1;
        }
        if (Input.GetKey(right))
        {
            velo.x = 1;
        }
        if (Input.GetKey(up))
        {
            velo.y = 1;
        }
        if (Input.GetKey(down))
        {
            velo.y = -1;
        }

        dirPressed.Invoke(velo);

    }
}
