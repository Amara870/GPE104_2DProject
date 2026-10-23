using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public PlayerController playerController;

    public List<Asteroid> asteroidList;

    public int score;

    // create UI variable to grab UI element
    private TextMeshProUGUI ScoreValue;

    public void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        asteroidList = new List<Asteroid>();
    }
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerController.pawn == null)
        {
            Debug.Log("Game Over!");
        }
    }

    public void AddToScore(int scoreToAdd)
    {
        score += scoreToAdd;

        // Grab the UI element from the scene
        ScoreValue = GameObject.Find("ScoreValue").GetComponent<TextMeshProUGUI>();

        // Convert the int to a string and set the text of the UI element to the new score
        ScoreValue.text = score.ToString();
    }
}
