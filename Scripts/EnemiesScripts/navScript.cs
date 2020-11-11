using UnityEngine;
using UnityEngine.AI;

public class navScript : MonoBehaviour
{
    private NavMeshAgent agent;
    private GameObject player;
    private Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        agent = gameObject.GetComponent<NavMeshAgent>();
        player = GameObject.Find("Player");
        anim = gameObject.GetComponent<Animator>();

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        RaycastHit hit;
        if (Physics.SphereCast(transform.position + new Vector3(0, 3, 0), 2, transform.forward, out hit, 3) && anim.GetCurrentAnimatorStateInfo(0).IsName("Zombie Running"))
        {
            if (hit.collider.gameObject.transform.root.name == "Player")
            {
                anim.SetTrigger("Attack");
            }
        }
        if (anim.GetCurrentAnimatorStateInfo(0).IsName("Zombie Punching")) { }
        else
        {
            agent.SetDestination(player.transform.position);
        }

    }
}
