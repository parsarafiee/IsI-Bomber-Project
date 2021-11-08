using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationMng : MonoBehaviour
{

    public Animator anim;
    InputToV2EventSy inputV2;
    int numb;

    // Start is called before the first frame update
    void Start()
    {
        inputV2 = FindObjectOfType<InputToV2EventSy>();
    }
    public void AnimationDirection()
    {

            anim.SetInteger("D", numb);

       

    }

    // Update is called once per frame
    void Update()
    {
        numb = inputV2.animationNumber;


    }
}
