using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementSystem : IUpdater
{
    public void SystemUpdate()
    {
        TAccessor<MovementModule> mymodAccessor = TAccessor<MovementModule>.Instance();
        foreach (var ok in mymodAccessor.DisplayListT())
        {
            ok.playerTransform.position += new Vector3(ok.SpeedX, 0,ok.SpeedY) * Time.deltaTime;
        }
    }
}
