using UnityEngine;
using UnityEngine.Events;

public class EventTrigger2D : MonoBehaviour
{
    [SerializeField]
    string expectedTag = "Player";

    [Space]
    [SerializeField]
    UnityEvent onEnter;
    [SerializeField]
    UnityEvent onExit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag(expectedTag)) onEnter?.Invoke();
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.CompareTag(expectedTag)) onExit?.Invoke();
    }
}
