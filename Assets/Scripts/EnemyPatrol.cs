using UnityEngine;

public class EnemyPatrol : MonoBehaviour
{
    [SerializeField] private float vitesseMouvement = 2f;
    [SerializeField] private float distancePatrouille = 3f;

    private Vector3 PositionDepart;
    private bool DeplaceDroite = true;
    private SpriteRenderer sr;

    private void Awake()
    {
        PositionDepart = transform.position;
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        float direction = DeplaceDroite ? 1f : -1f;
        transform.position += Vector3.right * direction * vitesseMouvement * Time.deltaTime;

        if (DeplaceDroite && transform.position.x >= PositionDepart.x + distancePatrouille)
        {
            DeplaceDroite = false;
        }
        else if (!DeplaceDroite && transform.position.x <= PositionDepart.x - distancePatrouille)
        {
            DeplaceDroite = true;
        }

        if (sr != null)
        {
            sr.flipX = !DeplaceDroite;
        }
    }
}