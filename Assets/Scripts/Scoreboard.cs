using UnityEngine;
using TMPro;

public class Scoreboard : MonoBehaviour
{
    int score = 0;
    [SerializeField] TMP_Text scoreboardText;

    public void increaseScore(int amount)
    {
        score += amount;
        scoreboardText.text = score.ToString();
        //problem i want to call this method everytime
        //enemy ship is destroyed and update the score text
    }
}
