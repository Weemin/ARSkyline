// Copyright 2022 ARSkyline Authors. All rights reserved.
// Powered by Weemin

#if UNITY_EDITOR
    using UnityEditor;
    using UnityEditor.SceneManagement;
#endif
using UnityEngine;
using UnityEngine.SceneManagement;

// Author: Maxime PREMONT

[ExecuteInEditMode]
public class SceneLoader : MonoBehaviour {

    [SerializeField] private SceneReference[] scenes;
    public string scenesFolder;
    public bool wipeScenesList = false;

    public void Start() {
        if (Application.isEditor) {
            #if UNITY_EDITOR
                if (EditorApplication.isPlayingOrWillChangePlaymode) {
                    for (int j = 0; j < scenes.Length; j++) {
                        LoadSceneParameters parameters = new LoadSceneParameters();
                        parameters.loadSceneMode = LoadSceneMode.Additive;
                        SceneManager.UnloadSceneAsync(scenes[j]);
                        EditorSceneManager.LoadSceneInPlayMode(scenes[j].ScenePath, parameters);
                    }
                } else {
                    for (int j = 0; j < scenes.Length; j++)
                        EditorSceneManager.OpenScene(scenes[j].ScenePath, OpenSceneMode.Additive);
                }
            #endif
        } else {
            for (int j = 0; j < scenes.Length; j++)
                SceneManager.LoadScene(scenes[j], LoadSceneMode.Additive);
        }
    }
}
