using StarterAssets;
using UnityEngine;
using UnityEngine.AI;

public class Robot : MonoBehaviour
{
    private NavMeshAgent agent;
    private FirstPersonController player;

    private void Awake()
    {
        agent = GetComponent<NavMeshAgent>();
    }

    private void Start()
    {
        player = FindFirstObjectByType<FirstPersonController>();
    }

    private void Update()
    {
        agent.SetDestination(player.transform.position);
    }
}
