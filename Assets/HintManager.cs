using System.Collections;
using TMPro;
using UnityEngine;

public class HintManager : MonoBehaviour
{
    public GameObject hintPanel;
    public TMP_Text hintText;
    public float showSeconds = 3f;

    Coroutine routine;

    public void ShowHint(string msg)
    {
        if (routine != null) StopCoroutine(routine);
        routine = StartCoroutine(ShowRoutine(msg));
    }

    IEnumerator ShowRoutine(string msg)
    {
        hintPanel.SetActive(true);
        hintText.text = msg;
        yield return new WaitForSeconds(showSeconds);
        hintPanel.SetActive(false);
    }
}