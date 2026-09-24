using UnityEngine;
using UnityEngine.InputSystem;

public class ScriptLocalSpace : MonoBehaviour
{
    public Vector3 localPosition;
    public float magnitude;
    public float turbo;

    private float prevMagnitude;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        localSpace();
        turboSpeed();
    }

    void localSpace()
    {
        // Get the local position of the sprite

        // check if the player is pressing the W key
        if (Keyboard.current.wKey.isPressed)
        {
            localPosition = transform.localPosition;
            // Moves the object up relative to its own local space
            transform.Translate(Vector3.up * magnitude * Time.deltaTime, Space.Self);
            Debug.Log("W Key Pressed");
        }

        // check if the player is pressing the A key
        if (Keyboard.current.aKey.isPressed)
        {
            localPosition = transform.localPosition;
            // Moves the object left relative to its own local space
            transform.Translate(Vector3.left * magnitude * Time.deltaTime, Space.Self);
            Debug.Log("A Key Pressed");
        }

        // check if the player is pressing the S key
        if (Keyboard.current.sKey.isPressed)
        {
            localPosition = transform.localPosition;
            // Moves the object down relative to its own local space
            transform.Translate(Vector3.down * magnitude * Time.deltaTime, Space.Self);
            Debug.Log("S Key Pressed");
        }

        // check if the player is pressing the D key
        if (Keyboard.current.dKey.isPressed)
        {
            localPosition = transform.localPosition;
            // Moves the object right relative to its own local space
            transform.Translate(Vector3.right * magnitude * Time.deltaTime, Space.Self);
            Debug.Log("D Key Pressed");
        }
    }

    void turboSpeed()
    {
        // check if the player is pressing the Left Shift key
        if (Keyboard.current.leftShiftKey.isPressed || Keyboard.current.rightShiftKey.isPressed)
        {
            prevMagnitude = magnitude;
            magnitude = turbo;
            Debug.Log("Shift Key Pressed");
        }
    }
}
