using UnityEngine;

public class LookAround : MonoBehaviour
{
    public float sensitivity = 5.0f; // Velocidad de rotaci�n
    public float range = 60.0f; // Rango de rotaci�n vertical

    float rotationX = 0.0f;
    float rotationY = 0.0f;

    private Camera cam; // Referencia a la c�mara

    void Start()
    {
        // Busca la c�mara con el tag "MainCamera"
        cam = Camera.main;

        // Establece la posici�n inicial de la c�mara en la posici�n del objeto
        cam.transform.position = transform.position;
    }

    void Update()
    {
        // Rotaci�n horizontal
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        rotationY += mouseX;
        transform.localEulerAngles = new Vector3(0, rotationY, 0);
        rotationY = Mathf.Clamp(rotationY, -1000f, 1000f);

        // Rotaci�n vertical
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;
        rotationX += mouseY;
        rotationX = Mathf.Clamp(rotationX, -range, range);
        cam.transform.localEulerAngles = new Vector3(-rotationX, rotationY, 0);

        // Establece la posici�n de la c�mara en la posici�n del objeto
        cam.transform.position = transform.position;
    }
}