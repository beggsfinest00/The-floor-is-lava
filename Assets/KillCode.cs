using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class KillCode : MonoBehaviour
{
    int lives = 3;
    public Transform spawnPoint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
 
    }

    private void OnControllerColliderHit(ControllerColliderHit hit)
    {
        if (lives > 0 && hit.gameObject.CompareTag("lava"))
        {
            lives--;
            transform.position = spawnPoint.position;
            GetComponent<CharacterController>().SimpleMove(Vector3.zero);
        }
        else if (lives <= 0)
        {
            SceneManager.LoadScene(1);
        }

        if (hit.gameObject.CompareTag("win")) 
        {
            SceneManager.LoadScene(2);
        }
    }
}
