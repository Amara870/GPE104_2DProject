using UnityEngine;

public class SpriteChanger : MonoBehaviour
{
    public SpriteRenderer theRenderer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        theRenderer = GetComponent<SpriteRenderer>();

        if (theRenderer != null)
        {
            theRenderer.color = Color.green;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
