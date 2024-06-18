using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.XR;
using static UnityEditor.Timeline.TimelinePlaybackControls;

public class Player : MonoBehaviour
{
    private Rigidbody rb;
    public float moveSpeed; // 스피드 변수
    private Vector3 curMovementInput;
   

    // Start is called before the first frame update
    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
     
    }
    void Start()
    {
        
       
    }

    private void FixedUpdate()
    {
        Move();
    }

  

  
    

    private void Move()
    {
        Vector3 dir = transform.forward * curMovementInput.y + transform.right * curMovementInput.x;
     
        dir *= moveSpeed;
        
        dir.y = rb.velocity.y; 

        rb.velocity = dir;


    }


    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed) //키를 눌렀을때 Performed동시에 눌려도 가능하게
        {
            curMovementInput = context.ReadValue<Vector2>();

        }
        else if (context.phase == InputActionPhase.Canceled)  //키를 놨을때 
        {
            curMovementInput = Vector2.zero;      // 멈춰라
        }
      

    }
    public void GameOver()
    {
        Debug.Log("GameOver");
        Time.timeScale = 0f;

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.layer ==6)
        {

        GameOver();
        }
       


    }
}
