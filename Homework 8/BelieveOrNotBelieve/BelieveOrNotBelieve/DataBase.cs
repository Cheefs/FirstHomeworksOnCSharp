
using System;
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace BelieveOrNotBelieve
{
    // Класс для вопроса    
    [Serializable]
    public class Question
    {
        string Text;    // Текст вопроса
        bool TrueFalse;// Правда или нет
                              
        public Question()
        {
        }

        public string text 
        {
            get { return Text; }
            set { Text = value; }
        }
        public bool trueFalse
        {
            get { return TrueFalse; }
            set { TrueFalse = value; }
        }
        public Question(string Text, bool TrueFalse)
        {
           this.Text = Text;
           this.TrueFalse = TrueFalse;
        }
    }
    // Класс для хранения списка вопросов. А так же для сериализации в XML и десериализации из XML
    class TrueFalse
    {
        string fileName;
        List<Question> list;
        public string FileName
        {
            set { fileName = value; }
        }
        public TrueFalse(string fileName)
        {
            this.fileName = fileName;
            list = new List<Question>();
        }
        public void Add(string text, bool trueFalse)
        {
            //Question question = new Question(text, trueFalse);
            list.Add(new Question(text, trueFalse));
        }
        public void Remove(int index)
        {
            if (list != null && index < list.Count && index >= 0) list.RemoveAt(index);
        }

        // Индексатор - свойство для доступа к закрытому объекту
        public Question this[int index]
        {
            get { return list[index]; }
            set { list[index] = value; }
        }

        public void Save()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            xmlFormat.Serialize(fStream, list);
            fStream.Close();
        }
        public void Load()
        {
            XmlSerializer xmlFormat = new XmlSerializer(typeof(List<Question>));
            Stream fStream = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            list = (List<Question>)xmlFormat.Deserialize(fStream);
            fStream.Close();
        }
        public int Count
        {
            get { return list.Count; }
        }
    }
}