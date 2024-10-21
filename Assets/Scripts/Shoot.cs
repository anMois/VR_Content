using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] PistolControll pistol;

    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform muzzlePoint;
    [SerializeField] float speed;

    public void PistolFire_GameObject()
    {
        if (pistol.MagazineData.OnFire == false || pistol.MagazineData.Bullet < 0) return;

        GameObject bullet = Instantiate(bulletPrefab, muzzlePoint.position, muzzlePoint.rotation);
        Rigidbody rigid = bullet.GetComponent<Rigidbody>();
        rigid.velocity = bullet.transform.forward * speed;
        pistol.MagazineData.Bullet--;
    }

    public void Fire_Raycast()
    {
        if(Physics.Raycast(muzzlePoint.position, muzzlePoint.forward, out RaycastHit hit, 100))
        {
            Renderer render = hit.collider.gameObject.GetComponent<Renderer>();
            if(hit.collider.name.Equals("Cube"))
            {
                render.material.color = Color.yellow;
            }
        }
    }
}
