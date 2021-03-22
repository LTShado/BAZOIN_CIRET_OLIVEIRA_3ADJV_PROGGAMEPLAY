using UnityEngine;

public class LinearMovement : MovementModule
{

    public float Speed;
    public Vector3 Direction;

    private void Awake()
    {
        Accessor<MovementModule>.Instance().Register(this);
    }
}
