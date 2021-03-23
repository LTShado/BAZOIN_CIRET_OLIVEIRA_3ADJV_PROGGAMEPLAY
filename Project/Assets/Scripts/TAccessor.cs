using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class TAccessor<T> where T: TModule
{
    static private TAccessor<T> _singleton;
    private List<T> _moduleList;
    static public TAccessor<T> Instance()
    {
        if (_singleton == null)
        {
            _singleton = new TAccessor<T>();
        }
        return _singleton;
    }
    
    public void Register(T t)
    {
        if (_moduleList == null)
        {
            _moduleList = new List<T>();
        }
        _moduleList.Add(t);
    }
    public void UnRegister(T t)
    {
        _moduleList.Remove(t);
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
