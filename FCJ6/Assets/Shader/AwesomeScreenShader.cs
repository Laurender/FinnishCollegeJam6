using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AwesomeScreenShader : MonoBehaviour
{
    
    public Shader awesomeShader = null;
    private Material m_renderMaterial;
    
    void Start()
    {
        if (awesomeShader == null)
        {
            Debug.LogError("no awesome shader.");
            m_renderMaterial = null;
            return;
        }

        m_renderMaterial = new Material(awesomeShader);
        
    }

    void OnRenderImage(RenderTexture source, RenderTexture destination)
    {
        if(m_renderMaterial == null)
        {
            Graphics.Blit(source, destination);
            return;
        }
        Graphics.Blit(source, destination, m_renderMaterial);
    }
}
