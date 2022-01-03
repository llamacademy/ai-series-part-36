using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class PlayerMovement : MonoBehaviour
{
    [SerializeField]
    private Camera Camera = null;
    [SerializeField]
    private Vector3 CameraFollowOffset = new Vector3(0, 10, -2);
    [SerializeField]
    private LayerMask LayerMask;
    private NavMeshAgent Agent;
    
    private void Awake()
    {
        Agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        if (Input.GetKeyUp(KeyCode.Mouse0))
        {
            Ray ray = Camera.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out RaycastHit hit, float.MaxValue, LayerMask))
            {
                Agent.SetDestination(hit.point);
            }
        }
    }

    private void LateUpdate()
    {
        Camera.transform.position = Agent.transform.position + CameraFollowOffset;
    }
}
