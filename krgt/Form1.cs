using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace krgt
{
    public partial class Form1 : Form
    {

                 
   
        
  
        public Form1()
        {
            InitializeComponent();

            
            lborder.SelectionMode = SelectionMode.MultiExtended;
            lbsandwich.SelectionMode = SelectionMode.MultiExtended;
            lbpotato.SelectionMode = SelectionMode.MultiExtended;
            lbsalat.SelectionMode = SelectionMode.MultiExtended;
            lbdesert.SelectionMode = SelectionMode.MultiExtended;
            lbdrink.SelectionMode = SelectionMode.MultiExtended;
            lbdrinkbehavior.SelectionMode = SelectionMode.MultiExtended;
            lbdesertbehavior.SelectionMode = SelectionMode.MultiExtended;
            lbmainsauce.SelectionMode = SelectionMode.MultiExtended;
            lbmenu.SelectionMode = SelectionMode.MultiExtended;

           

            xmlread(lbdesert, "", "prop1"); //ice cream
            xmlread(lbdesert, "", "prop2"); //cake
            xmlread(lbdesert, "", "prop3"); //pie

            xmlread(lbdesertbehavior, "", "prop4"); //caramel
            xmlread(lbdesertbehavior, "", "prop5"); // chocolate
            xmlread(lbdesertbehavior, "", "prop6"); // cakesauce

            xmlread(lbpotato, "", "prop7"); //fried

            xmlread(lbmainsauce, "", "prop8"); //potato sauce
            
            xmlread(lbsandwich, "", "chick"); //chicken
            xmlread(lbsandwich, "", "cheese"); //cheeseburger
            xmlread(lbsandwich, "", "beef"); // beef
            xmlread(lbsandwich, "", "fish"); //fish
            xmlread(lbsandwich, "", "gamb"); //gamburger

            xmlread(lbsalat, "", "chickensalat"); // chicken salat
            xmlread(lbsalat, "", "beefsalat"); //beef salat
            xmlread(lbsalat, "", "fishsalat"); // fish salat

            xmlread(lbmainsauce, "", "chickensalatsauce"); // chicken salat sauce
            xmlread(lbmainsauce, "", "beefsalatsauce"); //beef salat sauce
            xmlread(lbmainsauce, "", "fishsalatsauce"); // fish salat sauce

            xmlread(lbdrink, "", "sodawater"); //soda water
            xmlread(lbdrink, "", "water"); //mineral water
            xmlread(lbdrink, "", "tea"); //tea
            xmlread(lbdrink, "", "coffee"); //coffee

            xmlread(lbdrinkbehavior, "", "Honey"); //honey
            xmlread(lbdrinkbehavior, "", "Lemon"); //lemon
            xmlread(lbdrinkbehavior, "", "Syrop"); //syrop
        }

        

        private void xmlread(ListBox lb, string getnameditem, string childnote)
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("users.xml");
            // получим корневой элемент
            XmlElement xRoot = xDoc.DocumentElement;
            // обход всех узлов в корневом элементе
            foreach (XmlNode xnode in xRoot)
            {
                // получаем атрибут name
                if (xnode.Attributes.Count > 0)
                {
                    XmlNode attr = xnode.Attributes.GetNamedItem(getnameditem);
                    if (attr != null)
                        lb.Items.Add(attr.Value);
                }
                // обходим все дочерние узлы элемента user
                foreach (XmlNode childnode in xnode.ChildNodes)
                {
                    // если узел - prop
                    if (childnode.Name == childnote)
                    {
                        lb.Items.Add(childnode.InnerText);
                    }
                }
            }

        }
            private void addlborder(ListBox lb,string s)
            {
                          
                if (lb.Items.Count > 0)
                    if (lb.SelectedItems.Count != 0)
                    {
                        if (lb.SelectedItem.Equals(s))
                        {
                            lborder.Items.Add(s);
                        }
                    }

            }

        

       

       
    }
}

   

