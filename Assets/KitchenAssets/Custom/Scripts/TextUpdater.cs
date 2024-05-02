using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TextUpdater : MonoBehaviour
{
    public GameObject uiText;

    public bool isScoreboard;

    public void UpdateText(string newText)
    {
        uiText.GetComponentInChildren<TMP_Text>().text = newText;
    }

    private void Update() {
        if(isScoreboard)
        {
            uiText.GetComponentInChildren<TMP_Text>().text = gameObject.GetComponent<ScoreUpdater>().score.ToString();
        }
    }
}
