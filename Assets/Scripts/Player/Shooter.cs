using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Shooter : MonoBehaviour
{
    // reference to the original prefab to instatiate
    public GameObject projectilePrefab;
    public int AmmoCount;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            Shoot();
           // AmmoCounter();
        }
    }

    void Shoot()
    {
        // We instantiate the prefab at the same position as the player,
        // since this script is on the player GameObject
        Instantiate(projectilePrefab, transform.position, Quaternion.identity);
    }

    //public void AmmoCounter()
    //{
    //    AmmoCount = AmmoCount - 1;
    //    print(AmmoCount);
    //    if(AmmoCount <= 0)
    //    {
    //        SceneManager.LoadScene("Game Over");
    //    }
    //}

    //public void MoveToSceneGameOver(string GameOverScreen)
    //{
    //    SceneManager.LoadScene("GameOverScreen");
    //}
}
