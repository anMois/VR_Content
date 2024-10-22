using System.Collections;
using System.Collections.Generic;
using System.Text;
using TMPro;
using UnityEngine;

public class MagazinContoll : MonoBehaviour
{
    [SerializeField] MagazineData magazinData;
    [SerializeField] TextMeshProUGUI curBulletText;
    [SerializeField] TextMeshProUGUI maxBulletText;

    private StringBuilder sb = new StringBuilder();

    private void Start()
    {
        Init();
    }

    private void LateUpdate()
    {
        BulletText(magazinData.Bullet.ToString(), curBulletText);
    }

    private void Init()
    {
        BulletText(magazinData.Bullet.ToString(), curBulletText);
        BulletText(magazinData.MaxBullet.ToString(), maxBulletText);
    }

    private void BulletText(string msg, TextMeshProUGUI text)
    {
        sb.Clear();
        sb.Append(msg);
        text.SetText(sb.ToString());
    }

}
