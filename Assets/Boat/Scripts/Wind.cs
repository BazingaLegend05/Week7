using UnityEngine;

public class RotateWithMouse : MonoBehaviour
{
    [SerializeField]
    private float rotationSpeed = 5f;

    void Update()
    {
        float mouseX = Input.mousePosition.x;
        float screenWidth = Screen.width;
        float normalizedMouseX = (mouseX / screenWidth) - 0.5f;
        float rotationAmount = normalizedMouseX * 360f;

        transform.rotation = Quaternion.Euler(0f, rotationAmount * rotationSpeed, 0f);
    }
}