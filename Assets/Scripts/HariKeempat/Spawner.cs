using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject SpawnObject;
    public bool SedangSpawn = true;
    private void Start()
    {
        StartCoroutine(MunculkanObject());
    }
    IEnumerator MunculkanObject()
    {
        while (SedangSpawn == true)
        {
            //Spwan Object
            Instantiate(SpawnObject, new Vector3(Random.Range(-5, 5), Random.Range(-5, 5), 0), Quaternion.identity);   //Memunculkan Object dengan posisi random diantara -5 - 5
            yield return new WaitForSeconds(1);
        }
    }
}
