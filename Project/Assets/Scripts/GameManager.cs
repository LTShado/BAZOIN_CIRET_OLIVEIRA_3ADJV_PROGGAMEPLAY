using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    private static GameManager _singleton;

    private static GameManager Instance()
    {
        return _singleton;
    }

    private List<IUpdater> UpdateList = new List<IUpdater>();

    private void Awake()
    {
        _singleton = this;
        new TAccessor<MovementModule>();
        new TAccessor<ShootModule>();
    }
    
    List<PoolableObject> objectPool;
    // Start is called before the first frame update
    void Start()
    {
        UpdateList.Add(new MovementSystem());
        UpdateList.Add(new ShootSystem());
        
        PoolManager poolManager = PoolManager.Instance();
        poolManager.Initialize();

        objectPool = new List<PoolableObject>();

        
    }

    // Update is called once per frame
    void Update()
    {
        foreach (var up in UpdateList)
        {
            up.SystemUpdate();
        }
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            PoolManager poolManager = PoolManager.Instance();
            foreach (PoolableObject obj in objectPool)
            {
                poolManager.ReleaseObjectInPool(obj);
            }
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            PoolManager poolManager = PoolManager.Instance();
            PoolableObject obj = poolManager.GetObjectInPool(ObjectType.Bullet);
            objectPool.Add(obj);
        }
    }
}
