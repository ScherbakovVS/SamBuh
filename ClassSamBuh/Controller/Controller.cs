using ClassSamBuh.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace ClassSamBuh.Controller
{
    public class Controller
    {
        public Materials Materials { get; }

        public Controller(Materials materials)
        {
            Materials = materials ?? throw new ArgumentNullException("Поле материал не может быть null", nameof(materials));
        }

        /// <summary>
        /// Сохранение материалов
        /// </summary>
        public void SaveMaterials()
        {
            var formatter = new BinaryFormatter(); 

            using (var fs = new FileStream("materials.dat", FileMode.OpenOrCreate))
            {
                formatter.Serialize(fs, Materials);
            
            }

            
        }


        /// <summary>
        /// Загрузка материалов 
        /// </summary>
        /// <returns></returns>
        public Materials LoadMaterials()
        {
            var formatter = new BinaryFormatter();

            using (var fs = new FileStream("materials.dat", FileMode.OpenOrCreate))
            {
                return formatter.Deserialize(fs) as Materials;

            }
        }


        public Agent Agent { get; }

        public Controller(string NameAgent, int NumberOfContract)
        {
            Agent = new Agent(NameAgent, NumberOfContract); 
        }

        /// <summary>
        /// Сохранение материалов
        /// </summary>
        public void SaveAgent()
        {
            var saveAgent = new BinaryFormatter();

            using (var fs2 = new FileStream("agents.dat", FileMode.OpenOrCreate))
            {
                saveAgent.Serialize(fs2, Agent);

            }


        }


        /// <summary>
        /// Загрузка материалов 
        /// </summary>
        /// <returns></returns>
        public Agent LoadAgent()
        {
            var loadAgent = new BinaryFormatter();

            using (var fs = new FileStream("agents.dat", FileMode.OpenOrCreate))
            {
                return loadAgent.Deserialize(fs) as Agent;

            }

        }
    }
}
