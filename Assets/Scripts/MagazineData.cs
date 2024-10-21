using UnityEngine;

public class MagazineData : MonoBehaviour
{
    [SerializeField] int bullet;
    [SerializeField] int maxBullet;
    [SerializeField] bool onFire;

    public int Bullet { get {  return bullet; }  set { bullet = value; } }
    public int MaxBullet { get { return maxBullet; } }
    public bool OnFire { get { return onFire; } set { onFire = value; } }

    private void Update()
    {
        if(bullet <= 0)
        {
            onFire = false;
        }
    }
}
