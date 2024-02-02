using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Points : MonoBehaviour
{

    private int scorevalue = 0;
    public Text score;
    public Text score2;

    void Start()
    {
        score.text = scorevalue.ToString();
        score2.text = scorevalue.ToString();
    }

    public void OnTriggerEnter2D()
    {
        scorevalue += 1;
        score.text = scorevalue.ToString();
        score2.text = scorevalue.ToString();
    }
}
