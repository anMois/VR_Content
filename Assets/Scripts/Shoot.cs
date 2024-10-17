using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] GameObject bulletPrefab;
    [SerializeField] Transform muzzlePoint;
    [SerializeField] float speed;

    public void Fire_GameObject()
    {
        GameObject bullet = Instantiate(bulletPrefab, muzzlePoint.position, muzzlePoint.rotation);
        Rigidbody rigid = bullet.GetComponent<Rigidbody>();
        rigid.velocity = bullet.transform.forward * speed;
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
