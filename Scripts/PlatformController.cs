using UnityEngine;

public class PlatformController : MonoBehaviour
{
    [SerializeField] private float force;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.transform.CompareTag("Player"))
        {
            var player = collision.transform.GetComponent<PlayerController>();
            player.Jump(force);
        }
    }
}