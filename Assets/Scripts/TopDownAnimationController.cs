using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownAnimationController : AnimationController
{
    private static readonly int IsWalk = Animator.StringToHash("IsWalk");
  

    public void Awake()
    {
        base.Awake();
    }

    // Start is called before the first frame update
    void Start()
    {
        controller.OnMoveEvent += Move;
    }
    private void Move(Vector2 obj)
    {
        animator.SetBool(IsWalk, obj.magnitude > 0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
