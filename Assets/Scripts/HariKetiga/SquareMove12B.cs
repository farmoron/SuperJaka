using Unity.VisualScripting;
using UnityEngine;

public class SquareMove12B : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public ArahGerakB arahGerakB = ArahGerakB.atas;
    public Interaksi12B interaksi12B;
    public float kecepatan = 5.0f;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        switch (arahGerakB)
        {
            case ArahGerakB.atas:
                gameObject.transform.Translate(0, kecepatan * Time.deltaTime, 0);
                break;
            case ArahGerakB.bawah:
                gameObject.transform.Translate(0, -kecepatan * Time.deltaTime, 0);
                break;
            case ArahGerakB.kiri:
                gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0);
                break;
            case ArahGerakB.kanan:
                gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0);
                break;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Dinding"))
        {
            Debug.Log("kotak tabrak dinding");
            if (arahGerakB == ArahGerakB.atas)
            {
                arahGerakB = ArahGerakB.bawah;
            }
            else if (arahGerakB == ArahGerakB.bawah)
            {
                arahGerakB = ArahGerakB.atas;
            }
            else if (arahGerakB == ArahGerakB.kiri)
            {
                arahGerakB = ArahGerakB.kanan;
            }
            else if (arahGerakB == ArahGerakB.kanan)
            {
                arahGerakB = ArahGerakB.kiri;
            }
            interaksi12B.skor++;
            TambahSkor();
        }
    }

    public void TambahSkor()
    {
        interaksi12B.TeksSkor.text = "Skor: " + interaksi12B.skor.ToString();
    }
    
}
public enum ArahGerakB
    {
        atas,
        bawah,
        kiri,
        kanan
    }