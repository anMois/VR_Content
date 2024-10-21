using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReroadControll : MonoBehaviour
{
    [SerializeField] MagazineData magData;

    public void ReloadIn()
    {
        if (magData == null || magData.Bullet == magData.MaxBullet) return;

        magData.Bullet = magData.MaxBullet;
    }

    public void ReloadOut()
    {
        if (magData != null) return;

        magData = null;
    }
    

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.CompareTag("Mag"))
        {
            magData = other.transform.GetComponent<MagazineData>();
        }
    }
}
