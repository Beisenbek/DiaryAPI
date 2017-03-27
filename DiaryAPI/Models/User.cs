using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DiaryAPI.Models
{
    public enum DiaryRoles
    {
        Teacher,
        Parent,
        Pupil
    }
    public class User
    {
        public string name;
        public string surname;
        public DiaryRoles role;
        public string id;
        public string photo_url;
    }
}