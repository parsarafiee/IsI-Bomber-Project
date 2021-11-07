using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BombEventSy : MonoBehaviour
{
    public UnityEvent<Transform> dropTheBomb;
    public Transform rightPos;
    public Transform leftPos;
    public KeyCode right = KeyCode.X;
    public KeyCode left = KeyCode.Z;
    [HideInInspector]public bool numberOfBombsAvalable;

    void FixedUpdate()
    {
        ReadKeyboard();
    }

    public void ReadKeyboard()
    {


        if (numberOfBombsAvalable && Input.GetKeyDown(left))
        {
            dropTheBomb.Invoke(leftPos);

        }    
    }
}
