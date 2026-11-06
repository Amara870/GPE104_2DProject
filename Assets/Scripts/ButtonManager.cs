using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void LoadScene(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
        Debug.Log("Loading scene: " + sceneName);
    }   

    public void QuitGame()
    {
        Application.Quit();
        #if UNITY_EDITOR
                // This line safely closes play mode inside the Unity Editor during testing
                UnityEditor.EditorApplication.isPlaying = false;
        #endif
    }

}
