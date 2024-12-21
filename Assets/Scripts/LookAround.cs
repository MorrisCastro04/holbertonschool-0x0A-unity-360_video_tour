using UnityEngine;
using UnityEngine.InputSystem;

public class LookAround : MonoBehaviour
{
    public float speed = 3f;
    private Vector2 lastMousePosition;
    private bool isDragging = false;

    void Update()
    {
        // Detecta cuando se presiona el botón izquierdo del mouse
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            lastMousePosition = Mouse.current.position.ReadValue();
            isDragging = true;
        }

        // Detecta cuando el botón izquierdo está siendo mantenido
        if (Mouse.current.leftButton.isPressed && isDragging)
        {
            Vector2 currentMousePosition = Mouse.current.position.ReadValue();
            Vector2 delta = currentMousePosition - lastMousePosition;

            // Rotar el objeto alrededor de los ejes
            transform.RotateAround(transform.position, -Vector3.up, speed * delta.x * Time.deltaTime);
            transform.RotateAround(transform.position, transform.right, speed * delta.y * Time.deltaTime);

            lastMousePosition = currentMousePosition;
        }

        // Detecta cuando se suelta el botón izquierdo
        if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            isDragging = false;
        }
    }
}
