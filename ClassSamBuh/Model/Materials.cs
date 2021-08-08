using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSamBuh.Model

{/// <summary>
/// Основной класс всех материалов
/// </summary>
/// 
[Serializable]
    public class Materials
    {
        /// <summary>
        /// Название материала
        /// </summary>
        public string NameMaterials { get;  }

        /// <summary>
        /// Cost это закупочная цена
        /// </summary>

        public int CostMaterials { get; set; }

        /// <summary>
        /// Price цена продажи
        /// </summary>

        public int PriceMaterials { get; set; }


        public int ProfitMaterials { get; set; }

        public Materials(int costMaterials, int priceMaterials)
        { CostMaterials = costMaterials;
            PriceMaterials = priceMaterials;
        }

        public override string ToString()
        {
            return NameMaterials;
        }

    }
}
