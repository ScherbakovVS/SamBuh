using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSamBuh.Model
{/// <summary>
/// Класс для контрагентов
/// </summary>
/// 
[Serializable]
    public class Agent

    {
        /// <summary>
        /// Название организации
        /// </summary>
        public string NameAgent { get; }
        

        /// <summary>
        /// Номер действующего договора
        /// </summary>
        public int NumberOfContract { get; set; }

        #region
        public Agent(string nameAgent, int numberofcontract)
        { if (string.IsNullOrWhiteSpace(nameAgent))
            {
                throw new ArgumentNullException("Ввели пустое имя",nameof(nameAgent));

            }
            if (numberofcontract <= 0)
            { throw new ArgumentNullException("Номер договора не может быть меньше или равен нулю", nameof(nameAgent));
            }
            NameAgent = nameAgent;
            NumberOfContract = numberofcontract;
        }
        #endregion

        public override string ToString()
        {
            return NameAgent;
        }


    }
}
