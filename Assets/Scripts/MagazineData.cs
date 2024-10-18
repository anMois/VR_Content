using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagazineData : MonoBehaviour
{
    [SerializeField] int curBullet;
    [SerializeField] int maxBullet;

    public int CurBullet { get {  return curBullet; }  set { curBullet = value; } }
    public int MaxBullet { get { return maxBullet; } }

}
