using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class ReadMouseInput : MonoBehaviour
{
    public TMP_Text display;

    void OnLook(InputValue value)
    {
        Vector2 vector = value.Get<Vector2>();
        display.text = $"{vector.x},{vector.y}";
    }
}
