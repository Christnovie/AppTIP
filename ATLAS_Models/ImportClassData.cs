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
            ClasseCollection collection = new ClasseCollection();
            this.collection = new ClasseCollection();
            this.collection = JsonConvert.DeserializeObject<ClasseCollection>(File.ReadAllText(System.Environment.CurrentDirectory + "\\..\\..\\DatabaseSoftwood.json"));
            collection = JsonConvert.DeserializeObject<ClasseCollection>(File.ReadAllText( System.Environment.CurrentDirectory + "\\..\\..\\DatabaseKmod.json"));
            this.collection.KmodClass = collection.KmodClass;
        }
        public ClasseCollection Collection
        {
            get { return collection; }
        }

    }
}