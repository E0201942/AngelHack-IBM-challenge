using UnityEngine;

public class CameraDrag : MonoBehaviour
{
    public float dragSpeed = 5;
    private Vector3 dragOrigin;
    const int orthographicSizeMin = 1;
    const int orthographicSizeMax = 6;



    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            dragOrigin = Input.mousePosition;
            return;
        }

        if (!Input.GetMouseButton(0)) return;

        Vector3 pos = Camera.main.ScreenToViewportPoint(Input.mousePosition - dragOrigin);
        Vector3 move = new Vector3(-pos.x * dragSpeed, 0, -pos.z * dragSpeed);

        transform.Translate(move, Space.World);
        if (Input.GetAxis("Mouse ScrollWheel") > 0) // forward
 {
            Camera.main.orthographicSize++;
        }
        if (Input.GetAxis("Mouse ScrollWheel") < 0) // back
 {
            Camera.main.orthographicSize--;
        }
        Camera.main.orthographicSize = Mathf.Clamp(Camera.main.orthographicSize, orthographicSizeMin, orthographicSizeMax);
    }


}