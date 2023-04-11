

using UnityEngine;
using UnityEngine.UI;

public class CapsuleColor : MonoBehaviour
{
    public Slider colorSlider;
    public Color[] colors;
    public Renderer capsuleRenderer;

    private int currentIndex = 0;

    private void Start()
    {
        // Set the initial color of the capsule
        capsuleRenderer.material.color = colors[currentIndex];
    }

    private void Update()
    {
        // Determine the current index based on the slider value
        currentIndex = (int) (colorSlider.value * (colors.Length - 1));

        // Update the color of the capsule
        capsuleRenderer.material.color = colors[currentIndex];
    }
}
