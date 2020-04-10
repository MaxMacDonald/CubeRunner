using UnityEngine.SceneManagement;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;

    public void EndGame()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }

    }

    public void CompleteLevel()
    {
        completeLevelUI.SetActive(true);
    }

    void Restart()

    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
