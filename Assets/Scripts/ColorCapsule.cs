using UnityEngine;

public class ColorCapsule : MonoBehaviour
{
    SpriteRenderer colorcapsule;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        colorcapsule = GetComponent<SpriteRenderer>();
        //colorcapsule.color = Color.green;
        Color warna;

        ColorUtility.TryParseHtmlString("#FFFFFFF", out warna);
        colorcapsule.color = warna;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
