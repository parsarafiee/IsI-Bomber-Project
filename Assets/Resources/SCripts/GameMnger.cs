using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMnger : MonoBehaviour
{
    public BombEventSy bombSy;
    public int playerNumberOfBomb;
    
    List<GameObject> playertag = new List<GameObject>();
    BoombScript[] bombScrpts;

    void Update()
    {
        CheckNumberOfBombs();


    }
    void CheckNumberOfBombs()
    {
        playertag.Clear();
        bombScrpts = FindObjectsOfType<BoombScript>();
        for (int i = 0; i < bombScrpts.Length; i++)
        {
            if (bombScrpts[i].tag == "Player")
            {
                playertag.Add(bombScrpts[i].gameObject);
            }
        }

        if (playertag.Count < playerNumberOfBomb)
        {
            bombSy.numberOfBombsAvalable = true;
        }
        else
        {
            bombSy.numberOfBombsAvalable = false;
        }

    }
}
