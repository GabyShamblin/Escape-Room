using UnityEngine;

/// <summary>
/// Control painting certain objects to solve the cipher puzzle
/// </summary>
public class SkullPaintController : MonoBehaviour
{
    
    public GameObject redPaint;
    public GameObject greenPaint;
    public GameObject bluePaint;
    public GameObject orangePaint;

    private Material _objectNewMaterial;
    private GameObject _objectToPaint;
    private MeshRenderer _redPaintMeshRenderer;
    private MeshRenderer _greenPaintMeshRenderer;
    private MeshRenderer _bluePaintMeshRenderer;
    private MeshRenderer _orangePaintMeshRenderer;
    private MeshRenderer _skullMeshRenderer;

    /// <summary>
    /// Initialize paint renderers
    /// </summary>
    private void Start()
    {
        _objectToPaint = gameObject;
        _skullMeshRenderer = _objectToPaint.GetComponent<MeshRenderer>();
        _orangePaintMeshRenderer = orangePaint.GetComponent<MeshRenderer>();
        _bluePaintMeshRenderer = bluePaint.GetComponent<MeshRenderer>();
        _greenPaintMeshRenderer = greenPaint.GetComponent<MeshRenderer>();
        _redPaintMeshRenderer = redPaint.GetComponent<MeshRenderer>();
    }

    /// <summary>
    /// Check for collisions and paint the object
    /// </summary>
    void Update()
    {
        if (InteractionHandler.AreColliding(_objectToPaint, redPaint))
        {
            _objectNewMaterial = _redPaintMeshRenderer.material;
        }
        else if (InteractionHandler.AreColliding(_objectToPaint, greenPaint))
        {
            _objectNewMaterial = _greenPaintMeshRenderer.material;
        }
        else if (InteractionHandler.AreColliding(_objectToPaint, bluePaint))
        {
            _objectNewMaterial = _bluePaintMeshRenderer.material;
        }
        else if (InteractionHandler.AreColliding(_objectToPaint, orangePaint))
        {
            _objectNewMaterial = _orangePaintMeshRenderer.material;
        }
        else
        {
            return;
        }

        _skullMeshRenderer.material = _objectNewMaterial;
    }
}
