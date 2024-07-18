using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    // variables

    public GameObject preFab; // access to the game object prefab (bullet)
    public Transform bulletTrash; // where all the prefabs will be spawned
    public Transform bulletSpawn; // where bullets will appear in

    private const float Timer = 0.5f; // value that will be resetting the current timer to; timer set to half a second
    private float _currentTime = 0.5f; // counts down current timer and when reached < 0, player can shoot again; then timer reset to .5seconds
    private bool _canShoot = true; // player can always shoot at the very start of the game

    private void Update()
    {
        TimerMethod();
        Shoot();
    }
        private void TimerMethod() //section for timer
    {
        if (!_canShoot) // If player can't shoot, timer will be couned down
        {
            _currentTime -= Time.deltaTime; //deltaTime is how much time has passed in the game 

            if (_currentTime < 0) // if current time < 0, set the shoot to true and resetting current time to timer (0.5s)
            {
                _canShoot = true;
                _currentTime = Timer;
            }
        }
    }

        private void Shoot() //section for shooting
    {
        if (Input.GetKeyDown(KeyCode.Mouse0) && _canShoot) // if player clicks left mouse button, player will spawn bullet
        {
            GameObject bullet = Instantiate(preFab, bulletSpawn.position, Quaternion.identity); // Instantiate means makin a copy of the bullet

            bullet.transform.SetParent(bulletTrash);

            _canShoot = false; // player can't shoot for a period of time
        }
    }
}
