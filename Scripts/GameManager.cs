using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField] private TextMeshPro textScore;
    public int Score 
    { 
        get => minScore; 
        set
        {
            if(value > minScore)
                minScore = value;
                textScore.SetText(minScore.ToString());
        }
    }

    private int minScore;


    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void Awake()
    {
        Instance = this;
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        Time.timeScale = 0;
    }
}
