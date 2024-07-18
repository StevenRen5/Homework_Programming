using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody2D _rigidbody2D; //1: private/public variable name (use _ for private)

    private float _xSpeed;
    private float _ySpeed;
                                //public allows editing of speed in Unity 
    public float speed = 3; // Multiplying speed by 3

    private string InputX = "Horizontal"; //easier to modify horizontal speed; use InputX
    private string InputY = "Vertical"; //...

    private void Start()    //  Happens once
    {
        _rigidbody2D = GetComponent<Rigidbody2D>(); //2: Connect rigidbody2D to the player object w/ the rigidbody2D component
    }
    private void Update()  // Updates constantly
    {
        _xSpeed = Input.GetAxis(InputX); // Gets horizontal movement labeled "Horizontal" in Unity
        _ySpeed = Input.GetAxis(InputY); //Gets vertical movement.... (x & y speed moves by 1 originally)

        _rigidbody2D.velocity = new Vector2(_xSpeed, _ySpeed) * speed; // Save x&y speed into RigidBody2D
    }

}
