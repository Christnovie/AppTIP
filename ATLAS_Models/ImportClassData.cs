using System.Collections.Generic;
using System;
using System.IO;
using System.Text;
using ATLAS_Models;
using Newtonsoft.Json;


namespace ATLAS_Models
{
    public class ImportClassData
    {
        private ClasseCollection collection;
        List<WoodClass> classList = new List<WoodClass>();
        public ImportClassData()
        {
            GetSoftwoodDataValue();
        }

        public static WoodClass GetSoftwoodDataValueTarget(ClasseCollection classData, string classVal)
        {
            WoodClass woodClass = new WoodClass();
            if (classData.CollectionWood.ContainsKey(classVal))
            {
                woodClass = classData.CollectionWood[classVal];
             
            }
        
            return woodClass;
        }
        public void  GetSoftwoodDataValue()
        {
            collection = new ClasseCollection();
            collection = JsonConvert.DeserializeObject<ClasseCollection>(File.ReadAllText(System.Environment.CurrentDirectory + "\\..\\..\\DatabaseSoftwood.json"));
        }
        public ClasseCollection Collection
        {
            get { return collection; }
        }

    }
}