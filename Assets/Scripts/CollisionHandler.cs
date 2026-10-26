using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
   [SerializeField] GameObject destroyedVFX;
  private void OnTriggerEnter()
    {
        Instantiate(destroyedVFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
