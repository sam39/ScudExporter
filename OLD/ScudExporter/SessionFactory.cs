using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NHibernate;
using NHibernate.Cfg;
using System.Runtime.Remoting.Messaging;

namespace ScudExporter
{
    public class SessionFactory
    {
        public static void Init()
        { 
            Configuration cfg = new Configuration();            
            cfg.AddAssembly("ScudExporter");       
            sessionFactory = cfg.BuildSessionFactory();
        }

        private static ISessionFactory sessionFactory; //Объект фабрики сессий, реализованный в хибере

        public static ISession GetSession() //Метод возвращающий нам сессию.
        {
            return sessionFactory.OpenSession();
        }

        public static IStatelessSession GetStatelessSession() //Метод возвращающий нам сессию.
        {
            return sessionFactory.OpenStatelessSession();
        }
    }

    //public class SessionFactory
    //{
    //    public static void Init() //Инициализация фабрики сессий
    //    {
    //        Configuration cfg = new Configuration();
    //        cfg.AddAssembly("CompC"); //Конфигурируем NHibernate. Здесь мы указываем на сборку, в которой хранятся мои хибер классы.
    //        //cfg.Configure();
    //        //cfg.AddClass(typeof(Price));
    //        sessionFactory = cfg.BuildSessionFactory();
    //    }
    //    private static ISessionFactory sessionFactory; //Объект фабрики сессий, реализованный в хибере
    //    private static ISession threadSession //Сама сессия
    //    {
    //        get
    //        {
    //            return (ISession)System.Runtime.Remoting.Messaging.CallContext.GetData("THREAD_SESSION"); //Сессию мы храним в контексте, вот так работать с контекстом
    //        }
    //        set
    //        {
    //            CallContext.SetData("THREAD_SESSION", value);
    //        }
    //    }

    //    public static ISession GetSession() //Метод возвращающий нам сессию.
    //    {
    //        ISession session = threadSession; //Берем сессию из контекста

    //        if (session == null) //Смотрим “метрва” ли она
    //        {
    //            session = sessionFactory.OpenSession(); //Через фабрику сессий открываем сессию
    //            threadSession = session; //Записываем ее в контекс
    //        }

    //        return session; //Возвращаем
    //    }
    //}
}
