using UnityEngine;

public class LookAround : MonoBehaviour
{
    public float sensitivity = 5.0f; // Velocidad de rotación
    public float range = 60.0f; // Rango de rotación vertical

    float rotationX = 0.0f;
    float rotationY = 0.0f;

    private Camera cam; // Referencia a la cámara

    void Start()
    {
        // Busca la cámara con el tag "MainCamera"
        cam = Camera.main;

        // Establece la posición inicial de la cámara en la posición del objeto
        cam.transform.position = transform.position;
    }

    void Update()
    {
        // Rotación horizontal
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        rotationY += mouseX;
        transform.localEulerAngles = new Vector3(0, rotationY, 0);
        rotationY = Mathf.Clamp(rotationY, -1000f, 1000f);

        // Rotación vertical
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;
        rotationX += mouseY;
        rotationX = Mathf.Clamp(rotationX, -range, range);
        cam.transform.localEulerAngles = new Vector3(-rotationX, rotationY, 0);

        // Establece la posición de la cámara en la posición del objeto
        cam.transform.position = transform.position;
    }
}