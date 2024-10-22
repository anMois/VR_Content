using UnityEngine;

public class PistolControll : MonoBehaviour
{
    [SerializeField] BoxCollider handle;

    [Header("źâ ����")]
    [SerializeField] bool hasMagazin;
    [SerializeField] MagazineData magazineData;

    public MagazineData MagazineData { get { return magazineData; } set { magazineData = value; } }

    public void MagazineOut()
    {
        magazineData.FireAble = false;
        magazineData = null;
        Debug.Log("źâ �и�");
        GetMagazine();
    }

    public void GetMagazine()
    {
        hasMagazin = hasMagazin == false ? true : false;
        handle.isTrigger = hasMagazin;
        Debug.Log("źâ ����");
        PistolInit();
    }

    private void PistolInit()
    {
        if (magazineData == null)
        {
            Debug.Log("������ ����");
            return;
        }

        if (magazineData.Bullet > 0)
        {
            Debug.Log("��� ����");
            magazineData.FireAble = true;
        }
        else
        {
            Debug.Log("��� �Ұ���");
            magazineData.FireAble = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform.CompareTag("Mag") )
        {
            Debug.Log("źâ �浹");
            magazineData = other.transform.GetComponent<MagazineData>();
        }
    }
}

