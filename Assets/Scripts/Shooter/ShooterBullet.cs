using UnityEngine;

public class ShooterBullet : Shooter
{
    public GameObject bulletPrefab;

    public Transform bulletSpawnPoint;

    public AudioSource audioSource;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public override void Shoot()
    {
        if(audioSource != null)
        {
            audioSource.Play();
        }
        Instantiate(bulletPrefab, bulletSpawnPoint.position, bulletSpawnPoint.rotation);
    }
}
