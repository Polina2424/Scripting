using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float speed;
    public Transform target;
    public int PlayerDamage = 2;


    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime.deltaTime);
        transform.LookAt(target.position)
    }
    private void OnTriggerEnter(Collider other)
    {
        Player player = other.GetComponent<player>();
        player.TakeDamage(playerDamage);
    }
 
}
