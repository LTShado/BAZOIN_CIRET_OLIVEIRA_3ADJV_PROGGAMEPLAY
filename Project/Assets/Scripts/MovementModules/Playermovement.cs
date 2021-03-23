using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{ 
    List<ScriptableObject> Module;
    public MovementModule movecomponant;

    public Vector2 speed = new Vector2(10, 10);

    private void Start()
    {
        movecomponant = new MovementModule(speed.x * Input.GetAxis("Horizontal"), speed.y * Input.GetAxis("Vertical"),
            this.gameObject.transform);
        Module = new List<ScriptableObject>();
        Module.Add(movecomponant);
        TAccessor<MovementModule>.Instance().Add(movecomponant);
    }

    private void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        Vector3 move = new Vector3(speed.x * inputX,0, speed.y * inputY) * Time.deltaTime;
        
        transform.Translate(move);
    }
}
