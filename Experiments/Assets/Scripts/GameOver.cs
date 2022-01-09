using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameOver : MonoBehaviour
{
    public int tries = 3;

    public Text triesDisplay;

    public ArrowSpawner arrow_Spawner;
    public ArrowBehaviour arrowBehavior;

    private void Update()
    {
        triesDisplay.text = "Arrows: " + tries.ToString();
    }

    private void OnCollisionEnter2D(Collision2D lose)
    {
        if (lose.gameObject.CompareTag("Arrow") && tries == 1)
        {
            UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.GetActiveScene().buildIndex);
        } else if (lose.gameObject.CompareTag("Arrow") && tries > 1)
        {
            tries--;
            
            arrow_Spawner.WaitForSpawn();
        }
    }
}
