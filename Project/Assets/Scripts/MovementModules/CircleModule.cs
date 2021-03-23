using UnityEngine;

public class CircleModule : TModule
{
    public Transform pwayer;

    private void Awake()
    {
        TAccessor<CircleModule>.Instance().Register(this);
    }
    
}