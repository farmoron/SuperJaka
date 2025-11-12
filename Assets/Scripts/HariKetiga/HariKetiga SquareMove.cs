using UnityEngine;

public class HariKetigaSquareMove : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool isMoveRight = true;
    public float kecepatan = 5.0f;
    public bool isMove = true;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //bergerak

        //tidakbergerak
        if (isMove)
        {
            if (isMoveRight == true)
            {
                gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0);
            }
            else
            {
                gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0);
            }
        }
        else
        {
            gameObject.transform.Translate(0, 0, 0);
        }
    }
}
