using TMPro;
using UnityEngine;

public class Interaksi12B : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public SquareMove12B squareMove12B;
    public int skor;
    public int nyawa;
    public TMP_Text TeksSkor;
    public TMP_Text TeksNyawa;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GerakAtas()
    {
        squareMove12B.arahGerakB = ArahGerakB.atas;
    }
    public void GerakBawah()
    {
        squareMove12B.arahGerakB = ArahGerakB.bawah;
    }
    public void GerakKiri()
    {
        squareMove12B.arahGerakB = ArahGerakB.kiri;
    }
    public void GerakKanan()
    {
        squareMove12B.arahGerakB = ArahGerakB.kanan;
    }
}
