using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class spaceShipcontrollerScript : MonoBehaviour
{
    
    public float speed = 30;
    public GameObject Explosion;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(Vector3.right * Time.deltaTime * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(Vector3.left * Time.deltaTime * speed);
        }
        float x = Mathf.Clamp(transform.position.x, -126, 100);
        Vector3 position = transform.position;
        position.x = x;
        transform.position = position;

    }
    //Collision dectection from enemy and destroying the player
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Enemy")
        {
            GetComponent <MeshRenderer>().enabled = false ;
            GetComponent<SphereCollider>().enabled = false;
            Instantiate(Explosion,transform.position,transform.rotation);
            Invoke("Reset", 5);
        }
    }

     void Reset()
    {
        Scoremanager.score = 0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
