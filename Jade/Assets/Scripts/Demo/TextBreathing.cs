using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextBreathing : MonoBehaviour
{

    private float breathCounter;
    private bool exhale;
    void Start() { exhale = false; breathCounter = 0; }

    // Update is called once per frame
    void Update()
    {
        if (exhale) breathCounter -= 0.01f;
        else        breathCounter += 0.01f;

        if (breathCounter >= 1) exhale = true;
        else
        if (breathCounter <= 0) exhale = false;

        //GetComponent<Text>().color.a = breathCounter;
        var txt = GetComponent<Text>();
        var newColor = new Color(txt.color.r, txt.color.g, txt.color.b, breathCounter);
        GetComponent<Text>().color = newColor;
    }
}