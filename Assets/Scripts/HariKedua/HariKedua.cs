using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting.ReorderableList.Element_Adder_Menu;
using UnityEngine;

public class HariKedua : MonoBehaviour
{
    //Serialize
    [SerializeField]
    //Player player;

    //Array1
    //public string[] ArrayNama;
    //Array2
    //Player[] ArrayPlayer;

    //List
    public List<Player> ListPlayer = new List<Player>();

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //int hp = 10;

        //Looping - While
        //int hp = 10;
        //while (hp > 0)
        //{
        //hp = hp - 1;
        //Debug.Log(hp);
        //}
        //Debug.Log("Game Over");

        //Looping - For
        //for (int hp = 0; hp < 3; hp++)
        //{
        //Debug.Log("Pengulangan ke-" + hp);
        //}

        //Challenge Factorial
        //int number = 4;
        //int factorial = 1;

        //for (int i = 1; i <= number; i++)
        //{
        //factorial *= i;
        //Debug.Log(factorial);
        //}

        //for (int i = number; i > 0; i--)
        //{
        //factorial = factorial * 1;
        //Debug.Log(factorial);
        //}
        //Debug.Log(factorial);


        //Objek
        //Player player = new Player();
        //player.Name = "Fadhli";
        //player.Level = 1;
        //player.Health = 100;

        //Debug.Log(player.Name);
        //Debug.Log(player.Level);
        //Debug.Log(player.Health);

        //Objek 2
        //Player player1 = new Player("Fadhil", 1, 100);
        //Player player2 = new Player("John", 2, 200);

        //Debug.Log(player1.Name);
        //Debug.Log(player1.Level);
        //Debug.Log(player1.Health);

        //Debug.Log(player2.Name);
        //Debug.Log(player2.Level);
        //Debug.Log(player2.Health);

        //Serialize
        //Debug.Log(player.Name + " namanya, dia level " + player.Level + " dengan health " + player.Health);

        //Array
        //Debug.Log(ArrayNama[1]);
        //ArrayNama[0] = "Alpha";
        //Debug.Log(ArrayNama[0]);
        //Debug.Log(ArrayNama.Length);
        //for (int index = 0; index < ArrayPlayer.Length; index++)
        //{
        //Debug.Log(ArrayPlayer[index].Name);
        //}

        //foreach (Player player in ArrayPlayer)
        //{
        //Debug.Log(player.Name);
        //}
        //Debug.Log(ArrayPlayer.Length);

        //List
        Player player = ListPlayer.Find(element => element.Level > 15);
        Debug.Log(player.Level);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
