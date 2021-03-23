using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletModule : TModule
{
    public GameObject Bullet;

    private void Awake()
    {
        TAccessor<BulletModule>.Instance().Register(this);
    }

    private void OnDestroy()
    {
        TAccessor<BulletModule>.Instance().UnRegister(this);
    }
}
