using UnityEngine;

public class ChildRescue : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log("Bravo ! Tu as sauvé ton enfant !");
            Time.timeScale = 0f;
        }
    }
}