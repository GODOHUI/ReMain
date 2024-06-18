using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    public event Action<Vector3> OnMoveEvent;

    public void CallMoveEvent(Vector3 direction)
    {
        // onMoveEvent는 public이어서 TopDownMovement에서 메소드들을 등록해놨음(a.k.a. 구독)
        OnMoveEvent?.Invoke(direction);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
