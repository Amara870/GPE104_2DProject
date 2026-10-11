using UnityEngine;

public class helloWorld : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        string testVar = OutputHello();

        Debug.Log("Hello World");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string OutputHello()
    {
        return "Hello";
    }
}
