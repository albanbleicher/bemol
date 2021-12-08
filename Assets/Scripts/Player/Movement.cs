using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Movement : MonoBehaviour
{
    // Speed of Camera Movement
    private Animator animator;
    private NavMeshAgent agent;
    public GameObject BeginCamera;
    public GameObject SideCamera;
    public GameObject manivelle;


    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        StartCoroutine(Begin());
    }

    IEnumerator Begin()
    {
        yield return new WaitForSeconds(5);
        Debug.Log("Waited 5 seconds");
        BeginCamera.SetActive(false);
        SideCamera.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {

        float x = Input.GetAxis("Horizontal") * 2f;
        float z = Input.GetAxis("Vertical");

        Vector3 move = transform.forward * z * agent.speed;
        transform.Rotate(0f, x, 0f);
        agent.Move(move * Time.deltaTime);
        float speed = move.magnitude;
        animator.SetFloat("Speed", speed);
        manivelle.transform.Rotate(0f, speed * 2f, 0f);

    }
}
