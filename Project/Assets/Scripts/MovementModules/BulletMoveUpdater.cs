using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletMoveUpdater : IUpdater
{
    public void SystemUpdate()
    {
        TAccessor<BulletMov> movAccessor = TAccessor<BulletMov>.Instance();
        
        foreach (var module in movAccessor.GetAllModule())
        {
            GameObject myEntity=module.gameObject;
            Vector3 move = new Vector3(0,0, module.Speed) * Time.deltaTime;
            myEntity.transform.Translate(move);
        }
        
    }
}
