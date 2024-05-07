
using UnityEditor;
using UnityEngine;

public class SkillCreateWindow : EditorWindow
{
    static SkillCreateWindow window;
    private string skillId;
    [MenuItem("GameTools/��������")]
    private static void Init() 
    {
        window = GetWindow<SkillCreateWindow>("���ܱ༭��");
        window.position = new Rect(200, 300, 600, 400);
        window.maxSize = new Vector2(600, 400);
        window.Show();
    }

    private void OnGUI()
    {
        skillId = EditorGUILayout.TextField("�����뼼��id:", skillId);
       
        if (GUILayout.Button("����"))
        {
            if (int.TryParse(skillId, out int a))
            {
                SkillConfigTool.CraeteSkillGameObject(a);
                window.Close();
            }
            else 
            {
                EditorUtility.DisplayDialog("����","����id��������������","ȷ��");
            }
        }

    }
}
