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

    public void Speak()
    {
        Debug.Log("I speak with no input");
    }

    public void Speak(string message)
    {
        Debug.Log(message);
    }

    public void Speak(int numToPrint)
    {
        Debug.Log("" + numToPrint);
    }
}
