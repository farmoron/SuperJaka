using Unity.VisualScripting;                        
using UnityEngine;

public class SquareMove12B : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public ArahGerakB arahGerakB = ArahGerakB.atas; //Mendeklarasikan fungsi dengan arahGerakB dengan 
                                                    //memanggil class ArahGerakB dari script Interaksi12B dan memilih enum atas
    public Interaksi12B interaksi12B;               //Mendeklarasikan referensi GameObject dengan tipe data class Interaksi12B
    public float kecepatan = 5.0f;                  //Mendeklarasikan variabel kecepatan dengan tipe data float bernilai 5
    void Start()
    {
        interaksi12B.TeksNyawa.text = "Nyawa = " + 5;
    }

    // Update is called once per frame
    void Update()
    {
        switch (arahGerakB)                                                         //Control looping untuk menentukan arah gerak GameObject
        {
            case ArahGerakB.atas:
                gameObject.transform.Translate(0, kecepatan * Time.deltaTime, 0);   //Control Looping untuk menentukan arah gerak game object ke atas
                break;
            case ArahGerakB.bawah:
                gameObject.transform.Translate(0, -kecepatan * Time.deltaTime, 0);  //Control Looping untuk menentukan arah gerak game object ke bawah
                break;
            case ArahGerakB.kiri:
                gameObject.transform.Translate(-kecepatan * Time.deltaTime, 0, 0);  //Control Looping untuk menentukan arah gerak game object ke kiri
                break;
            case ArahGerakB.kanan:
                gameObject.transform.Translate(kecepatan * Time.deltaTime, 0, 0);   //Control Looping untuk menentukan arah gerak game object ke kanan
                break;
        }
    }

    void OnCollisionEnter2D(Collision2D collision)          //Mendeklarasikan function OnCollisionEnter2D dengan memanggil Collision2D dari library 
    {
        if (collision.gameObject.CompareTag("Dinding"))     //Fungsi If apabila game objek bertabrakan dengan tag objek "Dinding"
        {
            Debug.Log("kotak tabrak dinding");              //Menampilkan pesan di Log ketika objek menabrak dinding
            if (arahGerakB == ArahGerakB.atas)              //Fungsi If apabila game objek menabrak dindik ketika arah gerak game objek ke atas
            {
                arahGerakB = ArahGerakB.bawah;              //Apabila fungsi If diatas benar, maka akan memindahkan arah gerak game objek ke bawah
            }
            else if (arahGerakB == ArahGerakB.bawah)        //Fungsi If apabila game objek menabrak dindik ketika arah gerak game objek ke bawah
            {
                arahGerakB = ArahGerakB.atas;               //Apabila fungsi If diatas benar, maka akan memindahkan arah gerak game objek ke atas
            }
            else if (arahGerakB == ArahGerakB.kiri)         //Fungsi If apabila game objek menabrak dindik ketika arah gerak game objek ke kiri
            {
                arahGerakB = ArahGerakB.kanan;              //Apabila fungsi If diatas benar, maka akan memindahkan arah gerak game objek ke kanan
            }
            else if (arahGerakB == ArahGerakB.kanan)        //Fungsi If apabila game objek menabrak dindik ketika arah gerak game objek ke kanan
            {
                arahGerakB = ArahGerakB.kiri;               //Apabila fungsi If diatas benar, maka akan memindahkan arah gerak game objek ke kiri
            }
            interaksi12B.skor++;
            TambahSkor();
        }
        if (collision.gameObject.CompareTag("BolaRintangan"))
        {
            interaksi12B.nyawa--;
            SistemNyawa();
        }
    }

    public void TambahSkor()
    {
        interaksi12B.TeksSkor.text = "Skor = " + interaksi12B.skor.ToString(); //Menambahkan Skor ketika kotak menabrak dinding
    }
    public void SistemNyawa()
    {
        interaksi12B.TeksNyawa.text = "Nyawa = " + interaksi12B.nyawa.ToString(); //Menambahkan Skor ketika kotak menabrak dinding
    }
    
}
public enum ArahGerakB      //Memberikan nilai enum pada ArahGerakB
    {
        atas,
        bawah,
        kiri,
        kanan
    }