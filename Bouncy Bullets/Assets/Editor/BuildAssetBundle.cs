using UnityEngine;
using UnityEditor;
using System.IO;

public class BuildAssetBundle {

    [MenuItem("Assets/Build Asset Bundle")]
    static void BuildAllAssetBundle() {
        string bundleDirectory = "Assets/StreamingAssets";
        if (!Directory.Exists(Application.streamingAssetsPath)) {
            Directory.CreateDirectory(bundleDirectory);
        }
        BuildPipeline.BuildAssetBundles(bundleDirectory, BuildAssetBundleOptions.None, EditorUserBuildSettings.activeBuildTarget);
    }
}