using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolControll : MonoBehaviour
{
    [SerializeField] PistolData pistolData;
    [SerializeField] BoxCollider handle;

    [Header("탄창 관련")]
    [SerializeField] bool hasMagazin;
    [SerializeField] MagazineData magazineData;

    private void FixedUpdate()
    {
        if(magazineData != null)
        {
            Debug.Log(magazineData.Bullet + " 교체 전");
            magazineData.Bullet = pistolData.CurBullet;
            Debug.Log(magazineData.Bullet + " 교체 후");
        }
    }

    private void GetMagazine()
    {
        hasMagazin = hasMagazin == false ? true : false;
        handle.isTrigger = hasMagazin;

        PistolInit();
    }

    private void PistolInit()
    {
        if (magazineData == null) return;

        pistolData.CurBullet = magazineData.Bullet;

        if (pistolData.CurBullet > 0)
            pistolData.OnFire = true;
        else
            pistolData.OnFire = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.CompareTag("Mag"))
        {
            magazineData = other.transform.GetComponent<MagazineData>();
            GetMagazine();
            Debug.Log("탄창 결합");
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.parent.CompareTag("Mag"))
        {
            magazineData = null;
            GetMagazine();
            Debug.Log("탄창 분리");
        }
    }
}

