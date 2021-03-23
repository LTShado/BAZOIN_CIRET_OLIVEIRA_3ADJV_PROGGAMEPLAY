using System.Numerics;

public class MovementModule : TModule
{
    public float Speed;
    public Vector3 Direction;

    private void Awake()
    {
        TAccessor<MovementModule>.Instance().Register(this);
    }
    
}
