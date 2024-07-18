using UnityEngine;


public class PlayerDie : MonoBehaviour
{
    private string enemy = "Enemy"; //This is tagged in the asteroid blocks in Unity

    public GameObject endPanel; //

    private void OnCollisionEnter2D(Collision2D collision) // on impact
    {
        if (collision.gameObject.tag == enemy) //check if the player is hitting the asteroids
        {
            endPanel.SetActive(true); // turns the end panel on
            gameObject.SetActive(false); // turns the player off and can no longer interact w/ it
        }
    }
}
