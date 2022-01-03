using UnityEngine;
using UnityEngine.AI;

public class DoorTrigger : MonoBehaviour
{
    [SerializeField]
    private Door Door;
    private int AgentsInRange = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.TryGetComponent<NavMeshAgent>(out NavMeshAgent agent))
        {
            // In here if you want them to play some animation or something of that sort, you can disable the NavMeshAgent,
            // play the animation, then once the animation is complete, open the door. something like...
            /*
             * if (AgentsInRange == 0)
             * {
             *      agent.enabled = false;
             *      // play the animation, move the agent, whatever needs to be done to feel like the door will open
             *      // then once it is open.
             *      Door.Open(other.transform.position);
             * }
             */
            // This way you will only have the first agent opening the door instead of all of them trying to open the door
            AgentsInRange++;
            if (!Door.IsOpen)
            {
                Door.Open(other.transform.position);
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.TryGetComponent<NavMeshAgent>(out NavMeshAgent agent))
        {
            // if you do not want to automatically close doors, do not implement this method
            AgentsInRange--;
            if (Door.IsOpen && AgentsInRange == 0)
            {
                Door.Close();
            }
        }
    }
}
