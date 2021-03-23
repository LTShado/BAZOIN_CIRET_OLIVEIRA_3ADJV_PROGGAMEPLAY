using UnityEngine;

public class PetModule : TModule
{
    public Transform pwayer;

    private void Awake()
    {
        TAccessor<PetModule>.Instance().Register(this);
    }
    
}