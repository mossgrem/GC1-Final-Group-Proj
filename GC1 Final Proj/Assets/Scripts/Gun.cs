using UnityEngine.Events;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public UnityEvent OnGunShoot;
    public float FireCooldown;
    public AudioSource GCGunSound01;
    public ParticleSystem MuzzleFlash;

    public bool Automatic;
    private float CurrentCooldown;
    // Start is called before the first frame update
    void Start()
    {
        CurrentCooldown = FireCooldown;
        {
            {
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (Automatic)
        {
            if (Input.GetMouseButton(0))
            if (Input.GetMouseButton(0))
                    MuzzleFlash.Play();
            if (Input.GetMouseButton(0))
                GCGunSound01.Play();
            {
                if (CurrentCooldown <= 0f)
                {
                    OnGunShoot?.Invoke();
                    CurrentCooldown = FireCooldown;
                }
            }
        }
        CurrentCooldown -= Time.deltaTime;
    }
}
