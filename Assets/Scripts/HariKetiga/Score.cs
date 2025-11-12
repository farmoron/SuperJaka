using UnityEngine;

public class Score : MonoBehaviour
{
    public InputKey objectInputKey;
    public int score;
    private void OnEnable()
    {
        //Listen
        //objectInputKey.InputEventAddScore += AddScore;  //+= Function yang mau di listen
    }
    public void AddScore()
    {
        score = score + 1;
    }
    public void ReduceScore()
    {
        score = score - 1;
    }
    
    private void OnDisable()
    {
        //Unlisten
        //objectInputKey.InputEventAddScore -= AddScore;  //-= Function yang mau di unlisten
    }
}
