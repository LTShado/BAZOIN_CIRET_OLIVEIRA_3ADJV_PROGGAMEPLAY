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
            
            float inputX = Input.GetAxis("Horizontal");
            float inputY = Input.GetAxis("Vertical");

            Vector3 move = new Vector3(module.Speed * inputX,0, module.Speed  * inputY) * Time.deltaTime;

            myEntity.transform.Translate(move);
            
        }
        
    }
}