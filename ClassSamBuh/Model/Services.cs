using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSamBuh.Model
{/// <summary>
 /// Основной класс всех услуг
 /// </summary>
 /// 
    [Serializable]
    public class Services
    {
        /// <summary>
        /// Название услуги
        /// </summary>
        public string NameService { get; }

        /// <summary>
        /// Cost - себестоимость
        /// </summary>

        public int CostService { get; set; }

        /// <summary>
        /// Price цена услуги
        /// </summary>

        public int PriceService { get; set; }


        public int ProfitService { get; set; }

        public Services(int costService, int priceService)
        {
            CostService = costService;
            PriceService = priceService;
        }

        public override string ToString()
        {
            return NameService;
        }

    }
}
