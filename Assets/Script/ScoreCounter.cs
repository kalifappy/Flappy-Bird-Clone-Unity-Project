using TMPro;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI score;
    [SerializeField] TextMeshProUGUI highScoreText;
    [SerializeField] public int Score_Count = 0;
    private int highScore = 0;
    Spawner spawner;

    // Start is called before the first frame update
    void Start()
    {
        spawner = FindFirstObjectByType<Spawner>();
        highScore = PlayerPrefs.GetInt("HighScore", 0);
        highScoreText.text = highScore.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        score.text = Score_Count.ToString();

        if (Score_Count > highScore)
        {
            highScore = Score_Count;
            PlayerPrefs.SetInt("HighScore", highScore);
            highScoreText.text = highScore.ToString();
        }

        if (Score_Count > 30)
        {
            spawner.spawner_Rate = 0.9f;
        }
        if (Score_Count > 50)
        {
            spawner.spawner_Rate = 0.8f;
        }
    }
}
