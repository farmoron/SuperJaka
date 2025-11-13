using UnityEngine;

public class PemainLompat : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public float forceMultiplier = 3.0f;
    public bool diLantai;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Lompat()
    {
        if (diLantai)
        {
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.AddForce(transform.up * forceMultiplier, ForceMode2D.Impulse);
        }
        else
        {
            Debug.Log("Lagi Lompat");
        }
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Lantai"))
        {
            diLantai = true;
            Debug.Log("di Lantai");
        }
    }
}
