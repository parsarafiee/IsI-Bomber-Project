using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class BombEventSy : MonoBehaviour
{
    public UnityEvent dropTheBomb;
    public KeyCode dropBombKey = KeyCode.Space;
    public int numberOfBombsAvalable;

    void Update()
    {
        ReadKeyboard();
    }

    public void ReadKeyboard()
    {
        if (numberOfBombsAvalable>0&&Input.GetKeyDown(dropBombKey))
        {
            dropTheBomb.Invoke();
        }
    }
}
