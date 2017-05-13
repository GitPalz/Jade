using UnityEngine;

public enum Buttons
{
    Right,  // 1
    Left,   // 2
} // enum Buttons

public enum Condition
{
    GreaterThan,
    LessThan
}

[System.Serializable]
public class InputAxisState
{
    public string    axisName;
    public float     offValue;
    public Buttons   button;
    public Condition condition;

    public bool value{
        get
        {
            var val = Input.GetAxis(axisName);

            switch(condition)
            {
                case Condition.GreaterThan:
                    return val > offValue;
                case Condition.LessThan:
                    return val < offValue;
            }

            // default return: unreachable code for compiling only 
            return false;

        } // get : bool value
    } // bool value

} // class InputAxisState

public class InputManager : MonoBehaviour {

    public InputAxisState[] inputs;
    public InputState       inputState;

    // Use this for initialization
    void Start () {
		
	} // Start ()
	
	// Update is called once per frame
	void Update () {
		foreach(var input in inputs)
        {
            inputState.SetButtonValue(input.button, input.value);
        }
	} // Update ()

} // class InputManager