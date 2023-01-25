using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TMP_Text scoreValueText;
    public float scoreValue = 0f;
    public float pointIncreasedPerSecond = 1f;

    void FixedUpdate()
    {
        scoreValueText.text = ((int)scoreValue).ToString();
        scoreValue += pointIncreasedPerSecond * Time.fixedDeltaTime;
    }
}
