using UnityEngine;

public class DeathDestroy : Death
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Die()
    {
        // Destroy the game object this script is attached to
        Destroy(gameObject);
    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
