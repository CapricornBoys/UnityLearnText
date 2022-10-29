using UnityEditor;
using UnityEngine;
using UnityEngine.UI;

public class UIUtils
    {

        private static Material m_garyMaterial;
        public static Material GaryMaterial
        {
            get
            {
                if (m_garyMaterial == null)
                {
                    m_garyMaterial = AssetDatabase.LoadAssetAtPath<Material>("Assets/Material/Gray.mat");
                }
                return m_garyMaterial;
            }
        }
        /// <summary>
        /// 图片置灰
        /// </summary>
        /// <param name="img"></param>
        /// <param name="isGary"></param>
        public static void SetImgGary(Image img, bool isGary)
        {
            if (img != null)
            {
                if (isGary)
                {
                    img.material = GaryMaterial;
                }
                else
                {
                    img.material = null;
                }
            }

        }
    }
