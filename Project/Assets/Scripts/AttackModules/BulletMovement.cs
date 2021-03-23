using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMovement : MonoBehaviour
{ 
    List<ScriptableObject> Module;
    public MovementModule movecomponant;

    public Vector2 speed = new Vector2(10, 10);

    private void Start()
    {
        movecomponant = new MovementModule(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"),this.gameObject.transform);
        Module = new List<ScriptableObject>();
        Module.Add(movecomponant);
        TAccessor<MovementModule>.Instance().Add(movecomponant);
    }

    private void Update()
    {
        Vector3 move = new Vector3(speed.x,0, speed.y) * Time.deltaTime;
        transform.Translate(move);
    }
}