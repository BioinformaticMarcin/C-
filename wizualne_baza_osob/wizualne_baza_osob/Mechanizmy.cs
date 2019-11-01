using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;

namespace wizualne_baza_osob
{
    public class Mechanizmy
    {
        public void writeXML(List<Osoba> lista_osob)
        {
            XmlSerializer writer = new XmlSerializer(typeof(List<Osoba>));

            var path = Directory.GetCurrentDirectory() + "//SerializationOverview.xml";

            FileStream file = File.Create(path);

            writer.Serialize(file, lista_osob);
            file.Close();
        }
        public List<Osoba> readXML(List<Osoba> lista_osob)
        {
            XmlSerializer reader = new XmlSerializer(typeof(List<Osoba>));

            try
            {
                StreamReader file = new StreamReader(Directory.GetCurrentDirectory() + "//SerializationOverview.xml");
                lista_osob = (List<Osoba>)reader.Deserialize(file);
                file.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
            return lista_osob;
        }



    }
}
