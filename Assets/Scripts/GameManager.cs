using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [Header("Dégâts")]
    [SerializeField] private int CoupMax = 3;
    private int Coup = 0;

    [Header("Collection")]
    [SerializeField] private int CaisseMax = 3;
    [SerializeField] private GameObject grotte; // à assigner dans l'Inspector
    private int Caisse = 0;

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

    private void Start()
    {
        if (grotte != null)
        {
            grotte.SetActive(false); // cachée tant que les 3 caisses ne sont pas ramassées
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

    public void CollectCrate()
    {
        Caisse++;
        Debug.Log("Caisse ramassée : " + Caisse + "/" + CaisseMax);

        if (Caisse >= CaisseMax && grotte != null)
        {
            grotte.SetActive(true);
            Debug.Log("La grotte est maintenant accessible !");
        }
    }

    private void RestartGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}