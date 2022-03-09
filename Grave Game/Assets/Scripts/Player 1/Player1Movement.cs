using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player1Movement : MonoBehaviour
{
    public Vector2 moveVal;
    public float moveSpeed;
    public bool clicked;
    public Camera player1Cam;
    public Vector2 clickPosition;
    public bool pressed;
    
    void Start()
    {
        player1Cam =  GetComponentInChildren<Camera>();
        
    }

    void OnMove(InputValue value)
    {
        moveVal = value.Get<Vector2>();
    }

    void Update()
    {
        transform.Translate(new Vector3(moveVal.x, 0 , moveVal.y) * moveSpeed * Time.deltaTime);

        if (clicked)
        {
            Ray ray = player1Cam.ScreenPointToRay(clickPosition);
            RaycastHit hit; 
            if (Physics.Raycast(ray, out hit))
            {

                if(hit.transform.tag == "Grave")
                {
                    Debug.Log(hit.point);
                    hit.transform.GetComponent<gravedigging>().BeginDigging();
                }

            }
            clicked = false;
        }
        if (pressed)
        {

        }

    } 

 
    void OnClick()
    {
        clicked = !clicked;
    }
    void OnMouseposition(InputValue value)
    {
        clickPosition = value.Get<Vector2>();
    }

    void OnSpace()
    {
        pressed = !pressed;
    }

}
