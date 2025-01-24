using StarterAssets;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    private StarterAssetsInputs starterAssetsInputs;

    private void Awake()
    {
        starterAssetsInputs = GetComponentInParent<StarterAssetsInputs>();
    }

    private void Update()
    {
        if (starterAssetsInputs.shoot)
        {
            if (Physics.Raycast(Camera.main.transform.position, Camera.main.transform.forward, out RaycastHit hit, Mathf.Infinity))
            {
                if (hit.collider.CompareTag("Enemy")) {
                    EnemyHealth enemyHealth = hit.collider.GetComponent<EnemyHealth>();
                    enemyHealth.TakeDamage(1);
                }
            }

            starterAssetsInputs.ShootInput(false);
        }
    }
}
