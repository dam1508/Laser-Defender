using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreDisplay : MonoBehaviour
{
    TextMeshProUGUI score;
    GameSession gameSession;
    // Start is called before the first frame update
    void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
        gameSession = FindObjectOfType<GameSession>();

    }

    // Update is called once per frame
    void Update()
    {
        //score.text = gameSession.GetScore().ToString();
        UpdateScore();
    }

    private void UpdateScore()
    {
        score.text = gameSession.GetScore().ToString();
    }
}
