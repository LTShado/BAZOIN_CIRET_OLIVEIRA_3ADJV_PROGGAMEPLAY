using UnityEngine;

public class LinearMovement : MovementModule
{

    public float Speed;
    public Vector3 Direction;

    private void Awake()
    {
        TAccessor<MovementModule>.Instance().Register(this);
    }
}
