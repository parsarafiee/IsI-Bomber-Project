using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BombEventSy : MonoBehaviour
{
    public UnityEvent dropTheBomb;
    public KeyCode dropBombKey = KeyCode.Space;
    [HideInInspector]public bool numberOfBombsAvalable;

    void Update()
    {
        ReadKeyboard();
    }

    public void ReadKeyboard()
    {

        if (numberOfBombsAvalable&&Input.GetKeyDown(dropBombKey))
        {
            dropTheBomb.Invoke();

        }
    }
}
