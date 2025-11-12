using System.Security.Cryptography;
using UnityEngine;

public class HariKedua_2 : MonoBehaviour
{
    public GameObject onoff;
    public GameObject spawnobject;
    public GameObject capsulBerwarna;
    //public GameObject destroyobject;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("'Space' key are being pressed");
        }

        if (Input.GetKeyDown(KeyCode.O))
        {
            Debug.Log("'O' key are being pressed");
            onoff.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.K))
        {
            Debug.Log("'K' key are being pressed");
            onoff.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Return))
        {
            Debug.Log("'Enter' key are being pressed");
            Instantiate(spawnobject);   //Memunculkan objek secara instant

            Vector3 spawnPosition = new Vector3(Random.Range(-10, 10), Random.Range(-10, 10), 0); //Menentukan posisi spawn
            Quaternion spawnRotation = Quaternion.Euler(0, 0, 45);
            Instantiate(spawnobject, spawnPosition, spawnRotation);
        }

        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            Debug.Log("'Backspace' key are being pressed");
            //Instantiate(spawnobject);   //Memunculkan objek secara instant
            GameObject destroythis = GameObject.Find("Square(Clone)");
            Destroy(spawnobject);
            Destroy(destroythis);
        }

        if (Input.GetKeyDown(KeyCode.C))
        {
            Debug.Log("'C' key are being pressed");
            SpriteRenderer localSpriterRenderer = capsulBerwarna.GetComponent<SpriteRenderer>();
            Color colorRandom = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
            localSpriterRenderer.color = colorRandom;
        }
    }
}
