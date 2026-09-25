using UnityEngine;

public class Crate : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            GameManager.Instance.CollectCrate();
            Destroy(gameObject);
        }
    }
}