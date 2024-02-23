using UnityEngine;

public class KillCollider : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.transform.CompareTag("Player"))
        {
            GameManager.Instance.GameOver();
        }
    }
}
