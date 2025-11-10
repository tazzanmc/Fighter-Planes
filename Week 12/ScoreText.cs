using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreText : MonoBehaviour
{
    public Text textComponent;
    public GameManager gm;

    void Update()
    {
        UpdateText(gm.score);
    }

    void UpdateText(int value)
    {
        textComponent.text = "Score: " + value;
    }
}
