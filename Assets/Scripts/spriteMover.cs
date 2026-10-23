/* using UnityEngine;
using UnityEngine.InputSystem;

public class spriteMover : MonoBehaviour
{
    // global variables for the min and max range of the random values
    public Vector2 minRange;
    public Vector2 maxRange;

    public KeyCode teleportKey;
    public KeyCode escapeKey;
    
    private Transform tf;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        tf = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {

        // check if player is pressing the quit key
        if (Input.GetKey(escapeKey))
        {
            Debug.Log("Quit button pressed");
            Application.Quit();

            #if UNITY_EDITOR
            // This line safely closes play mode inside the Unity Editor during testing
            UnityEditor.EditorApplication.isPlaying = false;
            #endif
        }

        // check if the player is pressing the movement keys
        if (Input.GetKey(teleportKey)) {
            Debug.Log("Pressing movement keys");
            MoveSprites();
        }

    }

    // move sprites function
    void MoveSprites()
    {
        // find random x value
        float randomX = Random.Range(minRange.x, maxRange.x);
        // find random y value
        float randomY = Random.Range(minRange.y, maxRange.y);

        // apply the random position to the sprites
        tf.position = new Vector2(randomX, randomY);
    }
}
*/