using System.Collections;
using UnityEngine;
using UnityEngine.EventSystems;

public class Despawner : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(HapusObject());
        //Destroy(gameObject, 5);
    }
    IEnumerator HapusObject()
    {
        yield return new WaitForSeconds(4);
        Destroy(gameObject);
    }
}
