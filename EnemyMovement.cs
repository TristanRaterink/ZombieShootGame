using UnityEngine.AI;
using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    Transform player;               // Reference to the player's position.
    PlayerHealth playerHealth;      // Reference to the player's health.
    EnemyHealth enemyHealth;        // Reference to this enemy's health.
    NavMeshAgent nav;
    public AudioClip soundClip;
// Reference to the nav mesh agent.
    //AudioSource enemyAudio;


    void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        playerHealth = player.GetComponent<PlayerHealth>();
        enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();
        //enemyAudio = GetComponent<AudioSource>();
        //enemyAudio.Play();

    }


    void Update()
    {
        //If the enemy and the player have health left...
        if (enemyHealth.currentHealth > 5 && playerHealth.currentHealth > 0)
        {
            // ... set the destination of the nav mesh agent to the player.
            nav.SetDestination(player.position);
            //nav.speed = Random.Range(1f, 4f);
            //enemyAudio.Play();
        }
         //Otherwise...
        else
       {
           //  ... disable the nav mesh agent.
            nav.enabled = false;
           
        }
    }
}