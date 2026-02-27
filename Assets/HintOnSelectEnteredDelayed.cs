using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HintOnSelectEnteredDelayed : MonoBehaviour
{
    public HintManager hintManager;
    [TextArea] public string message;
    public float delay = 0.15f;

    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        Invoke(nameof(Show), delay);
    }

    void Show()
    {
        if (hintManager != null)
            hintManager.ShowHint(message);
    }
}