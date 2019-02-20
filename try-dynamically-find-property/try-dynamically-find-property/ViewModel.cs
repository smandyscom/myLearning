﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Runtime.InteropServices.Expando;

namespace try_dynamically_find_property
{
    public class ObjectIndexer

    {
        
        private Model m_model = new Model();
        private Dictionary<string, Func<object>> m_modelProperties = new Dictionary<string, Func<object>>();

        public object this[string key]
        {
            get
            {
                return m_modelProperties[key].Invoke();
            }
            set
            {
                //m_modelProperties[index.ToString()] = value;
            }
        }

        public ObjectIndexer()
        {
            //Scan all properties from model
            var properties = typeof(Model).GetProperties(System.Reflection.BindingFlags.Public);
            foreach (var item in properties)
            {
                m_modelProperties.Add(item.Name, delegate { return item.GetValue(m_model); } );
            }
        }

       
    }

    public class ViewModel : INotifyPropertyChanged
    {
        /// <summary>
        /// The collection property
        /// </summary>
        public Dictionary<string, object> Collection {
            get
            {
                return m_collection;
            }
            set
            {
                //TODO , whole dictionary copy?
                m_collection = value;
            }
        }

        public string NamedStaticProperty
        {
            get => m_namedStaticProperty;
            set {
                m_namedStaticProperty = value;
                OnPropertyChanged(); 
            }
        }
        internal string m_namedStaticProperty = DateTime.Now.ToString();

        internal Dictionary<string, object> m_collection = new Dictionary<string, object>();

        private Model m_model = new Model();


        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// TODO , when to raise
        /// </summary>
        /// <param name="key"></param>
        internal void OnPropertyChanged(string key = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(key));
        }

        public ViewModel()
        {
            //Scan all properties from model
            var properties = typeof(Model).GetProperties(System.Reflection.BindingFlags.Public | 
                System.Reflection.BindingFlags.NonPublic |
                 System.Reflection.BindingFlags.Instance);
            foreach (var item in properties)
            {
                m_collection.Add(item.Name, item.GetValue(m_model));
            }
        }
    }
}
