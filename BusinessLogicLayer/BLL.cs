using System;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessLogicLayer
{
    public abstract class Registration
    {
        protected DAL d;
        public Registration()
        {
            d = new DAL();
        }
        public abstract void Register();
        protected void OpenAndCloseConnection(Action action)
        {
            d.OpenConnection();
            action();
            d.CloseConnection();
        }
    }
    public class Teacher : Registration
    {
        public override void Register()
        {
            OpenAndCloseConnection(() =>
            {
                d.LoadSpParameters("_spinsertteacherinfo", tid, tname, tgender, tCNIC, tcontact);
                d.ExecuteQuery();
                d.UnLoadSpParameters();
            });
        }
        public int tid { get; set; }
        public string tname { get; set; }
        public string tgender { get; set; }
        public string tCNIC { get; set; }
        public string tcontact { get; set; }
    }
    public class Student : Registration
    {
        public override void Register()
        {
            OpenAndCloseConnection(() =>
            {
                d.LoadSpParameters("_spinsertstudentinfo", sid, sname, scontact, saddress);
                d.ExecuteQuery();
                d.UnLoadSpParameters();
            });
        }
        public int sid { get; set; }
        public string sname { get; set; }
        public string scontact { get; set; }
        public string saddress { get; set; }
    }
    public class BLL
    {
        public void RegisterTeacher(int tid, string tname, string tgender, string tCNIC, string tcontact)
        {
            Teacher teacher = new Teacher
            {
                tid = tid,
                tname = tname,
                tgender = tgender,
                tCNIC = tCNIC,
                tcontact = tcontact
            };
            teacher.Register();
        }
        public void RegisterStudent(int sid, string sname, string scontact, string saddress)
        {
            Student student = new Student
            {
                sid = sid,
                sname = sname,
                scontact = scontact,
                saddress = saddress
            };
            student.Register();
        }
        public bool SelectStudent(int sid, string spassword)
        {
            DAL d = new DAL();
            d.OpenConnection();
            d.LoadSpParameters("_spselectstudentinfo", sid, spassword);
            SqlDataReader reader = d.GetDataReader();
            bool loginSuccessful = reader.Read();
            d.CloseConnection();
            return loginSuccessful;
        }
        public bool SelectTeacher(int tid, string tpassword)
        {
            DAL d = new DAL();
            d.OpenConnection();
            d.LoadSpParameters("_spselectteacherinfo", tid, tpassword);
            SqlDataReader reader = d.GetDataReader();
            bool loginSuccessful = reader.Read();
            d.CloseConnection();
            return loginSuccessful;
        }
    }
}
