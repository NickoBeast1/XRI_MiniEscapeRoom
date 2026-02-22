using UnityEngine;

public class DoorUnlockAndOpen : MonoBehaviour
{
    public DoorController door;

    public void UnlockAndOpen()
    {
        if (door == null) door = GetComponent<DoorController>();
        if (door == null) return;

        door.lockedClosed = false;
        door.Open();
    }
}