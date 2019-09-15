
using UnityEngine;
using UnityEngine.UI;

public class Highscore : MonoBehaviour
{
    public static int number;
    public Text score;
    public Text highScore;

    
    void Start()
    {
        highScore.text = PlayerPrefs.GetInt("HighScore", 0).ToString();
    }

    // Update is called once per frame
  public void Scores()
    {
        number = Score.PinCount;
        score.text = number.ToString();
        

        if (number > PlayerPrefs.GetInt("HighScore", 0))
        {
            PlayerPrefs.SetInt("HighScore", number);
            highScore.text = number.ToString();
        }
    }

    public void Reset()
    {
        PlayerPrefs.DeleteKey("HighScore");
    }
}
