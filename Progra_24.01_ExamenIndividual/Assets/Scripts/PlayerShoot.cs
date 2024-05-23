using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour
{
    public GameObject whiteBulletPrefab;
    public GameObject blackBulletPrefab;
    public Transform spawnPoint;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            ShootBullet(whiteBulletPrefab, "White");
        }
        if (Input.GetMouseButtonDown(1))
        {
            ShootBullet(blackBulletPrefab, "Black");
        }
    }

    void ShootBullet(GameObject bulletPrefab, string targetTag)
    {
        GameObject bullet = Instantiate(bulletPrefab, spawnPoint.position, spawnPoint.rotation);
        Bullet bulletScript = bullet.GetComponent<Bullet>();
        bulletScript.targetTag = targetTag;
    }
}
