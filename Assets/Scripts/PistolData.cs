using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolData : MonoBehaviour
{
    [SerializeField] int curBullet;
    [SerializeField] bool onFire;

    public int CurBullet { get { return curBullet; } set { curBullet = value; } }
    public bool OnFire { get { return onFire; }  set { onFire = value; } }

    private void FixedUpdate()
    {
        if (curBullet <= 0)
            OnFire = false;
    }
}
