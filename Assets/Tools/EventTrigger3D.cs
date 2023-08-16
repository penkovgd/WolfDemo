using UnityEngine;
using UnityEngine.Events;

public class EventTrigger3D : MonoBehaviour
{
    [SerializeField]
    string expectedTag = "Player";

    [Space]
    [SerializeField]
    UnityEvent onEnter;
    [SerializeField]
    UnityEvent onExit;

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag(expectedTag)) onEnter?.Invoke();
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag(expectedTag)) onExit?.Invoke();
    }
}
