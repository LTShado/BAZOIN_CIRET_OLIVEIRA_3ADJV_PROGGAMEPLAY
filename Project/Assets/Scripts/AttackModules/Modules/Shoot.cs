using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : AttackModule
{
    public float Speed;
    public Vector3 Bullet;

    private void Awake()
    {
        TAccessor<AttackModule>.Instance().Register(this);
    }
}