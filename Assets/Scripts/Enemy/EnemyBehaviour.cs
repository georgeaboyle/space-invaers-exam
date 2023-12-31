using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EnemyBehaviour : MonoBehaviour
{
    public AudioClip destructionSFX;
    
    // Variable to count enemies
    public static int EnemyCount = 0;

   

    // Function to count up enemies on spawn
    public void OnEnable()
    {
        EnemyCount++;
        print(EnemyCount);
    }

    // Function to count down enemies on destruction and call GameOver function
    public void OnDisable()
    {
        EnemyCount--;
        print(EnemyCount);
        GameOver();
    }

    // physical sim hits. For Unity to call this, at least one of the colliding objects
    // needs to have their RigidBody component set to "Dynamic" for Body Type
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // print("I'm hit collision!");
    }

    // This is called if the Collider on the game object has "Is Trigger" checked.
    // Then it doesn't physically react to hits but still detects them
    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("I'm hit!");

        // Check the other colliding object's tag to know if it's
        // indeed a player projectile
        if (collision.tag == "PlayerProjectile")
        {
            

            // Play an audio clip in the scene and not attached to the alien
            // so the sound keeps playing even after it's destroyed
            AudioSource.PlayClipAtPoint(destructionSFX, Vector3.zero);

            // Destroy the alien game object
            Destroy(gameObject);

            // Destroy the projectile game object
            Destroy(collision.gameObject);

            


        }
    }
    

    // A function to end the game when all enemies have died
    void GameOver()
    {
        if (EnemyCount <= 0)
        {
            SceneManager.LoadScene("LoveWins");
        }


    }


}
