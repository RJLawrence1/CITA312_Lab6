using UnityEngine;

public class Scoreboard : MonoBehaviour
{
    int score = 0;

    public void IncreaseScore(int ammount)
    {
        score += ammount;
        Debug.Log(score);
    }
}
