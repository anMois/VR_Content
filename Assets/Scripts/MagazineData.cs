using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagazineData : MonoBehaviour
{
    [SerializeField] int bullet;
    [SerializeField] int maxBullet;

    public int Bullet { get {  return bullet; }  set { bullet = value; } }
    public int MaxBullet { get { return maxBullet; } }
}
