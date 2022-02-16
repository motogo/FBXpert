using FBXpertLib.DataClasses;
using System;
using System.IO;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;


namespace Initialization
{
    /// <summary>
    /// Zusammenfassende Beschreibung für Class
    /// </summary>


    public class SQLViewLastRunClass
	{
		public string MainPfad=System.Environment.CurrentDirectory;
        public string XMLName;				
	                    
        public string ScriptPath;                               
        public string ServerDatabasePfad = "";                     
        
        public eAppType AppType;        
        public bool TestMode = false;
        public string Version;
      
        public string ServerName;
        public string ClientName;

		public SQLViewLastRunClass()
		{
			//
			// TODO: Hier die Konstruktorlogik einfügen
			//			
		}
		private static SQLViewLastRunClass instance = null;
		public static SQLViewLastRunClass Instance()
		{
		   if(instance == null)
		   {
			  instance = new SQLViewLastRunClass();
		   }
		   return(instance);
		}
        public void TestParams()
        {
            string error_str = "";                                    
            if(error_str.Length > 0)
            MessageBox.Show(error_str, "Pfade SQLView unvollständig !!!", MessageBoxButtons.OK, MessageBoxIcon.Error);            
        }
		public bool Deserialize(string FileName)
		{
				bool ok = false;
				XmlReader reader;
                FileInfo fi = new FileInfo(FileName);
                if (fi.Exists)
                {
                    try
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(SQLViewLastRunClass));
                        Stream fs = new FileStream(FileName, FileMode.Open);
                        reader = new XmlTextReader(fs);
                        SQLViewLastRunClass PF = (SQLViewLastRunClass)serializer.Deserialize(reader);
                        reader.Close();
                        this.XMLName = FileName;
                        this.ServerDatabasePfad = PF.ServerDatabasePfad;
                        this.Version = PF.Version;
                        this.AppType = PF.AppType;
                        this.ServerName = PF.ServerName;
                        this.ClientName = PF.ClientName;
                        this.ScriptPath = PF.ScriptPath;
                        TestParams();
                        ok = true;
                    }
                    catch (Exception ex)
                    {
                        ok = false;
                        MessageBox.Show(ex.Message + "\r\nFile:" + FileName, "Grundparameter für SQLView konnten nicht geladen werden.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return (ok);
                    }
                    finally
                    {

                    }
                }
                else
                {
                    MessageBox.Show(fi.FullName + " existier nicht.", "Grundparameter für SQLView konnten nicht geladen werden.", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

				return(ok);
		}
		
		public void SerializeCurrent()
        {
			XmlSerializer serializer   = new XmlSerializer(typeof(SQLViewLastRunClass));
			XmlQualifiedName q1 = new XmlQualifiedName("", "");
			XmlQualifiedName[] names = {q1};
			XmlSerializerNamespaces test = new XmlSerializerNamespaces(names);
			Stream writer = new FileStream(this.XMLName, FileMode.Create);
			serializer.Serialize(writer, instance, test);
			writer.Close();
		}

	}

    
}
