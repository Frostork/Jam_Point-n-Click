using UnityEngine;
using UnityEngine.AI;

public class PlayerController : MonoBehaviour
{
    public NavMeshAgent agent;
    //public Animator animator;

    void Update()
    {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
        mousePosition.z = 0;
        
        agent.SetDestination(mousePosition);
        //animator.SetBool("isWalking", true);

        if (agent.remainingDistance <= agent.stoppingDistance)
        {
            //animator.SetBool("isWalking", false);
        }
    }
}