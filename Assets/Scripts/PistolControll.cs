using UnityEngine;

public class PistolControll : MonoBehaviour
{
    [SerializeField] PistolData pistolData;
    [SerializeField] BoxCollider handle;

    [Header("ÅºÃ¢ °ü·Ã")]
    [SerializeField] bool hasMagazin;
    [SerializeField] MagazineData magazineData;

    public void MagazineOut()
    {
        magazineData = null;
        GetMagazine();
    }

    public void GetMagazine()
    {
        hasMagazin = hasMagazin == false ? true : false;
        handle.isTrigger = hasMagazin;

        PistolInit();
    }

    private void PistolInit()
    {
        if (magazineData == null)
        {
            pistolData.OnFire = false;
            pistolData.CurBullet = 0;
            return;
        }

        pistolData.CurBullet = magazineData.Bullet;

        if (pistolData.CurBullet > 0)
            pistolData.OnFire = true;
        else
            pistolData.OnFire = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Mag"))
        {
            magazineData = other.transform.GetComponent<MagazineData>();
        }
    }
}

