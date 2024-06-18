using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TopDownController : MonoBehaviour
{
    public event Action<Vector3> OnMoveEvent;

    public void CallMoveEvent(Vector3 direction)
    {
        // onMoveEvent�� public�̾ TopDownMovement���� �޼ҵ���� ����س���(a.k.a. ����)
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
