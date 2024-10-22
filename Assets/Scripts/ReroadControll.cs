using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class ReroadControll : MonoBehaviour
{
    [SerializeField] MagazineData magData;

    [Header("UI")]
    [SerializeField] TextMeshProUGUI text;

    private StringBuilder sb = new StringBuilder();

    private void Start()
    {
        TextReset(" ");
    }

    private void TextReset(string msg)
    {
        sb.Clear();
        sb.AppendLine(msg);
        text.SetText(sb.ToString());
    }

    public void ReloadIn()
    {
        if (magData == null || magData.Bullet == magData.MaxBullet)
        {
            TextReset(magData.name);
            return;
        }

        Debug.Log("Åº¾à ÃæÀü");
        magData.Bullet = magData.MaxBullet;
        TextReset(magData.name);
    }

    public void ReloadOut()
    {
        magData = null;
        TextReset(" ");
    }
    
    private void OnTriggerEnter(Collider other)
    {
        if(other.transform.CompareTag("Mag"))
        {
            magData = other.transform.GetComponent<MagazineData>();
        }
    }
}
