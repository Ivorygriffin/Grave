using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player1CameraMoveUp : MonoBehaviour
{

    public float sensitivity;
    public Vector2 moveVal;
    private Vector3 offset;

    public void Start()
    {
        offset = transform.position - transform.position;
    }
    private void OnCam(InputValue value)
    {
        moveVal = value.Get<Vector2>();
    }
    void FixedUpdate()
    {
        
        transform.Rotate( -transform.right * moveVal.y * sensitivity);



    }
    void LateUpdate()
    {
        transform.position = transform.position + offset;
    }


}