using UnityEngine;

[ExecuteInEditMode]
/// <summary>
/// Creates a spotlight that will illuminate a material
/// </summary>
public class Reveal : MonoBehaviour
{
    [SerializeField] Material Mat;
    [SerializeField] Light PointLight;
	
	void Update ()
    {
        Mat.SetVector("MyLightPosition",  PointLight.transform.position);
        Mat.SetVector("MyLightDirection", -PointLight.transform.forward );
        Mat.SetFloat ("MyLightAngle", PointLight.spotAngle         );
    }
}