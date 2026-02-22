using UnityEngine;

public class DoorController : MonoBehaviour
{
    [Header("Assign door parts that move")]
    public Transform leftDoor;
    public Transform rightDoor;

    [Header("Slide settings")]
    public float slideDistance = 0.8f;
    public float speed = 3f;

    [Header("State")]
    public bool isOpen;
    public bool lockedClosed;

    Vector3 leftClosed, rightClosed;
    Vector3 leftOpen, rightOpen;

    void Awake()
    {
        leftClosed = leftDoor.localPosition;
        rightClosed = rightDoor.localPosition;

        // If your door slides a different direction, we can flip these later.
        leftOpen = leftClosed + Vector3.left * slideDistance;
        rightOpen = rightClosed + Vector3.right * slideDistance;
    }

    void Update()
    {
        var targetL = isOpen ? leftOpen : leftClosed;
        var targetR = isOpen ? rightOpen : rightClosed;

        leftDoor.localPosition = Vector3.Lerp(leftDoor.localPosition, targetL, Time.deltaTime * speed);
        rightDoor.localPosition = Vector3.Lerp(rightDoor.localPosition, targetR, Time.deltaTime * speed);
    }

    public void Open()
    {
        if (lockedClosed) return;
        isOpen = true;
    }

    public void Close()
    {
        if (lockedClosed) return;
        isOpen = false;
    }

    public void CloseAndLock()
    {
        isOpen = false;
        lockedClosed = true;
    }
}