using System.Collections;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    public float Waktu;
    public float MaximumWaktu;
    public TMP_Text textTimer;
    public bool WaktuBerjalan = true;
    public KeyCode StartCoroutineKey;
    public KeyCode StopCoroutineKey;
    public Coroutine HitungTimerCoroutine;
    public Image ProgressFill;
    // private void Start()
    // {
    //     StartCoroutine(HitungTimer());
    // }

    private void Update()
    {
        if (Input.GetKeyDown(StartCoroutineKey))
        {
            if (HitungTimerCoroutine == null)
            {
                HitungTimerCoroutine = StartCoroutine(HitungTimer());
            }
        }
        if(Input.GetKeyDown(StopCoroutineKey))
        {
            if (HitungTimerCoroutine != null)                       //Untuk merecek apabila coroutine aktif
            {
                StopCoroutine(HitungTimerCoroutine);
                HitungTimerCoroutine = null;
            }
        }
    }
    IEnumerator HitungTimer()
    {
        while (WaktuBerjalan == true && Waktu < MaximumWaktu)
        {
            Waktu = Waktu + 1;
            textTimer.text = Waktu.ToString();
            ProgressFill.fillAmount = Waktu / MaximumWaktu;
            yield return new WaitForSeconds(1);
        }
    }
}
