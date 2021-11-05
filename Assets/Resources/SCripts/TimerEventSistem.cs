using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class TimerEventSistem : MonoBehaviour
{
    public UnityEvent triggerTheEvent;
    public float timeToExplode;
    float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer> timeToExplode)
        {
            triggerTheEvent.Invoke();
        }
    }
}
