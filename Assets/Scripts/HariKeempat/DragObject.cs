using UnityEngine;

public class DragObject : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    // void OnMouseEnter()
    // {
    //     Debug.Log("Enter");
    // }
    // void OnMouseDown()
    // {
    //     Debug.Log("Down");
    // }
    void OnMouseDrag()
    {
        Debug.Log("Drag");
        Vector2 worldMousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

        Vector2 squarePosition = new Vector2(worldMousePosition.x, transform.position.y);   //Untuk Membatasi pergerakan Objek agar hanya bisa bergerak secara horizontal
        worldMousePosition.x = Mathf.Clamp(worldMousePosition.x, -6.3f, 6.3f);
        worldMousePosition.y = Mathf.Clamp(worldMousePosition.y, -4, 4);
        transform.position = worldMousePosition;

        // Vector2 squarePosition = new Vector2(worldMousePosition.x, transform.position.y);
        // Vector2 minimum = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, 0));
        // Vector2 maximum = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, 0));
        // squarePosition.x = Mathf.Clamp(squarePosition.x, minimum.x, maximum.x);
        // transform.position = squarePosition;
    }
    // void OnMouseExit()
    // {
    //     Debug.Log("Exit");
    // }
}
