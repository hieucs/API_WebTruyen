using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace api.truyenonline.Models
{
    public class MenuItem
    {
        public string ID { get; set; }
        public string IDParent { get; set; }
        public string Alias { get; set; }
        public string Name { get; set; }
        public int OrderIndex { get; set; }
        public List<MenuItem> ItemsChild { get; set; }
    }
    public class MenuReturn
    {
        public List<MenuItem> Items { get; set; }
    }
    public class Item
    {
        public string ID { get; set; }
        public string ChapterID { get; set; }
        public string Page { get; set; }
    }
    public class TimKiem
    {
        public string Value { get; set; }
    }
    public class Category
    {
        public string Alias { get; set; }
        public string Pages { get; set; }
    }
    public class User
    {
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Pass { get; set; }
    }
    public class Param
    {
        public string SiteID { get; set; }
        public string CatID { get; set; }
    }
}