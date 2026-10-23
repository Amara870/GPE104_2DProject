using System;
using UnityEngine;

public class DeathDestroy : Death
{

    public int scoreToAdd;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public override void Die()
    {
        if(GameManager.instance != null)
        {
            GameManager.instance.AddToScore(scoreToAdd);
        }
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
