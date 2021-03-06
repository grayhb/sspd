﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SSPD;

namespace Контроль_запросов_ТКП
{
    public static class TKP_Log
    {

        /// <summary>
        /// Добавление записи в лог
        /// </summary>
        /// <param name="EventType">Событие</param>
        /// <param name="TableName">Имя таблицы</param>
        /// <param name="IDRec">Имя поля</param>
        public static void add(string EventType, string TableName, object IDRec)
        {
            //if (!flAddLog()) return;

            Dictionary<string, object> DS = new Dictionary<string, object>();
            DS.Add("ID_Worker", Params.UserInfo.ID_Worker);
            DS.Add("DateTimeLog", DateTime.Now.ToString());
            DS.Add("ID_RecTable", IDRec.ToString());
            DS.Add("TableName", TableName);
            DS.Add("EventLog", EventType);
            DS.Add("DescLog", getDesc(EventType));

            LocalDB.InsertData(DS, "КонтрольТКП_Лог");
        }


        /// <summary>
        /// Возвращает описание события
        /// </summary>
        /// <param name="EventType">тип события</param>
        /// <returns>Описание события</returns>
        private static string getDesc(string EventType)
        {
            string ret = "";

            if (EventType.ToLower().IndexOf("authorchecked") > -1)
                ret = "Отметка о проверке ТКП автором задания";
            else if (EventType.ToLower().IndexOf("status") > -1)
                ret = "Статус карточки запроса ТКП";
            else if (EventType == "Login")
                ret = "Запуск программы";
            else if (EventType.ToLower().IndexOf("loadondiskl") > -1)
                ret = "Выгрузка входящего документа на диск L";
            else if (EventType.IndexOf("flConAnal") > -1)
                ret = "Установка флага Коньюктурного анализа в карточке задания";
            else if (EventType.ToLower().IndexOf("usetkp") > -1)
                ret = "Установка флага использования ТКП в сметах в карточке задания";
            
            ret += string.Format(" [{0}  -  {1}]", Params.UserInfo.FIO, Params.UserInfo.NBMOtdel);

            return ret;
        }

        /// <summary>
        /// Флаг добавления лога
        /// </summary>
        /// <returns></returns>
        private static bool flAddLog()
        {
            if (Params.UserInfo.ID_Worker == "6774")
                return false;


            return true;
        }

    }
}
