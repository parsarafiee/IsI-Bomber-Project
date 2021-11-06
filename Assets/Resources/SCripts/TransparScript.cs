using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransparScript : MonoBehaviour
{

    public float timeToTranspar=3;
    SpriteRenderer[] mr;
    float fadeTimer = 0;

    private void Start()
    {
        mr = this.gameObject.GetComponentsInChildren<SpriteRenderer>();

    }
    public void Update()
    {
        fadeTimer += Time.deltaTime;

        for (int i = 0; i < mr.Length; i++)
        {
            mr[i].color = Color.Lerp(Color.white, new Color(1, 1, 1, 0), fadeTimer / timeToTranspar);
        }
        if (fadeTimer> timeToTranspar)
        {
            GameObject.Destroy(gameObject);
        }
    }
    public void Transparency()
    {

    }
}
