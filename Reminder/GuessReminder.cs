using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBook
{
    [Serializable]
    public class GuessReminder
    {
        //ID
        public Guid ID { get; set; }

        //预算日期
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
            GlobalData.Guess.Add(this);
            StorageHelper.Serialization<GuessReminder>(GlobalData.Guess, StorageHelper.GuessReminderDat);
        }

        //更新数据并保存
        public void Update()
        {
            //遍历数据，找到要更新的数据，修改数据并保存
            foreach (GuessReminder reminder in GlobalData.Guess)
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

            StorageHelper.Serialization<GuessReminder>(GlobalData.Guess, StorageHelper.GuessReminderDat);
        }

        //删除数据。遍历数据，找到要删除的数据，删除掉，保存数据库
        public void Delete()
        {
            foreach (GuessReminder reminder in GlobalData.Guess)
            {
                if (reminder.ID == this.ID)
                {
                    GlobalData.Guess.Remove(reminder);
                    break;
                }
            }
            StorageHelper.Serialization<GuessReminder>(GlobalData.Guess, StorageHelper.GuessReminderDat);
        }

        //找到需要的数据
        public void Load()
        {
            foreach (GuessReminder reminder in GlobalData.Guess)
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
            GlobalData.Guess = StorageHelper.Deserialization<GuessReminder>(StorageHelper.GuessReminderDat);

            if (GlobalData.Guess == null)
            {
                GlobalData.Guess = new List<GuessReminder>();
            }
        }
        
    }
}
