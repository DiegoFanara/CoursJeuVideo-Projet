using UnityEngine;

public class ChildRescue : MonoBehaviour
{
    [SerializeField] private GameObject TextVctoire;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (TextVctoire != null)
            {
                TextVctoire.SetActive(true);
            }
            Time.timeScale = 0f;
        }
    }
}