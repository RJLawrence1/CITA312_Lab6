using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] GameObject[] lasers;

    bool isFiring = false;

    private void Update()
    {
        ProcessFiring();
    }

    public void OnFire(InputValue value)
    {
        if (value.isPressed)
        {
            isFiring = !isFiring; // flips true → false or false → true
        }
    }

    void ProcessFiring()
    {
        foreach (GameObject laser in lasers)
        {
            var emissionModule = laser.GetComponent<ParticleSystem>().emission;
            emissionModule.enabled = isFiring;
        }
    }
}