using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace KnowledgeBase
{
    class AccidentController
    {
        public void Save(AccidentModel model)
        {
            // オブジェクトをファイルalice.binとしてシリアライズ
            using (Stream stream = File.OpenWrite("alice.bin"))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                formatter.Serialize(stream, model);
            }
        }

        public AccidentModel Load()
        {
            AccidentModel model = null;
            using (Stream stream = File.OpenRead("alice.bin"))
            {
                BinaryFormatter formatter = new BinaryFormatter();

                model = (AccidentModel)formatter.Deserialize(stream);
            }
            return model;
        }
    }
}
