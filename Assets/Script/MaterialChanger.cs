using UnityEngine;
using UnityEngine.EventSystems;

public class MaterialChanger : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerClickHandler
{
    public Material baseMaterial;
    public Material selectedMaterial;
    public AudioClip clip;
    public Mesh[] shapes = new Mesh[2];


    public GameObject particle;

    [SerializeField] private Renderer renderer;
    [SerializeField] private AudioSource source;
    private MeshFilter filter;
    private int index = 0;

    void Start()
    {
        renderer = GetComponent<Renderer>();
        renderer.material = baseMaterial;
        source = GetComponent<AudioSource>();
        filter.mesh = shapes[index];
        filter = GetComponent<MeshFilter>();
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        renderer.material = selectedMaterial;
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        renderer.material = baseMaterial;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        particle.SetActive(!particle.activeSelf);
        source.PlayOneShot(clip);
        
        if(++index > 1)
            index = 0;
        
        filter.mesh = shapes[index];
    }

    void Update()
    {
    }
}