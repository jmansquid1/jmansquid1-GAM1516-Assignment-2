using UnityEngine;

public enum EMarioState : byte
{
    Idle,
    Walking,
    Running,
    Ducking,
    Jumping,
    Falling,
    Dead
}

public enum EMarioDirection : byte
{
    Left, 
    Right
}

public class MarioState : MonoBehaviour
{
    private EMarioState marioState = EMarioState.Idle;
    private EMarioDirection marioDirection = EMarioDirection.Right;

    private int runningMeter = 0;

    private bool isRunning = false;
    private bool isOnGround = true;


    public EMarioState State
    { 
        get { return marioState; }
        set { marioState = value; }
    }

    public EMarioDirection Direction
    {
        get { return marioDirection; }
        set { marioDirection = value; }
    }

    public float DirectionScalar
    {
        get { return Direction == EMarioDirection.Left ? -1.0f : 1.0f; }
    }

    public int RunningMeter
    {
        get { return runningMeter; }
        set { runningMeter = value; }
    }

    public bool IsRunning
    {
        get { return isRunning; }
        set { isRunning = value; }
    }

    public bool IsOnGround
    {
        get { return isOnGround; }
        set { isOnGround = value; }
    }
}