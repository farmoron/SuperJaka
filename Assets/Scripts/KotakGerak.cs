using UnityEngine;

public class KotakGerak : MonoBehaviour
{
    public float moveSpeed = 5.0f;
    public bool isMoveRight = true;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (isMoveRight)
        {
            gameObject.transform.Translate(moveSpeed * Time.deltaTime, 0, 0); //Menggerakan objek dari posisi awal
        }
        else
        {
            gameObject.transform.Translate(-moveSpeed * Time.deltaTime, 0, 0); //Menggerakan objek dari posisi awal
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        Debug.Log("Kotak Bertabrakan");
        if (isMoveRight)
        {
            isMoveRight = false;
        }
        else
        {
            isMoveRight = true;
        }
    }
}
