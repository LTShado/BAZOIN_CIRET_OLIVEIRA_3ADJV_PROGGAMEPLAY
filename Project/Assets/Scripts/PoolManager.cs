using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[Serializable]
public struct ObjectForPool
{
    public ObjectType ObjectType;
    public PoolableObject Prefab;
    public int Number;
}
public class PoolManager : MonoBehaviour
{
    static public PoolManager Instance()
    {
        return _singleton;
    }

    static private PoolManager _singleton;

    private void Awake()
    {
        _singleton = this;
    }

    public List<ObjectForPool> ObjectForPoolList;
    private Dictionary<ObjectType, Pool> PoolDictionnary;

    public void Initialize()
    {
        PoolDictionnary = new Dictionary<ObjectType, Pool>();
        foreach (ObjectForPool obj in ObjectForPoolList)
        {
            Pool newPool = new Pool();
            newPool.Initialize(obj.Prefab, obj.Number);
            PoolDictionnary.Add(obj.ObjectType, newPool);
        }
    }

    public PoolableObject GetObjectInPool(ObjectType parObjectType)
    {
        Pool poolForObject;
        PoolDictionnary.TryGetValue(parObjectType, out poolForObject);
        if (poolForObject == null)
        {
            Debug.LogError("No pool for this object type");
            return null;
        }

        PoolableObject obj = poolForObject.GetObjectInPool();
        if (obj != null)
        {
            obj.Pull();
        }

        return obj;
    }

    public void ReleaseObjectInPool(PoolableObject obj)
    {
        obj.Release();
    }
}
