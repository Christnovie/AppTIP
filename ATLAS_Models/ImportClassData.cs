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
        private ClasseCollection collectionKmod;
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
            collectionKmod = new ClasseCollection();
            collection = JsonConvert.DeserializeObject<ClasseCollection>(File.ReadAllText(System.Environment.CurrentDirectory + "\\..\\..\\DatabaseSoftwood.json"));
            collectionKmod = JsonConvert.DeserializeObject<ClasseCollection>(File.ReadAllText(System.Environment.CurrentDirectory + "\\..\\..\\DatabaseKmod.json"));
         //   collectionKmod = JsonConvert.DeserializeObject<Dictionary<string, KmodClass>>(System.Environment.CurrentDirectory + "\\..\\..\\DatabaseKmod.json");
        }
        public ClasseCollection Collection
        {
            get { return collection; }
        }
        public ClasseCollection CollectionKmod
        {
            get { return collectionKmod; }
        }
    }
}