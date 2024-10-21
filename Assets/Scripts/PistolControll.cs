using UnityEngine;

public class PistolControll : MonoBehaviour
{
    [SerializeField] BoxCollider handle;

    [Header("ÅºÃ¢ °ü·Ã")]
    [SerializeField] bool hasMagazin;
    [SerializeField] MagazineData magazineData;

    public MagazineData MagazineData { get { return magazineData; } set { magazineData = value; } }

    public void MagazineOut()
    {
        magazineData.OnFire = false;
        magazineData = null;
        Debug.Log("ÅºÃ¢ ºÐ¸®");
        GetMagazine();
    }

    public void GetMagazine()
    {
        hasMagazin = hasMagazin == false ? true : false;
        handle.isTrigger = hasMagazin;
        Debug.Log("ÅºÃ¢ °áÇÕ");
        PistolInit();
    }

    private void PistolInit()
    {
        if (magazineData == null) return;

        if (magazineData.Bullet > 0)
            magazineData.OnFire = true;
        else
            magazineData.OnFire = false;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Mag"))
        {
            magazineData = other.transform.GetComponent<MagazineData>();
        }
    }
}

