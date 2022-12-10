using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MoveToPosition : MonoBehaviour
{

    public float knockbackTime = 1;
    public float kick = 1.8f;

    private Transform  goal;
    private NavMeshAgent agent;

    private bool hit;
    private ContactPoint contact;
    private float timer;

    Animator enemyAnim;

    // Start is called before the first frame update
    void Start()
    {
        goal = GameObject.FindGameObjectWithTag("Player").transform;
        agent = GetComponent<NavMeshAgent>();
        timer = knockbackTime;
        enemyAnim = gameObject.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(hit){
            gameObject.GetComponent<Rigidbody>().isKinematic = false;
            gameObject.GetComponent<NavMeshAgent>().isStopped = true;
            gameObject.GetComponent<Rigidbody>().AddForceAtPosition(Camera.main.transform.forward * kick, contact.point, ForceMode.Impulse);
            hit = false;
            timer = 0;
        } else {
            timer += Time.deltaTime;
            if(knockbackTime < timer) {
                gameObject.GetComponent<Rigidbody>().isKinematic = true;
                gameObject.GetComponent<NavMeshAgent>().isStopped = false;
                agent.SetDestination(goal.position); 
                
                if(agent.remainingDistance < 1.5f){
                enemyAnim.SetTrigger("Attack");
                }
                
            }
        }
    }

    void OnCollisionEnter(Collision other){
        if (other.transform.CompareTag("bullet")){
            contact = other.contacts[0];
            hit = true;
        }
    }
}
