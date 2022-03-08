using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
public class player2cam : MonoBehaviour
{
    public float sensitivity;
    public Vector2 moveVal;
    public GameObject cam2;
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
        cam2.transform.Rotate(new Vector3(-moveVal.y * sensitivity, 0, 0));


    }
    void LateUpdate()
    {
        transform.position = transform.position + offset;
    }






}
