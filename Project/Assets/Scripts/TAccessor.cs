using System.Collections.Generic;
using UnityEngine;
using System;

public class Accessor<T> where T: TModule
{

    static public Accessor<T> Instance() { return _singleton; }
    static private Accessor<T> _singleton;

    private List<T> _moduleList;

    public void Register(T t)
    {
        _moduleList.Add(t);
    }

    private void Awake()
    {
        _singleton = this;
        _moduleList = new List<T>();
    }

    public List<T> GetAllModule()
    {

        return _moduleList;
        
    }

    public T TryGetModule(GameObject entity)
    {
        T component;
        entity.TryGetComponent(out component);
        return component;
    }
    
}
