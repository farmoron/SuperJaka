using UnityEngine;

public class KotakGerak3 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public bool isMoveRight = true;
    public float kecepatan = 5.0f;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (isMoveRight)
        {
            gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0); //Menggerakan objek dari posisi awal ke kanan
        }
        else
        {
            gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0); //Menggerakan objek dari posisi awal ke kiri
        }
    }
    
}
