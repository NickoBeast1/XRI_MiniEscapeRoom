using UnityEngine;

public class DoorTriggerZone : MonoBehaviour
{
    public DoorController door;
    public bool openOnEnter;
    public bool closeOnExit;
    public bool lockOnEnter;

    void OnTriggerEnter(Collider other)
    {
        if (lockOnEnter) door.CloseAndLock();
        else if (openOnEnter) door.Open();
    }

    void OnTriggerExit(Collider other)
    {
        if (closeOnExit) door.Close();
    }
}