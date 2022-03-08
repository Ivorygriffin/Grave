using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class Player1Cam : MonoBehaviour
{
    public float sensitivity;
    public Vector2 moveVal;
    public GameObject cam1;
    private Vector3 offset;

    public void Start()
    {
        Cursor.lockState = CursorLockMode.Confined;
        offset = transform.position - transform.position;
    }
    private void OnCam(InputValue value)
    {
        moveVal = value.Get<Vector2>();
    }
    void FixedUpdate()
    {

        transform.Rotate(transform.up * moveVal.x * sensitivity);
        cam1.transform.Rotate(new Vector3(-moveVal.y * sensitivity, 0, 0) );


    }
    void LateUpdate()
    {
        transform.position = transform.position + offset;
    }

}
