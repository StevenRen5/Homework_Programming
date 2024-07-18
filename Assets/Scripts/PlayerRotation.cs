using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    private Camera _camera; // need to access Unity's camera for player rotation

    private string CameraName = "Game_Camera"; // object we will look for

    private Vector3 _positionMouse; // keeps track of our mouse's position

    private void Start()
    {
        _camera = GameObject.Find(CameraName).GetComponent<Camera>(); //looks into our hierachy for a game object with the provided name
    }

    private void Update()
    {   // saving position of the mouse = within our game 
        _positionMouse = _camera.ScreenToWorldPoint(Input.mousePosition); // saves position of mouse within game = translates where camera is directed at

        Vector3 pos = _positionMouse - transform.position; // distance difference between the player and the mouse

        float rotZ = Mathf.Atan2(pos.y , pos.x) * Mathf.Rad2Deg; // translating position into an angle; translating angle into degrees

        transform.rotation = Quaternion.Euler(0, 0, rotZ - 90); //(higher math regarding angles and position)
    }
}
