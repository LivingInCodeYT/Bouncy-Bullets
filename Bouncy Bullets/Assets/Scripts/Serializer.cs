using System.Xml.Serialization;
using System.IO;

namespace LivingInCode.PreMadeCode {
    public class Serializer {
        public static string Serialize<T>(T toSerialize) {
            XmlSerializer serializer = new XmlSerializer(typeof(T));
            StringWriter writer = new StringWriter();
            serializer.Serialize(writer, toSerialize);
            writer.Close();
            return writer.ToString();
        }
        public static T DeSerialize<T>(string toDeSerialize) {
            XmlSerializer deSerializer = new XmlSerializer(typeof(T));
            StringReader reader = new StringReader(toDeSerialize);
            T deSerialized = (T)deSerializer.Deserialize(reader);
            reader.Close();
            return deSerialized;
        }
    }
}