using UnityEngine;
using UnityEngine.InputSystem;

public class SpriteDirections : MonoBehaviour
{
    public Vector3 worldPosition;
    // dynamically change the magnitude of the movement in the inspector
    public float magnitude;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        worldSpace();
    }
    void worldSpace()
    {
        // Get the world position of the sprite

        // check if the player is pressing the Up arrow key
        if (Keyboard.current.upArrowKey.wasPressedThisFrame)
        {
            worldPosition = transform.position;
            Debug.Log("Pressing Up arrow");
            // move sprite up in world space
            worldPosition += Vector3.up * magnitude * Time.deltaTime;
            // update the sprite's position in world space
            transform.position = worldPosition;
        }

        // check if the player is pressing the Right arrow key
        if (Keyboard.current.rightArrowKey.wasPressedThisFrame)
        {
            worldPosition = transform.position;
            Debug.Log("Pressing Right arrow");
            // move sprite right in world space
            worldPosition += Vector3.right * magnitude * Time.deltaTime;
            // update the sprite's position in world space
            transform.position = worldPosition;
        }

        // check if the player is pressing the Left arrow key
        if (Keyboard.current.leftArrowKey.wasPressedThisFrame)
        {
            worldPosition = transform.position;
            Debug.Log("Pressing Left arrow");
            // move sprite left in world space
            worldPosition += Vector3.left * magnitude * Time.deltaTime;
            // update the sprite's position in world space
            transform.position = worldPosition;
        }

        // check if the player is pressing the Down arrow key
        if (Keyboard.current.downArrowKey.wasPressedThisFrame)
        {
            worldPosition = transform.position;
            Debug.Log("Pressing Down arrow");
            // move sprite down in world space
            worldPosition += Vector3.down * magnitude * Time.deltaTime;
            // update the sprite's position in world space
            transform.position = worldPosition;
        }
    }
}
