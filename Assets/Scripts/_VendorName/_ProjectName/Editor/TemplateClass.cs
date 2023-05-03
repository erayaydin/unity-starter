using UnityEditor;

namespace _VendorName._ProjectName.Editor
{
    // Namespace Properties
    
    /// <summary>
    /// Summary of the class.
    /// </summary>
    // Class Attributes
    public class TemplateClass
    {
        #region Events

        #endregion

        #region Properties

        #endregion

        #region Fields

        private const string MenuItemName = Meta.VendorName + "/" + Meta.ProjectName + "/MenuItem";

        #endregion

        #region Unity Events

        #endregion

        #region Methods

        [MenuItem(MenuItemName, false, 0)]
        public static void ExampleMenuItem()
        {
        }
        
        [MenuItem(MenuItemName, true, 0)]
        public static bool ExampleMenuItem_Validate()
        {
            return true;
        }
        
        #endregion

        #region Event Handlers

        #endregion
    }
}