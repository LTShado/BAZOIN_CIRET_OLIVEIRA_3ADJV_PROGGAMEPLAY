using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMov : TModule
{
    public float Speed;
    
    private void Awake()
    {
        TAccessor<BulletMov>.Instance().Register(this);
    }
    private void OnDestroy()
    {
        TAccessor<BulletMov>.Instance().UnRegister(this);
    }
}
