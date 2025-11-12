using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class HariKetigaInteraksiUI : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public HariKetigaSquareMove squareMove;
    public GameObject squareUbahWarna;
    public TMP_Text kataBerubah;
    public TMP_Text namaBerubah;
    public List<string> daftarNama;
    public int idNama = 0;
    void Start()
    {
        namaBerubah.text = daftarNama[idNama];
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void UbahKataKiri()
    {
        string kata = "kiri";
        kataBerubah.text = kata;
    }
    public void UbahKataKanan()
    {
        string kata = "kanan";
        kataBerubah.text = kata;
    }

    public void LanjutNama()
    {
        if (idNama < daftarNama.Count - 1)
        {

            idNama++;
        }
        else
        {
            idNama = 0;
        }
        namaBerubah.text = daftarNama[idNama];
    }
    public void KembalitNama()
    {
        if (idNama <= 0)
        {

            idNama = daftarNama.Count - 1;
        }
        else
        {
            idNama--;
        }
        namaBerubah.text = daftarNama[idNama];
    }
    public void ubahWarna(Color warna)
    {
        SpriteRenderer sr = squareUbahWarna.GetComponent<SpriteRenderer>();
        sr.color = warna;
    }
    public void ubahWarnaMerah()
    {
        ubahWarna(Color.red);
    }
    public void ubahWarnaHijau()
    {
        ubahWarna(Color.green);
    }
    public void ubahWarnaBiru()
    {
        ubahWarna(Color.blue);
    }
    public void ubahWarnaRandom()
    {
        Color col = new Color(Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f), Random.Range(0.0f, 1.0f));
        ubahWarna(col);
    }
    public void Mulai()
    {
        squareMove.isMove = true;
    }
    public void Berhenti()
    {
        squareMove.isMove = false;
    }
    public void GerakKanan()
    {
        squareMove.isMoveRight = true;
    }
    public void GerakKiri()
    {
        squareMove.isMoveRight = false;
    }
}