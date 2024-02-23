using UnityEngine;
using UnityEngine.SceneManagement;

public class changeScene : MonoBehaviour
{
    public Animator btnAnim;
   
    public string sceneToLoad; // Name of the scene to load

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            Debug.Log("Hand interaction detected, changing scene...");
            btnAnim.Play("btnPress");
            SceneManager.LoadScene(sceneToLoad); // Load the specified scene
        }
    }
}
