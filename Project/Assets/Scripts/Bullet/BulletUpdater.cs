using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletUpdater : IUpdater
{
    public void SystemUpdate()
    {
        TAccessor<BulletModule> BulAccessor = TAccessor<BulletModule>.Instance();
        
        foreach (var module in BulAccessor.GetAllModule())
        {
            if (Input.GetKeyDown("space"))
            {
                GameObject myEntity=module.gameObject;
                Vector3 V= new Vector3(myEntity.transform.position.x,myEntity.transform.position.y,myEntity.transform.position.z+0.5f);
                var tempBullet = UnityEngine.Object.Instantiate(module.Bullet,V,myEntity.transform.rotation);
                UnityEngine.Object.Destroy(tempBullet, 5);
            }
        }
        
    }
    
}
