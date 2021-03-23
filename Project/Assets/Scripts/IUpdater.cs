using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;
using UnityEngine.UI;

public interface IUpdater
{
    void SystemUpdate();
}
public class MyUpdater : IUpdater
{
    public void SystemUpdate()
    {
        TAccessor<MovementModule> movAccessor = TAccessor<MovementModule>.Instance();
        TAccessor<LinearMovement> linAccessor = TAccessor<LinearMovement>.Instance();
        foreach (var module in movAccessor.GetAllModule())
        {
            GameObject myEntity=module.gameObject;
            LinearMovement othermodule = linAccessor.TryGetModule(myEntity);
            if (othermodule != null)
            {
                myEntity.transform.Translate(othermodule.Direction);
            }
        }
        
    }
}