using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootSystem : IUpdater
{
    public void SystemUpdate()
    {
        TAccessor<ShootModule> mymodAccessor = TAccessor<ShootModule>.Instance();
        foreach (var ok in mymodAccessor.DisplayListT())
        {
            
        }
    }
}