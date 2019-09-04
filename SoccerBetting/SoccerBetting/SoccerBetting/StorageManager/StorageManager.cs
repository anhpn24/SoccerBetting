using SoccerBetting.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Linq;
using Xamarin.Forms;

namespace SoccerBetting.StorageManager
{
    public static class StorageManager<T> where T : BaseModel
    {
        private static List<T> _cache { get; set; }
        private static string _filePath { get; set; } = GetFilePath();

        public static string GetFilePath()
        {
            if(!string.IsNullOrWhiteSpace(_filePath) && File.Exists(_filePath))
            {
                return _filePath;
            }

            var localFolder = System.Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            var filePath = localFolder + "/" + typeof(T).Name + ".json";

            string folderPath = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }

            return filePath;
        }

        public static T FindRecordById(Predicate<T> condition)
        {
            var currentData = All();
            return currentData?.Find(condition);
        }

        public static void Add(T model)
        {
            if(model == null)
            {
                throw new ArgumentNullException("Model Input Null Exception");
            }
            Add(new List<T>() { model });
        }

        public static void Add(IEnumerable<T> listModel)
        {
            if (listModel == null)
            {
                throw new ArgumentNullException("List Model Input Null Exception");
            }

            if (!listModel.Any())
            {
                return;
            }

            List<T> listData = listModel.ToList();
            string data = JsonConvert.SerializeObject(listData, Formatting.Indented);

            if (File.Exists(_filePath))
            {
                string currentData = File.ReadAllText(_filePath);
                if (!string.IsNullOrWhiteSpace(currentData))
                {
                    listData = JsonConvert.DeserializeObject<List<T>>(currentData);
                    if (listData == null || listData.Count > 0)
                    {
                        listData.AddRange(listModel);
                        data = JsonConvert.SerializeObject(listData, Formatting.Indented);
                    }
                }
            }

            File.WriteAllText(_filePath, data);
            _cache = listData;
        }

        public static List<T> All()
        {
            List<T> dataModel = new List<T>();

            if (_cache != null)
            {
                return _cache;
            }
            else
            {
                string stringData = File.ReadAllText(_filePath);
                dataModel = JsonConvert.DeserializeObject<List<T>>(stringData);

                if (dataModel != null && dataModel.Count > 0)
                {
                    _cache = dataModel;
                }
                return dataModel;
            }
        }

        public static void Update(T model)
        {
            if(model == null)
            {
                throw new ArgumentNullException("Model Input Null Exception");
            }

            Update(new List<T>() { model });
        }

        public static void Update(IEnumerable<T> listModel)
        {
            if (listModel == null)
            {
                throw new ArgumentNullException("List Model Input Null Exception");
            }

            if (!listModel.Any())
            {
                return;
            }

            List<T> currentData = All();
            if (currentData != null && currentData.Count > 0)
            {
                foreach (var model in listModel)
                {
                    var editRecordIndex = currentData.FindIndex(x => x.GuidId == model.GuidId);
                    if (editRecordIndex != -1)
                    {
                        currentData[editRecordIndex] = model;
                        currentData[editRecordIndex].ModifiedDate = DateTime.Now;
                    }
                    else
                    {
                        throw new KeyNotFoundException("Record Id Not Found Exception");
                    }
                }

                string stringData = JsonConvert.SerializeObject(currentData);
                File.WriteAllText(_filePath, stringData);
                _cache = currentData;
            }
            else
            {
                throw new ArgumentNullException("Current Data Null Exception");
            }
        }

        public static void Delete(IEnumerable<Guid> listId)
        {
            if (!listId.Any())
            {
                return;
            }

            List<T> currentData = All();
            if (currentData != null && currentData.Count > 0)
            {
                foreach(var id in listId)
                {
                    var deleteRecordIndex = currentData.FindIndex(x => x.GuidId == id);
                    if (deleteRecordIndex != -1)
                    {
                        currentData.RemoveAt(deleteRecordIndex);
                    }
                    else
                    {
                        throw new KeyNotFoundException("Record Id Not Found Exception");
                    }
                }

                string stringData = JsonConvert.SerializeObject(currentData);
                File.WriteAllText(_filePath, stringData);
                _cache = currentData;
            }
            else
            {
                throw new ArgumentNullException("Current Data Null Exception");
            }
        }

        public static void Delete(Guid Id)
        {
            Delete(new List<Guid>() { Id });
        }

        public static void Delete(IEnumerable<T> listModel)
        {
            if (listModel == null)
            {
                throw new ArgumentNullException("List Model Input Null Exception");
            }

            var listId = listModel.Select(x => x.GuidId);
            Delete(listId);
        }

        public static void Delete(T model)
        {
            if (model != null)
            {
                Delete(model.GuidId);
            }
            else
            {
                throw new ArgumentNullException("Model Input Null Exception");
            }
        }

        public static void RefreshCache()
        {
            _cache = null;
            _cache = All();
        }

    }
}
