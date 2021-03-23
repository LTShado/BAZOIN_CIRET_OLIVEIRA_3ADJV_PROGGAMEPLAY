using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float speed;

    private void Start()
    {
        
    }

    private void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(speed * inputX,0, speed * inputY) * Time.deltaTime;

        transform.Translate(move);
    }
}
