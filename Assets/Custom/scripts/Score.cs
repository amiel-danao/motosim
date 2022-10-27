using System.Collections;
using UnityEngine;


public class Score : MonoBehaviour
{
    private int _totalScore;
    public static Score Instance;
    public void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
        }

    }

    public int GetScore()
    {
        return _totalScore;
    }
    public void AddScore(int add)
    {
        _totalScore += add;
        ScoreUI.Instance.CreateScore(add);
    }
}