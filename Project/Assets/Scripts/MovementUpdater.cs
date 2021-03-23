using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class MovementUpdater : IUpdater
{
    public void SystemUpdate()
    {
        TAccessor<MovementModule> movAccessor = TAccessor<MovementModule>.Instance();
        foreach (var module in movAccessor.GetAllModule())
        {
            GameObject myEntity=module.gameObject;
            
            //myEntity.transform.position= ;
            
        }
        
    }
}