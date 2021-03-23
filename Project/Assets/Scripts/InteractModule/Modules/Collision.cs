using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : InteractModule
{
    public Vector3 Bullet;
    public Vector3 Ennemy;

    private void Awake()
    {
        TAccessor<InteractModule>.Instance().Register(this);
    }
}