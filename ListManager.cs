using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Administration;

namespace WorkingWithLists
{
    public static class ListManager

    {
        public static SPSite site = new SPSite("http://sf2016");
        public static SPWeb web = site.OpenWeb();

        public static string AddList(string title, string description, SPListTemplateType templateType)
        {
            Guid guid = web.Lists.Add(title, description, templateType);

            SPList list = web.Lists[guid];
            list.Description = "List of Trainers " + title;

            return title + " :->  list has been created with success";
        }
        public static string DeleteList(string listName)
        {

            SPList list = web.Lists[listName];
            list.Delete();

            return listName + " < -- > list has been deleted with success";
        }



    }
}
