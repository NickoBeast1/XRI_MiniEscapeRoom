using UnityEngine;
using UnityEngine.Events;

public class SimpleVRButton : MonoBehaviour
{
    public UnityEvent onPressed;
    private bool pressed;

    private void OnTriggerEnter(Collider other)
    {
        if (pressed) return;
        pressed = true;
        onPressed.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        pressed = false;
    }
}
