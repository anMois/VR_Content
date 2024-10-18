using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolControll : MonoBehaviour
{
    [SerializeField] PistolData pistolData;
    [SerializeField] BoxCollider handle;

    [Header("ÅºÃ¢ °ü·Ã")]
    [SerializeField] bool hasMagazin;
    [SerializeField] MagazineData magazineData;

    private void GetMagazine()
    {
        hasMagazin = hasMagazin == false ? true : false;
        handle.isTrigger = hasMagazin;

        PistolInit();
    }

    private void PistolInit()
    {
        if (magazineData == null) return;

        pistolData.CurBullet = magazineData.CurBullet;

        if (pistolData.CurBullet > 0)
            pistolData.OnFire = true;
        else
            pistolData.OnFire = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.parent.CompareTag("Mag"))
        {
            magazineData = other.transform.parent.GetComponent<MagazineData>();
            GetMagazine();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.transform.parent.CompareTag("Mag"))
        {
            magazineData = null;
            GetMagazine();
        }
    }
}

