// using System;        //menggunakan listener
using UnityEngine;
using UnityEngine.Events;

public class InputKey : MonoBehaviour
{
    public Score objectScore; //Membuat variabel untuk function di script lain
    // public Action InputEventAddScore;
    // public Action InputEventReduceScore;
    public UnityEvent inputEventAddScore;
    public UnityEvent inputEventReduceScore;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //objectScore.AddScore();         //Memanggil function di script lain
            //Debug.Log(objectScore.score);   //Menampilkan function dari script lain
            //InputEventAddScore.Invoke();
            inputEventAddScore.Invoke();
            Debug.Log(objectScore.score);   //Menampilkan function dari script lain
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            //objectScore.AddScore();         //Memanggil function di script lain
            //Debug.Log(objectScore.score);   //Menampilkan function dari script lain
            //InputEventAddScore.Invoke();
            inputEventReduceScore.Invoke();
            Debug.Log(objectScore.score);   //Menampilkan function dari script lain
        }
    }
}
