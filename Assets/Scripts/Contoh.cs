using UnityEngine;

public class Contoh : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        int Number1 = 10;
        int Number2 = 7;
        int temp = Number1;
        Number1 = Number2;
        Number2 = temp;
        Debug.Log(Number1);
        Debug.Log(Number2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
