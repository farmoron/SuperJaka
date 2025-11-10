using System.Collections;
using NUnit.Framework;
using Unity.VisualScripting;
using UnityEngine;

public class Contoh : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int Number1 = 10;
        //int Number2 = 7;
        //int temp = Number1;
        //Number1 = Number2;
        //Number2 = temp;
        //Debug.Log(Number1);
        //Debug.Log(Number2);

        //bool result = (1287 * 14 + 589) > (63 + 55 * 5) && !(21 < 10);
        //Debug.Log(result);

        //int age = 17;
        //int money = 50000;
        //if (age >= 18 || money >= 10000)
        //{
        //Debug.Log("Masuk");
        //}
        //else
        //{
        //Debug.Log("Dilarang");
        //}

        //int ID = 2;
        //switch (ID)
        //{
            //case 1:
                //Debug.Log("Basic Sword");
                //break;
            //case 2:
                //Debug.Log("Electric Bow");
                //break;
            //case 3:
                //Debug.Log("Fire Spell");
                //break;
        //}
        Debug.Log(bilangan(1, 2, 3));

    }
    //int bilangan = 0;
    public int bilangan(int bilangan1, int bilangan2, int bilangan3)
    {
        int result = bilangan1 + bilangan2 + bilangan3;
        return result;
    }
    //public void Sembuhkan(int tambahkannyawa)
    //{
        //nyawa = nyawa + tambahkannyawa
    //}
    // Update is called once per frame
    void Update()
    {
        
    }
}
