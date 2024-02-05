using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public AudioSource BGM;
    public AudioSource SFX;
    public AudioSource SFX2;
    public AudioClip StartBackground;
    public AudioClip MainBackground;
    public AudioClip SmallDogBark;
    public AudioClip Laugh;
    public AudioClip BigDogBark;
    public AudioClip AirplaneTakeffEdited;
    public AudioClip CoughEdited;
    public AudioClip DogSickEdited;
    public AudioClip DogSad;
    public AudioClip CryEdited;
    public float speed;
    public bool IsStart;
    public GameObject Heading;
    public GameObject ADMove;
    // Start is called before the first frame update
    void Start()
    {
        IsStart = false;
        BGM.clip= StartBackground;
        BGM.Play();
    }

    // Update is called once per frame


   
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("aa");

        if (collision.name == "2")
        {
            SFX.clip = BigDogBark;
            SFX.Play();
        }

        if (collision.name == "3")
        {
            SFX.clip = AirplaneTakeffEdited;
            SFX.Play();
        }

        if (collision.name == "4")
        {
            SFX.clip = CoughEdited;
            SFX.Play();
        }

        if (collision.name == "5")
        {
            SFX.clip = DogSad;
            SFX.Play();
        }

        if (collision.name == "6")
        {
            SFX.clip = DogSickEdited;
            SFX.Play();
        }

        if (collision.name == "7")
        {
            SFX.clip = CryEdited;
            SFX.Play();
        }

    }
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space) && !IsStart)
        {
            IsStart = true;
            BGM.clip = MainBackground;
            BGM.Play();
            SFX.clip = SmallDogBark;
            SFX.Play();
            SFX2.clip = Laugh;
            SFX2.Play();
            Heading.active= false;
            ADMove.active = false;

        }
     
        if (IsStart && Input.GetKey(KeyCode.D))
        {
            this.transform.position += new Vector3(speed * Time.deltaTime, 0, 0);

        }

        if (IsStart && Input.GetKey(KeyCode.A))
        {
            this.transform.position += new Vector3(-speed * Time.deltaTime, 0, 0);

        }

    
    
    }
}
