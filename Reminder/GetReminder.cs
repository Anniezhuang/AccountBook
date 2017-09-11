using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook
{
    [Serializable]
    public class GetReminder
    {
        //ID
        public Guid ID { get; set; }

        //收入日期
        public string Time { get; set; }

        //备注
        public string Remark { get; set; }

        //收入金额
        public string Money { get; set; }

        //收入类别
        public string Class { get; set; }

        //添加到数据库，保存数据
        public void Add()
        {
            GlobalData.Get.Add(this);
            StorageHelper.Serialization<GetReminder>(GlobalData.Get, StorageHelper.GetReminderDat);
        }

        //更新数据并保存
        public void Update()
        {
            //遍历数据，找到要更新的数据，修改数据并保存
            foreach (GetReminder reminder in GlobalData.Get)
            {
                if (reminder.ID == this.ID)
                {
                    reminder.Class = this.Class;
                    reminder.Money = this.Money;
                    reminder.Remark = this.Remark;
                    reminder.Time = this.Time;
                    break;
                }
            }

            StorageHelper.Serialization<GetReminder>(GlobalData.Get, StorageHelper.GetReminderDat);
        }

        //删除数据。遍历数据，找到要删除的数据，删除掉，保存数据库
        public void Delete()
        {
            foreach (GetReminder reminder in GlobalData.Get)
            {
                if (reminder.ID == this.ID)
                {
                    GlobalData.Get.Remove(reminder);
                    break;
                }
            }
            StorageHelper.Serialization<GetReminder>(GlobalData.Get, StorageHelper.GetReminderDat);
        }

        //找到需要的数据
        public void Load()
        {
            foreach (GetReminder reminder in GlobalData.Get)
            {
                if (reminder.ID == this.ID)
                {
                    this.Class = reminder.Class;
                    this.Money = reminder.Money;
                    this.Remark = reminder.Remark;
                    this.Time = reminder.Time;
                    break;
                }
            }
        }

        //加载所有数据
        public static void LoadAll()
        {
            GlobalData.Get = StorageHelper.Deserialization<GetReminder>(StorageHelper.GetReminderDat);

            if (GlobalData.Get == null)
            {
                GlobalData.Get = new List<GetReminder>();
            }
        }

        //查询日支出，周支出，月支出。
        //0,1,2分别表示日支出，周支出，月支出查询
        //通过传递0,1,2，判断查询类别，进行所需要的操作
        //建一个临时的全局数据GlobalData.Tempget，用于返回需要查询的数据
        public static List<GetReminder> Search(string time, int state)
        {
            //初始化GlobalData.Tempget
            GlobalData.Tempget.Clear();
            GetReminder temp = new GetReminder();

            foreach (GetReminder reminder in GlobalData.Get)
            {
                temp = new GetReminder();

                //查询每一项收入
                //符合用户查询日期的收入，添加到GlobalData.Tempget中
                if (state == 0 && reminder.Time == time)
                {
                    temp.Time = reminder.Time;
                    temp.Remark = reminder.Remark;
                    temp.ID = reminder.ID;
                    temp.Money = reminder.Money;
                    temp.Class = reminder.Class;
                    GlobalData.Tempget.Add(temp);
                }

                //查询每一项收入
                //和用户查询日期的月份相同的收入，添加到GlobalData.Tempget中
                if (state == 2 && Convert.ToDateTime(reminder.Time).Month 
                    == Convert.ToDateTime(time).Month)
                {
                    temp.Time = reminder.Time;
                    temp.Remark = reminder.Remark;
                    temp.ID = reminder.ID;
                    temp.Money = reminder.Money;
                    temp.Class = reminder.Class;
                    GlobalData.Tempget.Add(temp);
                }

                //参考https://zhidao.baidu.com/question/580407451.html
                //计算某一天的那周的开始时间和结束时间
                //如果收入的日期所在的周和用户查询日期所在的周是相同的,
                //那么这个收入添加到GlobalData.Tempcost中
                if (state == 1)
                {
                    int week = (int)Convert.ToDateTime(time).DayOfWeek;
                    if (week == 0)
                    {
                        //按中国的习惯，星期天是最后一天
                        week = 7;
                    }

                    //得到某一天的那周的开始时间和结束时间
                    DateTime dtWeekSt = Convert.ToDateTime(time).AddDays(1 - week);
                    DateTime dtWeekEd = Convert.ToDateTime(time).AddDays(7 - week);

                    if (DateTime.Compare
                        (Convert.ToDateTime(reminder.Time), dtWeekSt) >= 0
                        && DateTime.Compare
                        (Convert.ToDateTime(reminder.Time), dtWeekEd) <= 0)
                    {
                        temp.Time = reminder.Time;
                        temp.Remark = reminder.Remark;
                        temp.ID = reminder.ID;
                        temp.Money = reminder.Money;
                        temp.Class = reminder.Class;
                        GlobalData.Tempget.Add(temp);
                    }
                }
            }
            return GlobalData.Tempget;
        }

    }
}
