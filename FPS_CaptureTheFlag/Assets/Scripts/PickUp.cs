using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum PickUpType
{
    Health,
    Ammo
}

public class PickUp : MonoBehaviour
{
    [Header("Pickup Stats")]
    public PickUpType type;
    public int healthAmount;
    public int ammoAmount;

    [Header("Bobbing Anim")]
    public float rotationSpeed;
    public float bobSpeed;
    public float bobHeight;

    private Vector3 startPos;
    private bool bobbingUp;
    //public AudioClip pickupSfx;


    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            FPSController player = other.GetComponent<FPSController>();

            switch(type)
            {
                case PickUpType.Health:
                    player.GiveHealth(healthAmount);
                    break;

                case PickUpType.Ammo:
                    player.GiveAmmo(ammoAmount);
                    break;
            }
            //Play pickup audio clip
            //other.GetComponent<AudioSource>().PlayOneShot(pickupSfx);

            Destroy(gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {

        //Rotating
        transform.Rotate(Vector3.up, rotationSpeed * Time.deltaTime);

        //Bobbing up and down
        Vector3 offset = (bobbingUp == true ? new Vector3(0, bobHeight / 2, 0) : new Vector3(0, -bobHeight / 2, 0));
        transform.position = Vector3.MoveTowards(transform.position, startPos + offset, bobSpeed * Time.deltaTime);

        if(transform.position == startPos + offset)
        {
            bobbingUp = !bobbingUp;
        }
    }
}
