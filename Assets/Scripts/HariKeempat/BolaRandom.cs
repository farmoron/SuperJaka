using Unity.VisualScripting;                        
using UnityEngine;

public class BolaRandom : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Interaksi12B interaksi12B;               //Mendeklarasikan referensi GameObject dengan tipe data class Interaksi12B
    public float kecepatan = 5.0f;                  //Mendeklarasikan variabel kecepatan dengan tipe data float bernilai 5
    public float intervalGantiArah = 2f;
    private Vector3 arahAcak;
    private float timer;
    void Start()
    {
        PilihArahAcakBaru();
    }

    // Update is called once per frame
    void Update()
    {
        //gameObject.transform.Translate(kecepatan * Random.Range(-0.5f, 0.5f), kecepatan * Random.Range(-0.5f, 0.5f), 0);   //Control Looping untuk menentukan arah gerak game object ke atas
        timer += Time.deltaTime;
        if (timer >= intervalGantiArah)
        {
            // Jika waktu telah tercapai, pilih arah baru dan reset timer
            PilihArahAcakBaru();
            timer = 0f;
            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.linearVelocity = arahAcak * kecepatan;
        }
    }

    void PilihArahAcakBaru()
    {
        // Membuat Vector3 baru dengan nilai X dan Z yang acak 
        // (Gerakan pada bidang horizontal X-Z)
        float randX = Random.Range(-1f, 1f);
        float randZ = Random.Range(-1f, 1f);
        
        // Normalisasi vektor agar pergerakan selalu memiliki kecepatan yang konsisten
        arahAcak = new Vector3(randX, 0.5f, randZ).normalized; 
    }

    void OnCollisionEnter2D(Collision2D collision)          //Mendeklarasikan function OnCollisionEnter2D dengan memanggil Collision2D dari library 
    {
        
    }

    public void TambahSkor()
    {
        interaksi12B.TeksSkor.text = "Skor = " + interaksi12B.skor.ToString(); //Menambahkan Skor ketika kotak menabrak dinding
    }
    public void SistemNyawa()
    {
        
    }
    
}