using UnityEngine;
using UnityEngine.InputSystem;

public class VoiceCommandHandler : MonoBehaviour
{
    public GameObject Cube; 

    public InputActionReference changeColorAction; 

    private void OnEnable()
    {
        changeColorAction.action.performed += OnChangeColor;
        changeColorAction.action.Enable();
    }

    private void OnDisable()
    {
        changeColorAction.action.Disable();
        changeColorAction.action.performed -= OnChangeColor;
    }

    private void OnChangeColor(InputAction.CallbackContext context)
    {
        ChangeCubeColor();
    }

    private void ChangeCubeColor()
    {
        if (Cube != null)
        {
            Renderer cubeRenderer = Cube.GetComponent<Renderer>();
            if (cubeRenderer != null)
            {
                cubeRenderer.material.color = new Color(Random.value, Random.value, Random.value); // Change to a random color
            }
        }
    }
}
