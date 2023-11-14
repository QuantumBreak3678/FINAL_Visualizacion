using System.Collections;
using System.Collections.Generic;
using Tilia.Interactions.Interactables.Interactables;
using UnityEngine;

public class ChangeMaterial : MonoBehaviour
{
    public List<GameObject> objetosConMeshRender;
    public List<InteractableFacade> InteractableFecade;
    public Material materiaL;
    public GameObject Capsule; 
    
    public void CambiarMeshRenderers()
    {
        foreach (GameObject objeto in objetosConMeshRender)
        {
            objeto.tag = "Charged"; 
            MeshRenderer meshRenderer = objeto.GetComponent<MeshRenderer>();

            if (meshRenderer != null)
            {
                
                meshRenderer.material = materiaL;
            }
            else
            {
                Debug.LogWarning("El objeto " + objeto.name + " no tiene un MeshRenderer.");
            }
        }
        
        foreach (InteractableFacade interactableFacade in InteractableFecade)
        {
            interactableFacade.enabled = true;
        }
    }

    public void AddObject()
    {
        
        if (!objetosConMeshRender.Contains(Capsule))
        {
            objetosConMeshRender.Add(Capsule);
            
        }
     
    }

    public void RemoveObject()
    {
        if (objetosConMeshRender.Contains(Capsule))
        {
            objetosConMeshRender.Remove(Capsule);
        }
    }
    
    
}
    

