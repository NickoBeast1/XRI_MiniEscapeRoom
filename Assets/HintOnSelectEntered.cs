using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class HintOnSelectEntered : MonoBehaviour
{
    public HintManager hintManager;
    [TextArea] public string message;

    public bool onlyOnce = true;
    private bool hasFired = false;

    public void OnSelectEntered(SelectEnterEventArgs args)
    {
        if (onlyOnce && hasFired) return;
        hasFired = true;

        if (hintManager != null)
            hintManager.ShowHint(message);
    }
}