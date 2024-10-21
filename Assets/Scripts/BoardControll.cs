using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class BoardControll : MonoBehaviour
{
    [SerializeField] int score;

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.CompareTag("Bullet"))
        {
            gameObject.SetActive(false);
            Debug.Log("ÃÑ¾Ë Ãæµ¹");
            Destroy(collision.transform);
        }
    }
}
