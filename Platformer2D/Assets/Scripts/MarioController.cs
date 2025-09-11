using UnityEngine;
using UnityEngine.InputSystem;

public class MarioController : MonoBehaviour
{
    private MarioState marioState;

    private InputAction MoveInputAction;
    private InputAction RunInputAction;
    private InputAction JumpInputAction;
    private InputAction DuckInputAction;
    private InputAction UpInputAction;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        marioState = GetComponent<MarioState>();

        //get PlayerInput and InputActions
        PlayerInput input = GetComponent<PlayerInput>();
        MoveInputAction = input.actions["Move"];
        RunInputAction = input.actions["Run"];
        JumpInputAction = input.actions["Jump"];
        DuckInputAction = input.actions["Duck"];
        UpInputAction = input.actions["Up"];
    }//Start

    public float GetMoveValue()
    {
        return MoveInputAction.ReadValue<float>();
    }//GetMoveValue

    public bool IsRunPressed()
    {
        return RunInputAction.IsPressed();
    }//IsRunPressed

    public bool IsJumpPressed()
    {
        return JumpInputAction.IsPressed();
    }//IsJumpPressed

    public bool IsDuckPressed()
    {
        return DuckInputAction.IsPressed();
    }//IsDuckPressed

    public bool IsUpPressed()
    {
        return UpInputAction.IsPressed();
    }//IsUpPressed

    public void OnMove(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed || context.phase == InputActionPhase.Canceled)
        {
            float direction = context.ReadValue<float>();

            if (direction < 0.0f)
            {
                marioState.Direction = EMarioDirection.Left;

                Vector3 scale = transform.localScale;
                scale.x = -1.0f;
                transform.localScale = scale;
            }
            else if (direction > 0.0f)
            {
                marioState.Direction = EMarioDirection.Right;

                Vector3 scale = transform.localScale;
                scale.x = 1.0f;
                transform.localScale = scale;
            }
        }
    }//OnMove

    public void OnJump(InputAction.CallbackContext context)
    {
        if(context.phase == InputActionPhase.Performed || context.phase == InputActionPhase.Canceled)
        {
            float value = context.ReadValue<float>();

            //todo make jump
        }
    }//OnJump

    public void OnRun(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed || context.phase == InputActionPhase.Canceled)
        {
            float value = context.ReadValue<float>();

            //todo make run
        }
    }//OnRun

    public void OnDuck(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed || context.phase == InputActionPhase.Canceled)
        {
            float value = context.ReadValue<float>();

            //todo make duck
        }
    }//OnDuck

    public void OnUp(InputAction.CallbackContext context)
    {
        if (context.phase == InputActionPhase.Performed || context.phase == InputActionPhase.Canceled)
        {
            float value = context.ReadValue<float>();

            //todo make up
        }
    }//OnUp
}
