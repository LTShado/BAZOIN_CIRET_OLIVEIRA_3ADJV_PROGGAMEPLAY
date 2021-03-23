using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : AttackModule
{
    public Vector3 Spawn;

    private void Awake()
    {
        TAccessor<AttackModule>.Instance().Register(this);
    }
}
