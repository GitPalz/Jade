using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDemoText : MonoBehaviour {
    //public float speed = 1.0f;
    public static bool up = false;
    public static bool down = false;
    public static bool left = false;
    public static bool right = false;

    // Update is called once per frame
    void Update()
    {
        //Up
        if (Input.GetKeyDown("w")) up = true;
        if (Input.GetKeyUp("w")) up = false;

        //Down
        if (Input.GetKeyDown("s")) down = true;
        if (Input.GetKeyUp("s")) down = false;

        //Left
        if (Input.GetKeyDown("a")) left = true;
        if (Input.GetKeyUp("a")) left = false;

        //Right
        if (Input.GetKeyDown("d")) right = true;
        if (Input.GetKeyUp("d")) right = false;

        if (up) transform.Translate(Vector2.up); //up
        if (down) transform.Translate(-Vector2.up); //down
        if (left) transform.Translate(-Vector2.right); //left
        if (right) transform.Translate(Vector2.right); //right

    }
}