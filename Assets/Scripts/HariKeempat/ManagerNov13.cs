using TMPro;
using UnityEngine;

public class ManagerNov13 : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public int skor;
    public TMP_Text teksSkor;
    public KotakGerak3 squareMove;
    public GameObject bolaJatuh;
    public PemainLompat pemainLompat;
    void Start()
    {
        UpdateTeksSkor();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Debug.Log("Klik Kiri");
            // Vector3 vector = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            // Debug.Log("Posisi mouse ada di " + vector.ToString());
            TambahSkor();
            UpdateTeksSkor();
            squareMove.isMoveRight = false;
            munculdariatas();
            pemainLompat.Lompat();
        }
        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log("Klik Kanan");
            KurangSkor();
            UpdateTeksSkor();
            squareMove.isMoveRight = true;
        }
        if (Input.GetMouseButtonDown(2))
        {
            Debug.Log("Klik ScrollButton");
        }
    }
    void TambahSkor()
    {
        skor++;
        Debug.Log("Skor bertambah");
    }
    void KurangSkor()
    {
        skor--;
        Debug.Log("Skor berkurang");
    }
    void UpdateTeksSkor()
    {
        teksSkor.text = skor.ToString();
    }
    // void ToggleKiriKanan()
    // {
    //     if(squareMove.isMoveRight)
    //     {
    //         squareMove.isMoveRight = false;
    //     }
    //     else
    //     {
    //         squareMove.isMoveRight = true;
    //     }
    // }
    void munculdariatas()
    {
        Vector3 posisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);               //Ambil posisidi dimana cursor berada
        Vector3 titikatas = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, 0));   //Ambil posisi titik paling atas
        Vector3 tempatJatuh = new Vector3(posisiKlik.x, titikatas.y, 0);                        //

        Instantiate(bolaJatuh, tempatJatuh, Quaternion.identity);                               //Memunculkan object dengan nama bola jatuh di posisi tempatJatuh dan dengan rotasi Quaternion.identity
    }
}
