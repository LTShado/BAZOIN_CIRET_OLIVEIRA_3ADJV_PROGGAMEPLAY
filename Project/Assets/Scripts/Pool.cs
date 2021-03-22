using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ObjectType
{
    Ennemy,
    Bullet,
    Player
}

public class Pool
{
    private List<PoolableObject> objectInPool;

    public void Initialize(PoolableObject parPrefabObject, int parNumber)
    {
        objectInPool = new List<PoolableObject>();
        for (int i = 0; i < parNumber; ++i)
        {
            PoolableObject obj = MonoBehaviour.Instantiate(parPrefabObject);
            obj.Release();
            objectInPool.Add(obj);
        }
    }

    public PoolableObject GetObjectInPool()
    {
        foreach (PoolableObject obj in objectInPool)
        {
            if (!obj.Active())
            {
                return obj;
            }
        }
        
        Debug.LogError("Warning, object outside");
        return null;
    }
}