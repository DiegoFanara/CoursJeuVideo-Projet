using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private int CoupMax = 3;
    private int Coup = 0;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void PlayerHit()
    {
        Coup++;
        Debug.Log("Player hit! Total hits: " + Coup + "/" + CoupMax);

        if (Coup >= CoupMax)
        {
            RestartGame();
        }
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}