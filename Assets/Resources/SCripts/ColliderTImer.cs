using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderTImer : MonoBehaviour
{
    public float  timeToHaveCollider;
    float timer = 0;
    public CircleCollider2D cr;
    // Start is called before the first frame update
    void Start()
    {
        cr.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timeToHaveCollider< timer)
        {
            cr.enabled = true;
        }
    }
}
