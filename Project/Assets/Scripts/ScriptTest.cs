using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptTest : MonoBehaviour
{
    List<PoolableObject> objectPool;
    // Start is called before the first frame update
    void Start()
    {
        PoolManager poolManager = PoolManager.Instance();
        poolManager.Initialize();

        objectPool = new List<PoolableObject>();

        for (int i = 0; i < 10; ++i)
        {
            PoolableObject obj = poolManager.GetObjectInPool(ObjectType.Bullet);
            objectPool.Add(obj);
        }
        
        for (int i = 0; i < 5; ++i)
        {
            PoolableObject obj = poolManager.GetObjectInPool(ObjectType.Ennemy);
            objectPool.Add(obj);
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PoolManager poolManager = PoolManager.Instance();
            foreach (PoolableObject obj in objectPool)
            {
                poolManager.ReleaseObjectInPool(obj);
            }
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            PoolManager poolManager = PoolManager.Instance();
            PoolableObject obj = poolManager.GetObjectInPool(ObjectType.Ennemy);
            objectPool.Add(obj);
        }
        if (Input.GetKeyDown(KeyCode.Z))
        {
            PoolManager poolManager = PoolManager.Instance();
            PoolableObject obj = poolManager.GetObjectInPool(ObjectType.Bullet);
            objectPool.Add(obj);
        }

    }
}
