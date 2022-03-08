using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player1Movement : MonoBehaviour
{
    public Vector2 moveVal;
    public float moveSpeed;


    void Start()
    {
        
    }

    void OnMove(InputValue value)
    {
        moveVal = value.Get<Vector2>();
    }

    void Update()
    {
        transform.Translate(new Vector3(moveVal.x, 0 , moveVal.y) * moveSpeed * Time.deltaTime);



    } 

 


    
}
