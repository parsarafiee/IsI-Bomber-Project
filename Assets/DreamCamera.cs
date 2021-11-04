using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCamera : MonoBehaviour
{
    // Start is called before the first frame update

    public Transform background;
    public Transform player;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = player.transform.position +new Vector3(0, 0, -1);
        background.transform.position = this.transform.position / 3;


    }
}
