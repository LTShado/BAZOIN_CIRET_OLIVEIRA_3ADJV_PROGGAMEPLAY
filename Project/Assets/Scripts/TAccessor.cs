using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TAccessor<T> 
{
    static public TAccessor<T> Instance()
    {
        return _singleton;
    }
    static private TAccessor<T> _singleton;

    List<T> moduleList;

    public TAccessor()
    {
        _singleton = this;
        moduleList = new List<T>();
    }

    public void Add(T para)
    {
        moduleList.Add(para);
    }

    public List<T> DisplayListT()
    {
        return moduleList;
    }
}