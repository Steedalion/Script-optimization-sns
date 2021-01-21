using UnityEngine;

public class PlayerShipController : MonoBehaviour
{
    private ObjectPool objectPool;
    
	private Transform myTransform;
	AudioSource asource;
	public AudioClip clip;

	public Color color1, color2;
	
    // Start is called before the first frame update
    void Start()
    {
	    myTransform = transform;
	    asource = GetComponent<AudioSource>();
        objectPool = GetComponent<ObjectPool>();

        InvokeRepeating("Shoot", .33f, .33f);
    }

    void Shoot()
    {
        GameObject bullet = objectPool.GetAvailableObject();
        bullet.transform.position = myTransform.position;
	    bullet.SetActive(true);
	    playSoundAtRandomPitch(clip);
    }
    
    
	private void playSoundAtRandomPitch(AudioClip clip, float minPitch = 0.5f, float maxPitch= 1.5f)
	{
		float orignalPitch = asource.pitch;
		asource.pitch = Random.Range(minPitch, maxPitch);
		asource.PlayOneShot(clip);
		//asource.pitch = orignalPitch;
		//I found that resetting the pitch did not allow it to play at the random pitch.
	}
}
