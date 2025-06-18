using UnityEngine;
using UnityEngine.AI;
using SpatialSys.UnitySDK;

public class Enemy : MonoBehaviour
{
    public NavMeshAgent navMeshAgent;
    private IAvatar localAvatar;

    void Start()
    {
        if (navMeshAgent == null)
            navMeshAgent = GetComponent<NavMeshAgent>();

        localAvatar = SpatialBridge.actorService.localActor?.avatar;
    }

    void Update()
    {
        SetEnemyPosition();
    }

    private void SetEnemyPosition()
    {
        if (navMeshAgent != null && localAvatar != null)
        {
            navMeshAgent.SetDestination(localAvatar.position);
        }
    }
}
