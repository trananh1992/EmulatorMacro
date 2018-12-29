﻿using Macro.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Windows;

namespace Macro.Extensions
{
    public static class ObjectExtensions
    {
        public static byte[] SerializeObject(this ConfigEventModel model)
        {
            using (var ms = new MemoryStream())
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(ms, "\uFF1C");
                bf.Serialize(ms, model.Index);
                bf.Serialize(ms, model.Image);
                bf.Serialize(ms, model.EventType);
                bf.Serialize(ms, model.MousePoint?? new object());
                bf.Serialize(ms, model.KeyboardCmd);
                bf.Serialize(ms, model.ProcessName);
                bf.Serialize(ms, "\uFF1E");
                return ms.ToArray();
            }
        }
        public static List<ConfigEventModel> DeserializeObject(byte[] data)
        {
            var list = new List<ConfigEventModel>();
            using (var ms = new MemoryStream(data))
            {
                BinaryFormatter bf = new BinaryFormatter();
                while (ms.Position < ms.Length)
                {
                    var model = new ConfigEventModel();
                    var startTag = bf.Deserialize(ms);
                    model.Index = (int)bf.Deserialize(ms);
                    model.Image = (System.Drawing.Bitmap)bf.Deserialize(ms);
                    model.EventType = (EventType)bf.Deserialize(ms);
                    model.MousePoint = (Point?)bf.Deserialize(ms);
                    model.KeyboardCmd = (string)bf.Deserialize(ms);
                    model.ProcessName = (string)bf.Deserialize(ms);
                    var endTag = bf.Deserialize(ms);
                    list.Add(model);
                }
            }
            return list;
        }
        public static bool Remove(this ObservableCollection<ConfigEventModel> collection, int key)
        {
            foreach(var item in collection)
            {
                if(item.Index == key)
                {
                    collection.Remove(item);
                    return true;
                }
            }
            return false;
        }
    }
}
