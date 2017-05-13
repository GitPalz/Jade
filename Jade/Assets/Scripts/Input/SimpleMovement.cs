using UnityEngine;

public class SimpleMovement : MonoBehaviour {

    public float speed = 5f;
    private Rigidbody2D body2D;


	// Use this for initialization
	void Start () {
        body2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
        var valueHorizontal = Input.GetAxis("Horizontal");
        var valueVertical   = Input.GetAxis( "Vertical" );

        body2D.velocity = new Vector2(speed * valueHorizontal, speed * valueVertical);
	}
}
