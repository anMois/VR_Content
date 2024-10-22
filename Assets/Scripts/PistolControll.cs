using UnityEngine;

public class PistolControll : MonoBehaviour
{
    [SerializeField] BoxCollider handle;

    [Header("탄창 관련")]
    [SerializeField] bool hasMagazin;
    [SerializeField] MagazineData magazineData;

    public MagazineData MagazineData { get { return magazineData; } set { magazineData = value; } }

    public void MagazineOut()
    {
        magazineData.FireAble = false;
        magazineData = null;
        Debug.Log("탄창 분리");
        GetMagazine();
    }

    public void GetMagazine()
    {
        hasMagazin = hasMagazin == false ? true : false;
        handle.isTrigger = hasMagazin;
        Debug.Log("탄창 결합");
        PistolInit();
    }

    private void PistolInit()
    {
        if (magazineData == null)
        {
            Debug.Log("데이터 없음");
            return;
        }

        if (magazineData.Bullet > 0)
        {
            Debug.Log("사격 가능");
            magazineData.FireAble = true;
        }
        else
        {
            Debug.Log("사격 불가능");
            magazineData.FireAble = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Mag") )
        {
            Debug.Log("탄창 충돌");
            magazineData = other.transform.GetComponent<MagazineData>();
        }
    }
}

