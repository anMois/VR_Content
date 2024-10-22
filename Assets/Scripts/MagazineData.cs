using UnityEngine;

public class MagazineData : MonoBehaviour
{
    [SerializeField] int bullet;
    [SerializeField] int maxBullet;
    [SerializeField] bool fireAble;

    public int Bullet { get { return bullet; } set { bullet = value; } }
    public int MaxBullet { get { return maxBullet; } }
    public bool FireAble { get { return fireAble; } set { fireAble = value; } }

    private void Update()
    {
        if(bullet <= 0)
        {
            fireAble = false;
        }
    }
}
