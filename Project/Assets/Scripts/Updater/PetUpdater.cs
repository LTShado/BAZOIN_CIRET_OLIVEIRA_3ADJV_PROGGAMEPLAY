using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor.PackageManager;
using UnityEditor.UIElements;
using UnityEngine;

public class PetUpdater : IUpdater
{
    public void SystemUpdate()
    {
        double angle = 180;
        TAccessor<PetModule> movAccessor = TAccessor<PetModule>.Instance();
        
        foreach (var module in movAccessor.GetAllModule())
        {
            GameObject myEntity=module.gameObject;
            angle *= Math.PI / 180;
            
            float xO = module.pwayer.position.x;
            float zO = module.pwayer.position.z;

            float xM = myEntity.transform.position.x - xO;
            float zM = myEntity.transform.position.z - zO;

            float X = (float)((xM * Math.Cos(angle)) + (zM * Math.Sin(angle)) + xO);
            float Z = (float)((-xM * Math.Sin(angle)) + (zM * Math.Cos(angle)) + zO);
            
            Debug.Log("X : "+X);
            Debug.Log("Z : "+Z+" le z");
            Debug.Log("Angle : "+angle);
            
            Vector3 move = new Vector3(X,0, Z) * Time.deltaTime;

            myEntity.transform.Translate(move);
            
        }
        
    }
}