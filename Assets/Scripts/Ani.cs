using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ani : MonoBehaviour
{
    public Animator anim;


    public void Walk(bool moveWalk)
    {

        anim.SetBool("IsWalk", moveWalk);

    }
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
