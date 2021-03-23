using UnityEngine;

public class MovementModule: ScriptableObject
{
    public float SpeedX;
    public float SpeedY;
    public Transform playerTransform;

    public void Speedx(float speedx)
    {
        this.SpeedX = speedx;
    }

    public void Speedy(float speedy)
    {
        this.SpeedY = speedy;
    }
    public MovementModule(float speedx,float speedy, Transform playerTransform)
    {
        this.SpeedX = speedx;
        this.SpeedY = speedy;
        this.playerTransform = playerTransform;
    }
}
