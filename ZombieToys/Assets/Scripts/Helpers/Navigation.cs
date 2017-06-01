using UnityEngine;

public class Navigation : MonoBehaviour {
    [SerializeField] Transform target;
    [SerializeField] UnityEngine.AI.NavMeshAgent agent;
    [SerializeField] float updateDelay = .3f;
	
	void Reset () {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
	}

    void Start()
    {
        InvokeRepeating("FollowTarget", 0f, updateDelay);
    }

	void Update () {
        agent.SetDestination(target.position);
	}
}
