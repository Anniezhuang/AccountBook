using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//设置全局的数据
namespace AccountBook
{
    public class GlobalData
    {
        public static List<CostReminder> Cost { get; set; }
        public static List<GuessReminder> Guess { get; set; }
        public static List<GetReminder> Get { get; set; }
        public static List<CostReminder> Tempcost { get; set; }
        public static List<GetReminder> Tempget { get; set; }

        //初始化List<>数据
        static GlobalData()
        {
            Cost = new List<CostReminder>();
            Guess= new List<GuessReminder>();
            Get= new List<GetReminder>();
            Tempcost = new List<CostReminder>();
            Tempget = new List<GetReminder>();
        }
    }
}
