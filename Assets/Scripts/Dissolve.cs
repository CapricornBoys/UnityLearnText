using UnityEngine;

/// <summary>
/// 该脚本挂在要溶解的物体上
/// </summary>
public class Dissolve : MonoBehaviour
{
    /// <summary>
    /// 材质球
    /// </summary>
    public Material mat;
    /// <summary>
    /// 要靠近过来的物体
    /// </summary>
    public Transform m_targetObj;



    // Update is called once per frame
    void Update()
    {
        // ShaderGraph 公用变量id
        mat.SetVector("Vector3_2EA64B54", m_targetObj.position);
    }
}
