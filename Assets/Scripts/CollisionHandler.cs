using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
  private void OnTriggerEnter()
    {
        // Debug.Log("Hit " + other.name);
        Debug.Log($"Hit {gameObject.name}");
    }
}
