using System.Collections;
using UnityEngine;
using TMPro;


public class ScoreUI : MonoBehaviour
{
    [SerializeField] private GameObject _scorePrefab;
    [SerializeField] private TMP_Text _scoreText;
    [SerializeField] private MotorbikeController _motorbikeController;
    public static ScoreUI Instance;

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

    public void CreateScore(int score)
    {
        var newScore = Instantiate(_scorePrefab).GetComponent<TextMesh>();        
        newScore.transform.parent = _motorbikeController.transform;
        newScore.transform.localPosition = Vector3.zero;
        newScore.text = $"+{score}";
        UpdateUI();
    }

    

    private void UpdateUI()
    {
        _scoreText.text = $"Score:{Score.Instance.GetScore()}";
    }
}