using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private int health = 10;
    private int coins;
    public GameObject fireballPrefab;
    public Transform attackPoint;
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("�������� ������:" + health);
    }
    // Update is called once per frame
    public void CollectCoins()
    {
        coins++;
        print("��������� �������:" + coins);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }
}
