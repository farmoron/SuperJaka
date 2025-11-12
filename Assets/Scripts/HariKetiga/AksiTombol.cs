using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class AksiTombol : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Sprite assetGambar;      //Sprite adalah asset gambar yang ingin dimasukan kedalam object image
    public Image image;             //Image adalah component dari object image yang ada di dalam scene
    public TMP_Text objectText;     //TMP_Text adalah component text 
    
    public void Aksi()
    {
        //Mengubah gambar
        image.sprite = assetGambar;

        //Mengubah Text
        // objectText.text = "Apakah dia berhasil?";

        //SceneManager.LoadScene("HariKetiga SceneBaru");
        Debug.Log("Tombol ditekan");
    }
}
