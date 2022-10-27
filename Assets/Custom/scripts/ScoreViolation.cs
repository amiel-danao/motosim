using System.Collections;
using UnityEngine;

public class ScoreViolation : MonoBehaviour
{
    [SerializeField] private int _score;

    public void GiveScore()
    {
        Score.Instance.AddScore(_score);
    }
}
