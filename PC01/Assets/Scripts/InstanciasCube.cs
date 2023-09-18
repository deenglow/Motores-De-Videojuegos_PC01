using UnityEngine;
public class InstanciasCube : MonoBehaviour
{
    // Start is called before the first frame update
    public ScriptableObjectsInGame scriptableObjectsInGame;
    void Start()
    {
        for (int i = 0; i < scriptableObjectsInGame.numeroPrefabRespawn; i++)
        {
            Instantiate(scriptableObjectsInGame.prefab, transform.position, Quaternion.identity);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
