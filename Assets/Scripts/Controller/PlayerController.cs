using UnityEngine;

public class PlayerController : Controller
{

    public KeyCode moveForwardKey;
    public KeyCode moveBackwardKey;
    public KeyCode rotateClockwiseKey;
    public KeyCode rotateCounterClockwiseKey;

    public KeyCode moveForwardWorldSpace;
    public KeyCode moveBackwardWorldSpace;
    public KeyCode moveLeftWorldSpace;
    public KeyCode moveRightWorldSpace;

    public KeyCode teleportKey;
    public KeyCode escapeKey;
    public KeyCode leftShift;
    public KeyCode rightShift;

    public float turbo;

    public override void Start()
    {

    }

    public override void Update()
    {
        base.Update();
    }

    public override void MakeDecisions()
    {
        if (Input.GetKey(leftShift) || Input.GetKey(rightShift))
        {
            pawn.moveSpeed = turbo; 
        }

        if(Input.GetKey(moveForwardKey))
        {
            pawn.Move(pawn.transform.up);
            Debug.Log("Up Key Pressed");
        }

        if(Input.GetKey(moveBackwardKey))
        {
            pawn.Move(-pawn.transform.up);
        }

        if(Input.GetKey(rotateClockwiseKey))
        {
            pawn.Rotate(-pawn.rotateSpeed);
        }

        if(Input.GetKey(rotateCounterClockwiseKey))
        {
            pawn.Rotate(pawn.rotateSpeed);
        }

        // World Space Movement
        if (Input.GetKeyDown(moveForwardWorldSpace))
        {
            pawn.MoveWorldSpace(Vector3.up);
        }
        
        if (Input.GetKeyDown(moveBackwardWorldSpace))
        {
            pawn.MoveWorldSpace(-Vector3.up);
        }

        if(Input.GetKeyDown(moveLeftWorldSpace))
        {
            pawn.MoveWorldSpace(-Vector3.right);
        }

        if(Input.GetKeyDown(moveRightWorldSpace))
        {
            pawn.MoveWorldSpace(Vector3.right);
        }

        // Teleportation
        if (Input.GetKeyDown(teleportKey))
        {
            pawn.Teleport();
        }

        // escape key to quit the application
        if (Input.GetKeyDown(escapeKey))
        {
            Debug.Log("Quit button pressed");
            Application.Quit();
            #if UNITY_EDITOR
            // This line safely closes play mode inside the Unity Editor during testing
            UnityEditor.EditorApplication.isPlaying = false;
            #endif
        }
    }
}
