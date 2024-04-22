using UnityEngine;

public class BGScroll : MonoBehaviour
{
    public float scroll_Speed = 0.1f;

    private MeshRenderer mesh_Renderer;

    private Vector2 saved_Offset;

    private void Awake()
    {
        mesh_Renderer = GetComponent<MeshRenderer>();

        saved_Offset = mesh_Renderer.sharedMaterial.GetTextureOffset("_MainTex");
    }

    private void Update()
    {
        float x = Time.time * scroll_Speed;

        Vector2 offset = new Vector2(x, 0);

        mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", offset);
    }

    private void OnDisable()
    {
        mesh_Renderer.sharedMaterial.SetTextureOffset("_MainTex", saved_Offset);
    }


} // class
