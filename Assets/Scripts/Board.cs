using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    [SerializeField] BoardControll boardControll;
    [SerializeField] int score;

    private void GetScore()
    {
        boardControll.Total += score;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.CompareTag("Bullet"))
        {
            gameObject.SetActive(false);
            Debug.Log("�Ѿ� �浹");
            GetScore();
            Destroy(collision.gameObject);
        }
    }
}
