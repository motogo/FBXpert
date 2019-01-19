using System.Windows.Forms;

namespace FBXpert.DataClasses
{
    class ContextMenusClass
    {
        private static ContextMenusClass instance = null;
       // public ContextMenuStrip cmsDatabase;
      //  public ContextMenuStrip cmsTableGroup;
      //  public ContextMenuStrip cmsSystemTableGroup;
      //  public ContextMenuStrip cmsTable;
    //    public ContextMenuStrip cmsSystemTable;
      //  public ContextMenuStrip cmsViewGroup;
      //  public ContextMenuStrip cmsView;
      //  public ContextMenuStrip cmsForeignKeyGroup;
      //  public ContextMenuStrip cmsForeignKey;
      //  public ContextMenuStrip cmsContraintsGroup;
      //  public ContextMenuStrip cmsContraints;
       // public ContextMenuStrip cmsTriggerGroup;
       // public ContextMenuStrip cmsTrigger;
       /*
        public ContextMenuStrip cmsProcedureGroup;
        public ContextMenuStrip cmsFunction;
        public ContextMenuStrip cmsFunctionGroup;
        public ContextMenuStrip cmsUserDefinedFunction;
        public ContextMenuStrip cmsUserDefinedFunctionGroup;
        public ContextMenuStrip cmsProcedure;
        public ContextMenuStrip cmsDomainGroup;
        public ContextMenuStrip cmsDomain;
        public ContextMenuStrip cmsIndicesGroup;
        public ContextMenuStrip cmsIndices;
        public ContextMenuStrip cmsRolesGroup;
        public ContextMenuStrip cmsRoles;
        */
     //   public ContextMenuStrip cmsGeneratorGroup;
     //   public ContextMenuStrip cmsGenerator;
        // public ContextMenuStrip cmsPrimaryKeyGroup;
        // public ContextMenuStrip cmsPrimaryKey;

        //  public ContextMenuStrip cmsFieldGroup;
        //  public ContextMenuStrip cmsField;
        public static ContextMenusClass Instance()
        {
            if (instance == null)
            {
                instance = new ContextMenusClass();                
            }
            return (instance);
        }
    }
}
