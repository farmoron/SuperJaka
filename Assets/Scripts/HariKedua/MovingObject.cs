using UnityEngine;

public class MovingObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        gameObject.transform.Translate(1 * Time.deltaTime, 1 * Time.deltaTime, 0); //Menggerakan objek dari posisi awal
        gameObject.transform.Rotate(0, 0, 75 * Time.deltaTime); //Memutar objek
        gameObject.transform.localScale += new Vector3(1, 1, 1) * Time.deltaTime; //Memutar objek
    }
}
