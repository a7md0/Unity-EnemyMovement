using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemeyAI : MonoBehaviour {
    private NavMeshAgent agent;
    public GameObject target;

    // Use this for initialization
    void Start() {
        this.agent = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update() {
        this.agent.destination = this.target.transform.position;
    }
}
