using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAnimationController : AnimationController
{
    private static readonly int IsWalk = Animator.StringToHash("IsWalk");
  

    private readonly float magnituteThreshold = 0.5f;


    private void Awake()
    {
        base.Awake();
    }

    // Start is called before the first frame update
    void Start()
    {
        controller.OnMoveEvent += Move;
    }
    private void Move(Vector3 obj)
    {
        animator.SetBool(IsWalk, obj.magnitude > magnituteThreshold);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
