using ReactUnity.Layout;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace ReactUnity.Editor
{
    [CustomEditor(typeof(ReactElement))]
    public class ReactElementDrawer : UnityEditor.Editor
    {
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();

            if (GUILayout.Button("Edit Style"))
            {
                EditStyleWindow.Open();
            }
        }
    }
}
