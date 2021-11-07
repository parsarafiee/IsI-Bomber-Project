using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BombEventSy : MonoBehaviour
{
    public UnityEvent dropTheBomb;
    public KeyCode dropBomb = KeyCode.Space;
    
    [HideInInspector]public bool numberOfBombsAvalable;

    void Update()
    {
        ReadKeyboard();
    }

    public void ReadKeyboard()
    {


        if (numberOfBombsAvalable && Input.GetKeyDown(dropBomb) )
        {
            dropTheBomb.Invoke();

        }    
    }
}
