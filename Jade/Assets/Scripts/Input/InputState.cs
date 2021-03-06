﻿using System.Collections.Generic;
using UnityEngine;

public class ButtonState
{
    public bool  value;
    public float holdTime = 0;
}

public class InputState : MonoBehaviour {

    private Dictionary<Buttons, ButtonState> buttonStates =
        new Dictionary<Buttons, ButtonState> ();

    public void SetButtonValue(Buttons key, bool value)
    {
        if (!buttonStates.ContainsKey(key))
            buttonStates.Add(key, new ButtonState());
        var state = buttonStates[key];

        if (state.value && !value)
        {
            Debug.Log("Button " + key + " released after" + state.holdTime);
            state.holdTime = 0;
        }
        else
        if (state.value && value)
        { 
            state.holdTime += Time.deltaTime;
            Debug.Log("Button " + key + " down for " + state.holdTime);
        }
        state.value = value;
    }
}
