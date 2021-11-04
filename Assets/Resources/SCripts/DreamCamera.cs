using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DreamCamera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform camera;
    public float parallax;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = camera.transform.position / parallax;


    }
}
