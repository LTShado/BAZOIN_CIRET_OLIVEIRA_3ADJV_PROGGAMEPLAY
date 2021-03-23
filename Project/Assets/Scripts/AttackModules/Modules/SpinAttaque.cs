using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinAttaque : AttackModule
{
    public float Speed;
    public Vector3 Rotation;

    private void Awake()
    {
        TAccessor<AttackModule>.Instance().Register(this);
    }
}
