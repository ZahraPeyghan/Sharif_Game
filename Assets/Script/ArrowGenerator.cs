using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(MeshFilter))]
[RequireComponent(typeof(MeshRenderer))]
public class ArrowGenerator : MonoBehaviour
{
    public float stemLength;
    public float stemWidth;
    public float tipLength;
    public float tipWidth;
    [System.NonSerialized]
    public List<Vector3> verticesList;
    [System.NonSerialized]
    public List<int> trianglesList;
    Mesh mesh;
    private Camera cam;
    private Renderer arrayRend;
    void Start()
    {
       mesh = new Mesh();
       this.GetComponent<MeshFilter>().mesh = mesh; 
       cam = Camera.main;
       arrayRend = GetComponent<Renderer>();
       arrayRend.sortingOrder = 5;
    }

    void Update()
    {
        if(PlayerManager.pleyerManagerInstance.Drag){
        GenerateArrow();
        var dir = Input.mousePosition - cam.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y,dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle , Vector3.forward);
        var offset = PlayerManager.pleyerManagerInstance.transform.position - transform.position;
        stemLength = offset.magnitude;
        arrayRend.enabled = true;
        }
        else {
            stemLength = 0f;
            arrayRend.enabled = false;
        }
    }

    void GenerateArrow(){
        verticesList = new List<Vector3>();
        trianglesList = new List<int>();
        Vector3 stemOrigin = Vector3.zero;
        float steHalfWidth = stemWidth/2f;
        verticesList.Add(stemOrigin+(steHalfWidth*Vector3.down));
        verticesList.Add(stemOrigin+(steHalfWidth*Vector3.up));
        verticesList.Add(verticesList[0]+(stemLength*Vector3.right));
        verticesList.Add(verticesList[1]+(stemLength*Vector3.right));
        trianglesList.Add(0);
        trianglesList.Add(1);
        trianglesList.Add(3);
        trianglesList.Add(0);
        trianglesList.Add(3);
        trianglesList.Add(2);
        Vector3 tipOrigin = stemLength*Vector3.right;
        float tipHalfWidth = tipWidth/2;
        verticesList.Add(tipOrigin+(tipHalfWidth*Vector3.up));
        verticesList.Add(tipOrigin+(tipHalfWidth*Vector3.down));
        verticesList.Add(tipOrigin+(tipLength*Vector3.right));
        trianglesList.Add(4);
        trianglesList.Add(6);
        trianglesList.Add(5);
        mesh.vertices = verticesList.ToArray();
        mesh.triangles = trianglesList.ToArray();
    }
}
