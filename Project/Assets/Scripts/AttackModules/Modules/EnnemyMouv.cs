using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnnemyMouv : AttackModule
{
    public float Speed;
    public Vector3 Direction;

    private void Awake()
    {
        TAccessor<AttackModule>.Instance().Register(this);
    } 
}
