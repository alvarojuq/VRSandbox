using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUpdater : MonoBehaviour
{

    public float score = 0;

    public void AddScore(float newScore)
    {
        score += newScore;
    }

    public void RemoveScore(float newScore)
    {
        score -= newScore;
    }

    public void ResetScore()
    {
        score = 0;
    }

    public float GetScore()
    {
        return score;
    }
    
}
