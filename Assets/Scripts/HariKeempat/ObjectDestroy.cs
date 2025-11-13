using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Mouse0))
        {
            Vector2 PosisiKlik = Camera.main.ScreenToWorldPoint(Input.mousePosition);
            Collider2D ObjekTerdeteksi = Physics2D.OverlapPoint(PosisiKlik);
            if(ObjekTerdeteksi != null)
            {
                Debug.Log("Objek Terdeteksi");
                Destroy(ObjekTerdeteksi.gameObject);
            }
        }
    }
}
