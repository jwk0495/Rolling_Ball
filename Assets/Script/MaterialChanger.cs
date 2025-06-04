using UnityEngine;
using UnityEngine.EventSystems;

public class MaterialChanger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public Material baseMaterial;
    public Material selectedMaterial;
    public AudioClip clip;

    public GameObject particle;

    [SerializeField] private Renderer renderer;
    private AudioSource source;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material = baseMaterial;

        source = GetComponent<AudioSource>();
        source.PlayOneShot(clip);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        renderer.material = selectedMaterial;
        source.PlayOneShot(clip);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        renderer.material = baseMaterial;
        source.PlayOneShot(clip);
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        particle.SetActive(!particle.activeSelf);
        source.PlayOneShot(clip);
    }

    void Update()
    {
    }
}