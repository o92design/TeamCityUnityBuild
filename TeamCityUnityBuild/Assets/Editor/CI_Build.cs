using UnityEditor;
using UnityEngine;

public class CI_Build : MonoBehaviour
{
    /// <summary>
    /// Calls the CLI perform build function which exits the editor after finish
    /// <br>
    /// <seealso cref="https://github.com/superunitybuild/buildtool/wiki/Command-Line-Interface"/> 
    /// </br>
    /// </summary>
    [MenuItem("Build/Perform Build")]
    public static void CLI_PerformBuild()
    {
        SuperUnityBuild.BuildTool.BuildCLI.PerformBuild();
    }
}
