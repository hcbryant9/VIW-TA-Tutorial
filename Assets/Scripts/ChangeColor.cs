using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    public Animator btnAnim;
  
    public GameObject objectToChangeMaterial;
    public Material newMaterial;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Hand"))
        {
            Debug.Log("Button clicked");
            btnAnim.Play("btnPress");
            

            // Change the material of the object if it's assigned
            if (objectToChangeMaterial != null && newMaterial != null)
            {
                Renderer renderer = objectToChangeMaterial.GetComponent<Renderer>();
                if (renderer != null)
                {
                    renderer.material = newMaterial;
                }
                else
                {
                    Debug.LogWarning("Object to change material does not have a Renderer component.");
                }
            }
            else
            {
                Debug.LogWarning("Object to change material or new material is not assigned.");
            }
        }
    }
}
